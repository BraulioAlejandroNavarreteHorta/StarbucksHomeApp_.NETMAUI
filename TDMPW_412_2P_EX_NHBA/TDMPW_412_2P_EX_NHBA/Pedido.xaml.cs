namespace TDMPW_412_2P_EX_NHBA;

public partial class Pedido : ContentPage
{
    List<Cafes> cafes = new List<Cafes>();
    int contador = 1;

    public Pedido()
	{
		InitializeComponent();
        
        cafes.Add(new Cafes("bebidascalientes.png", "Café Americano", "Grande (16oz-437ml) 0 calorías Sin Leche", 45));
        cafes.Add(new Cafes("smoothies.png", "Smoothie sabor Mango", "Mediano (12oz-337ml) 10 calorías Hielo", 50));
        cafes.Add(new Cafes("bebidasfrias.png", "Té helado sabor Limón", "Chico (10oz-237ml) 4 calorías Té Orgánico", 35));
        this.imgCafe.Source = cafes[contador].image;
        this.lblTitle.Text = cafes[contador].title;
        this.lblDatos.Text = cafes[contador].data;
        this.lblPrice.Text = $"{cafes[contador].price:C}";
        this.lblTotal.Text = $"Total ...............................{cafes[contador].price:C}";

    }

    void stpCantidad_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        if (this.stpCantidad.Value < 1) {
            this.stpCantidad.Value = 1;
        }
        calcularPrecio();
        this.lblCantidad.Text = $"Cantidad {this.stpCantidad.Value}";
    }

    void cafe1_Clicked(System.Object sender, System.EventArgs e)
    {
        contador = 0;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"Cantidad: {this.stpCantidad.Value}";
        asignarValores();
    }

    void cafe2_Clicked(System.Object sender, System.EventArgs e)
    {
        contador = 1;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"Cantidad: {this.stpCantidad.Value}";
        asignarValores();
    }

    void cafe3_Clicked(System.Object sender, System.EventArgs e)
    {
        contador = 2;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"Cantidad: {this.stpCantidad.Value}";
        asignarValores();
    }

    private void calcularPrecio()
    {
        var total = cafes[contador].price * this.stpCantidad.Value;
        this.lblPrice.Text = $"{total:C}";
        this.lblTotal.Text = $"Total................................{total:C}";
    }

    private void asignarValores()
    {
        this.imgCafe.Source = cafes[contador].image;
        this.lblDatos.Text = cafes[contador].data;
        this.lblTitle.Text = cafes[contador].title;
        calcularPrecio();
    }

    void cafe2_Clicked_1(System.Object sender, System.EventArgs e)
    {
        contador = 1;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"Cantidad: {this.stpCantidad.Value}";
        asignarValores();
    }

    void cafe1_Clicked_1(System.Object sender, System.EventArgs e)
    {
        contador = 0;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"Cantidad: {this.stpCantidad.Value}";
        asignarValores();
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        contador = 0;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"Cantidad: {this.stpCantidad.Value}";
        asignarValores();
    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        contador = 1;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"Cantidad: {this.stpCantidad.Value}";
        asignarValores();
    }

    void Button_Clicked_2(System.Object sender, System.EventArgs e)
    {
        contador = 2;
        this.stpCantidad.Value = 1;
        this.lblCantidad.Text = $"Cantidad: {this.stpCantidad.Value}";
        asignarValores();
    }
}
