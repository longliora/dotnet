

// //Khởi tạo ứng dụng
// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
// // Thêm một Middleware vào pipeline
// app.Run(async context =>
// {
//     await context.Response.WriteAsync("Hello world");
// });
// app.Run();


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
// // Tạo Middleware 1
// app.Use(async (context, next) =>
// {
//     await context.Response.WriteAsync("<div> Middleware 1 </div>");
//     await next.Invoke();
// });
// // Tạo Middleware 2
// app.Run(async (context) =>
// {
//     await context.Response.WriteAsync("<div> Middleware 2 </div>");
// });
// app.Run();



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// Tạo Middleware 1
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("<div> Beginning of Middleware 1 </div>");
    await next.Invoke();
    await context.Response.WriteAsync("<div> End of Middleware 1 </div>");
});
// Tạo Middleware 2
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("<div> Beginning of Middleware 2 </div>");
    await next.Invoke();
    await context.Response.WriteAsync("<div> End of Middleware 2 </div>");
});
// Tạo Middleware 3
app.Run(async (context) =>
{
    await context.Response.WriteAsync("<div> Hello World from Middleware 3 </div>");
});
app.Run();

/*

Pipeline là luồng xử lý request/response của ứng dụng, trong đó:

Request đi từ trên xuống dưới

Qua từng middleware

Sau đó response đi ngược lên lại


- app.use() được dùng ở middleware đầu hoặc giữa pipeline, nó sẽ cho phép các middleware tiếp theo được thực thi. 
Nếu bạn gọi app.use() ở middleware cuối cùng, thì các middleware trước đó sẽ được thực thi,
nhưng middleware sau đó sẽ không được thực thi vì app.run() sẽ kết thúc pipeline.

- app.run() được dùng ở middleware cuối cùng, nó sẽ kết thúc pipeline và trả về response cho client.
Nếu gọi app.run() ở middleware đầu tiên, thì các middleware sau đó sẽ không được thực thi,
vì app.run() sẽ kết thúc pipeline ngay lập tức.


*/