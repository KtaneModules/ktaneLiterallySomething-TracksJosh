using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using KModkit;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

public class literallySomethingScript : MonoBehaviour {

    public KMAudio audio;
    public KMBombModule bombModule;
    public Material[] colorful;
    public Renderer[] ColorRender;
    public KMBombInfo Bomb;

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

    private double[] numb = new double[9];

    private int serInt1;
    private int serInt2;
    private int serInt3;
    private int serInt4;
    private int serInt5;
    private int serInt6;
    private int serInt7;
    private int serInt8;
    private int serInt9;

    private int letterValues;
    private double SletterValue = 0;
    private double OletterValue = 0;
    private double MletterValue = 0;
    private double EletterValue = 0;
    private double TletterValue = 0;
    private double HletterValue = 0;
    private double IletterValue = 0;
    private double NletterValue = 0;
    private double GletterValue = 0;

    private int letterValueS;
    private int letterValueO;
    private int letterValueM;
    private int letterValueE;
    private int letterValueT;
    private int letterValueH;
    private int letterValueI;
    private int letterValueN;
    private int letterValueG;

    private string serialNumber;
    private string serialLetters;

    private static int moduleIdCounter = 1;
    private int moduleId;
    private bool _isSolved;




    // Use this for initialization
    void Start () {
        moduleId = moduleIdCounter++;
        status = false;
        audio = GetComponent<KMAudio>();
        letterValues = 0;
        bombModule.OnActivate += Activate;
        obtainSerial();
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
    void Update ()
    {
        #region Update
        if (status == true)
        {
            Status.gameObject.SetActive(true);
        }
        else
        {
            Status.gameObject.SetActive(false);
        }

        if (letterValues == 9)
        {
            SolveOrNot();
        }
        #endregion
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
        if (SletterValue == 0)
        {
            SletterValue = 1;
            letterValueS = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[0].material = colorful[1];
    }

    void LetterO()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        if (OletterValue == 0)
        {
            OletterValue = 1;
            letterValueO = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[1].material = colorful[1];
    }

    void LetterM()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        if (MletterValue == 0)
        {
            MletterValue = 1;
            letterValueM = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[2].material = colorful[1];
    }

    void LetterE()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        if (EletterValue == 0)
        {
            EletterValue = 1;
            letterValueE = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[3].material = colorful[1];
    }

    void LetterT()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        if (TletterValue == 0)
        {
            TletterValue = 1;
            letterValueT = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[4].material = colorful[1];
    }

    void LetterH()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        if (HletterValue == 0)
        {
            HletterValue = 1;
            letterValueH = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[5].material = colorful[1];
    }

    void LetterI()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        if (IletterValue == 0)
        {
            IletterValue = 1;
            letterValueI = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[6].material = colorful[1];
    }

    void LetterN()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        if (NletterValue == 0)
        {
            NletterValue = 1;
            letterValueN = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[7].material = colorful[1];
    }

    void LetterG()
    {
        audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
        GetComponent<KMSelectable>().AddInteractionPunch();
        if (GletterValue == 0)
        {
            GletterValue = 1;
            letterValueG = letterValues;
            letterValues = (letterValues + 1);
        }
        ColorRender[8].material = colorful[1];
    }

    void obtainSerial()
    {
        serialNumber = Bomb.GetSerialNumber();
        serialLetters = Regex.Replace(serialNumber, @"[\d-]", string.Empty);
        Debug.LogFormat("[Literally Something #{0}] Letters of the serial number: {1}.", moduleId, serialLetters);
        serialLetters = serialLetters + serialLetters + serialLetters + serialLetters;
        serialLetters = serialLetters.Remove(9);
        Debug.LogFormat("[Literally Something #{0}] The Finished string of nine letters: {1}.", moduleId, serialLetters);
        serialProcess();
    }

    void serialProcess()
    {
        char[] separateSerialLetters = serialLetters.ToCharArray();
        int[] serialNumeral = Array.ConvertAll(separateSerialLetters, c => (int)Char.GetNumericValue(c));
        StringBuilder st = new StringBuilder();
        for (int i = 0; i < separateSerialLetters.Length; i++)
        {
            st.Append(separateSerialLetters[i]);
        }
        serInt1 = st[0] - 64;
        serInt2 = st[1] - 64;
        serInt3 = st[2] - 64;
        serInt4 = st[3] - 64;
        serInt5 = st[4] - 64;
        serInt6 = st[5] - 64;
        serInt7 = st[6] - 64;
        serInt8 = st[7] - 64;
        serInt9 = st[8] - 64;
        Debug.LogFormat("[Literally Something #{0}] Alphabetic Positions: S = {1}, O = {2}, M = {3}, E = {4}, T = {5}, H = {6}, I = {7}, N = {8}, G = {9}.", moduleId, serInt1, serInt2, serInt3, serInt4, serInt5, serInt6, serInt7, serInt8, serInt9);
        Adding();
    }

    void Adding()
    {
        serInt1 = serInt1 + 19;
        serInt2 = serInt2 + 15;
        serInt3 = serInt3 + 13;
        serInt4 = serInt4 + 5;
        serInt5 = serInt5 + 20;
        serInt6 = serInt6 + 8;
        serInt7 = serInt7 + 9;
        serInt8 = serInt8 + 14;
        serInt9 = serInt9 + 7;


        Rascal();
    }

    void Rascal()
    {
        if (serInt2 == serInt1)
        {
            serInt2 = serInt2 + 1;
        }
        if (serInt3 == serInt2 || serInt3 == serInt1)
        {
            serInt3 = serInt3 + 1;
        }
        if (serInt4 == serInt3 || serInt4 == serInt2 || serInt4 == serInt1)
        {
            serInt4 = serInt4 + 1;
        }
        if (serInt5 == serInt4 || serInt5 == serInt3 || serInt5 == serInt2 || serInt5 == serInt1)
        {
            serInt5 = serInt5 + 1;
        }
        if (serInt6 == serInt5 || serInt6 == serInt4 || serInt6 == serInt3 || serInt6 == serInt2 || serInt6 == serInt1)
        {
            serInt6 = serInt6 + 1;
        }
        if (serInt7 == serInt6 || serInt7 == serInt5 || serInt7 == serInt4 || serInt7 == serInt3 || serInt7 == serInt2 || serInt7 == serInt1)
        {
            serInt7 = serInt7 + 1;
        }
        if (serInt8 == serInt7 || serInt8 == serInt6 || serInt8 == serInt5 || serInt8 == serInt4 || serInt8 == serInt3 || serInt8 == serInt2 || serInt8 == serInt1)
        {
            serInt8 = serInt8 + 1;
        }
        if (serInt9 == serInt8 || serInt9 == serInt7 || serInt9 == serInt6 || serInt9 == serInt5 || serInt9 == serInt4 || serInt9 == serInt3 || serInt9 == serInt2 || serInt9 == serInt1)
        {
            serInt9 = serInt9 + 1;
        }

        if (serInt2 == serInt1)
        {
            serInt2 = serInt2 + 1;
        }
        if (serInt3 == serInt2 || serInt3 == serInt1)
        {
            serInt3 = serInt3 + 1;
        }
        if (serInt4 == serInt3 || serInt4 == serInt2 || serInt4 == serInt1)
        {
            serInt4 = serInt4 + 1;
        }
        if (serInt5 == serInt4 || serInt5 == serInt3 || serInt5 == serInt2 || serInt5 == serInt1)
        {
            serInt5 = serInt5 + 1;
        }
        if (serInt6 == serInt5 || serInt6 == serInt4 || serInt6 == serInt3 || serInt6 == serInt2 || serInt6 == serInt1)
        {
            serInt6 = serInt6 + 1;
        }
        if (serInt7 == serInt6 || serInt7 == serInt5 || serInt7 == serInt4 || serInt7 == serInt3 || serInt7 == serInt2 || serInt7 == serInt1)
        {
            serInt7 = serInt7 + 1;
        }
        if (serInt8 == serInt7 || serInt8 == serInt6 || serInt8 == serInt5 || serInt8 == serInt4 || serInt8 == serInt3 || serInt8 == serInt2 || serInt8 == serInt1)
        {
            serInt8 = serInt8 + 1;
        }
        if (serInt9 == serInt8 || serInt9 == serInt7 || serInt9 == serInt6 || serInt9 == serInt5 || serInt9 == serInt4 || serInt9 == serInt3 || serInt9 == serInt2 || serInt9 == serInt1)
        {
            serInt9 = serInt9 + 1;
        }

        if (serInt2 == serInt1)
        {
            serInt2 = serInt2 + 1;
        }
        if (serInt3 == serInt2 || serInt3 == serInt1)
        {
            serInt3 = serInt3 + 1;
        }
        if (serInt4 == serInt3 || serInt4 == serInt2 || serInt4 == serInt1)
        {
            serInt4 = serInt4 + 1;
        }
        if (serInt5 == serInt4 || serInt5 == serInt3 || serInt5 == serInt2 || serInt5 == serInt1)
        {
            serInt5 = serInt5 + 1;
        }
        if (serInt6 == serInt5 || serInt6 == serInt4 || serInt6 == serInt3 || serInt6 == serInt2 || serInt6 == serInt1)
        {
            serInt6 = serInt6 + 1;
        }
        if (serInt7 == serInt6 || serInt7 == serInt5 || serInt7 == serInt4 || serInt7 == serInt3 || serInt7 == serInt2 || serInt7 == serInt1)
        {
            serInt7 = serInt7 + 1;
        }
        if (serInt8 == serInt7 || serInt8 == serInt6 || serInt8 == serInt5 || serInt8 == serInt4 || serInt8 == serInt3 || serInt8 == serInt2 || serInt8 == serInt1)
        {
            serInt8 = serInt8 + 1;
        }
        if (serInt9 == serInt8 || serInt9 == serInt7 || serInt9 == serInt6 || serInt9 == serInt5 || serInt9 == serInt4 || serInt9 == serInt3 || serInt9 == serInt2 || serInt9 == serInt1)
        {
            serInt9 = serInt9 + 1;
        }

        Debug.LogFormat("[Literally Something #{0}] After Adding: S = {1}, O = {2}, M = {3}, E = {4}, T = {5}, H = {6}, I = {7}, N = {8}, G = {9}.", moduleId, serInt1, serInt2, serInt3, serInt4, serInt5, serInt6, serInt7, serInt8, serInt9);

        numb[0] = serInt1;
        numb[1] = serInt2;
        numb[2] = serInt3;
        numb[3] = serInt4;
        numb[4] = serInt5;
        numb[5] = serInt6;
        numb[6] = serInt7;
        numb[7] = serInt8;
        numb[8] = serInt9;

        //Thank you Goofy! I love you <3

        var result = numb
        .Select((ch, ix) => new { Character = ch, Index = ix })
        .OrderBy(inf => inf.Character)
        .Select((inf, ix) => new { inf.Index, Character = (char)(ix + '1') })
        .OrderBy(inf => inf.Index)
        .Select(inf => inf.Character)
        .Join("");
        for (int i = 0; i < numb.Length; i++)
        {
            numb[i] = char.GetNumericValue(result[i]);
            numb[i] = numb[i] - 1;
        }

        Debug.LogFormat("[Literally Something #{0}] Assigned Values: S = {1} , O = {2} , M = {3} , E = {4} , T = {5} , H = {6} , I = {7} , N = {8} , G = {9}.", moduleId, numb[0] + 1, numb[1] + 1, numb[2] + 1, numb[3] + 1, numb[4] + 1, numb[5] + 1, numb[6] + 1, numb[7] + 1, numb[8] + 1);
    }

    void Activate()
    {
        isActive = true;
    }

    void SolveOrNot()
    {

        if (letterValues == 9 && letterValueS == numb[0] && letterValueO == numb[1] && letterValueM == numb[2] && letterValueE == numb[3] && letterValueT == numb[4] && letterValueH == numb[5] && letterValueI == numb[6] && letterValueN == numb[7] && letterValueG == numb[8])
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
            letterValues = 0;
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
        letterValueS = 0;
        letterValueO = 0;
        letterValueM = 0;
        letterValueE = 0;
        letterValueT = 0;
        letterValueH = 0;
        letterValueI = 0;
        letterValueN = 0;
        letterValueG = 0;
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