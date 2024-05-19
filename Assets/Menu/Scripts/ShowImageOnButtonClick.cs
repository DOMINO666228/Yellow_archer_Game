using UnityEngine;
using UnityEngine.UI;

public class ShowImageOnButtonClick : MonoBehaviour
{
    public Button button;
    public Image image;

    void Start()
    {

        if (button == null || image == null)
        {
            Debug.LogError("Не удалось найти кнопку или картинку!");
            return;
        }
        button.onClick.AddListener(ShowImage);

        image.gameObject.SetActive(false);
    }

    private void ShowImage()
    {
        image.gameObject.SetActive(true);
    }
}