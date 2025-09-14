using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.DefaultDB
{

    [Migration(20141107170000)]
    public class DefaultDB_20141107_170000_MoviesTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Movie")
                .WithColumn("MovieId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Title").AsString(200).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("Storyline").AsString(Int32.MaxValue).Nullable()
                .WithColumn("Year").AsInt32().Nullable()
                .WithColumn("ReleaseDate").AsDateTime().Nullable()
                .WithColumn("Runtime").AsInt32().Nullable();
        }
    }
}