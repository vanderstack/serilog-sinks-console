﻿// Copyright 2017 Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;

namespace Serilog.Sinks.SystemConsole.Themes
{
    static class AnsiConsoleThemes
    {
        public static AnsiConsoleTheme Literate { get; } = new AnsiConsoleTheme(
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = "\x1b[37;1m",
                [ConsoleThemeStyle.SecondaryText] = "\x1b[37m",
                [ConsoleThemeStyle.Punctuation] = "\x1b[30;1m",
                [ConsoleThemeStyle.Invalid] = "\x1b[33;1m",
                [ConsoleThemeStyle.Null] = "\x1b[34;1m",
                [ConsoleThemeStyle.Name] = "\x1b[37m",
                [ConsoleThemeStyle.String] = "\x1b[36;1m",
                [ConsoleThemeStyle.Number] = "\x1b[35;1m",
                [ConsoleThemeStyle.Boolean] = "\x1b[34;1m",
                [ConsoleThemeStyle.Object] = "\x1b[32;1m",
                [ConsoleThemeStyle.LevelVerbose] = "\x1b[37m",
                [ConsoleThemeStyle.LevelDebug] = "\x1b[37m",
                [ConsoleThemeStyle.LevelInformation] = "\x1b[37;1m",
                [ConsoleThemeStyle.LevelWarning] = "\x1b[33;1m",
                [ConsoleThemeStyle.LevelError] = "\x1b[37;1m\x1b[41;1m",
                [ConsoleThemeStyle.LevelFatal] = "\x1b[37;1m\x1b[41;1m"
            });

        public static AnsiConsoleTheme Grayscale { get; } = new AnsiConsoleTheme(
            new Dictionary<ConsoleThemeStyle, string>
            {
                [ConsoleThemeStyle.Text] = "\x1b[37;1m",
                [ConsoleThemeStyle.SecondaryText] = "\x1b[37m",
                [ConsoleThemeStyle.Punctuation] = "\x1b[30;1m",
                [ConsoleThemeStyle.Invalid] = "\x1b[37;1m\x1b[47m",
                [ConsoleThemeStyle.Null] = "\x1b[37;1m",
                [ConsoleThemeStyle.Name] = "\x1b[37m",
                [ConsoleThemeStyle.String] = "\x1b[37;1m",
                [ConsoleThemeStyle.Number] ="\x1b[37;1m",
                [ConsoleThemeStyle.Boolean] ="\x1b[37;1m",
                [ConsoleThemeStyle.Object] ="\x1b[37;1m",
                [ConsoleThemeStyle.LevelVerbose] = "\x1b[30;1m",
                [ConsoleThemeStyle.LevelDebug] = "\x1b[30;1m",
                [ConsoleThemeStyle.LevelInformation] ="\x1b[37;1m",
                [ConsoleThemeStyle.LevelWarning] = "\x1b[37;1m\x1b[47m",
                [ConsoleThemeStyle.LevelError] = "\x1b[30m\x1b[47;1m",
                [ConsoleThemeStyle.LevelFatal] = "\x1b[30m\x1b[47;1m"
            });
    }
}
