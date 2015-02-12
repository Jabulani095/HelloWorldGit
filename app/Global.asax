<%@ Application Language="C#" %>

<script runat="server">

    /// <summary>
    /// singleton Design parttern AppHost.
    /// </summary>        
    public class HelloAppHost : ServiceStack.AppHostBase
    {
        /// <summary>
        /// Initializes a new instance of your ServiceStack application, with the specified name and assembly containing the services.
        /// </summary>
        public HelloAppHost() : base("Hello Web Services", typeof(ServiceInterface.HelloWorld.HelloService).Assembly) { }

        /// <summary>
        /// Configure the container with the necessary routes for your ServiceStack application.
        /// </summary>
        /// <param name="container">The built-in IoC used with ServiceStack.</param>
        public override void Configure(Funq.Container container)
        {

           //container.Register<IDbConnectionFactory>(
           //new OrmLiteConnectionFactory("~/HelloWorldDB.sqlite".MapHostAbsolutePath(), SqliteDialect.Provider));
            //Register user-defined REST-ful urls. You can access the service at the url similar to the following.
            //http://localhost/ServiceStack.Hello/servicestack/hello or http://localhost/ServiceStack.Hello/servicestack/hello/John%20Doe
            //You can change /servicestack/ to a custom path in the web.config.
            //Routes
            //  .Add<Hello>("/hello")
            //  .Add<Hello>("/hello/{Name}");
        }
    }

    protected void Application_Start(object sender, EventArgs e)
    {
        //Initialize your application
        (new HelloAppHost()).Init();
    }
       
</script>
