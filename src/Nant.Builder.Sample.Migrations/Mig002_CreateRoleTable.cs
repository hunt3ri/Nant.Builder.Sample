using FluentMigrator;

namespace Nant.Builder.Sample.Migrations
{
    [Migration(2)]
    public class Mig002_CreateRoleTable : Migration
    {
        public override void Up()
        {
            Create.Table("Role")
                .WithColumn("RoleId").AsInt16().PrimaryKey().Identity().NotNullable()
                .WithColumn("Name").AsString(150).NotNullable();

        }

        public override void Down()
        {
            Delete.Table("Role");
        }
    }
}