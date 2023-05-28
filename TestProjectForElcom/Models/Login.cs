using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProjectForElcom.Models
{
    public class Login
    {
        [Key]
        public int LoginID { get; set; }
        
        //[Column(TypeName ="nvarchar(50)")]
//#pragma warning disable CS8618  Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
//        public string UserName { get; set; }
//#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
#pragma warning disable CS8618 //Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора.Возможно, стоит объявить поле как допускающее значения NULL.
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

        [Column(TypeName = "nvarchar(100)")]
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public string Password { get; set; }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

    }
}
