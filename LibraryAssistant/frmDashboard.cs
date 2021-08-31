using LibraryAssistant.Model;
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

        LibraryService LibraryService = new LibraryService();
        public frmDashboard()
        {
            InitializeComponent();
            

        }

        //List<Book> Books = new List<Book>();

    

     

        private async void frmDashboard_Load(object sender, EventArgs e)
        {
           // await LibraryService.GetBooks();


        }

        private void lblbooks_Click(object sender, EventArgs e)
        {

        }
    }
}
