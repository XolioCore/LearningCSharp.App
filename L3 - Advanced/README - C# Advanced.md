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
![image](https://github.com/user-attachments/assets/12f86abb-7247-43ed-ae79-29bc98fd8786)

![image](https://github.com/user-attachments/assets/69b7945d-2726-4d5d-bfe8-b55b314e75ef)

