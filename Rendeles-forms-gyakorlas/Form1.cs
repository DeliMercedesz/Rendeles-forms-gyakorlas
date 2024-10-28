using Rendeles_forms_gyakorlas.Data;
using Rendeles_forms_gyakorlas.Models;
using System.Xml.Linq;

namespace Rendeles_forms_gyakorlas
{
    public partial class Form1 : Form
    {
        private RendelesDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void User_Click(object sender, EventArgs e)
        {
            UgyfelForm ugyfelForm = new UgyfelForm();
            ugyfelForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TermekKategoriaForm termekKategoriaForm = new TermekKategoriaForm();
            termekKategoriaForm.ShowDialog();
        }

        private void xml_Click(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument();
            XDeclaration xdecl = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Declaration = xdecl;

            XElement root = new XElement("Kategóriák");
            xdoc.Add(root);

            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();

            var fokategoriak = (from k in kategoriak
                                where k.SzuloKategoriaId == null
                                select k).ToList();

            foreach (var f in fokategoriak)
            {
                XElement node = CreateCategoryElement(f, kategoriak);
                root.Add(node);
            }

            // Segédfüggvény az alkategóriák kezeléséhez
            XElement CreateCategoryElement(TermekKategoria kategoria, List<TermekKategoria> kategoriak)
            {
                XElement element = new XElement("Kategória",
                                                new XAttribute("Név", kategoria.Nev),
                                                new XAttribute("KategóriaId", kategoria.KategoriaId));

                var alkategoriak = from k in kategoriak
                                   where k.SzuloKategoriaId == kategoria.KategoriaId
                                   select k;

                foreach (var alkat in alkategoriak)
                {
                    element.Add(CreateCategoryElement(alkat, kategoriak));
                }

                return element;
            }

            MessageBox.Show(xdoc.ToString());
        }


    }
}
