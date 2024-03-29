# SideKick.Core [![Nuget](https://img.shields.io/nuget/v/SideKick.Core?style=flat-square&logo=nuget)](https://www.nuget.org/packages/SideKick.Core) [![Nuget](https://img.shields.io/nuget/dt/SideKick.Core?style=flat-square)](https://www.nuget.org/packages/SideKick.Core)

 <img src="https://raw.githubusercontent.com/DennisPitallano/SideKick.Core/master/SideKick.Core/sidekick.png" alt="SideKick" height="100" style="zoom:25%;" />  Flyweight C# library for your .NET Core Applications. You can use this library to perform commonly use conversions, validations, and other object helpers.

## This Project has been supported by [JetBrains](https://www.jetbrains.com/shop/eform/opensource)！

<img src="https://www.jetbrains.com/shop/static/images/jetbrains-logo-inv.svg" height="100"> 

# Installation

1. Download and Install the latest `SideKick.Core` from [NuGet](https://www.nuget.org/packages/SideKick.Core/) using Package Manager, CLI or by adding it to Package Reference:
   
   ```
   <PackageReference Include="SideKick.Core" Version="1.0.3" />
   ```
   
   ```
   dotnet add package SideKick.Core --version 1.0.3
   ```
   
   ```
   PM> Install-Package SideKick.Core -Version 1.0.3
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
bool IsBefore(this DateTime current, DateTime toCompareWith)
bool IsAfter(this DateTime current, DateTime toCompareWith)
bool IsWeekend(this DayOfWeek dayOfWeek)
bool IsWeekday(this DayOfWeek dayOfWeek)
bool IsInFuture(this DateTime dateTime)
bool IsInPast(this DateTime dateTime)

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
bool IsNullOrEmpty(this string str)
bool IsNullOrWhiteSpace(this string str)

//Collection validators
bool IsNullOrEmpty<T>([CanBeNull] this ICollection<T> source)
```

#### DateTime Helpers

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
DateTime At(this DateTime current, int hour, int minute)
DateTime At(this DateTime current, int hour, int minute, int second)
DateTime At(this DateTime current, int hour, int minute, int second, int milliseconds)
DateTime FirstDayOfQuarter(this DateTime current)
DateTime FirstDayOfMonth(this DateTime current)
DateTime LastDayOfQuarter(this DateTime current)
DateTime LastDayOfMonth(this DateTime current)
DateTime AddBusinessDays(this DateTime current, int days)
DateTime SubtractBusinessDays(this DateTime current, int days)
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
//Number Helpers    => coming soon...
```

#### String Helpers

```c#
string EnsureEndsWith(this string str, char c, StringComparison comparisonType = StringComparison.Ordinal)
string EnsureStartsWith(this string str, char c, StringComparison comparisonType = StringComparison.Ordinal)
string Left(this string str, int len)
string Right(this string str, int len)
string NormalizeLineEndings(this string str)
int NthIndexOf(this string str, char c, int n)
string RemovePostFix(this string str, params string[] postFixes)
string RemovePostFix(this string str, StringComparison comparisonType, params string[] postFixes)
string RemovePreFix(this string str, params string[] preFixes)
string RemovePreFix(this string str, StringComparison comparisonType, params string[] preFixes)
string ReplaceFirst(this string str, string search, string replace, StringComparison comparisonType = StringComparison.Ordinal)
string[] Split(this string str, string separator)
string[] Split(this string str, string separator, StringSplitOptions options)
string[] SplitToLines(this string str)
string Truncate(this string str, int maxLength)
string TruncateFromBeginning(this string str, int maxLength)
string TruncateWithPostfix(this string str, int maxLength)
string TruncateWithPostfix(this string str, int maxLength, string postfix)
byte[] GetBytes(this string str)
byte[] GetBytes([NotNull] this string str, [NotNull] Encoding encoding)
```

#### Collection Helpers

```c#
IEnumerable<T> AddIfNotContains<T>([NotNull] this ICollection<T> source, IEnumerable<T> items)
bool AddIfNotContains<T>([NotNull] this ICollection<T> source, [NotNull] Func<T, bool> predicate, [NotNull] Func<T> itemFactory)
bool AddIfNotContains<T>([NotNull] this ICollection<T> source, T item)
IList<T> RemoveAll<T>([NotNull] this ICollection<T> source, Func<T, bool> predicate)
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
T ToEnum<T>(this string value)
T ToEnum<T>(this string value, bool ignoreCase)
string ToMd5(this string str)
string ToCamelCase(this string str, bool useCurrentCulture = false)
string ToSentenceCase(this string str, bool useCurrentCulture = false)
string ToKebabCase(this string str, bool useCurrentCulture = false)
string ToPascalCase(this string str, bool useCurrentCulture = false)
```

# Attribution

<div>Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
