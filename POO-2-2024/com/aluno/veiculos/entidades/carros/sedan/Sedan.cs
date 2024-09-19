using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2_2024.com.aluno.veiculos.entidades.carros.sedan
{
    public class Sedan : Carros
    {
        private int volumeCarroceria;
        public Sedan(string _renavam, string _placa, int _qtdPortas, int _volumeCarroceria) : base(_renavam, _placa, _qtdPortas)
        {
            this.volumeCarroceria = _volumeCarroceria;
        }
        public int getVolumeCarroceria()
        {
            return volumeCarroceria;
        }
        public void setVolumeCarroceria(int _volumeCarroceria)
        {
            this.volumeCarroceria= _volumeCarroceria;
        }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine($"O sedan é um carro do tipo {volumeCarroceria} volumes ");
        }
    }
}
