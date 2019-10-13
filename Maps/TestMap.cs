
using dockerapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace dockerapi.Maps{
    #pragma warning disable CS1591
       public class TestMap
    {
        public TestMap(EntityTypeBuilder<Test> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("test");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Handle).HasColumnName("handle");
        }
    }
    #pragma warning restore CS1591
}