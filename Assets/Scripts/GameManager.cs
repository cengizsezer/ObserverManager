using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Collections;
using MyProject.Observer;

public class GameManager : MonoBehaviour
{

    private void Start()
    {
        Observer1 Observer_1 = new Observer1();
        Observer2 Observer_2 = new Observer2();
        StartMessageStandart();
        //StartMessageAsync();
        //StartMessageGlobal();
    }

    public void StartMessageStandart()
    {
       
        ObserverManager.Send<StartMessage, Observer1>(StartMessage.Create("Observer1"));
        ObserverManager.Send<StartMessage, Observer2>(StartMessage.Create("Observer2"));
       
    }
    public async void StartMessageAsync()
    {
        await UniTask.Delay(2000);
        await ObserverManager.SendAsync<StartMessage, Observer1>(StartMessage.Create("Observer1"));
        await UniTask.Delay(10000);
        await ObserverManager.SendAsync<StartMessage, Observer2>(StartMessage.Create("Observer2"));
        await UniTask.CompletedTask;
    }


    public void StartMessageGlobal()
    {
        ObserverManager.SendGlobal(StartMessage.Create("GLOBALSEND"));
    }

   

}
