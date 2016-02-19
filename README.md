# HW5 - ISEM 551-50-2015/Semester IV (Late Fall)
©Copyright @ZiyuanHuang 
ID: 156230 
Email: zhuang@my.harrisburgu.edu

This project is located in: https://github.com/melhzy/HW5/

Homework 5 is to use C# ASP.net's MVC to create a sample website project contains business, model and data layer.
The website will use some database data to illustrate the website data processing logic.
Web service will be created in HW5 and the web application is going to call web service to populate database data as table list in the web site.

Using the web service to call the connection configuration has to be finished in Web Service level's Web.config file.
Connection string:
  <connectionStrings>
    <add name="EmpInfoConnection" connectionString="Data Source=(local);Initial Catalog=employee;Integrated Security=SSPI;" />
  </connectionStrings>
has to be added under Web Service layer's Web.config file. Directly reference Web.config connection string from Web Service layer in the main project, HW5_WCFSerice in this case, will not work because it returns null in configuration string in Data Access layer.

Configuration values do not transfer between two different layers.