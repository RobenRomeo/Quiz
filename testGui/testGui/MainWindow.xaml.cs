using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace QuizApp
{
    public partial class MainWindow : Window
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public MainWindow()
        {
            InitializeComponent();
            InitializeQuestions();
            DisplayCurrentQuestion();
        }

        private void InitializeQuestions()
        {
            //questions 
        }

        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                txtQuestion.Text = questions[currentQuestionIndex].Text;
                rbChoiceA.Content = questions[currentQuestionIndex].Choices[0];
                rbChoiceB.Content = questions[currentQuestionIndex].Choices[1];
                rbChoiceC.Content = questions[currentQuestionIndex].Choices[2];
            }
        }

        private void CheckAnswer()
        {
            if (currentQuestionIndex < questions.Count &&
                (rbChoiceA.IsChecked == true || rbChoiceB.IsChecked == true || rbChoiceC.IsChecked == true))
            {
                int selectedChoiceIndex = rbChoiceA.IsChecked == true ? 0 : rbChoiceB.IsChecked == true ? 1 : 2;
                if (selectedChoiceIndex == questions[currentQuestionIndex].CorrectChoiceIndex)
                {
                    score++;
                }
            }
        }

        private void NextQuestion()
        {
            if (currentQuestionIndex < questions.Count - 1)
            {
                currentQuestionIndex++;
                DisplayCurrentQuestion();
                rbChoiceA.IsChecked = rbChoiceB.IsChecked = rbChoiceC.IsChecked = false; // Clear selection
            }
            else
            {
                // Quiz is complete, display final score
                MessageBox.Show($"Your score is: {score} out of {questions.Count}");
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer();
            NextQuestion();
        }

        // Other event handlers for user interactions
    }

    public class Question
    {
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public int CorrectChoiceIndex { get; set; }
    }
}
