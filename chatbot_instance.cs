using System;
using System.Collections;
using System.Drawing.Text;
using System.Threading;

namespace ChatBot_App
{
    public class chatbot_instance
    {

        private Topic[] topics;
        public chatbot_instance()
        {
            // Initializing the Topics
            topics = new Topic[]
            {
                new Topic("phishing", new string[]
                {
                    "Phishing is a tactic used by hackers to trick users into providing sensitive information.",
                    "Phishing attacks often come in the form of emails or messages that appear to be from legitimate sources.",
                    "Always check the sender's email address and look for signs of phishing, such as poor grammar or urgent requests.",
                    "Never click on links or download attachments from unknown sources, as they may lead to phishing sites."
                }),
                new Topic("password", new string[]
                {
                    "Use a strong password with at least 12 characters, including uppercase, lowercase, numbers, and symbols.",
                    "Avoid using easily guessable information like birthdays or common words in your passwords.",
                    "Consider using a password manager to generate and store complex passwords securely.",
                    "Change your passwords regularly and avoid reusing them across different accounts."
                }),
                new Topic("safe browsing", new string[]
                {
                    "Safe browsing is important to protect against online threats. Use HTTPS, keep software updated, and use reputable security software.",
                    "Be cautious with public Wi-Fi; avoid accessing sensitive information when connected to unsecured networks.",
                    "Limit personal information sharing on social media to reduce the risk of identity theft.",
                    "Always verify the legitimacy of websites before entering personal information."
                }),
                new Topic("how are you", new string[]
                {"I'm feeling chatty and good :)" }),
                new Topic("what's your purpose", new string[]
                {"My purpose is to teach you everything I know about Cybersecurity and also help you to surf or stay safe on the internet."}),
                new Topic("what can i ask you about", new string[]
                { "You can ask me anything about Cybersecurity, and I will tell you everything I know about it, deal?" }),
            };

            // Display welcome message with a border
            Console.ForegroundColor = ConsoleColor.Green;
            DisplayHeader("Welcome to our ChatBot");
            Console.ResetColor();

            // Ask user for their name
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Greet the user
            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect($"\nHello, {userName}! Welcome to our CyberSecurity FAQS. You can ask me about cybersecurity, or type 'exit' to leave");
            Console.ResetColor();

            // Chat loop, the chat continues if the loop is true
            bool chatting = true;

            // Start the chat loop
            while (chatting)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\n {userName}:");
                string userInput = Console.ReadLine()?.ToLower().Trim();
                Console.ResetColor();

                Console.WriteLine("========================================================================================================================");

                // Check if the user wants to exit
                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    TypeEffect("Chatbot: Goodbye! Stay safe online.");
                    Console.ResetColor();
                    chatting = false;
                }
                else
                {
                    // Get response based on user input
                    string response = GetCyberSecurityResponse(userInput);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    TypeEffect($"-- Chatbot: {response}");
                    Console.ResetColor();
                }
            }
        }

        // Method to display a header with a border
        private void DisplayHeader(string header)
        {
            string border = new string('=', 160);
            Console.WriteLine(border);
            Console.WriteLine(header.PadLeft((border.Length + header.Length) / 2));
            Console.WriteLine(border);
        }

        // Method to get a response based on the user's question
        string GetCyberSecurityResponse(string question)
        {
            // Ensure the question is not empty or whitespace
            while (string.IsNullOrWhiteSpace(question))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                TypeEffect("Chatbot: Please ask a cybersecurity-related question: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                question = Console.ReadLine()?.ToLower().Trim();
                Console.ResetColor();
            }

            // Check if the question contains any known topics
            foreach (Topic topic in topics)
            {
                if (question.Contains(topic.Keyword))
                {
                    // Randomly select a response from the topic's responses
                    return topic.GetRandomResponse();
                }
            }

            // Default response if no topics match
            return "I didn't quite understand that. Could you rephrase?";
        }

        // Method to create a typing effect for chatbot responses
        private void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30); // Adjust speed of typing effect
            }
            Console.WriteLine();
        }
    }

    // Class to represent a cybersecurity topic and its responses
    public class Topic
    {
        public string Keyword { get; }
        private string[] Responses { get; }

        public Topic(string keyword, string[] responses)
        {
            Keyword = keyword;
            Responses = responses;
        }

        // Method to get a random response from the topic
        public string GetRandomResponse()
        {
            Random random = new Random();
            int index = random.Next(Responses.Length);
            return Responses[index];
        }//end of constructor
    }// end of class 
}// end of name space

       
    
    
    