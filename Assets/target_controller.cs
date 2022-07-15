using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class target_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Patient patient;
    public GameObject patient_panel, resp_panel , hr_panel, graph_object;
    public TextMeshProUGUI name, age, symptoms  , description;
    private AudioSource patient_desc_audio;
    public Animator nurse_animator;
    private bool is_talking_ended;
    private bool is_target_found;

    
    void Start()
    {
        resp_panel.SetActive(false);
        hr_panel.SetActive(false);
        graph_object.SetActive(false);
        patient_desc_audio = GetComponent<AudioSource>();
  

    }

    // Update is called once per frame
    void Update()
    {
        if (!patient_desc_audio.isPlaying && !is_talking_ended && is_target_found)
        {
            is_talking_ended = true;
            nurse_animator.SetTrigger("play_sound");

        }
    }
    public void show_patient_data()
    {
        name.text = patient.name;
        age.text = patient.age.ToString();
        symptoms.text = patient.symptoms;
        description.text = patient.description;
        is_target_found = true;

    }

    public void go_to_resp_panel()
    {

        resp_panel.SetActive(true);
        patient_panel.SetActive(false);

    }

    public void go_to_hr_panel()
    {

        graph_object.SetActive(true);
        hr_panel.SetActive(true);
        patient_panel.SetActive(false);

    }
    public void back_to_patient_panel()
    {
        Debug.Log("zdrg");
        patient_panel.SetActive(true);
        resp_panel.SetActive(false);
        hr_panel.SetActive(false);
        graph_object.SetActive(false);
        

    }
    public void play_clip()
    {
        patient_desc_audio.Play();
        nurse_animator.SetTrigger("play_sound");

    }
    
}
