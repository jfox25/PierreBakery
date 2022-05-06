# Pierre's Bakery

By James Fox

A Console app using C# that calculates the cost of bakery goods.

## Technologies Used

- C#
- MSTest
- GIT

## Info

Calculates the cost of an order of bakery goods.

# Project Setup

## To Run Tests

1. Clone this repository to your desktop using git clone

```
git clone https://github.com/jfox25/PierreBakery
```

2. Cd into project

```
cd PierreBakery.Solution
```

2. Open the project in Code Editor

```
code .
```

3. Comment out line 5 in the PierreBakery.csproj file

```
<!-- <OutputType>Exe</OutputType> -->
```

4. Cd into project tests

```
cd PierreBakery.Tests
```

5. Restore the Project

```
dotnet restore
```

6. Run the tests for project

```
dotnet test
```

## To Use UI

1. Uncomment out line 5 in the PierreBakery.csproj file

```
<OutputType>Exe</OutputType>
```

2. Cd into the PierreBakery from PierreBakery.Solution

```
cd PierreBakery
```

3. Run the Project

```
dotnet run
```

## GitHub Link

[Link to Code on GitHub](https://github.com/jfox25/PierreBakery)

## Bugs

No known bugs at this time.

## Future Improvements

- Plan to add more Bakery Items to buy.

## License

MIT
Copyright (c) 2022 James Fox
