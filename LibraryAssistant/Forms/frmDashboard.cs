using LibraryAssistant.Configuration;
using LibraryAssistant.Model;
using LibraryAssistant.Model.DTOs;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAssistant
{
    public partial class frmDashboard : Form
    {

        LibraryService libraryService = new LibraryService();
        AuthResult authTokens;
        DataTable dt = new DataTable();
        TokenRequest tokenRequest = new TokenRequest();
        public List<Book> bookList = new List<Book>();
      
        public frmDashboard(AuthResult authTokens, TokenRequest _tokenRequest)
        {
            InitializeComponent();
            

            System.Diagnostics.Debug.WriteLine("Innom Initialize");
            

            dt.Columns.Add("ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Author");
            dt.Columns.Add("Publisher");
            dt.Columns.Add("Available");
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;

            




            tokenRequest = _tokenRequest;
            SetFontAndColors();
        }  
    
        public class User
        {
            public string Name { get; set; }
        }
     

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Innom frmDashboard_LOAD");

        }

        private void lblbooks_Click(object sender, EventArgs e)
        {

        }


        private async void onLoad(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Innom onLoad");
            authTokens = await libraryService.RefreshToken(tokenRequest);
            List<Book> liste = await libraryService.GetBooks(authTokens.Token);
            foreach (var item in liste)
            {
                dt.Rows.Add(item.Id, item.Title, item.Author, item.Publisher, item.IsAvail);
                System.Diagnostics.Debug.WriteLine(item.Publisher, item.Title);

            }
        }

        private void SetFontAndColors()
        {
            //Column Width
            dataGridView1.Columns[0].Width = 69;
            dataGridView1.Columns[1].Width = 217;
            dataGridView1.Columns[2].Width = 189;
            dataGridView1.Columns[3].Width = 189;
            dataGridView1.Columns[4].Width = 69;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            dataGridView1.BorderStyle = BorderStyle.None;
            // FARGE I MELLOM SLAGA dataGridView1.GridColor = null;

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            //dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;


        }

        
    }
}
