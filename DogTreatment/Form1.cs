using DogTreatment.Models;
using EntityFrameworkDbFirst.Models;
using System.Xml.Linq;

namespace DogTreatment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateProduct();

        }

        private void CreateProduct()
        {
            using (var context = new ProductsContext())
            {
                var newProduct = new Product
                {
                    Name = txtName.Text,
                    Price = txtPrice.Text
                };
                context.Testess.Add(newProduct);
                context.SaveChanges();
            }
        }

        private void LoadProducts()
        {
            using (var context = new ProductsContext())
            {
                var products = context.Testess.ToList();
                dataGridView1.DataSource = products;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}