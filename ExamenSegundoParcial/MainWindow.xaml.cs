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

namespace ExamenSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            PanelPestaña.Children.Add(new InformacionPersonal());
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
            
            if(i==0)
            {
               
                var InformacionPersonal = (InformacionPersonal)PanelPestaña.Children[0];
                if (string.IsNullOrEmpty(InformacionPersonal.tbxNombre.Text))
                {
                    tbkError.Text = "Es necesario llenar todos los campos";
                }
                else
                {

                    if (string.IsNullOrEmpty(InformacionPersonal.tbxApellidoPaterno.Text))
                    {
                        tbkError.Text = "Es necesario llenar todos los campos";
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(InformacionPersonal.tbxApellidoMaterno.Text))
                        {
                            tbkError.Text = "Es necesario llenar todos los campos";
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(InformacionPersonal.tbxEdad.Text))
                            {
                                tbkError.Text = "Es necesario llenar todos los campos";
                            }
                            else
                            {
                                PanelPestaña.Children.Clear();
                                PanelPestaña.Children.Add(new Contacto());
                                tbkError.Text = "";
                                i++;
                            }
                        }
                    }
                }
            }
            else
            {
                if(i==1)
                {
                    var Contacto = (Contacto)PanelPestaña.Children[0];
                    if (string.IsNullOrEmpty(Contacto.tbxCorreo.Text))
                    {
                        tbkError.Text = "Es necesario llenar todos los campos";
                    }
                    else
                    {

                        if (string.IsNullOrEmpty(Contacto.tbxTelefono.Text))
                        {
                            tbkError.Text = "Es necesario llenar todos los campos";
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(Contacto.tbxCelular.Text))
                            {
                                tbkError.Text = "Es necesario llenar todos los campos";
                            }
                            else
                            {
                                PanelPestaña.Children.Clear();
                                PanelPestaña.Children.Add(new InformacionDePago());
                                
                                tbkError.Text = "";
                                i++;
                            }
                        }
                    }
                }
                else
                {
                    if(i==2)
                    {
                        var InformacionDePago = (InformacionDePago)PanelPestaña.Children[0];
                        if (string.IsNullOrEmpty(InformacionDePago.tbxNumeroDeTarjeta.Text))
                        {
                            if(InformacionDePago.tbxNumeroDeTarjeta.Text.Length < 16)
                            {
                                tbkTarjeta.Text = "Es necesario que el número de tarjeta sean 16 dígitos";
                            }
                            else
                            {
                                tbkTarjeta.Text = "";
                            }
                            tbkError.Text = "Es necesario llenar todos los campos";
                        }
                        else
                        {
                            if (InformacionDePago.tbxNumeroDeTarjeta.Text.Length < 16)
                            {
                                tbkTarjeta.Text = "Es necesario que el número de tarjeta sean 16 dígitos";
                            }
                            else
                            {
                                tbkTarjeta.Text = "";
                            }

                            if (string.IsNullOrEmpty(InformacionDePago.tbxCVV.Text) && InformacionDePago.tbxNumeroDeTarjeta.Text.Length < 16)
                            {
                                tbkError.Text = "Es necesario llenar todos los campos";
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(InformacionDePago.tbxMesDeExpiracion.Text))
                                {
                                    tbkError.Text = "Es necesario llenar todos los campos";
                                }
                                else
                                {
                                    if(string.IsNullOrEmpty(InformacionDePago.tbxAñoDeExpiracion.Text))
                                    {
                                        tbkError.Text = "Es necesario llenar todos los campos";
                                    }
                                    else
                                    {
                                        PanelPestaña.Children.Clear();
                                        tbkError.Text = "";
                                        i++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            
        }
    }
}
