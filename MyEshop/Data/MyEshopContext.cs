using Microsoft.EntityFrameworkCore;
using MyEshop.Models;

namespace MyEshop.Data
{
    public class MyEshopContext : DbContext
    {
        public MyEshopContext(DbContextOptions<MyEshopContext> options) : base(options)
        {

        }

        public DbSet<categorycs> categorycs { get; set; }

        public DbSet<Users> users { get; set; }

        public DbSet<Categoritoproduct> categoritoproducts { get; set; }

        public DbSet<Productcs> productcs { get; set; }

        public DbSet<item> items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Categoritoproduct>()
                .HasKey(t => new { t.productid, t.categoriid });

            //modelBuilder.Entity<Productcs>(
            //    p =>
            //    {
            //        p.HasKey(w => w.Id);
            //        p.OwnsOne<item>(w => w.item);
            //        p.HasOne<item>(w=>w.item).WithOne(w=>w.productcs).HasForeignKey<item>(w=>w.Id);


            //    }
            //    );

            //modelBuilder.Entity<item>(
            //    i =>
            //    {
            //        i.Property(w => w.price).HasColumnType("Money");
            //        i.HasKey(i => i.Id);
            //    }
            //    );

            #region seaddatecategory
            modelBuilder.Entity<categorycs>().HasData(new categorycs()
            {
                Id = 1,
                Name = "سبزیحات",
                Description = "سبزیجات"
            },
                new categorycs()
                {
                    Id = 2,
                    Name = "میوه جات",
                    Description = " میوه جات"
                },
                new categorycs()
                {
                    Id = 3,
                    Name = "لبنیات",
                    Description = "لبنیات"
                }
            );
            #endregion

            #region seaddateitem
            modelBuilder.Entity<item>().HasData(
                new item()
                {
                    Id = 1,
                    price = 854.0M,
                 
                },
            new item()
            {
                Id = 2,
                price = 3302.0M,
        
            },
            new item()
            {
                Id = 3,
                price = 2500,
               
            },
            new item()
            {
                Id = 4,
                price = 140000,
             
            },
            new item()
            {
                Id = 5,
                price = 250000,
                Quentitystock =0
            },
            new item()
            {
                Id = 6,
                price = 68000,
              
            },
            new item()
            {
                Id = 7,
                price = 48000,
              
            },
            new item()
            {
                Id = 8,
                price = 64000,
               
            }

            );
            #endregion

            #region seaddateproduct
            modelBuilder.Entity<Productcs>().HasData(

                new Productcs()
                {
                    Id = 1,
                    itemid = 1,
                    numbers=0,
                    Name = "فلفل دلمه ای",
                    Description = "فلفل دلمه ای نیز فلفل شیرین و یا کپسایسیم هستند و در رنگ های مختلف مثل زرد، قرمز، سبز، بنفش و نارنجی موجود هستند. این سبزیجات ، بیش از 900 سال پیش در جنوب و آمریکای مرکزی پرورش داده شدند و نام فلفل را از استعمارگران اروپایی آمریکای شمالی دریافت کردند.\r\n\r\n"
                },
                  new Productcs()
                  {
                      Id = 2,
                      itemid = 2,
                      numbers = 0,
                      Name = "توت فرنگی",
                      Description = " توت فرنگی دارای مقدار قابل توجهی آنتی اکسیدان است و حتی دارای مزایای قلبی عروقی می باشد. لوبیا سبز ،منبع غنی از چربی های امگا 3 است. کاروتنوئید و فلاونوئید موجود در لوبیا سبز ،دارای مزایای ضد التهابی هستند."
                  },
                new Productcs()
                {
                    Id = 3,
                    itemid = 3,
                    numbers = 0,
                    Name = " لوبیا سبز",
                    Description = "لوبیا سبز، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند."
                }
                ,
                new Productcs()
                {
                    Id = 4,
                    itemid = 4,
                    numbers = 0,
                    Name = " کلم بنفش ",
                    Description = "کلم بنفش، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند."
                },
                new Productcs()
                {
                    Id = 5,
                    itemid = 5,
                    numbers = 0,
                    Name = " گوجه  فرنگی",
                    Description = "گوجه فرنگی، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند."
                },
                new Productcs()
                {
                    Id = 6,
                    itemid = 6,
                     numbers = 0,
                    Name = " کلم بروکلی",
                    Description = "کلم بروکلی، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند."
                },
                new Productcs()
                {
                    Id = 7,
                    itemid = 7,
                    numbers = 0,
                    Name = " هویج",
                    Description = " هویج، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند."
                },
                new Productcs()
                {
                    Id = 8,
                    itemid = 8,
                    numbers = 0,
                    Name = " ابمیوه های طبیعی",
                    Description = "ابمیوه های طبیعی، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند."
                }
                );

            #endregion


        }
    }
}

