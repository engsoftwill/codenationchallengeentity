using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("candidate")]
    public class Candidate
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int   acceleration_id { get; set; }
        public int company_id { get; set; }
        public int satus { get; set; }
        public DateTime created_at { get; set; }
    }
}