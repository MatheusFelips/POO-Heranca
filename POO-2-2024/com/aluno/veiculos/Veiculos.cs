using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2_2024.com.aluno.veiculos { 

    public abstract class Veiculos
    {
        private string renavam;
        private string placa;

        public  Veiculos(string _renavam, string _placa)
        {
            this.renavam = _renavam;
            this.placa = _placa;
        }
        public virtual void mostrar() 
        { 

        }
        public string getRenavam()
        {
            return renavam;
        }
        public void setRenavam(string _placa)
        {
            this.placa = _placa;
        }
        public string getPlaca() { 
            return placa; 
        }
        public void setPlaca(string _placa)
        {
            this.placa = _placa;
        }

    }
}


