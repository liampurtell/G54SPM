using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public static AudioClip playerJump;
    static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
        playerJump = Resources.Load<AudioClip> ("jump_07");

        audioSrc = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update() {
    }
    public static void PlaySound (string clip)
        {
          switch (clip)
            {
              case "jump_07":
              audioSrc.PlayOneShot(playerJump);
              break;
            }
        }
	}