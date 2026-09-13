using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{




    public CharacterDatabase characterDB;
   
    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;
    // Start is called before the first frame update
   
    
    
    
  /*  void Start()
    {

        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else { Load(); }


        UpdateCharacter(selectedOption);
    }

    */
    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }

     
        SpriteRenderer birdRenderer = GetComponent<SpriteRenderer>();
        if (birdRenderer != null)
        {
            Character character = characterDB.GetCharacter(selectedOption);
            birdRenderer.sprite = character.characterSprite;
        }
        else
        {
            Debug.LogWarning(" SpriteRenderer not here");
        }
    }










    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;

    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }





}
