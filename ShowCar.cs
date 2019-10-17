using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCar : MonoBehaviour
{
    
    public GameObject monza;
    public GameObject camaro;
    public GameObject cien, other, silvia, gtr, info;
    
    //private bool showingC;
    //private bool showingM, showingCien, showingOther;

    public Text velT, torqueT, pesoT, anoT, potenciaT, motorT;
    void Start()
    {
        

    }

  
    void Update()
    {
        if(camaro.active == true)
        {
            velT.text = "Velocidade: 290 KM/H";
            torqueT.text = "Torque: 69.2 KGFM";
            pesoT.text = "Peso: 1709 KG";
            anoT.text = "Ano: 2015";
            potenciaT.text = "Potencia: 406cv";
            motorT.text = "6.2 V8";
        }
        if (cien.active == true)
        {
            velT.text = "Velocidade: 230 KM/H";
            torqueT.text = "Torque: 89 KGM/F";
            pesoT.text = "Peso: 1450 KG";
            anoT.text = "Ano: 2002";
            potenciaT.text = "Potencia: 750cv";
            motorT.text = "7.5 V12";
        }
        if (silvia.active == true)
        {
            velT.text = "Velocidade: 235 KM/H";
            torqueT.text = "Torque: 26.5 KGM/F";
            pesoT.text = "Peso: 1240 KG";
            anoT.text = "Ano: 1999";
            potenciaT.text = "Potencia: 197cv";
            motorT.text = "2.0 Turbo";
        }
    }
    public void ShowInfo()
    {
        if(info.active == true)
        {
            info.SetActive(false);
        }
        else
        {
            info.SetActive(true);
        }
    }

    public void ShowCamaro(){
        if(monza.active == true)
        {
            monza.SetActive(false);
            camaro.SetActive(true);
            //showingC = true;
           // showingM = false;
            velT.text = "Velocidade: 290 KM/H";
            torqueT.text = "Torque: 69.2 KGFM";
            pesoT.text = "Peso: 1709 KG";
            anoT.text = "Ano: 2015";
            potenciaT.text = "Potencia: 406cv";
            motorT.text = "6.2 V8";
        }
    }
    public void ShowMonza(){
        if (camaro.active == true)
        {
            camaro.SetActive(false);
            monza.SetActive(true);
            //showingM = true;
            //showingC = false;
            velT.text = "Velocidade: 172 KM/H";
            torqueT.text = "Torque: 16.6 KGFM";
            pesoT.text = "Peso: 1125 KG";
            anoT.text = "Ano: 1994";
            potenciaT.text = "Potencia: 116cv";
            motorT.text = "2.0";

        }
    }
    public void ShowCien()
    {
        if (other.active == true)
        {
            cien.SetActive(true);
            other.SetActive(false);
            velT.text = "Velocidade: 230 KM/H";
            torqueT.text = "Torque: 89 KGM/F";
            pesoT.text = "Peso: 1450 KG";
            anoT.text = "Ano: 2002";
            potenciaT.text = "Potencia: 750cv";
            motorT.text = "7.5 V12";

        }
       
    }
    public void ShowOther()
    {
        if (cien.active == true)
        {
            cien.SetActive(false);
            other.SetActive(true);
            velT.text = "Velocidade: 180 KM/H";
            torqueT.text = "Torque: 63.6 KGM/F";
            pesoT.text = "Peso: 2628 KG";
            anoT.text = "Ano: 2015";
            potenciaT.text = "Potencia: 426cv";
            motorT.text = "6.2 V8";

        }
    }
    public void ShowGTR()
    {
        if (silvia.active == true)
        {
            silvia.SetActive(false);
            gtr.SetActive(true);
            velT.text = "Velocidade: 315 KM/H";
            torqueT.text = "Torque: 63.2 KGM/F";
            pesoT.text = "Peso: 1815 KG";
            anoT.text = "Ano: 2014";
            potenciaT.text = "Potencia: 542cv";
            motorT.text = "V6";

        }
    }
    public void ShowSilvia()
    {
        if (gtr.active == true)
        {
            gtr.SetActive(false);
            silvia.SetActive(true);
            velT.text = "Velocidade: 235 KM/H";
            torqueT.text = "Torque: 26.5 KGM/F";
            pesoT.text = "Peso: 1240 KG";
            anoT.text = "Ano: 1999";
            potenciaT.text = "Potencia: 197cv";
            motorT.text = "2.0 Turbo";

        }
    }


}
