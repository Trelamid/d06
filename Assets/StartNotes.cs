using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartNotes : MonoBehaviour
{
    public TextMeshProUGUI _text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Cor());
    }

    IEnumerator Cor()
    {
        _text.text = "Чтобы пройти игру вам нужно найти записки владельца этого дома";
        yield return new WaitForSeconds(10);
        _text.text = "Не попадайтесь на свет, иначе вас заметят!";
        yield return new WaitForSeconds(10);
        _text.text = "Прячтесь в дыму, чтобы скрыться от камер";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
