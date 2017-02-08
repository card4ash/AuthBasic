﻿using Microsoft.AspNet.Identity.EntityFramework;
using AuthBasic.WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuthBasic.WebApi.Infrastructure
{
  public class AuthContext : IdentityDbContext<IdentityUser>
  {
    public AuthContext()
        : base("AuthBasicConnectionString")
    {

    }
    public DbSet<Client> Clients { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
  }
}