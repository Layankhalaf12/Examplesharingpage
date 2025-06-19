namespace LoopQuestions
{
  
        public partial class MainPage : ContentPage
        {
            private Random random = new();
            private int secretNumber;
            private int num1, num2;

            public MainPage()
            {
                InitializeComponent();
            }

         

            private void OnLoop1Clicked(object sender, EventArgs e)
            {
                string result = "";
                for (int i = 0; i < 10; i++)
                    result += "Welcome to Java 1\n";
                  Loop1Label.Text = result;
            }

            private void OnLoop2Clicked(object sender, EventArgs e)
            {
                Loop2Label.Text = string.Join(", ", Enumerable.Range(-10, 21));
            }

            private void OnLoop3Clicked(object sender, EventArgs e)
            {
                int sum = 0;
                for (int i = 1; i <= 100; i += 2)
                    sum += i;
                Loop3Label.Text = $"Sum of odd numbers: {sum}";
            }

            private void OnLoop4Clicked(object sender, EventArgs e)
            {
                int sum = 0;
                for (int i = 2; i <= 500; i += 2)
                    sum += i;
                Loop4Label.Text = $"Sum of even numbers: {sum}";
            }

            private void OnLoop5Clicked(object sender, EventArgs e)
            {
                var result = Enumerable.Range(1, 200).Where(n => n % 7 == 0);
                Loop5Label.Text = string.Join(", ", result);
            }

            private void OnLoop6Clicked(object sender, EventArgs e)
            {
                var result = Enumerable.Range(1, 200).Where(n => n % 4 == 0 && n % 7 == 0);
                Loop6Label.Text = string.Join(", ", result);
            }

            private void OnStartGuessing(object sender, EventArgs e)
            {
                secretNumber = random.Next(0, 101);
                GuessResultLabel.Text = "Enter your guess";
            }

            private void OnGuessClicked(object sender, EventArgs e)
            {
                int guess = int.Parse(GuessEntry.Text);
                if (guess < secretNumber)
                    GuessResultLabel.Text = "Too low";
                else if (guess > secretNumber)
                    GuessResultLabel.Text = "Too high";
                else
                    GuessResultLabel.Text = "Correct!";
            }

            private void OnMathQuizStart(object sender, EventArgs e)
            {
                num1 = random.Next(0, 10);
                num2 = random.Next(0, 10);
                QuizQuestionLabel.Text = $"What is {num1} + {num2}?";
            }

            private void OnMathQuizAnswer(object sender, EventArgs e)
            {
                string input = QuizAnswerEntry.Text;
                if (input.ToLower() == "q")
                {
                    QuizResultLabel.Text = "Quiz exited.";
                    return;
                }

                int answer = int.Parse(input);
                QuizResultLabel.Text = answer == (num1 + num2) ? "Correct!" : "Try again.";
            }

            private void OnRandomSumClicked(object sender, EventArgs e)
            {
                int sum = 0;
                List<int> nums = new();
                for (int i = 0; i < 10; i++)
                {
                    int r = random.Next(40, 81);
                    nums.Add(r);
                    sum += r;
                }
                RandomSumLabel.Text = $"Numbers: {string.Join(", ", nums)}\nSum: {sum}";
            }

            private void OnPatternA(object sender, EventArgs e)
            {
                string pattern = "";
                for (int i = 1; i <= 6; i++)
                    pattern += new string('*', i) + "\n";
                PatternALabel.Text = pattern;
            }

            private void OnPatternB(object sender, EventArgs e)
            {
                string pattern = "";
                for (int i = 1; i <= 5; i++)
                    pattern += new string('.', 5 - i) + new string((char)(i + '0'), i) + "\n";
                PatternBLabel.Text = pattern;
            }
        }
    }
}
    


