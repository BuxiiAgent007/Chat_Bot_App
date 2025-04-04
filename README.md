README - ChatBot_App

Description:
ChatBot_App is a simple C# console-based chatbot designed to educate users about Cybersecurity. It answers questions on topics like phishing, passwords, and safe browsing, while providing helpful safety tips.

Features:
- Interactive chatbot with a typing effect.
- Predefined cybersecurity topics and responses.
- Custom greeting based on the user's name.
- Randomized responses for a more natural feel.
- Easy-to-use and extendable code structure.

How to Use:
1. Run the application.
2. Enter your name when prompted.
3. Ask questions related to cybersecurity topics like:
   - phishing
   - password
   - safe browsing
   - how are you
   - what's your purpose
   - what can I ask you about
4. Type 'exit' anytime to quit the chatbot.

Tech Stack:
- Language: C#
- Environment: Console Application

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Voice Greeting - ChatBot App

This is a simple C# class that plays a greeting sound using the `SoundPlayer` class from `System.Media`. 

## How It Works
- The constructor of the `voice_greeting` class determines the root directory of the application.
- It modifies the path to point to the location of the `greetings.wav` file.
- Then, it plays the `.wav` file synchronously using `SoundPlayer`.
- If an error occurs (e.g., file not found), it catches the exception and prints the error message.

## Requirements
- The `greetings.wav` file must be placed in the root directory of the project (same level as `.csproj`, not inside `bin\Debug`).
- Works on .NET Framework and .NET Core supporting `System.Media`.

## Usage
Instantiate the `voice_greeting` class in your application to play the greeting sound:
```csharp
var greeting = new voice_greeting();
```
Make sure to handle sound file deployment properly when distributing the app.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
# ASCII Art Logo 

This C# program loads a `logo.jpg` image from the root directory of the project, resizes it to 150x120 pixels, 
and renders it as ASCII art in the console. It converts each pixel to a grayscale value and maps that to a specific ASCII character.

## Key Features
- Dynamically locates the image based on the project's base directory.
- Converts the image to grayscale.
- Uses ASCII characters to visualize the image in the console.

## Requirements
- A `logo.jpg` image placed in the root folder of the project (same level as the `.csproj` file).
- .NET Framework or .NET Core to run the application.

## Usage
Build and run the project. The console will display the ASCII representation of the image.

Author: Obakeng Thapelo Makgae ST10437854


