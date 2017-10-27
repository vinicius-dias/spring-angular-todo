using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace poc_webapi.data
{
    public partial class PocUser
    {
        public PocUser()
        {
            PocTask = new HashSet<PocTask>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore] 
        [IgnoreDataMember] 
        public ICollection<PocTask> PocTask { get; set; }
    }
}
