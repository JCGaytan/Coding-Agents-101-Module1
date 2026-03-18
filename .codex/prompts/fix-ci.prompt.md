# Fix Failing CI Tests

You are an expert C# developer. Your task is to fix failing tests in this repository.

## Repository Structure

- `src/MathUtils/MathCalculator.cs` — the main library with math functions
- `tests/MathUtils.Tests/MathCalculatorTests.cs` — xUnit tests

## Instructions

1. Read the failing test output provided below carefully.
2. Identify the root cause of each failure by examining the source code in `src/MathUtils/MathCalculator.cs`.
3. Fix **only the source code** (`src/MathUtils/MathCalculator.cs`) — do NOT modify the tests.
4. Ensure the fix makes all tests pass without breaking any currently passing tests.
5. Keep changes minimal and surgical — only fix what is broken.

## Rules

- Do NOT change test files.
- Do NOT add new dependencies.
- Do NOT change project structure or `.csproj` files.
- The fix must be in `src/MathUtils/MathCalculator.cs`.

## Expected behavior of each function

- `Add(a, b)` → returns `a + b`
- `Subtract(a, b)` → returns `a - b`
- `Multiply(a, b)` → returns `a * b`
- `Divide(a, b)` → returns `a / b`, throws `DivideByZeroException` when `b == 0`
