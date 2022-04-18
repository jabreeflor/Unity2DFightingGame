using UnityEngine;
using UnityEngine.UI;

public class CharaterSelectionUI : MonoBehaviour {
    public GameObject optionPrefab;

    public Transform prevCharacter;
    public Transform selectedCharacter;
    Color lerpedColor = Color.white;
    private void Start() {
        foreach (Character c in GameManager.instance.characters) {
            GameObject option = Instantiate(optionPrefab, transform);
            Button button = option.GetComponent<Button>();

            button.onClick.AddListener(() => {
                GameManager.instance.SetCharacter(c);
                if (selectedCharacter != null) {
                    prevCharacter = selectedCharacter;
                }

                selectedCharacter = option.transform;
            });

            Text text = option.GetComponentInChildren<Text>();
            text.text = c.name;

            Image image = option.GetComponentInChildren<Image>();
            image.sprite = c.icon;
        }
    }

    private void Update() {
        lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1));
        if (selectedCharacter != null) {
            selectedCharacter.localScale = Vector3.Lerp(selectedCharacter.localScale, new Vector3(1.2f, 1.2f, 1.2f), Time.deltaTime * 10);
        }

        if (prevCharacter != null) {
            prevCharacter.localScale = Vector3.Lerp(prevCharacter.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 10);
        }
    }
}
