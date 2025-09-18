# MissingNumberFinder

## Overview
`MissingNumberFinder` is a **C# console application** that finds the **single missing number** from a given array containing numbers from the range `0` to `n`. This project is designed following **SOLID principles**, making it modular, maintainable, and extendable.

---

## Description

Given an array of `n` distinct integers taken from the range `0` to `n`, the application returns the **one number that is missing**.

**Input:**  
An array of integers, e.g., `[3, 0, 1]` or `[9, 6, 4, 2, 3, 5, 7, 0, 1]`.

**Output:**  
The missing number from the array.

**Examples:**

Input: [3, 0, 1]
Output: 2

Input: [9, 6, 4, 2, 3, 5, 7, 0, 1]
Output: 8


---

## Algorithm: Arithmetic Series Sum Formula

The application uses the **Arithmetic Series Sum Formula** (also known as Gauss formula) to efficiently find the missing number:

1. **Expected Sum** of the sequence `0..n` is calculated using:

expectedSum = n * (n + 1) / 2;


2. **Actual Sum** of the array is computed by summing all elements.

3. The **missing number** is obtained by subtracting the actual sum from the expected sum:

{Missing Number} = {Expected Sum} - {Actual Sum}



---

## Project Structure

```bash
MissingNumberFinder.sln
├─ src/
│ └─ MissingNumberFinder.ConsoleApp/
│ ├─ Program.cs
│ ├─ IMissingNumberFinder.cs
│ ├─ ArithmeticSeriesMissingNumberFinder.cs
```


* `IMissingNumberFinder` — Interface defining the missing number finder contract.  
* `ArithmeticSeriesMissingNumberFinder` — Implementation using arithmetic series sum formula.  
* `Program.cs` — Entry point demonstrating example usage.

---

## Runtime Environment Setup (macOS)

1. **Install .NET 9 SDK**  
   Download from [Microsoft .NET](https://dotnet.microsoft.com/en-us/download/dotnet/9.0).  
   Verify installation:

   ```bash
   dotnet --version
   ```
   Example output:
    9.0.305

2. **Install VS Code and the C# extension (OmniSharp).**

3. **Open the project folder in VS Code.**

## Build and Run

**Build the project:**

```bash
dotnet build
```

**Run the console app:**
```bash
dotnet run --project src/MissingNumberFinder.ConsoleApp
```
``` bash
Expected output:

Missing number in [3,0,1]: 2
Missing number in [9,6,4,2,3,5,7,0,1]: 8
```

**Clean build (optional):**
```bash
dotnet clean
dotnet build
```

**Run the tests:**
```bash
dotnet test
```

example output
```bash
MissingNumberFinder.Tests test succeeded (0.3s)

Test summary: total: 4, failed: 0, succeeded: 4, skipped: 0, duration: 0.3s
Build succeeded with 2 warning(s) in 0.7s
```