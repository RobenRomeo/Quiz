using QuizApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testGui
{
    public void InitializeQuestions()
    {
        List<Question> Question = new List<Question>();

        // Question 1
        Question question1 = new Question
        {
            Text = "What is encapsulation in OOP?",
            Choices = new List<string> {
            "A process of hiding the implementation details and showing only the functionality to the user.",
            "A process of creating a new class from an existing class.",
            "A process of combining data and methods into a single unit."
        },
            CorrectChoiceIndex = 0 // A process of hiding the implementation details and showing only the functionality to the user.
        };
        object questions = null;
        questions.Add(question1);

        // Question 2
        Question question2 = new Question
        {
            Text = "What is inheritance in OOP?",
            Choices = new List<string> {
            "A process of hiding the implementation details and showing only the functionality to the user.",
            "A process of creating a new class from an existing class.",
            "A process of combining data and methods into a single unit."
        },
            CorrectChoiceIndex = 1 // A process of creating a new class from an existing class.
        };
        questions.Add(question2);

        // Question 3
        Question question3 = new Question
        {
            Text = "What is polymorphism in OOP?",
            Choices = new List<string> {
            "A process of hiding the implementation details and showing only the functionality to the user.",
            "A process of creating a new class from an existing class.",
            "A process of having multiple forms of a single object."
        },
            CorrectChoiceIndex = 2 // A process of having multiple forms of a single object.
        };
        questions.Add(question3);

        // Question 4
        Question question4 = new Question
        {
            Text = "What is a constructor in OOP?",
            Choices = new List<string> {
            "A method that is called when an object is created.",
            "A method that is called when an object is destroyed.",
            "A method that is used to access the data members of a class."
        },
            CorrectChoiceIndex = 0 // A method that is called when an object is created.
        };
        questions.Add(question4);

        // Question 5
        Question question5 = new Question
        {
            Text = "What is a destructor in OOP?",
            Choices = new List<string> {
            "A method that is called when an object is created.",
            "A method that is called when an object is destroyed.",
            "A method that is used to access the data members of a class."
        },
            CorrectChoiceIndex = 1 // A method that is called when an object is destroyed.
        };
        questions.Add(question5);

        // Question 6
        Question question6 = new Question
        {
            Text = "What is a method in OOP?",
            Choices = new List<string> {
            "A process of hiding the implementation details and showing only the functionality to the user.",
            "A process of creating a new class from an existing class.",
            "A function that belongs to a class and performs a specific task."
        },
            CorrectChoiceIndex = 2 // A function that belongs to a class and performs a specific task.
        };
        questions.Add(question6);

        // Question 7
        Question question7 = new Question
        {
            Text = "What is a class in OOP?",
            Choices = new List<string> {
            "A process of hiding the implementation details and showing only the functionality to the user.",
            "A blueprint for creating objects, providing initial values for state and implementations of behavior.",
            "A function that belongs to a class and performs a specific task."
        },
            CorrectChoiceIndex = 1 // A blueprint for creating objects, providing initial values for state and implementations of behavior.
        };
        questions.Add(question7);

        // Question 8
        Question question8 = new Question
        {
            Text = "What is an object in OOP?",
            Choices = new List<string> {
            "A process of hiding the implementation details and showing only the functionality to the user.",
            "A blueprint for creating objects, providing initial values for state and implementations of behavior.",
            "A function that belongs to a class and performs a specific task."
        },
            CorrectChoiceIndex = 2 // A function that belongs to a class and performs a specific task.
        };
        questions.Add(question8);

        // Question 9
        Question question9 = new Question
        {
            Text = "What is abstraction in OOP?",
            Choices = new List<string> {
            "A process of hiding the implementation details and showing only the functionality to the user.",
            "A process of creating a new class from an existing class.",
            "A process of having multiple forms of a single object."
        },
            CorrectChoiceIndex = 0 // A process of hiding the implementation details and showing only the functionality to the user.
        };
        questions.Add(question9);

        // Question 10
        Question question10 = new Question
        {
            Text = "What is composition in OOP?",
            Choices = new List<string> {
            "A process of hiding the implementation details and showing only the functionality to the user.",
            "A process of creating a new class from an existing class.",
            "A process of combining objects together to create more complex objects."
        },
            CorrectChoiceIndex = 2 // A process of combining objects together to create more complex objects.
        };
        questions.Add(question10);

        // Question 11
        Question question11 = new Question
        {
            Text = "What is aggregation in OOP?",
            Choices = new List<string> {
            "A process of hiding the implementation details and showing only the functionality to the user.",
            "A process of creating a new class from an existing class.",
            "A process of forming a new class from an existing class."
        },
            CorrectChoiceIndex = 2 // A process of forming a new class from an existing class.
        };
        questions.Add(question11);

        // Question 12
        Question question12 = new Question
        {
            Text = "What is method overriding in OOP?",
            Choices = new List<string> {
            "A process of hiding the implementation details and showing only the functionality to the user.",
            "A process of creating a new class from an existing class.",
            "A process of providing a new implementation for a method in the subclass that is already provided by its superclass."
        },
            CorrectChoiceIndex = 2 // A process of providing a new implementation for a method in the subclass that is already provided by its superclass.
        };
        questions.Add(question12);
    }
}
