using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MyProject.Observer;

public class Observer1:IObserver
{

    public Observer1()
    {
        ObserverManager.Register<StartMessage, Observer1>(Message);
    }

    public void Message(StartMessage msg)
    {
        Debug.Log(msg.Message);
    }

}
