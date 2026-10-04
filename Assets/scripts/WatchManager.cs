using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class WatchManager : MonoBehaviour
{
    [Header("Données des montres")]
    public List<WatchData> allWatches;

    [Header("UI Panneau info")]
    public GameObject infoPanel;
    public TMP_Text watchNameText;
    public TMP_Text brandText;
    public TMP_Text priceText;
    public TMP_Text descriptionText;
    public Image selectedWatchImage;

    [Header("Galerie UI")]
    public Transform galleryContainer;
    public GameObject watchCardPrefab;

    [Header("Montres AR dans la scène")]
    public GameObject[] watchObjects;

    void Start()
    {
        // Désactiver toutes les montres sauf la première
        for (int i = 0; i < watchObjects.Length; i++)
            watchObjects[i].SetActive(i == 0);

        // Cacher InfoPanel au départ
        if (infoPanel != null)
            infoPanel.SetActive(false);

        // Générer la galerie
        GenerateGallery();
    }

    void GenerateGallery()
    {
        if (galleryContainer == null || watchCardPrefab == null)
            return;

        // Supprimer les anciennes cartes
        foreach (Transform child in galleryContainer)
            Destroy(child.gameObject);

        for (int i = 0; i < allWatches.Count; i++)
        {
            int index = i;
            WatchData data = allWatches[i];

            GameObject card = Instantiate(watchCardPrefab,
                                          galleryContainer);

            // Assigner image
            Image[] images = card.GetComponentsInChildren<Image>();
            foreach (Image img in images)
            {
                if (img.gameObject != card.gameObject 
                    && data.previewImage != null)
                {
                    img.sprite = data.previewImage;
                    img.preserveAspect = true;
                    break;
                }
            }

            // Assigner nom
            TMP_Text txt = card.GetComponentInChildren<TMP_Text>();
            if (txt != null)
                txt.text = data.watchName;

            // Assigner clic
            Button btn = card.GetComponent<Button>();
            if (btn != null)
                btn.onClick.AddListener(() => SelectWatch(index));
        }
    }

    public void SelectWatch(int index)
    {
        if (index < 0 || index >= allWatches.Count) return;

        WatchData data = allWatches[index];

        // Afficher la bonne montre AR
        for (int i = 0; i < watchObjects.Length; i++)
            watchObjects[i].SetActive(i == index);

        // Mettre à jour le panneau
        if (watchNameText != null)
            watchNameText.text = data.watchName;
        if (brandText != null)
            brandText.text = "🏷 " + data.brand;
        if (priceText != null)
            priceText.text = "💰 " + 
                data.priceInDinar.ToString("0") + " DT";
        if (descriptionText != null)
            descriptionText.text = data.description;
        if (selectedWatchImage != null && data.previewImage != null)
            selectedWatchImage.sprite = data.previewImage;

        // Afficher le panneau
        if (infoPanel != null)
            infoPanel.SetActive(true);
    }

    public void CloseInfoPanel()
    {
        if (infoPanel != null)
            infoPanel.SetActive(false);
    }
}