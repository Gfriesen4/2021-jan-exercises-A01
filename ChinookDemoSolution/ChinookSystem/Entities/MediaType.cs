﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespace
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace ChinookSystem.Entities
{
    [Table("MediaTypes")]
    internal class MediaType
    {

        private string _Name;
        [Key]
        public int MediaTypeId { get; set; }

        // [Required(ErrorMessage = "Media Type is limited to 120 characters.")]
        [StringLength(120, ErrorMessage = "Media Type is limited to 120 characters.")]
        public string Name
        {
            get { return _Name; }
            set { _Name = string.IsNullOrEmpty(value) ? null : value; }

        }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
