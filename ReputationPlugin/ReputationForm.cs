using RBot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReputationPlugin
{
    public partial class ReputationForm : Form
    {
        public static ReputationForm Instance { get; } = new ReputationForm();

        public static ScriptInterface Bot => ScriptInterface.Instance;
        public ReputationForm()
        {
            InitializeComponent();
            RefreshView(false);
        }

        public int CalculateRemainingRank10Rep(int totalRep) => (totalRep >= 302500) ? 0 : 302500 - totalRep;

        private void ExampleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* Keeps the example form from disposing itself so it can be reopened
             * This should be in every plugin
             */
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void RefreshView(bool dontShowRank10)
        {
            reputationListView.Items.Clear();

            List<Faction> allFactions = Bot.Player.Factions
                .Select(item => new Faction(item.Name, item.Rank, item.Rep, item.RequiredRep, item.RemainingRep, CalculateRemainingRank10Rep(item.TotalRep), item.TotalRep)).ToList();

            List<Faction> missingFactions = Factions.AllFactionNames
                .Where(item => allFactions.Any(allFactionItem => allFactionItem.name == item) == false).Select(item => new Faction(item)).ToList();

            allFactions.AddRange(missingFactions);

            allFactions = allFactions.OrderBy(item => item.name).ToList();

            foreach (Faction faction in allFactions)
            {
                if (dontShowRank10 && faction.rank == 10)
                    continue;

                reputationListView.Items.Add(new ListViewItem(new String[]
                {
                    faction.name, // factionNameColumn
                    faction.rank.ToString(), // rankColumn
                    faction.rep.ToString(), // repColumn
                    faction.requiredRep.ToString(), // requiredRepColumn
                    faction.remainingRep.ToString(), // remainingRepColumn
                    faction.rank10Remaining.ToString(), // rank10RemainingColumn,
                    faction.totalRep.ToString(), // totalRepColumn
                    
                }));
            }

            dateLabel.Text = $"Last refresh: {DateTime.Now}";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshView(rank10CheckBox.Checked);
        }

        private void rank10CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView(rank10CheckBox.Checked);
        }
    }
}
