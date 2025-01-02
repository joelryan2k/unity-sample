using System;
using System.Linq;
using FishNet.Managing;
using TMPro;
using UnityEngine;

public class PlayerList : MonoBehaviour
{
    private NetworkManager _networkManager;
    private TextMeshProUGUI _textBox;

    void Start()
    {
        _networkManager = FindFirstObjectByType<NetworkManager>();
        _textBox = FindFirstObjectByType<TextMeshProUGUI>();
    }

    void Update()
    {
        _textBox.text = String.Join("\n", _networkManager.ClientManager.Clients
            .Where(c => !c.Value.IsHost)
            .Select(c => c.Value.GetAddress().ToString()));
    }
}
