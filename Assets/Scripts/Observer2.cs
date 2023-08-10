using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MyProject.Observer;

public class Observer2:IObserver
{

    public Observer2()
    {
        ObserverManager.Register<StartMessage, Observer2>(OnStartMessage);
    }

    public void OnStartMessage(StartMessage msg)
    {
        Debug.Log(msg.Message);
    }

}
