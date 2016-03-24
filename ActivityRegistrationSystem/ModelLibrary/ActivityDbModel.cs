namespace ModelLibrary
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ActivityDbModel : DbContext
    {
        // Your context has been configured to use a 'ActivityDbModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ModelLibrary.ActivityDbModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ActivityDbModel' 
        // connection string in the application configuration file.
        public ActivityDbModel()
            : base("name=ActivityDbModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<ProjectType> ProjectTypes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Source.Book> Books { get; set; }
        public virtual DbSet<Source.WebPage> WebPages { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}