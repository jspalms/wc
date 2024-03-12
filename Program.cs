using System.CommandLine;

var countBytesOption = new Option<bool>(
            name: "-c",
            description: "Count the number of bytes in a file.");

var countLinesOption = new Option<bool>(
            name: "-l",
            description: "Count the number of lines in a text file.");

var countWordsOption = new Option<bool>(
            name: "-w",
            description: "Count the number of words in a text file.");

var countCharactersOption = new Option<bool>(
            name: "-m",
            description: "Count the number of Characters in a text file.");

var fileArgument = new Argument<string?>(description: "Path to the file to analyse.", name: "file path", getDefaultValue: () => null);

var rootCommand = new RootCommand("WC clone for powershell");

rootCommand.AddOption(countBytesOption);
rootCommand.AddOption(countLinesOption);
rootCommand.AddOption(countWordsOption);
rootCommand.AddOption(countCharactersOption);

rootCommand.AddArgument(fileArgument);


rootCommand.SetHandler((fileInput, countBytesOption, countLineOption, countWordsOption, countCharactersOption) =>
    {
        Stream streamInput;
        MemoryStream ms = new MemoryStream();
        if (fileInput == null)
        {
            streamInput = Console.OpenStandardInput();
        }
        else
        {
            streamInput = File.OpenRead(fileInput);
        }
        streamInput.CopyTo(ms);


        if (countBytesOption)
        {
            Console.WriteLine(Utilities.GetFileSize(ms));
        }
        if (countLineOption)
        {
            Console.WriteLine(Utilities.GetFileLines(ms));
        }
        if (countWordsOption)
        {
            Console.WriteLine(Utilities.GetAllWords(ms));
        }

        if (countCharactersOption)
        {
            Console.WriteLine(Utilities.GetAllCharacters(ms));
        }
        if (!countBytesOption && !countLineOption && !countWordsOption && !countCharactersOption)
        {
            Console.WriteLine(Utilities.GetFileSize(ms));
            Console.WriteLine(Utilities.GetFileLines(ms));
            Console.WriteLine(Utilities.GetAllWords(ms));
        }

    },
    fileArgument, countBytesOption, countLinesOption, countWordsOption, countCharactersOption);


return await rootCommand.InvokeAsync(args);