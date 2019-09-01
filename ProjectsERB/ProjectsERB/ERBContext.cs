using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elm5zenDatabase;
using System.Data.Entity;

namespace ProjectsERB
{
    public class ERBContext : DbContext
    {
        
        
        public ERBContext() : base(@"Data Source=desktop-r8kpj9o\mathewdatabase;Initial Catalog=M5zn;Integrated Security=True") { }
        public virtual DbSet<Categories> categories { get; set; }
        public virtual DbSet<Payment_Type> PaymentType { get; set; }

        public virtual DbSet<InvoiceProduct> invoice_products { get; set; }
        public virtual DbSet<InvoiceType> invoice_types { get; set; }
        public virtual DbSet<Invoice> invoices { get; set; } 
        public virtual DbSet<Person> person { get; set; }
        public virtual DbSet<PersonType> PersonTypes { get; set; }
        public virtual DbSet<login_check> login_checks { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ResetCashMoney> RestCashMoneys { get; set; }
        public virtual DbSet<InvoiceSellPermision> InvoiceSellPermisions { get; set; }
        public virtual DbSet<invoiceTypePrice> invoiceTypePrices { get; set; }


        // public virtual DbSet<Store> Stores { get; set; }
        //public virtual DbSet<SubCategories> SubCategories { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Invoice>()
        //        .HasRequired(iv => iv.PermisionInvoice)
        //        .WithRequiredPrincipal(ivs => ivs.PermisionIDs);
        //}

    }
}
