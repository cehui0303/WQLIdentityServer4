﻿using System.Collections.Generic;

namespace WQLIdentity.Application.Dtos.ApiResources
{
    public class UpdateScopeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
        public bool Emphasize { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }
        public List<string> UserClaims { get; set; }

    }
}
