using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AuthorKey.UserFrom
{
     [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class UserWriting : UserControl
    {
        public UserWriting()
        {
            InitializeComponent();
         }

        private void UserWriting_Load(object sender, EventArgs e)
        {
            string aa = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string cc = System.AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
