using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Service.ModeldsDB
{
    public class DbUser
    {
        public const string TableName = "UsersService";
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }

        public class DBUserConfiguration : IEntityTypeConfiguration<DbUser>
        {
            public void Configure(EntityTypeBuilder<DbUser> builder)
            {
                builder.ToTable(DbUser.TableName);
                builder.HasKey(u => u.Id);
            }
        }
    }
}
