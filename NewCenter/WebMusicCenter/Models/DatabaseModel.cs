using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using NewCenter;

namespace WebMusicCenter.Models
{
    namespace DataAccessPostgreSqlProvider
    {
        public class MusicCenterDbContext : DbContext
        {
            public MusicCenterDbContext()
            {
                Database.EnsureCreated();
            }

            public MusicCenterDbContext(DbContextOptions<MusicCenterDbContext> options) : base(options)
            {
            }

            public DbSet<DbCompletingForm> CompletingForms{ get; set; }

            public static string ConnectionString { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql(ConnectionString);
                base.OnConfiguring(optionsBuilder);
            }
        }
        //Класс формы заявки на обслуживание инструмента
        public class DbCompletingForm
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            // Название заявления
            public string FormName { get; set; }

            // Имя клиента       
            public string Name { get; set; }

            // Фамилия клиента
            public string Surname { get; set; }

            // Отчество клиента
            public string Patronymic { get; set; }

            //Контактная информация клиента
            public string ContactDetails { get; set; }

            public InstrumentType InstrumentType { get; set; }

            public DateTime Create { get; set; }

            public List<DbProblemDescription> Description { get; set; }

            public List<DbMaster> Master { get; set; }

            // Прилагаемая фотография  
            public byte[] Photo { get; set; }
        }

        public class DbProblemDescription
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            public int CompletingFormId { get; set; }
            [ForeignKey("CompletingFormId")]
            public virtual DbCompletingForm CompletingForm { get; set; }

            // Модель инструмента
            public string ModelOfInstrument { get; set; }

            public string FullDescription { get; set; }

            public override string ToString()
            {
                return $"Модель: {ModelOfInstrument}, Описание: {FullDescription},";
            }
        }

        public class DbMaster
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            public int CompletingFormId { get; set; }
            [ForeignKey("CompletingFormId")]
            public virtual DbCompletingForm CompletingForm { get; set; }

            public List<string> ListMaster { get; set; }

            public string NameMaster { get; set; }

            public byte[] Photo { get; set; }
        }
    }
}
