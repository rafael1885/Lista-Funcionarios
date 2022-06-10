using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Funcionarios
{
    class funcionarios
    {

      public   int Id { get; set; }
      public  string Name { get; set; }
      public  int Salario { get; set; }

        public funcionarios (int id, string name, int salario)
        {
            Id = id;
            Name = name;
            Salario = salario
        }
 
    
    }
}
