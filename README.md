# iTrellis CarDealership

This car dealership is a .NET Core 2.0 app developed in conjunction with Angular 6.0

## Tech

iTrellis CarDealership uses a number of open source projects to work properly:

* VS Studio 2017
* Angulat 4.0 or above
* VS Code
* .NET Core 2.0
* Bootsrap
* Sqllite

## APIs

There are only two APIs for this applicaiton:
#### Cars
  Returns json data of filtered cars. If no filter is provided, all cars are returned.

**URL:**
`/cars/{:options}`
**Method:**
  `GET`
**Data Params**

Field | Description
------|------------
Color | `string` Filter cars by color
HasSunroof | `bool` Filters out cars without sunroof if set to `true`
IsFourWheelDrive | `bool` Filters out cars without 4 wheel drive if set to `true`
HasLowMiles | `bool` Filters out cars with high mileage if set to `true`
HasPowerWindows | `bool` Filters out cars without power windows if set to `true`
HasNavigation | `bool` Filters out cars without navigation if set to `true`
HasHeatedSeats | `bool` Filters out cars without seats if set to `true`

## Setup

You need to have .NET Core 2.0, Sqllite, and Angular CLI 4.0 or above to run this application.

#### Method #1 - Command prompt

Open command prompt and go to root directory then follow the next steps:

```sh
/CarDealership/$ cd CarDealership .\CarDealership\
/CarDealership/CarDealership/$ dotnet restore
/CarDealership/CarDealership/$ npm i
/CarDealership/CarDealership/$ dotnet ef database update
/CarDealership/CarDealership/$ dotnet run
```

After running the final command, you should see a line in the command prompt that says 

```sh
Now listening on: http://localhost:{PORT}
```

{PORT} should be some port number. Usually its port 5000.

#### Method #2 - Visual Studio 2017

Launch Visual Studio 2017 and open the solution file CarDealership.sln.

Hit F5 or Build -> Start Debugging to launch the application.

# ENJOY YOUR NEW CAR!