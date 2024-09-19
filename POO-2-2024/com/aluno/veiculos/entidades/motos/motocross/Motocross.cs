using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2_2024.com.aluno.veiculos.entidades.motos.motocross
{
    public class Motocross : Moto
    {
        public Motocross(string _renavam, string _placa, bool _guidao) : base(_renavam, _placa, _guidao)
        {
            setTipo("Off-Road"); 
        }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("Essa moto é do tipo: " + getTipo());
        }
    }
}
