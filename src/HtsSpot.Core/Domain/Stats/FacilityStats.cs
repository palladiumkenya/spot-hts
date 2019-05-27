using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Humanizer;

namespace HtsSpot.Core.Domain.Stats
{
    [Table("vFacilityClientStats")]
    public class FacilityStats
    {
        [Key]
        public Guid Id { get; set; }
        public int SiteCode { get; set; }
        public string Name { get; set; }
        public string County { get; set; }
        public string Partner { get; set; }
        public string Emr { get; set; }
        public int ClientCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? LastUpdate { get; set; }
        [NotMapped]
        public string TimeAgo =>LastUpdate?.Humanize(false);

        public FacilityStats()
        {
        }

        public override string ToString()
        {
            return $"{SiteCode}|{Name}|{County}|{TimeAgo}";
        }
    }
}
