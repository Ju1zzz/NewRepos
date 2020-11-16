using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        List<Watchable> watchList = new List<Watchable>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.watchList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) 
                {
                    case 0:
                        this.watchList.Add(Movie.Generate());
                        break;
                    case 1: 
                        this.watchList.Add(TVshow.Generate());
                        break;
                    case 2: 
                        this.watchList.Add(Telecast.Generate());
                        break;
                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            
            int moviesCount = 0;
            int TVshowsCount = 0;
            int telecastsCount = 0;
            foreach (var picture in this.watchList)
            {   if (picture is Movie) 
                {
                    moviesCount += 1;
                    txtList.Text += "Фильм\n";
                }
                else if (picture is TVshow)
                {
                    TVshowsCount += 1;
                    txtList.SelectionColor = Color.Red;
                    txtList.Text += "Сериал\n";
                }
                else if (picture is Telecast)
                {
                    telecastsCount += 1;
                    txtList.Text += "Телепередача\n";
                }
            } 
            txtInfo.Text = "Фильмы\tСериалы\tТелепередачи"; 
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", moviesCount, TVshowsCount, telecastsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtList.Text = " ";
            this.txtList.Text.Remove(0);
            
            if (this.watchList.Count == 0)
            {
                txtOut.Text = "Ничего не осталось...";
                return;
            }
            
            var picture = this.watchList[0];
            this.watchList.RemoveAt(0);
            txtOut.Text = picture.GetInfo();
            ShowInfo();
        }

        private void txtOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtList_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
