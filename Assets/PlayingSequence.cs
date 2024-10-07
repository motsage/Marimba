using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingSequence : MonoBehaviour
{

   
    static int count = 0;

    public GameObject[] FreemodeNotes;
    public GameObject[] highlighterArray;
    public GameObject[] HideHighlighterArray;
    static bool isColliding = true;
    public GameObject[] menuUI;
    static bool freeMode = false;

    public GameObject[] highlighterArray2;
    public GameObject[] HideHighlighterArray2;

    public GameObject[] highlighterArray3;
    public GameObject[] HideHighlighterArray3;

    public GameObject[] highlighterArray4;
    public GameObject[] HideHighlighterArray4;

    public GameObject[] highlighterArray5;
    public GameObject[] HideHighlighterArray5;

    public GameObject[] highlighterArray6;
    public GameObject[] HideHighlighterArray6;

    public GameObject[] highlighterArray7;
    public GameObject[] HideHighlighterArray7;

    public GameObject[] highlighterArray8;
    public GameObject[] HideHighlighterArray8;

    public GameObject[] highlighterArray9;
    public GameObject[] HideHighlighterArray9;

    public GameObject[] highlighterArray10;
    public GameObject[] HideHighlighterArray10;

    public GameObject[] highlighterArray11;
    public GameObject[] HideHighlighterArray11;

    static bool FirstSong = false;
    static bool SecondSong = false;
    static bool ThirdSong = false;
    static bool FourthSong = false;
    static bool FifthSong = false;
    static bool SixthSong = false;
    static bool SeventhSong = false;
    static bool EighthSong = false;
    static bool NinethSong = false;
    static bool TenthSong = false;
    static bool EleventhSong = false;

    public AudioSource WellDone;
    public GameObject UICanvas;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        isColliding = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!isColliding) return;
        isColliding = false;

        if (FirstSong == true)
        {
            if (freeMode == false)
            {
            

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay());
                }
            }
        }
        else if (SecondSong == true)
        {
            if (freeMode == false)
            {

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay2());
                }
            }
        }
        else if (ThirdSong == true)
        {
            if (freeMode == false)
            {

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay3());
                }
            }
           
        }
        else if (FourthSong == true)
        {
            if (freeMode == false)
            {

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay4());
                }
            }
        }
        else if (FifthSong == true)
        {
            if (freeMode == false)
            {

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay5());
                }
            }
        }
        else if (SixthSong == true)
        {
            if (freeMode == false)
            {

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay6());
                }
            }
        }
        else if (SeventhSong == true)
        {
            if (freeMode == false)
            {

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay7());
                }
            }
        }
        else if (EighthSong == true)
        {
            if (freeMode == false)
            {

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay8());
                }
            }
        }
        else if (NinethSong == true)
        {
            if (freeMode == false)
            {

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay9());
                }
            }
        }
        else if (TenthSong == true)
        {
            if (freeMode == false)
            {

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay10());
                }
            }
        }
        else if (EleventhSong == true)
        {
            if (freeMode == false)
            {

                if (other.CompareTag("marimbaWood"))
                {
                    hideMesh();
                    StartCoroutine(delay11());
                }
            }
        }

    }
    public void SongPlaylist()
    {
        count = 0;
        ResetSelection();
        FirstSong = true;
      
        for (int x = 0; x < highlighterArray.Length; x++)
        {
            highlighterArray[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray[x].GetComponent<MeshRenderer>().enabled = false;
        }
        highlighterArray[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
        UICanvas.SetActive(false);


    }
    public void SongPlaylist2()
    {
        count = 0;
        ResetSelection();
        SecondSong = true;

        for (int x = 0; x < highlighterArray2.Length; x++)
        {
            highlighterArray2[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray2[x].GetComponent<MeshRenderer>().enabled = false;
        }
       
            Invoke("secondDelay", 2);
        UICanvas.SetActive(false);

    }
    public void SongPlaylist3()
    {
        count = 0;
        ResetSelection();
        ThirdSong = true;
        for (int x = 0; x < highlighterArray3.Length; x++)
        {
            highlighterArray3[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray3[x].GetComponent<MeshRenderer>().enabled = false;
        }

        highlighterArray3[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray3[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
        UICanvas.SetActive(false);

    }
    public void SongPlaylist4()
    {
        count = 0;
        ResetSelection();
        FourthSong = true;
        for (int x = 0; x < highlighterArray4.Length; x++)
        {
            highlighterArray4[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray4[x].GetComponent<MeshRenderer>().enabled = false;
        }

        highlighterArray4[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray4[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
        UICanvas.SetActive(false);

    }
    public void SongPlaylist5()
    {
        count = 0;
        ResetSelection();
        FifthSong = true;
        for (int x = 0; x < highlighterArray5.Length; x++)
        {
            highlighterArray5[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray5[x].GetComponent<MeshRenderer>().enabled = false;
        }

        highlighterArray5[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray5[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
        UICanvas.SetActive(false);

    }
    public void SongPlaylist6()
    {
        count = 0;
        ResetSelection();
        SixthSong = true;

        for (int x = 0; x < highlighterArray6.Length; x++)
        {
            highlighterArray6[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray6[x].GetComponent<MeshRenderer>().enabled = false;
        }

        highlighterArray6[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray6[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
        UICanvas.SetActive(false);

    }
    public void SongPlaylist7()
    {
        count = 0;
        ResetSelection();
        SeventhSong = true;

        for (int x = 0; x < highlighterArray7.Length; x++)
        {
            highlighterArray7[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray7[x].GetComponent<MeshRenderer>().enabled = false;
        }

        highlighterArray7[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray7[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
        UICanvas.SetActive(false);

    }
    public void SongPlaylist8()
    {
        count = 0;
        ResetSelection();
        EighthSong = true;

        for (int x = 0; x < highlighterArray8.Length; x++)
        {
            highlighterArray8[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray8[x].GetComponent<MeshRenderer>().enabled = false;
        }

        highlighterArray8[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray8[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
        UICanvas.SetActive(false);

    }
    public void SongPlaylist9()
    {
        count = 0;
        ResetSelection();
        NinethSong = true;

        for (int x = 0; x < highlighterArray9.Length; x++)
        {
            highlighterArray9[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray9[x].GetComponent<MeshRenderer>().enabled = false;
        }

        highlighterArray9[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray9[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
        UICanvas.SetActive(false);


    }
    public void SongPlaylist10()
    {
        count = 0;
        ResetSelection();
        TenthSong = true;

        for (int x = 0; x < highlighterArray10.Length; x++)
        {
            highlighterArray10[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray10[x].GetComponent<MeshRenderer>().enabled = false;
        }

        highlighterArray10[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray10[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
        UICanvas.SetActive(false);

    }
    public void SongPlaylist11()
    {
        count = 0;
        ResetSelection();
        EleventhSong = true;

        for (int x = 0; x < highlighterArray11.Length; x++)
        {
            highlighterArray11[x].GetComponent<BoxCollider>().enabled = false;
            highlighterArray11[x].GetComponent<MeshRenderer>().enabled = false;
        }

        highlighterArray11[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray11[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
        UICanvas.SetActive(false);

    }


    void secondDelay()
    {
        highlighterArray2[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray2[count].GetComponent<MeshRenderer>().enabled = true;
        count++;
    }
    public void hideMesh()
    {
        for (int x = 0; x < FreemodeNotes.Length; x++)
        {
            FreemodeNotes[x].GetComponent<BoxCollider>().enabled = false;
            FreemodeNotes[x].GetComponent<MeshRenderer>().enabled = false;
        }
    }
    public void UnhideMesh()
    {
        freeMode = true;
        for (int x = 0; x < HideHighlighterArray.Length; x++)
        {
            HideHighlighterArray[x].GetComponent<BoxCollider>().enabled = true;
        //    HideHighlighterArray[x].GetComponent<MeshRenderer>().enabled = true;
        }
      //  menuUI[2].SetActive(true);
      //  menuUI[1].SetActive(false);
      //  menuUI[0].SetActive(false);
    }
    public void MenuSelection()
    {
        menuUI[0].SetActive(false);
        menuUI[1].SetActive(true);
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(.2f);
        Debug.Log("countinf couintuinf" + count);

        if (count == 4)
        {
            yield return new WaitForSeconds(0.2f);
        }else if (count == 8)
        {
            yield return new WaitForSeconds(0.2f);
        }
        else if (count == 10)
        {
            yield return new WaitForSeconds(1f);
        }
        else if (count == 11)
        {
            yield return new WaitForSeconds(0.6f);
        }
      
        else if (count == 19)
        {
            yield return new WaitForSeconds(1f);
        }
        else if (count == 14)
        {
            yield return new WaitForSeconds(0.6f);
        }
        else if (count == 20)
        {
            yield return new WaitForSeconds(0f);
        }
        else if (count == 25)
        {
            yield return new WaitForSeconds(1f);
        }
        else if (count == 26)
        {
            yield return new WaitForSeconds(0.5f);
        }

        if (count != highlighterArray.Length)
        {
            highlighterArray[count].GetComponent<BoxCollider>().enabled = true;
            highlighterArray[count].GetComponent<MeshRenderer>().enabled = true;
            count++;
        }
        else
        {
            WellDone.Play();
            UICanvas.SetActive(true);
        }
          
     
    }
    IEnumerator delay2()
    {
        yield return new WaitForSeconds(.2f);
        Debug.Log("countinf couintuinf" + count);
        if (count == 5)
        {
            yield return new WaitForSeconds(1.5f);
        }
        else if (count == 14)
        {
            yield return new WaitForSeconds(1.5f);
        }
        else if (count == 23)
        {
            yield return new WaitForSeconds(1.5f);
        }

        if (count != highlighterArray2.Length)
        {
            highlighterArray2[count].GetComponent<BoxCollider>().enabled = true;
            highlighterArray2[count].GetComponent<MeshRenderer>().enabled = true;
            count++;
        }
        else
        {
            WellDone.Play();
            UICanvas.SetActive(true);
        }

    }
    IEnumerator delay3()
    {

        yield return new WaitForSeconds(.2f);
        highlighterArray3[count].GetComponent<BoxCollider>().enabled = true;
        highlighterArray3[count].GetComponent<MeshRenderer>().enabled = true;
        count++;

        if (count == 54)
        {
             
            WellDone.Play();
            count = 0;
            StartCoroutine(delay3());
        }
    }
    IEnumerator delay4()
    {

        yield return new WaitForSeconds(0.2f);

         if (count == 7)
          {
              yield return new WaitForSeconds(1f);
          }


          if (count == 14)
          {
              yield return new WaitForSeconds(1f);
          }

          if (count == 21)
          {
              yield return new WaitForSeconds(1f);
          }

          if (count == 28)
          {
              yield return new WaitForSeconds(1f);
          }

          if (count == 34)
          {
              yield return new WaitForSeconds(1f);
          }
        


        if (count != highlighterArray4.Length)
        {
            highlighterArray4[count].GetComponent<BoxCollider>().enabled = true;
            highlighterArray4[count].GetComponent<MeshRenderer>().enabled = true;
            count++;
        }
        else
        {
            WellDone.Play();
            UICanvas.SetActive(true);
        }



    }
    IEnumerator delay5()
    {
        yield return new WaitForSeconds(.2f);

        if (count == 9)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count == 12)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count == 15)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count == 20)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 24)
        {
            yield return new WaitForSeconds(1f);
        }


        if (count != highlighterArray5.Length)
        {
            highlighterArray5[count].GetComponent<BoxCollider>().enabled = true;
            highlighterArray5[count].GetComponent<MeshRenderer>().enabled = true;
            count++;
        }
        else
        {
            WellDone.Play();
            UICanvas.SetActive(true);
        }


        //   if (count == 54)
        //   {
        //        count = 0;
        //       StartCoroutine(delay4());
        //   }
    }
    IEnumerator delay6()
    {
        yield return new WaitForSeconds(0.2f);
        if (count == 7)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count == 12)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count == 20)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count == 25)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count == 30)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count == 35)
        {
            yield return new WaitForSeconds(1.5f);
        }

        if (count == 37)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 38)
        {
            yield return new WaitForSeconds(1.5f);
        }

        if (count == 39)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count == 43)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count == 51)
        {
            yield return new WaitForSeconds(1f);
        }
      


        if (count != highlighterArray6.Length)
        {
            highlighterArray6[count].GetComponent<BoxCollider>().enabled = true;
            highlighterArray6[count].GetComponent<MeshRenderer>().enabled = true;
            count++;
        }
        else
        {
            WellDone.Play();
            UICanvas.SetActive(true);
        }


        //   if (count == 54)
        //   {
        //        count = 0;
        //       StartCoroutine(delay4());
        //   }
    }
    IEnumerator delay7()
    {
        yield return new WaitForSeconds(.2f);
        if (count == 8)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 10)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 12)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 15)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 20)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 24)
        {
            yield return new WaitForSeconds(1f);
        }
       



        if (count != highlighterArray7.Length)
        {
            highlighterArray7[count].GetComponent<BoxCollider>().enabled = true;
            highlighterArray7[count].GetComponent<MeshRenderer>().enabled = true;
            count++;
        }
        else
        {
            WellDone.Play();
            UICanvas.SetActive(true);
        }


        //   if (count == 54)
        //   {
        //        count = 0;
        //       StartCoroutine(delay4());
        //   }
    }
    IEnumerator delay8()
    {
        yield return new WaitForSeconds(.2f);

        /*   if (count == 5)
           {
               yield return new WaitForSeconds(1f);
           }
           if (count == 10)
           {
               yield return new WaitForSeconds(1f);
           }
           if (count == 15)
           {
               yield return new WaitForSeconds(1f);
           }
           if (count == 20)
           {
               yield return new WaitForSeconds(1f);
           }
           if (count == 25)
           {
               yield return new WaitForSeconds(1f);
           }
           if (count == 30)
           {
               yield return new WaitForSeconds(1f);
           }
           if (count == 33)
           {
               yield return new WaitForSeconds(1f);
           }
           if (count == 36)
           {
               yield return new WaitForSeconds(1f);
           }
           */

        if (count != highlighterArray8.Length)
        {
            highlighterArray8[count].GetComponent<BoxCollider>().enabled = true;
            highlighterArray8[count].GetComponent<MeshRenderer>().enabled = true;
            count++;
        }
        else
        {
            WellDone.Play();
            UICanvas.SetActive(true);
        }

       
    }
    IEnumerator delay9()
    {

        if (count == 4)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 8)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 11)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 16)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 26)
        {
            yield return new WaitForSeconds(1f);
        }

        if (count != highlighterArray9.Length)
        {
            highlighterArray9[count].GetComponent<BoxCollider>().enabled = true;
            highlighterArray9[count].GetComponent<MeshRenderer>().enabled = true;
            count++;
        }
        else
        {
            WellDone.Play();
            UICanvas.SetActive(true);
        }


        //   if (count == 54)
        //   {
        //        count = 0;
        //       StartCoroutine(delay4());
        //   }
    }
    IEnumerator delay10()
    {

        yield return new WaitForSeconds(.2f);

        if (count != highlighterArray10.Length)
        {
            highlighterArray10[count].GetComponent<BoxCollider>().enabled = true;
            highlighterArray10[count].GetComponent<MeshRenderer>().enabled = true;
            count++;
        }
        else
            WellDone.Play();


        //   if (count == 54)
        //   {
        //        count = 0;
        //       StartCoroutine(delay4());
        //   }
    }
    IEnumerator delay11()
    {
        if (count == 5)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 8)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 12)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 14)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 17)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 20)
        {
            yield return new WaitForSeconds(1f);
        }
        if (count == 24)
        {
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(.2f);

        if (count != highlighterArray11.Length)
        {
            highlighterArray11[count].GetComponent<BoxCollider>().enabled = true;
            highlighterArray11[count].GetComponent<MeshRenderer>().enabled = true;
            count++;
        }
        else
        {
            WellDone.Play();
            UICanvas.SetActive(true);
        }


        //   if (count == 54)
        //   {
        //        count = 0;
        //       StartCoroutine(delay4());
        //   }
    }

    void ResetSelection()
    {
        freeMode = false;
        FirstSong = false;
        SecondSong = false;
        ThirdSong = false;
        FourthSong = false;
        FifthSong = false;
        SixthSong = false;
        SeventhSong = false;
        EighthSong = false;
        NinethSong = false;
        TenthSong = false;
        EleventhSong = false;

        for (int x = 0; x < FreemodeNotes.Length; x++)
        {
            FreemodeNotes[x].GetComponent<BoxCollider>().enabled = false;
            FreemodeNotes[x].GetComponent<MeshRenderer>().enabled = false;
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
} 
