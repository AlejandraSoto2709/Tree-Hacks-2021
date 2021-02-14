using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diversity
{
    public partial class Form1 : Form
    {
       ThotEntities3 context = new ThotEntities3();
        public Form1()
        {
            InitializeComponent();
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {
            string cadSQL;
            cadSQL = $"select * from Avatar where username = '{txUsu.Text}' and " +
                $"passw = '{txContra.Text}'";

            List<Avatar> lsA = context.Avatars.SqlQuery(cadSQL).ToList();

            //Verifing that the information is correct
            if (lsA.Count != 0)
            {
                username = lsA[0].username;
                MainWindow w = new MainWindow();
                w.Show();


            }
            else
                MessageBox.Show("Incorrect information.");
        }

        public static string username = "";


        private void btAcceder_Click_1(object sender, EventArgs e)
        {
            CreateAvatar w = new CreateAvatar();
            w.Show();
        }
    }
}
