# MathUtils — C# Console App

A simple C# console application demonstrating math utility functions, xUnit tests, GitHub Actions CI, Codex-powered auto-fix, and automated grading.

---

## Project Structure

```
MathUtils/
├── src/MathUtils/            # Console app + MathCalculator library
│   ├── MathCalculator.cs     # Add, Subtract, Multiply, Divide functions
│   └── Program.cs            # Entry point
├── tests/MathUtils.Tests/    # xUnit test project
│   └── MathCalculatorTests.cs
├── .github/workflows/
│   ├── ci.yml                # CI: build & test on every PR
│   ├── codex-autofix.yml     # Auto-fix failing tests with Codex
│   └── grade.yml             # Automated grading workflow
├── .codex/prompts/
│   └── fix-ci.prompt.md      # Prompt used by the auto-fix workflow
└── README.md
```

---

## How to Run Tests Locally

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Steps

```bash
# Restore dependencies
dotnet restore

# Build
dotnet build

# Run all tests
dotnet test

# Run tests with verbose output
dotnet test --verbosity normal
```

Expected output shows **3 failing** tests (intentional bug in `Multiply`) and **8 passing**.

---

## How to Run CI

CI runs automatically on every **pull request** and **push to `main`**.

To trigger manually:
1. Open a Pull Request targeting `main`.
2. GitHub Actions will run `.github/workflows/ci.yml` automatically.
3. View results in the **Actions** tab of the repository.

The CI workflow:
- Restores and builds the solution
- Runs all xUnit tests
- Uploads test results as an artifact

---

## How to Run the Auto-fix Workflow

The Codex Auto-fix workflow uses the [Codex CLI](https://github.com/openai/codex) to automatically detect and fix failing tests, then pushes a patch commit back to the PR branch.

### Setup

Add your OpenAI API key as a repository secret:
1. Go to **Settings → Secrets and variables → Actions**
2. Create a secret named `OPENAI_API_KEY` with your OpenAI API key.

### Trigger

1. Open a Pull Request that has failing tests.
2. Go to **Actions → Codex Auto-fix → Run workflow**.
3. Enter the PR number and click **Run workflow**.
4. The workflow will:
   - Run the tests and detect failures
   - Call Codex with the prompt in `.codex/prompts/fix-ci.prompt.md`
   - Apply the fix to the source code
   - Verify all tests pass
   - Push the fix as a new commit to the PR branch
   - Comment on the PR with a summary

---

## How Grading Works

The grading workflow scores a PR automatically based on test results and deliverable completeness.

### Scoring

| Criteria | Points |
|----------|--------|
| Test pass rate | up to 90 pts (% of tests passing) |
| README.md present (>10 lines) | +5 pts |
| All 3 workflows present | +5 pts |
| **Maximum** | **100 pts** |

### Grade Scale

| Score | Grade |
|-------|-------|
| 90–100 | A |
| 80–89  | B |
| 70–79  | C |
| 60–69  | D |
| < 60   | F |

### Trigger

Grading runs automatically on every **pull request** to `main`, or manually:
1. Go to **Actions → Grade PR → Run workflow**.
2. A comment is posted on the PR with the full grading report.
3. The workflow **fails** if the score is below 60.

---

## The Intentional Bug

`MathCalculator.Multiply` currently uses division (`/`) instead of multiplication (`*`). This causes 3 tests to fail. The **Codex Auto-fix** workflow is designed to detect and repair this automatically.
