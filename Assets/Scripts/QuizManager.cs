using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required for UI.Button
// using TMPro; // If you're using TextMeshPro, uncomment this

public class QuizManager : MonoBehaviour
{
    // Make sure you have a reference to your Quiz UI Panel if you're hiding/showing it
    public GameObject panelo; // Reference to the quiz panel
    public GameObject konohaPanel;

    // --- Other quiz-related variables (questions, text fields, etc.) would go here ---

    public static QuizManager Instance { get; private set; }

    void Awake()
    {
        Instance = this;

        // Initially hide the quiz panel when the game starts
        if (panelo == null)
            panelo = GameObject.Find("Panelo"); // Try to find by name

        if (panelo != null)
            panelo.SetActive(false); // Hide at start
        else
            Debug.LogWarning("KonohaPanel is not assigned and could not be found in the scene.");

        // Initially hide the quiz panel when the game starts
        if (konohaPanel == null)
            konohaPanel = GameObject.Find("KonohaPanel"); // Try to find by name

        if (konohaPanel != null)
            konohaPanel.SetActive(false); // Hide at start
        else
            Debug.LogWarning("KonohaPanel is not assigned and could not be found in the scene.");
        
    }

    // This is the method your "Start Quiz" button will call!
    public void OnStartQuizButtonClicked()
    {   
        panelo.SetActive(true); // Show the quiz panel
        konohaPanel.SetActive(true);

        /*
        Debug.Log("The 'Start Quiz' button was clicked! Quiz is starting...");

        // Your quiz initialization logic goes here:
        if (quizPanel != null)
        {
            quizPanel.SetActive(true); // Make the quiz UI visible
        }
        // Example: Call your LoadQuestion(), reset score, etc.
        // currentQuestionIndex = 0;
        // score = 0;
        // LoadQuestion();
        } */

        // Other quiz methods like LoadQuestion(), OnAnswerSelected(), EndQuiz() would be below this
    }
    
}