using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private GameObject gameObject;
    [SerializeField] private LayoutGroup layoutGroup;

    private void Update()
    {
        Button button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(() => OnDeleteButtonClick());
    }

    private void OnDeleteButtonClick()
    {
        Destroy(gameObject);
        layoutGroup.CalculateLayoutInputVertical();
        layoutGroup.SetLayoutVertical();
    }
}
