using UnityEngine;
#if UNITY_WEBGL && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif

public class WebGLDOMManipulator : MonoBehaviour
{
    [SerializeField]
    string position;

    [SerializeField]
    string text;

#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    static extern void _insertAdjacentHTML(string position, string text);
#endif

    void InsertAdjacentHTML(string position, string text)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        _insertAdjacentHTML(position, text);
#endif
    }

    void Start()
    {
        InsertAdjacentHTML(position, text);
    }
}