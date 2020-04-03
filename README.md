# _Animal Shelter API_

#### By _**Steph Podolak**_


## Description

_An ASP.NET API that allows users to access available cats and dogs at an animal shelter_


## Setup/Installation Requirements

### 1.  Install .NET Core

#### on macOS:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp.

#### on Windows:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp.

#### Install dotnet script
Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows).

### 2. Clone this repository

Enter the following commands in Terminal (macOS) or PowerShell (Windows):
```sh
cd desktop
git clone https://github.com/spodolak/AnimalShelter.Solution
cd AnimalShelter.Solution
```
### 3. Install all necessary packages and make sure the project will build
In your terminal, type the following commands to make sure all necessary packages are included in the project and to launch in your browser:
```sh
cd AnimalShelter
dotnet restore
dotnet build
```

### 4. Update the database and tables
Enter the following to update your database and tables for the program:
```sh
dotnet ef database update
```
If you'd like to add seed data to start project, enter the following: (This step is optional)
```sh
dotnet ef migrations add SeedData
dotnet ef database update
```

### 5. Launch the project in your browser
In your terminal, type:
```sh
dotnet watch run
```
Hold ```command``` while clicking the link in your local terminal to your local address, which should be:
```sh
http://127.0.0.1:5000
```

## API Endpoints
_Once you have installed this program, you can use these endpoints on your local host in your browser._

Base URL: ```https://localhost:5000```

### Cats

Access log of current cats in the animal shelter.

#### HTTP Requests
```sh
GET /api/cats
POST /api/cats
GET /api/cats/{id}
PUT /api/cats/{id}
DELETE /api/cats/{id}
```
#### Path Parameters
| Parameter | Type | Default | Description |
| :---: | :---: | :---: | --- |
| name | string | none | Returns matches by cat name.
| traits | string | none | Returns all cats with specified trait. |
| age | int | none | Returns all cats with specified age. |
| gender | string | none | Returns all cats with specified gender. |

#### Example Query
```sh
https://localhost:5000/api/cats/?name=maddie&traits=noisey&age=3&gender=female
```

### Dogs

Interact with the data for reviews that users left for different locations.

#### HTTP Requests
```sh
GET /api/dogs
POST /api/dogs
GET /api/dogs/{id}
PUT /api/dogs/{id}
DELETE /api/dogs/{id}
```

#### Path Parameters
| Parameter | Type | Default | Description |
| :---: | :---: | :---: | --- |
| name | string | none | Returns matches by dog name.
| traits | string | none | Returns all dogs with specified trait. |
| age | int | none | Returns all dogs with specified age. |
| gender | string | none | Returns all dogs with specified gender. |

#### Example Query
```sh
https://localhost:5000/api/dogs/?name=rolf&traits=feisty&age=8&gender=male
```



## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/spodolak/AnimalShelter.Solution/issues) here on GitHub._

## Technologies Used
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _MySQL 2.2.0_
* _EF Core 2.2.0_
* _Razor 2.2.0_
* _NSwag 13.3.0_
* _[Postman](postman.com)_

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Steph Podolak_**
