using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2_2024.com.aluno.veiculos.entidades.carros
{
    public class Carros : Veiculos
    {
        private int qtdPortas;

        public Carros(string _renavam, string _placa, int _qtdPortas) : base(_renavam, _placa)
        {
            this.qtdPortas = _qtdPortas;
        }
        public int getQtdPortas()
        {
            return qtdPortas;
        }
        public void setQtdPortas(int _qtdPortas)
        {
            this.qtdPortas = _qtdPortas;
        }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine($"Esse carro possui {qtdPortas} portas");
        }
    }
}
