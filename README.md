# Asynchronous-Random-Words
This is for the challenge Asynchronous Random Words in C# Players Guide Fifth Edtion on page 359.

Objectives:
Make the method int RandomlyRecreate(string word). It should take the strings length and generate an equal number of random characters. It is okay to assume all words only use lowercaseletters. One way to randomly generate a lowercase letter is (char)('a' + random.Next(26)). This method should loop until it randomly generates the target word counting the required attempts. The return value is the number of attempts.

Make the method Task<int> RandomlyRecreateAsync(string word) that schedules the above method to run asynchronously (Task.Run is one option).

Have your main method ask the user for a word. Run the RandomlyRecreateAsync method and await its result and display it. Note: Be careful about long words? For me, a five-letter word took several seconds, and my math indicates that a 10-letter word may take nearly two years.

Use DateTime.Now before and after async task runs to measure the wall clock time it took. Display the time elapsed(Level 32).