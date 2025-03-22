# Task Management Application

## 📌 Project Overview
This is a **Task Management Application** developed using **ASP.NET Core MVC and Razor Pages**. The application allows users to manage tasks efficiently by adding, viewing, editing, and deleting tasks. It also includes a secure login system to restrict access.


## 🛠 Features
- ✅ **User Authentication**: Users must log in before managing tasks.
  
- ✅ **Task Management**:
  - Add new tasks
  - View task details
  - Edit existing tasks
  - Delete tasks
    
- ✅ **Validation**:
  - Task ID is generated automatically.
  - Empty fields are not allowed; an error message is displayed if a field is left blank.
  - Incorrect login credentials trigger an error message.
    
- ✅ **Database**: Uses **Microsoft SQL Server** for data storage.

  


## 🔐 User Login Credentials
| Username | Password |
|----------|----------|
| admin    | password |

> **Note:** The system displays an error message if the user enters the wrong credentials or leaves the fields empty.


## 🏗 Technologies Used
- **ASP.NET Core MVC**
- **Razor Pages**
- **Microsoft SQL Server**
- **C#**
- **Entity Framework Core**


## 🚀 Installation Guide
### Prerequisites
Ensure you have the following installed:
- .NET SDK (latest version recommended)
- Microsoft SQL Server
- Visual Studio 2022 (or any compatible IDE)

### Steps to Set Up
1. **Clone the Repository**
   ```sh
   git clone https://github.com/yourusername/your-repo.git
   cd your-repo
   ```
2. **Configure the Database**
   - Update the `appsettings.json` file with your SQL Server connection string.
   ```json
   "ConnectionStrings": {
      "DefaultConnection": " Paste Your SQL Server Connection String Here"
   }
   ```
   - Run the following command to apply migrations:
   ```sh
   dotnet ef database update
   ```
3. **Run the Application**
   ```sh
   dotnet run
   ```
4. Open a web browser and navigate to `http://localhost:5000`



## 🖥 Screenshots
![Welcome Page](https://github.com/Chandupa1999/amf-assignment/blob/fb2cdb08bfd7a5c0a0face5509a938b065e69b24/Images/Welcome%20page.PNG)

![Login Page](https://github.com/Chandupa1999/amf-assignment/blob/b4b8ef2c804cd48b88007047f457576f51a2dad2/Images/Login%20Page.PNG)

![Login Page Error](https://github.com/Chandupa1999/amf-assignment/blob/b4b8ef2c804cd48b88007047f457576f51a2dad2/Images/Login%20Page%20with%20error.PNG)

![View Tasks](https://github.com/Chandupa1999/amf-assignment/blob/b4b8ef2c804cd48b88007047f457576f51a2dad2/Images/View%20Tasks.PNG)

![Add Task](https://github.com/Chandupa1999/amf-assignment/blob/b4b8ef2c804cd48b88007047f457576f51a2dad2/Images/Add%20task.PNG)

![Add Task Error](https://github.com/Chandupa1999/amf-assignment/blob/b4b8ef2c804cd48b88007047f457576f51a2dad2/Images/Add%20task%20error.PNG)

![Edit Task](https://github.com/Chandupa1999/amf-assignment/blob/b4b8ef2c804cd48b88007047f457576f51a2dad2/Images/Edit%20Task.PNG)

![Edit Task Error](https://github.com/Chandupa1999/amf-assignment/blob/b4b8ef2c804cd48b88007047f457576f51a2dad2/Images/Edit%20task%20with%20error.PNG)

![Delete Task](https://github.com/Chandupa1999/amf-assignment/blob/b4b8ef2c804cd48b88007047f457576f51a2dad2/Images/Tasks%20deleted.PNG)


## 🤝 Contributing
Feel free to submit a pull request if you find a bug or have a feature suggestion.


## 👨‍💻 Author
chadupa1999

---
🚀 Developed with ❤️ using **ASP.NET Core MVC & Razor Pages**
