# Unit Conversion API

## Overview

Unit Conversion API is an ASP.NET Core Web API that converts numerical values between different units of measurement.

The API currently supports the following conversion categories:

* Length

  * Meter
  * Kilometer
  * Foot
  * Inch

* Weight / Mass

  * Kilogram
  * Gram
  * Pound

* Temperature

  * Celsius
  * Fahrenheit
  * Kelvin

The solution is designed to be extensible, allowing additional conversion categories and units to be added with minimal changes.

---

## Architecture

The application follows a modular and extensible design using the Strategy Pattern.

### Components

* Controllers

  * Handles HTTP requests and responses.

* Services

  * Coordinates conversion operations.

* Converters

  * Contains category-specific conversion logic.
  * Each converter implements the `IUnitConverter` interface.

* Models

  * Request and response DTOs.

### Design Benefits

* Separation of concerns
* Easy maintenance
* Supports future expansion to hundreds of units
* Dependency Injection support
* Testable architecture

---

## API Endpoint

### Convert Units

**POST**

```http
/api/Conversion/convert
```

### Request

```json
{
  "value": 10,
  "fromUnit": "meter",
  "toUnit": "foot"
}
```

### Response

```json
{
  "originalValue": 10,
  "fromUnit": "meter",
  "toUnit": "foot",
  "convertedValue": 32.808398950131235
}
```

---

## Running the Application

### Prerequisites

* .NET 8 SDK or later

### Clone Repository

```bash
git clone <repository-url>
cd UnitConversionApi
```

### Restore Packages

```bash
dotnet restore
```

### Build Project

```bash
dotnet build
```

### Run Application

```bash
dotnet run
```

### Swagger UI

After starting the application, open:

```text
http://localhost:5058/swagger
```

(Port may vary depending on local configuration.)

---

## Running Tests

```bash
dotnet test
```

---

## Supported Conversions

### Length

* meter ↔ kilometer
* meter ↔ foot
* meter ↔ inch
* kilometer ↔ foot
* kilometer ↔ inch

### Weight

* kilogram ↔ gram
* kilogram ↔ pound
* gram ↔ pound

### Temperature

* celsius ↔ fahrenheit
* celsius ↔ kelvin
* fahrenheit ↔ kelvin

---

## Error Handling

Invalid conversions between different categories return a Bad Request response.

Example:

```json
{
  "error": "Conversion from 'meter' to 'celsius' is not supported."
}
```

---

## Future Improvements

* Store unit definitions in a database
* Add support for additional conversion categories
* Versioned APIs
* Logging and monitoring
* Caching frequently used conversions
* Integration tests
* Containerization using Docker

---

## Design Decisions

* Conversion logic is separated by category using dedicated converter classes.
* Dependency Injection is used to register and resolve converters.
* The architecture allows new conversion categories to be added without modifying existing conversion implementations.
* Units and conversion factors are currently hardcoded to keep the solution simple while demonstrating extensibility.
