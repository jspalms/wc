# DotNet WC Utility Clone

This is a .NET Core Console Application that functions as a clone of the Linux `wc` utility. The `wc` utility counts the number of bytes, words, and lines in files. This application replicates its functionality with support for the following options:

- `-w`: Count words.
- `-c`: Count bytes.
- `-l`: Count lines.

## Usage

To use this application, follow these steps:

After building, you can run the application using `dotnet run`. The syntax is as follows:

## Options

- **-w**: Count the number of words in the provided file.
- **-c**: Count the number of bytes in the provided file.
- **-l**: Count the number of lines in the provided file.

## Example

Using the included test.txt file `dotnet run -- test.txt` would output

```
339291
7145
59213
```

Made as part of John Cricket's [coding challenge](https://codingchallenges.fyi/challenges/challenge-wc)
