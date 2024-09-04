# Identifii WebForum Assessment

This is an example project for an Assessment done Identifii

## How to run the application 

1. Make sure that you have Visual Studio 2022 installed with support for LocalDB 
1. Clone assessment to local folder. How to clone Github repositories [How to clone repositories](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository?tool=webui)
```bash
git clone https://github.com/bothaellen/Identifii
```

2. Update appsettings.json on both WebApi and WebUi to point to a localdb instance for sql server
```json
"ConnectionStrings": {
  "ForumDB": "Server=(localdb)\\mssqllocaldb;Database=ForumDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
3. Execute database update via the package management console using the Update-Database command pointing to WebUi as the startup Project 
```powershell
Update-Database -StartupProject "Identifii.WebUi"
```
4. Testing Api Calls can be tested using the <strong><em>Identifii.WebApi.http</em></strong> file whilst the API is running 


#### Project Structure
- Identifii.ForumDBContext

Code first implementation of the forum Database 

- Identifii.Services 

Central Service for creating likes / comments / posts 

- Identifii.Models 

Shared Models between the Data and Application Requests models 

- Identifii.WebApi

API for external Integration logic i.e. using the services to save data where needed 

- Identifii.WebUi

Blazor Application for Testing the Web Application 


#### Notes
<strong>This assessment is not complete but I decided to dedicate only 16 Hours to this assessment ( 2 days ) </strong>
<em>Hope this helps to explain the logic of how I would follow some of the logic</em>

#### Missing Logic 
- The WebUi is basic, which only shows all posts. 
- Logic with regards to which users can do what is also not implemented yet. 
- Default Integration using IdentityFramework done with default roles defined ( Enum of UserTypes )
- Still need to add logic in UI to show only specific pages based on User Type
- This solution is by no means complete but way of handling different structures ect should be defined according to me 