# Unit Conversion API

A RESTful ASP.NET Core Web API that converts values between different units of measurement using a scalable and extensible architecture based on the Strategy Pattern.

## Features

* Length, Weight, and Temperature conversions
* Strategy Pattern implementation
* Dependency Injection
* Swagger/OpenAPI documentation
* Unit Testing support
* Extensible design for adding new units and categories

## Tech Stack

* ASP.NET Core 8
* C#
* Swagger / OpenAPI
* xUnit & FluentAssertions
* Git & GitHub

## Supported Units

| Category    | Units                        |
| ----------- | ---------------------------- |
| Length      | Meter, Kilometer, Foot, Inch |
| Weight      | Kilogram, Gram, Pound        |
| Temperature | Celsius, Fahrenheit, Kelvin  |

## API Endpoint

**POST** `/api/conversion/convert`

### Sample Request

```json
{
  "value": 10,
  "fromUnit": "meter",
  "toUnit": "foot"
}
```

### Sample Response

```json
{
  "originalValue": 10,
  "fromUnit": "meter",
  "toUnit": "foot",
  "convertedValue": 32.8084
}
```

## Design Patterns

* **Strategy Pattern** – Encapsulates category-specific conversion logic.
* **Dependency Injection** – Improves maintainability, scalability, and testability.

## Run Locally

```bash
git clone https://github.com/AnimaIndu/unit-conversion-api.git
cd UnitConversionApi
dotnet restore
dotnet run
```

## Design Decisions

* Implemented the Strategy Pattern to separate conversion logic by category.
* Used Dependency Injection to improve maintainability and testability.
* Kept unit definitions and conversion factors hardcoded to keep the implementation simple while demonstrating extensibility.
* Designed the solution so that additional conversion categories and units can be added with minimal code changes.
* Structured the project into Controllers, Services, Models, and Converters to maintain separation of concerns.


Swagger UI:

```text
http://localhost:5058/swagger
```

## Future Enhancements

* API Versioning
* Docker Support
* Redis Caching
* CI/CD with GitHub Actions
* Integration Testing

## Author

**Anima Indu**
