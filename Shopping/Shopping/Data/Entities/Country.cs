﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50,ErrorMessage ="El campo {0} debe tener máximo {1} caractéres.")]
        public string Name { get; set; }
        public ICollection<State> States { get; set; }
        // If states =null debe devolver cero, de lo contrario devuelve los estados
        [Display(Name= "Departamentos/Estados")]                          
        public int StatesNumer => States==null ? 0:States.Count;

    }
}
