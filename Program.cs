namespace mercado_tech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            classes.User user1 = new classes.Vendedor("anderson moraes", "moraes55", "Almaitaliano@braita26", "andpantmoraesgmail.com", "1458995");
            classes.UserConsoleUI.ExibirPerfil(user1);
        }
    }
}
