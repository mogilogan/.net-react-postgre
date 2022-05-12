
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using reactnet.Models;

namespace reactnet.Data;

public class  MydbContext : DbContext
{
   public MydbContext(DbContextOptions<MydbContext> options) : base(options){}

   public DbSet<Note> Notes {get; set;}
}
