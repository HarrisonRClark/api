
# Learning to create a Restful API

This project will be used to document my learning process when it comes to creating restful API's in ASP Core (.NET 6).




## Cloning the Repository

First you need to clone the repository into your local directory, open your terminal and cd to your development folder.

Next, clone the repository:

```bash
git clone https://github.com/HarrisonRClark/api.git
```

That should create an 'api' folder in your current directory, you now need to cd into that to access the project's contents.

```bash
cd api
```


## Usage

There will eventually be multiple working examples split in to subfolders for this repository as I learn more, but the first project is making use of an In Memory database - as it negates the need to set up a SQL server instance etc.

To run this, go into the sub folder:

```bash
cd in-memory
```

now enter the following command to spin up the local API server.

```bash
dotnet run
```
It might take a short while to build when you first run, but once it's complete - you should see an info pop up that looks something like this:

```powershell
Building...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7176
```

### Pull data

If you navigate to the url listed in the terminal: [https://localhost:7176/api/todoitems/](https://localhost:7176/api/todoitems/) (replacing the port number with the port you received above), you should be presented with an empty array. This is normal, as the data is only stored In Memory. You will need to post some data to test this is populated in a moment.

Each object has a unique ID which can be used when you're pulling data specifically for one item. So for example [https://localhost:7176/api/todoitems/3](https://localhost:7176/api/todoitems/3) would return the object with an ID of 3.


### Post data
To post data to the API, you can use something like Postman, or use [Http-repl](https://learn.microsoft.com/en-us/aspnet/core/web-api/http-repl/?view=aspnetcore-6.0) which is what is used in the Microsoft Learning documentation I followed. If you use Postman, you'll need to have the desktop version in order to request to localhost, you'll also need to set Authorization to **None**.

The post request is the same as the url listed eariler, replacing the port where applicable: [https://localhost:7176/api/todoitems/](https://localhost:7176/api/todoitems/)

As this is a simple Todo app, the only fields you need to post is the **name** (string) and an **isCompleted** flag (bool). This can be in the body of the request in a simple json format:

```json
{
  "name" : "Walk the dog",
  "isCompleted" : false
}
```

Once you post data, you should see that the array is populated when you pull data again. If you run the Post command a few times with different names, you can see that the array grows and each item is assigned a unique ID. 




