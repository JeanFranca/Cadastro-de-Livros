using SalvarItem.contextos;
using SalvarItem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace SalvarItem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void cadastrar(Object sender, RoutedEventArgs e)
        {
            Livro newLivro = new Livro()
            {
                nomeLivro = TbxNomeLivro.Text,
                editoraLivro = TbxEditora.Text,
                generoLivro = TbxGenero.Text,
                autorLivro = TbxAutor.Text

            };

            using (var contexto = new BibliotecaContextos())
            {
                contexto.Livros.Add(newLivro);
                contexto.SaveChanges();
            }

        }
    }
}
