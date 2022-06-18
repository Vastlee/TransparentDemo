using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class TransparencyController : MonoBehaviour {
    Material cubeMat;

    void Awake() => cubeMat = GetComponent<Renderer>().material;

    public void ToggleTransparency() {
        var newColor = cubeMat.color;
        newColor.a = (newColor.a == 1f) ? 0f : 1f;
        cubeMat.color = newColor;
    }
}
