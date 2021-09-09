using LibraryAssistant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryAssistant
{
    public partial class frmMembers : Form
    {
        DataTable dt = new DataTable();
        LibraryService libraryService = new();
        public frmMembers()
        {
            InitializeComponent();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Mobile");
            dt.Columns.Add("Email");
            DataView dv = new DataView(dt);
            dataGridViewMember.DataSource = dv;

            SetFontAndColors();
        }



        private void SetFontAndColors()
        {
            //Column Width
            dataGridViewMember.Columns[0].Width = 97;
            dataGridViewMember.Columns[1].Width = 258;
            dataGridViewMember.Columns[2].Width = 207;
            dataGridViewMember.Columns[3].Width = 207;


            dataGridViewMember.RowsDefaultCellStyle.BackColor = Color.FromArgb(230, 233, 239);
            dataGridViewMember.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(241, 243, 250);

            dataGridViewMember.BorderStyle = BorderStyle.None;


            dataGridViewMember.CellBorderStyle = DataGridViewCellBorderStyle.None;
            

            dataGridViewMember.RowHeadersVisible = false;

            dataGridViewMember.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridViewMember.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMember.EnableHeadersVisualStyles = false;


        }

        private async void onLoad(object sender, EventArgs e)
        {
            List<Member> memberList = await libraryService.GetMembers();
            foreach (var item in memberList)
            {
                dt.Rows.Add(item.Id, item.Name, item.Mobile, item.Email)
            }
        }
    }
}
