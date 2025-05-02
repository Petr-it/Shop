namespace Shop.Context;

using Microsoft.EntityFrameworkCore;
using Shop.Context.Entities;

public static class AuthorDetailsContextConfiguration
{
    public static void ConfigureAuthorDetails(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthorDetail>().ToTable("author_details");
        modelBuilder.Entity<AuthorDetail>().HasOne(x => x.Author).WithOne(x => x.Detail).HasPrincipalKey<AuthorDetail>(x => x.Id);
    }
}