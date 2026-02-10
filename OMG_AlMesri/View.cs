using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMG_AlMesri
{
    public partial class View : Form, IView
    {
        private Model IModel;
        private Controller IController;

        public View()
        {
            InitializeComponent();
        }

        private void buttonGGTBerechnen_Click(object sender, EventArgs e)
        {

        }
    }
}
