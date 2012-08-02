using FluentMigrator;

namespace Nant.Builder.Sample.Migrations
{
    [Migration(1)]
    public class Mig001_CreateUserTable : Migration
    {

        public override void Up()
        {
            Create.Table("User")
                .WithColumn("UserId").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Username").AsString(50).NotNullable()
                .WithColumn("Password").AsString(150).Nullable()
                .WithColumn("EmailAddress").AsString(500).Nullable()
                .WithColumn("AuthToken").AsGuid().Nullable()
                .WithColumn("DateRegistered").AsDateTime().Nullable()
                .WithColumn("Firstname").AsString(100).Nullable()
                .WithColumn("Lastname").AsString(100).Nullable()
                .WithColumn("DateOfBirth").AsDateTime().Nullable()
                .WithColumn("Status").AsInt32().NotNullable().WithDefaultValue(0);
        }

        public override void Down()
        {
            Delete.Table("User");
        }
    }
}