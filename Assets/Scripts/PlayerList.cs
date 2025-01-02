using System;
using System.Linq;
using FishNet.Managing;
using TMPro;
using UnityEngine;

public class PlayerList : MonoBehaviour
{
    private NetworkManager _networkManager;

    void Start()
    {
        _networkManager = FindFirstObjectByType<NetworkManager>();
    }

    void Update()
    {
        var theStupidPlayerList = FindFirstObjectByType<TextMeshProUGUI>();

        theStupidPlayerList.text = String.Join("\n", _networkManager.ClientManager.Clients
            .Where(c => !c.Value.IsHost)
            .Select(c => c.Value.GetAddress().ToString()));
    }
}
