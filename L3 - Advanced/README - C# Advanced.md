# Learning C# - Advanced
By Rafael Xolio

## Introduction
This section contains topics to continue Learning C# - Advanced level, I hope this can help others for starting learning.


## Working with APIs

### Prerequisites
![image](https://github.com/user-attachments/assets/fe5d699c-9225-4cab-a251-50d8cb22c8e3)

### Create First API
Start Visual Studio 2022 and select Create a new project.

In the Create a new project dialog:

- Enter Empty in the Search for templates search box.
- Select the ASP.NET Core Empty template and select Next.
![image](https://github.com/user-attachments/assets/37067d3f-37ec-4608-b744-04db0d208445)
![image](https://github.com/user-attachments/assets/ad4a1e3b-3f81-4d58-99a9-eb2e4315bc91)
![image](https://github.com/user-attachments/assets/8b71e6f1-fdae-4eb1-874a-d3e4283bb420)

### Create First Web API

#### Create a new project
- Open Visual Studio
- From the File menu, select New > Project.
- Enter Web API in the search box.
- Select the ASP.NET Core Web API template and select Next.
- In the Configure your new project dialog, name the project TodoApi and select Next.
- In the Additional information dialog:
- Confirm the Framework is .NET 8.0 (Long Term Support).
- Confirm the checkbox for Use controllers(uncheck to use minimal APIs) is checked.
- Confirm the checkbox for Enable OpenAPI support is checked.
- Select Create.

#### Add package to use Database on Memory
A NuGet package must be added to support the database used in this example.

- From the Tools menu, select NuGet Package Manager > Manage NuGet Packages for Solution.
- Select the Browse tab.
- Enter **Microsoft.EntityFrameworkCore.InMemory** in the search box, and then select Microsoft.EntityFrameworkCore.InMemory.
- Select the Project checkbox in the right pane and then select Install.

![image](https://github.com/user-attachments/assets/9a3800ea-2b37-4dd2-baae-474a5914232a)

- Run the project
![image](https://github.com/user-attachments/assets/69b7945d-2726-4d5d-bfe8-b55b314e75ef)

#### Add Molde class

- In Solution Explorer, right-click the project. Select Add > New Folder. Name the folder Models.
- Right-click the Models folder and select Add > Class. Name the class TodoItem and select Add.
- Replace the template code with the following:

```cs
namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}
```


#### Add a database context
The database context is the main class that coordinates Entity Framework functionality for a data model. This class is created by deriving from the **Microsoft.EntityFrameworkCore.DbContext class**.

```cs
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}
```

#### Register the database context
In ASP.NET Core, services such as the DB context must be registered with the dependency injection (DI) container. The container provides the service to controllers.

Update Program.cs with the following highlighted code:

```cs
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
```

#### Scaffold a controller

- Right-click the Controllers folder.
- Select Add > New Scaffolded Item.
- Select API Controller with actions, using Entity Framework, and then select Add.

![image](https://github.com/user-attachments/assets/9d152744-2354-401c-9597-d415203aa457)

In the Add API Controller with actions, using Entity Framework dialog:

- Select TodoItem (TodoApi.Models) in the Model class.
- Select TodoContext (TodoApi.Models) in the Data context class.
- Select Add.
If the scaffolding operation fails, select Add to try scaffolding a second time.

![image](https://github.com/user-attachments/assets/4928b47d-f7e3-4a45-a961-16d76fb3b062)

![image](https://github.com/user-attachments/assets/ed98b8eb-125d-43f1-af39-1622bcab9d39)

The ASP.NET Core templates for:

- Controllers with views include [action] in the route template.
- API controllers don't include [action] in the route template.


#### Update the PostTodoItem create method
Update the return statement in the PostTodoItem to use the nameof operator:

```cs
[HttpPost]
public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
{
    _context.TodoItems.Add(todoItem);
    await _context.SaveChangesAsync();

    //    return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
    return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
}
```
- The preceding code is an HTTP POST method, as indicated by the [HttpPost] attribute. The method gets the value of the TodoItem from the body of the HTTP request.

The CreatedAtAction method:

- Returns an **HTTP 201 status** code if successful. HTTP 201 is the standard response for an HTTP POST method that creates a new resource on the server.
- Adds a Location header to the response. The Location header specifies the URI of the newly created to-do item. For more information, see 10.2.2 201 Created.
- References the GetTodoItem action to create the Location header's URI. The C# **nameof** keyword is used to avoid hard-coding the action name in the CreatedAtAction call.

#### Try Post method
- Run application

![image](https://github.com/user-attachments/assets/ff7d4698-f7a6-4e5e-b882-845d65f10342)

![image](https://github.com/user-attachments/assets/873f7486-a8f5-4d99-9ac8-5560d15f382f)
