using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using KModkit;
using System.Text.RegularExpressions;

public class literallySomethingScript : MonoBehaviour {

    public KMAudio audio;
    public KMBombModule bombModule;
    public Material[] colorful;
    public Renderer[] ColorRender;
    public KMBombInfo BombInfo;

    public KMSelectable S;
    public KMSelectable O;
    public KMSelectable M;
    public KMSelectable E;
    public KMSelectable T;
    public KMSelectable H;
    public KMSelectable I;
    public KMSelectable N;
    public KMSelectable G;

    public GameObject SObject;
    public GameObject OObject;
    public GameObject MObject;
    public GameObject EObject;
    public GameObject TObject;
    public GameObject HObject;
    public GameObject IObject;
    public GameObject NObject;
    public GameObject GObject;

    public GameObject Status;

    private bool status;
    private bool isActive;


    private int letterValues;
    private int SletterValue;
    private int OletterValue;
    private int MletterValue;
    private int EletterValue;
    private int TletterValue;
    private int HletterValue;
    private int IletterValue;
    private int NletterValue;
    private int GletterValue;


    private static int moduleIdCounter = 1;
    private int moduleId;
    private bool _isSolved;


    // Use this for initialization
    void Start () {
        moduleId = moduleIdCounter++;
        bombModule.OnActivate += Activate;
        status = false;
        audio = GetComponent<KMAudio>();
        letterValues = 1;
        ColorRender[0].material = colorful[0];
        ColorRender[1].material = colorful[0];
        ColorRender[2].material = colorful[0];
        ColorRender[3].material = colorful[0];
        ColorRender[4].material = colorful[0];
        ColorRender[5].material = colorful[0];
        ColorRender[6].material = colorful[0];
        ColorRender[7].material = colorful[0];
        ColorRender[8].material = colorful[0];
    }
	
	// Update is called once per frame
	void Update () {
        if (status == true)
        {
            Status.gameObject.SetActive(true);
        }
        else
        {
            Status.gameObject.SetActive(false);
        }

        if (letterValues == 10)
        {
            SolveOrNot();
        }

    }

    void Activate()
    {
        isActive = true;
    }

    void Awake()
    {
        S.OnInteract += delegate { LetterS(); return false; };
        O.OnInteract += delegate { LetterO(); return false; };
        M.OnInteract += delegate { LetterM(); return false; };
        E.OnInteract += delegate { LetterE(); return false; };
        T.OnInteract += delegate { LetterT(); return false; };
        H.OnInteract += delegate { LetterH(); return false; };
        I.OnInteract += delegate { LetterI(); return false; };
        N.OnInteract += delegate { LetterN(); return false; };
        G.OnInteract += delegate { LetterG(); return false; };
    }


    //Letter Buttons

    void LetterS()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        Debug.LogFormat("[Literally Something #{0}] S.", moduleId);
        if(SletterValue == 0)
        {
            SletterValue = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[0].material = colorful[1];
    }

    void LetterO()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        Debug.LogFormat("[Literally Something #{0}] O.", moduleId);
        if (OletterValue == 0)
        {
            OletterValue = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[1].material = colorful[1];
    }

    void LetterM()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        Debug.LogFormat("[Literally Something #{0}] M.", moduleId);
        if (MletterValue == 0)
        {
            MletterValue = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[2].material = colorful[1];
    }

    void LetterE()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        Debug.LogFormat("[Literally Something #{0}] E.", moduleId);
        if (EletterValue == 0)
        {
            EletterValue = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[3].material = colorful[1];
    }

    void LetterT()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        Debug.LogFormat("[Literally Something #{0}] T.", moduleId);
        if (TletterValue == 0)
        {
            TletterValue = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[4].material = colorful[1];
    }

    void LetterH()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        Debug.LogFormat("[Literally Something #{0}] H.", moduleId);
        if (HletterValue == 0)
        {
            HletterValue = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[5].material = colorful[1];
    }

    void LetterI()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        Debug.LogFormat("[Literally Something #{0}] I.", moduleId);
        if (IletterValue == 0)
        {
            IletterValue = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[6].material = colorful[1];
    }

    void LetterN()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        Debug.LogFormat("[Literally Something #{0}] N.", moduleId);
        if (NletterValue == 0)
        {
            NletterValue = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[7].material = colorful[1];
    }

    void LetterG()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        Debug.LogFormat("[Literally Something #{0}] G.", moduleId);
        if (GletterValue == 0)
        {
            GletterValue = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[8].material = colorful[1];
    }

    void SolveOrNot()
    {
        if (letterValues == 10 && SletterValue == 1 && OletterValue == 2 && MletterValue == 3 && EletterValue == 4 && TletterValue == 5 && HletterValue == 6 && IletterValue == 7 && NletterValue == 8 && GletterValue == 9)
        {
            bombModule.HandlePass();
            _isSolved = true;
            status = true;

            ColorRender[0].material = colorful[0];
            ColorRender[1].material = colorful[0];
            ColorRender[2].material = colorful[0];
            ColorRender[3].material = colorful[0];
            ColorRender[4].material = colorful[0];
            ColorRender[5].material = colorful[0];
            ColorRender[6].material = colorful[0];
            ColorRender[7].material = colorful[0];
            ColorRender[8].material = colorful[0];

            StartCoroutine(SolveAnimation());
        }
        else
        {
            bombModule.HandleStrike();
            StartCoroutine(AnimateStrike());
        }
    }

    IEnumerator AnimateStrike()
    {
        SletterValue = 0;
        OletterValue = 0;
        MletterValue = 0;
        EletterValue = 0;
        TletterValue = 0;
        HletterValue = 0;
        IletterValue = 0;
        NletterValue = 0;
        GletterValue = 0;
        letterValues = 1;
        ColorRender[0].material = colorful[2];
        ColorRender[1].material = colorful[2];
        ColorRender[2].material = colorful[2];
        ColorRender[3].material = colorful[2];
        ColorRender[4].material = colorful[2];
        ColorRender[5].material = colorful[2];
        ColorRender[6].material = colorful[2];
        ColorRender[7].material = colorful[2];
        ColorRender[8].material = colorful[2];
        yield return new WaitForSeconds(0.1f);
        ColorRender[0].material = colorful[0];
        ColorRender[1].material = colorful[0];
        ColorRender[2].material = colorful[0];
        ColorRender[3].material = colorful[0];
        ColorRender[4].material = colorful[0];
        ColorRender[5].material = colorful[0];
        ColorRender[6].material = colorful[0];
        ColorRender[7].material = colorful[0];
        ColorRender[8].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        ColorRender[0].material = colorful[2];
        ColorRender[1].material = colorful[2];
        ColorRender[2].material = colorful[2];
        ColorRender[3].material = colorful[2];
        ColorRender[4].material = colorful[2];
        ColorRender[5].material = colorful[2];
        ColorRender[6].material = colorful[2];
        ColorRender[7].material = colorful[2];
        ColorRender[8].material = colorful[2];
        yield return new WaitForSeconds(0.1f);
        ColorRender[0].material = colorful[0];
        ColorRender[1].material = colorful[0];
        ColorRender[2].material = colorful[0];
        ColorRender[3].material = colorful[0];
        ColorRender[4].material = colorful[0];
        ColorRender[5].material = colorful[0];
        ColorRender[6].material = colorful[0];
        ColorRender[7].material = colorful[0];
        ColorRender[8].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        ColorRender[0].material = colorful[2];
        ColorRender[1].material = colorful[2];
        ColorRender[2].material = colorful[2];
        ColorRender[3].material = colorful[2];
        ColorRender[4].material = colorful[2];
        ColorRender[5].material = colorful[2];
        ColorRender[6].material = colorful[2];
        ColorRender[7].material = colorful[2];
        ColorRender[8].material = colorful[2];
        yield return new WaitForSeconds(0.1f);
        ColorRender[0].material = colorful[0];
        ColorRender[1].material = colorful[0];
        ColorRender[2].material = colorful[0];
        ColorRender[3].material = colorful[0];
        ColorRender[4].material = colorful[0];
        ColorRender[5].material = colorful[0];
        ColorRender[6].material = colorful[0];
        ColorRender[7].material = colorful[0];
        ColorRender[8].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        S.OnInteract += delegate { LetterS(); return false; };
        O.OnInteract += delegate { LetterO(); return false; };
        M.OnInteract += delegate { LetterM(); return false; };
        E.OnInteract += delegate { LetterE(); return false; };
        T.OnInteract += delegate { LetterT(); return false; };
        H.OnInteract += delegate { LetterH(); return false; };
        I.OnInteract += delegate { LetterI(); return false; };
        N.OnInteract += delegate { LetterN(); return false; };
        G.OnInteract += delegate { LetterG(); return false; };
    }

    IEnumerator SolveAnimation()
    {

        ColorRender[0].material = colorful[1];
        yield return new WaitForSeconds(0.1f);
        ColorRender[1].material = colorful[1];
        yield return new WaitForSeconds(0.1f);
        ColorRender[2].material = colorful[1];
        yield return new WaitForSeconds(0.1f);
        ColorRender[3].material = colorful[1];
        yield return new WaitForSeconds(0.1f);
        ColorRender[4].material = colorful[1];
        yield return new WaitForSeconds(0.1f);
        ColorRender[5].material = colorful[1];
        yield return new WaitForSeconds(0.1f);
        ColorRender[6].material = colorful[1];
        yield return new WaitForSeconds(0.1f);
        ColorRender[7].material = colorful[1];
        yield return new WaitForSeconds(0.1f);
        ColorRender[8].material = colorful[1];
        yield return new WaitForSeconds(0.1f);
        ColorRender[0].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        ColorRender[1].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        ColorRender[2].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        ColorRender[3].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        ColorRender[4].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        ColorRender[5].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        ColorRender[6].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        ColorRender[7].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        ColorRender[8].material = colorful[0];
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(SolveAnimation());
    }
}
