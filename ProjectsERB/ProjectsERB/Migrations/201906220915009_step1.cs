namespace ProjectsERB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class step1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PriceIn = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceOutOne = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceOutAll = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Categories_ID = c.Int(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Categories_ID)
                .Index(t => t.Categories_ID);
            
            CreateTable(
                "dbo.InvoiceProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        SerialNumber = c.String(),
                        Invoice_ID = c.Int(),
                        Product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Invoices", t => t.Invoice_ID)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .Index(t => t.Invoice_ID)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BillDate = c.DateTime(nullable: false),
                        TotalCash = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalBill = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalReset = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pesron_ID = c.Int(),
                        InvoiceType_ID = c.Int(),
                        PaymentType_ID = c.Int(),
                        invoiceTypePriceID = c.Int(),
                        invoicestatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.InvoiceTypes", t => t.InvoiceType_ID)
                .ForeignKey("dbo.invoiceTypePrices", t => t.invoiceTypePriceID)
                .ForeignKey("dbo.Payment_Type", t => t.PaymentType_ID)
                .ForeignKey("dbo.People", t => t.Pesron_ID)
                .Index(t => t.Pesron_ID)
                .Index(t => t.InvoiceType_ID)
                .Index(t => t.PaymentType_ID)
                .Index(t => t.invoiceTypePriceID);
            
            CreateTable(
                "dbo.InvoiceTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.invoiceTypePrices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Payment_Type",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InvoiceSellPermisions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InvoiceSellID = c.Int(),
                        InvoicePermisionID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Invoices", t => t.InvoicePermisionID)
                .ForeignKey("dbo.Invoices", t => t.InvoiceSellID)
                .Index(t => t.InvoiceSellID)
                .Index(t => t.InvoicePermisionID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        Address = c.String(),
                        AccountMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PersonType_ID = c.Int(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PersonTypes", t => t.PersonType_ID)
                .Index(t => t.PersonType_ID);
            
            CreateTable(
                "dbo.PersonTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ResetCashMoneys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ResetMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Invoice_ID = c.Int(),
                        Person_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Invoices", t => t.Invoice_ID)
                .ForeignKey("dbo.People", t => t.Person_ID)
                .Index(t => t.Invoice_ID)
                .Index(t => t.Person_ID);
            
            CreateTable(
                "dbo.login_check",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        logincheck_username = c.String(nullable: false),
                        logincheck_password = c.String(nullable: false),
                        logincheck_type = c.Int(nullable: false),
                        logincheck_name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceProducts", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.InvoiceProducts", "Invoice_ID", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "Pesron_ID", "dbo.People");
            DropForeignKey("dbo.ResetCashMoneys", "Person_ID", "dbo.People");
            DropForeignKey("dbo.ResetCashMoneys", "Invoice_ID", "dbo.Invoices");
            DropForeignKey("dbo.People", "PersonType_ID", "dbo.PersonTypes");
            DropForeignKey("dbo.InvoiceSellPermisions", "InvoiceSellID", "dbo.Invoices");
            DropForeignKey("dbo.InvoiceSellPermisions", "InvoicePermisionID", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "PaymentType_ID", "dbo.Payment_Type");
            DropForeignKey("dbo.Invoices", "invoiceTypePriceID", "dbo.invoiceTypePrices");
            DropForeignKey("dbo.Invoices", "InvoiceType_ID", "dbo.InvoiceTypes");
            DropForeignKey("dbo.Products", "Categories_ID", "dbo.Categories");
            DropIndex("dbo.ResetCashMoneys", new[] { "Person_ID" });
            DropIndex("dbo.ResetCashMoneys", new[] { "Invoice_ID" });
            DropIndex("dbo.People", new[] { "PersonType_ID" });
            DropIndex("dbo.InvoiceSellPermisions", new[] { "InvoicePermisionID" });
            DropIndex("dbo.InvoiceSellPermisions", new[] { "InvoiceSellID" });
            DropIndex("dbo.Invoices", new[] { "invoiceTypePriceID" });
            DropIndex("dbo.Invoices", new[] { "PaymentType_ID" });
            DropIndex("dbo.Invoices", new[] { "InvoiceType_ID" });
            DropIndex("dbo.Invoices", new[] { "Pesron_ID" });
            DropIndex("dbo.InvoiceProducts", new[] { "Product_ID" });
            DropIndex("dbo.InvoiceProducts", new[] { "Invoice_ID" });
            DropIndex("dbo.Products", new[] { "Categories_ID" });
            DropTable("dbo.login_check");
            DropTable("dbo.ResetCashMoneys");
            DropTable("dbo.PersonTypes");
            DropTable("dbo.People");
            DropTable("dbo.InvoiceSellPermisions");
            DropTable("dbo.Payment_Type");
            DropTable("dbo.invoiceTypePrices");
            DropTable("dbo.InvoiceTypes");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceProducts");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
