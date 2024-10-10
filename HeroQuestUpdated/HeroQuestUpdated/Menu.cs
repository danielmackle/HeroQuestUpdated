using System.Runtime.CompilerServices;

namespace HeroQuestUpdated
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            DisplayMenu(0);
        }
        public void DisplayMenu(int selection)
        {
            switch (selection)
            {
                case 0:
                    pnlMainMenu.Visible= true;
                    break;
            }
        }
    }
}
