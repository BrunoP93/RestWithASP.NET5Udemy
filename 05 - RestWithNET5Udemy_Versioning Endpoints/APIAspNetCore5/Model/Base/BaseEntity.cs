﻿using System.ComponentModel.DataAnnotations.Schema;


namespace APIAspNetCore5.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
    }
}
