using DocumentFormat.OpenXml.Drawing.Charts;
using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20221114_1703)]
public class DefaultDB_20221114_1703_MovieData : AutoReversingMigration
{
    public override void Up()
    {
        Insert.IntoTable("Movie").Row(new
        {
            Title = "Echoes of Tomorrow",
            Description = "A sci-fi thriller exploring time loops and memory.",
            Storyline = "A scientist discovers a way to send memories back in time, but unintended consequences arise.",
            Year = 2024,
            ReleaseDate = new DateTime(2024, 11, 10),
            Runtime = 118
        });

        Insert.IntoTable("Movie").Row(new
        {
            Title = "The Last Horizon",
            Description = "A deep space survival story.",
            Storyline = "A crew stranded near a black hole must find a way home before time runs out.",
            Year = 2025,
            ReleaseDate = new DateTime(2025, 2, 28),
            Runtime = 131
        });

        Insert.IntoTable("Movie").Row(new
        {
            Title = "Crimson Dusk",
            Description = "A mystery set in a cyberpunk future.",
            Storyline = "A detective investigates a string of digital consciousness thefts.",
            Year = 2023,
            ReleaseDate = new DateTime(2023, 9, 12),
            Runtime = 110
        });

        Insert.IntoTable("Movie").Row(new
        {
            Title = "Silent Code",
            Description = "A hacker uncovers a corporate conspiracy.",
            Storyline = "When a coder stumbles upon an encrypted AI project, her life is thrown into chaos.",
            Year = 2024,
            ReleaseDate = new DateTime(2024, 5, 19),
            Runtime = 124
        });

        Insert.IntoTable("Movie").Row(new
        {
            Title = "Gravity’s Echo",
            Description = "Exploring parallel universes and lost love.",
            Storyline = "A physicist’s experiment leads him to alternate realities where his choices played out differently.",
            Year = 2025,
            ReleaseDate = new DateTime(2025, 7, 2),
            Runtime = 143
        });

        Insert.IntoTable("Movie").Row(new
        {
            Title = "Neon Divide",
            Description = "A cyber-rebellion begins.",
            Storyline = "In a dystopian future, a group of rebels uses augmented reality to fight surveillance.",
            Year = 2023,
            ReleaseDate = new DateTime(2023, 12, 3),
            Runtime = 127
        });

        Insert.IntoTable("Movie").Row(new
        {
            Title = "Moonlight Protocol",
            Description = "A thriller about AI ethics and human rights.",
            Storyline = "An investigative journalist uncovers a hidden program training AI to make life-or-death decisions.",
            Year = 2024,
            ReleaseDate = new DateTime(2024, 8, 21),
            Runtime = 115
        });
    }
}