using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Animais_Carentes.Models
{
    public class contexto : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public contexto() : base("name=DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Animais_Carentes.Models.UsuarioModel> UsuarioModels { get; set; }

        public System.Data.Entity.DbSet<Animais_Carentes.Models.OngModel> OngModels { get; set; }

        public System.Data.Entity.DbSet<Animais_Carentes.Models.AgendamentoModel> AgendamentoModels { get; set; }

        public System.Data.Entity.DbSet<Animais_Carentes.Models.AnimalModel> AnimalModels { get; set; }

        public System.Data.Entity.DbSet<Animais_Carentes.Models.SocioModel> SocioModels { get; set; }

    }
}
