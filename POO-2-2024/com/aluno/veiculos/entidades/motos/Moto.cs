using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2_2024.com.aluno.veiculos.entidades.motos
{
    public class Moto : Veiculos
    {
        private bool guidao;
        private string tipo;
        public Moto(string _renavam, string _placa, bool _guidao) : base(_renavam, _placa)
        {
            this.guidao = _guidao;
            
        }
        public bool getGuidao()
        {
            return guidao;
        }
        public void setGuidao(bool _guidao)
        {
            this.guidao = _guidao;
        }
        public string getTipo()
        {
            return tipo;
        }
        public void setTipo(string _tipo)
        {
            this.tipo = _tipo;
        }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("Tem guidão: " + (guidao ? "Sim":"Não"));
        }
    }
}
