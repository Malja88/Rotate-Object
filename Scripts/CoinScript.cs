using DG.Tweening;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float speed;
    public Material material;
    void Update()
    {
        RotateObject();
    }

    public void OnMouseDown()
    {
        SetRandomColor(Random.Range(1, 7));
    }

    public void SetRandomColor(int index)
    {
        switch (index)
        {
            case 1: material.DOColor(Color.red, 1); break;
            case 2: material.DOColor(Color.blue, 1); break;
            case 3: material.DOColor(Color.yellow, 1); break;
            case 4: material.DOColor(Color.black, 1); break;
            case 5: material.DOColor(Color.green, 1); break;
            case 6: material.DOColor(Color.cyan, 1); break;
            case 7: material.DOColor(Color.magenta, 1); break;
        }
    }

    public void RotateObject()
    {
        transform.Rotate(0, 2 * speed * Time.deltaTime, 0);
    }
}
