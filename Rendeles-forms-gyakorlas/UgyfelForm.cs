using Microsoft.EntityFrameworkCore.Diagnostics;
using Rendeles_forms_gyakorlas.Data;
using Rendeles_forms_gyakorlas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeles_forms_gyakorlas
{
    public partial class UgyfelForm : Form
    {
        private RendelesDbContext _context; //itt az a zöld színű ami a scaffoldban -context után van
        public UgyfelForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadData();  //ez lefut és feltölti a datagridview-t
        }

        private void LoadData()
        {
            ugyfelBindingSource.DataSource = _context.Ugyfel.ToList();  //feltöltjük a Bindinglistet az ügyfél adataival
        }

        private void New_Click(object sender, EventArgs e)
        {
            var ujUgyfel = new Ugyfel { Nev = "Új Ügyfél", Email = "uj@pelda.com" }; //új ügyfél felvétele
            _context.Ugyfel.Add(ujUgyfel); //itt adjuk hozzá az adatbázishoz
            _context.SaveChanges(); //elmentjük
            LoadData(); //ismét betöltjük, mostmár a kiegészített adatbázist
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _context.SaveChanges(); //itt csak simán mentünk
            LoadData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var torlendoUgyfel = dataGridView1.CurrentRow.DataBoundItem as Ugyfel;
                if (torlendoUgyfel != null)
                {
                    _context.Ugyfel.Remove(torlendoUgyfel);
                    _context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
