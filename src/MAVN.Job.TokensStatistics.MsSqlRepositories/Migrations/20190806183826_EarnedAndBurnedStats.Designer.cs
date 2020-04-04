// <auto-generated />
using System;
using MAVN.Job.TokensStatistics.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Job.TokensStatistics.MsSqlRepositories.Migrations
{
    [DbContext(typeof(TokensStatisticsContext))]
    [Migration("20190806183826_EarnedAndBurnedStats")]
    partial class EarnedAndBurnedStats
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("tokens_statistics")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Job.TokensStatistics.MsSqlRepositories.Entities.DailyTokensSnapshotEntity", b =>
                {
                    b.Property<string>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("date");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.Property<long>("TotalBurnedTokens")
                        .HasColumnName("total_burned_tokens");

                    b.Property<long>("TotalEarnedTokens")
                        .HasColumnName("total_earned_tokens");

                    b.Property<long>("TotalTokens")
                        .HasColumnName("total_tokens");

                    b.HasKey("Date");

                    b.ToTable("daily_tokens_snapshot");
                });

            modelBuilder.Entity("MAVN.Job.TokensStatistics.MsSqlRepositories.Entities.LastKnownStatsEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("LastBurnedAmount")
                        .HasColumnName("last_burned_amount");

                    b.Property<long>("LastEarnedAmount")
                        .HasColumnName("last_earned_amount");

                    b.Property<long>("LastTotalAmount")
                        .HasColumnName("last_total_amount");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("Id");

                    b.ToTable("last_token_total_amount");
                });
#pragma warning restore 612, 618
        }
    }
}
