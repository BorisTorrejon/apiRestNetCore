namespace apiRestNetCore.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string Nombre {  get; set; }
        public double PrecioVenta {  get; set; }
        public double PrecioCompra {  get; set; }
        public int Stock {  get; set;}
    }
}
