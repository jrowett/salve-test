# Jon's Tech Test

## Back-end

The .NET Core API is in the `SalveTest.Service` project and can be run from within Visual Studio or via `dotnet run` in the normal fashion.

This code is "production ready" in so far as it does the minimum amount of work to satisfy the requirements, in a reasonably SOLID style, with test coverage.

A proper implementation would involve a real database, some configuration, logging, and no doubt a whole lot more!

## Front-end

The React front-end can be run from the `web\salve-web` folder using the `npm start` command. The data can be sorted by clicking on the column headers.

The front-end is neither production-ready nor pretty. Given more time I would put some work into making it look nicer, as well as using environment variables for configuration, putting proper error handling in there, and of course writing tests.

## Thanks for looking!