using DG.Tweening;
using UnityEngine;

public class RotationObjectScript : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public float duration;
    [SerializeField] public Material material;
    [SerializeField] private Color[] colors;
    private void Start()
    {
        RotateObject();
    }

    public void OnMouseDown()
    {
        SetRandomColor();
    }

    public void SetRandomColor()
    {

        for (int i = 0; i < colors.Length; i++)
        {
            material.DOColor(colors[Random.Range(0, colors.Length)], 1);
        }
    }

    public void RotateObject()
    {
        transform.DORotate(new Vector3(0, -360, 0), duration, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }
}

