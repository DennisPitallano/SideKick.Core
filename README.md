# SideKick.Core [![Nuget](https://img.shields.io/nuget/v/SideKick.Core?style=flat-square&logo=nuget)](https://www.nuget.org/packages/SideKick.Core) [![Nuget](https://img.shields.io/nuget/dt/SideKick.Core?style=flat-square)](https://www.nuget.org/packages/SideKick.Core)
 <img src="https://raw.githubusercontent.com/DennisPitallano/SideKick.Core/master/SideKick.Core/sidekick.png" alt="SideKick" height="100" style="zoom:25%;" />  Flyweight C# library for your .NET Core Applications. You can use this library to perform commonly use conversions, validations, and other object helpers.

# Installation

1. Download and Install the latest `SideKick.Core` from [NuGet](https://www.nuget.org/packages/SideKick.Core/) using Package Manager, CLI or by adding it to Package Reference:

   ```
   <PackageReference Include="SideKick.Core" Version="1.0.2" />
   ```

   ```
   dotnet add package SideKick.Core --version 1.0.2
   ```

   ```
   PM> Install-Package SideKick.Core -Version 1.0.2
   ```

2. Import the following namespace in the class:

   ```c#
   using SideKick.Core;
   ```

# Sample Usage

#### Validators

Validate string value:

```c#
//import 
using SideKick.Core.Validation;

var strValue = "1234567890";
if (strValue.IsNumber())
{
    //Do something here
}

var myEmailAddress = "dpitallano@gmail.com";
if (myEmailAddress.IsValidEmailAddress())
{
    //Do something here
}
```

#### Helper

```c#
//import 
using SideKick.Core.Helper;
 
var myBirthDate = new DateTime(1990,12,2);
Console.WriteLine($"I was born {myBirthDate.RelativeFormat()}.");

//output
I was born 30 years ago.
```

#### Converters

```c#
using SideKick.Core.Converter;

var strNumber = "123.90";
Console.WriteLine($"Decimal Value: {strNumber.ToDecimal()}");

//output
Decimal Value: 123.90
```



# List of Available Extension

#### Validators

```c#
//datetime validators
bool IsValidDateTime(this DateTime? date)
bool IsValidDateTime(this DateTime date)

//string value validators
bool IsNumber(this string value)
bool IsWholeNumber(this string value)
bool IsDecimalNumber(this string value)
bool IsFloatNumber(this string value)
bool IsBoolean(this string value)
bool IsValidCreditCardNumber(this string value)
bool IsValidJson(this string json)
bool IsValidDateTimeString(this string date)
bool IsFutureDate(this string date)
bool IsValidStandardDateString(this string value)
bool IsHtml(this string value)
bool IsAlphaNumeric(this string value)
bool IsAlphaNumericStrict(this string value)
bool IsValidEmailAddress(this string value)
bool ContainsSpecialCharacter(this string value)
bool IsValidPersonName(this string value)
bool IsIPv6Address(this string value)
bool IsIPAddress(this string value)
bool IsValidUrl(this string value)
bool IsValidDomain(this string value)

```

#### Helpers

```c#
//DateTime Helpers
string RelativeFormat(this DateTime source)
int GetYearsFromDate(this DateTime date)
int GetYearsDifference(this DateTime date, DateTime dateToCompare)
DateTime EndOfDay(this DateTime date)
DateTime EndOfDay(this DateTime date, int timeZoneOffset)
DateTime EndOfWeek(this DateTime date)
DateTime EndOfWeek(this DateTime date, int timeZoneOffset)
DateTime EndOfMonth(this DateTime date)
DateTime EndOfMonth(this DateTime date, int timeZoneOffset)
DateTime EndOfQuarter(this DateTime date)
DateTime EndOfQuarter(this DateTime date, int timeZoneOffset)
DateTime EndOfYear(this DateTime date)
DateTime EndOfYear(this DateTime date, int timeZoneOffset)
DateTime BeginningOfDay(this DateTime date)
DateTime BeginningOfDay(this DateTime date, int timezoneOffset)
DateTime BeginningOfWeek(this DateTime date)
DateTime BeginningOfWeek(this DateTime date, int timezoneOffset)
DateTime BeginningOfMonth(this DateTime date)
DateTime BeginningOfMonth(this DateTime date, int timezoneOffset)
DateTime BeginningOfQuarter(this DateTime date)
DateTime BeginningOfQuarter(this DateTime date, int timezoneOffset)
DateTime BeginningOfYear(this DateTime date)
DateTime BeginningOfYear(this DateTime date, int timezoneOffset)
DateTime IncreaseTime(this DateTime startDate, TimeSpan toAdd)
DateTime DecreaseTime(this DateTime startDate, TimeSpan toSubtract)
DateTime SetTime(this DateTime originalDate, int hour)
DateTime SetTime(this DateTime originalDate, int hour, int minute)
DateTime SetTime(this DateTime originalDate, int hour, int minute, int second)
DateTime SetTime(this DateTime originalDate, int hour, int minute, int second, int millisecond)
DateTime SetHour(this DateTime originalDate, int hour)
DateTime SetMinute(this DateTime originalDate, int minute)
DateTime SetSecond(this DateTime originalDate, int second)
DateTime SetMillisecond(this DateTime originalDate, int millisecond)
DateTime Midnight(this DateTime value)
DateTime Noon(this DateTime value)
DateTime SetDate(this DateTime value, int year)
DateTime SetDate(this DateTime value, int year, int month)
DateTime SetDate(this DateTime value, int year, int month, int day)
DateTime SetYear(this DateTime value, int year)
DateTime SetMonth(this DateTime value, int month)
DateTime SetDay(this DateTime value, int day)
bool IsBefore(this DateTime current, DateTime toCompareWith)
bool IsAfter(this DateTime current, DateTime toCompareWith)
DateTime At(this DateTime current, int hour, int minute)
DateTime At(this DateTime current, int hour, int minute, int second)
DateTime At(this DateTime current, int hour, int minute, int second, int milliseconds)
DateTime FirstDayOfQuarter(this DateTime current)
DateTime FirstDayOfMonth(this DateTime current)
DateTime LastDayOfQuarter(this DateTime current)
DateTime LastDayOfMonth(this DateTime current)
DateTime AddBusinessDays(this DateTime current, int days)
DateTime SubtractBusinessDays(this DateTime current, int days)
bool IsInFuture(this DateTime dateTime)
bool IsInPast(this DateTime dateTime)
DateTime Round(this DateTime dateTime, RoundTo rt)
DateTime FirstDayOfWeek(this DateTime dateTime)
DateTime FirstDayOfYear(this DateTime current)
DateTime LastDayOfWeek(this DateTime current)
DateTime LastDayOfYear(this DateTime current)
DateTime PreviousMonth(this DateTime current)
DateTime NextMonth(this DateTime current)
bool SameDay(this DateTime current, DateTime date)
bool SameMonth(this DateTime current, DateTime date)
bool SameYear(this DateTime current, DateTime date)
//String Helpers	=> coming soon...
//Number Helpers	=> coming soon...
```

#### Conversions

```c#
//byte conversions
string ToBase64Encode(this byte[] inArray)
//string conversions
DateTime ToDateTime(this string value)
DateTime? ToNullableDateTime(this string value)
short ToInt16(this string value)
int ToInt32(this string value)
int? ToNullableInt32(this string value)
long ToInt64(this string value)
long? ToNullableInt64(this string value)
bool ToBoolean(this string value)
float ToFloat(this string value)
decimal ToDecimal(this string value)
double ToDouble(this string value)
string ToBase64Encode(this string value)
string ToBase64Decode(this string value)
byte[] ToByteFromBase64CharArray(this string value)
byte[] ToByteArray(this string value)
string ToDateTimeFormat(this string date, string format)
string ToCamelCase(this string value)
```



# Attribution

<div>Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>

