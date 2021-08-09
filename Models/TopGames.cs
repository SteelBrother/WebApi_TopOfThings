using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCrud.Models
{
    public class TopGames : Entity
    {
        public string Name {get;set;}
        public string Price {get;set;}
        public DateTime PublicationDate {get;set;}
 
    }
}