using System.Windows.Markup;

namespace Projeto.Testes
{
    public class Teste
    {
        private int MyProperty { get; set; }
        protected int Property2 { get; set; }

        // Construtor sem argumentos
        public Teste()
        {
            MyProperty = 0;
        }

        // Construtor com argumentos
        public Teste(int property)
        {
            MyProperty = property;
        }

        // Método Sem Retorno = Procedure
        public void MultiplicarPor2()
        {
            MyProperty = MyProperty * 2;
        }

        // Método com retorno = Function
        public int Value()
        {
            return MyProperty;
        }
    }

    class Teste2: Teste
    {
        public int RetornaProperty2()
        {
            return Property2;
        }
    }
}