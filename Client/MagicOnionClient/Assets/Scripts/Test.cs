using Grpc.Core;
using MagicOnion.Client;
using MyApp.Shared;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        var channel = new Channel("localhost", 5033, ChannelCredentials.Insecure);
        var client = MagicOnionClient.Create<IMyFirstService>(channel);
        var result = await client.SumAsync(100, 200);
        Debug.Log(result);
    }
}
