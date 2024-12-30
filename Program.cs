var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) => {


    await context.Response.WriteAsync("This is Tehreem Fatima.\n");
    await next(context);

});
app.Use(async (context, next) => {


    await context.Response.WriteAsync("I'm pursuing diploma in Software Engineering.\n");
    await next(context);

});
app.Use(async (context, next) => {


    await context.Response.WriteAsync("Also pursuing degree in IT.\n");
    await next(context);

});
app.Use(async (context, next) => {


    await context.Response.WriteAsync("Aim to continue growing and contributing to the ever-evolving tech industry.\n");
    await next(context);

});
app.Run(async (context) => {

    await context.Response.WriteAsync("This is Tehreem Fatima,I'm pursuing diploma in Software Engineering,Also pursuing degree in IT,Aim to continue growing and contributing to the ever-evolving tech industry.\n");
});









app.Run();
