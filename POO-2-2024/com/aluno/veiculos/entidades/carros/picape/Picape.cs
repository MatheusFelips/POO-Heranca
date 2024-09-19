using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2_2024.com.aluno.veiculos.entidades.carros.picape
{
    public class Picape : Carros
    {
        private int capacidadeCarga;
        public Picape(string _renavam, string _placa, int _qtdPortas, int _capacidadeCarga) : base(_renavam, _placa, _qtdPortas)
        {
            this.capacidadeCarga = _capacidadeCarga;
        }
        public int getCapacidadeCarga()
        {
            return capacidadeCarga;
        }
        public void setCapacidadeCargaint(int _capacidadeCarga)
        {
            this.capacidadeCarga = _capacidadeCarga;
        }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("A capacidade de carga da picape é: " + capacidadeCarga);
        }
    }
}
