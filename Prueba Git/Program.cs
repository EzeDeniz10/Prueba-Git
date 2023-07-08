namespace Prueba_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona()
            {
                Nombre = " Ezequiel",
                Apellido = "Deniz",
            };
                var saludo = persona.Saludar();
            Console.WriteLine(saludo);
          

        }
    }

}
            
            