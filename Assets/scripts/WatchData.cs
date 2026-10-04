using UnityEngine;

[CreateAssetMenu(fileName = "WatchData", 
                 menuName = "ARWatches/Watch Data")]
public class WatchData : ScriptableObject
{
    public string watchName;
    public string brand;
    public float priceInDinar;
    public string description;
    public Sprite previewImage;
    public GameObject watchPrefab;
}