using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStructure.WebApp._4_DataAcess.Entity;

namespace WebStructure.WebApp._4_DataAcess.EntityConfiguration
{
    public class CarConfiguration : IEntityTypeConfiguration<CarEntity>
    {
        public void Configure(EntityTypeBuilder<CarEntity> builder)
        {
            builder.ToTable("Cars_Table");
            builder.HasKey(PrimaryKey => PrimaryKey.Id);
        }
    }
}
