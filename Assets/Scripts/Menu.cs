using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
    private Animator _animator; // the gameobject's animator component
    private CanvasGroup _canvasGroup;   // the gameobject's canvas group component

    public bool isOpen
    {
        // returns and sets the value of the animation state
        get { return _animator.GetBool("IsOpen"); }
        set { _animator.SetBool("IsOpen", value); }
    }

    public void Awake()
    {
        // Set private variables
        _animator = GetComponent<Animator>();
        _canvasGroup = GetComponent<CanvasGroup>();

        var rect = GetComponent<RectTransform>();
        rect.offsetMax = rect.offsetMin = new Vector2(0, 0);
    }

    // Manages the opening, closing, and interactability of the menus
    public void Update()
    {
        if (!_animator.GetCurrentAnimatorStateInfo(0).IsName("Open"))
        {
            _canvasGroup.blocksRaycasts = _canvasGroup.interactable = false;
        }
        else
        {
            _canvasGroup.blocksRaycasts = _canvasGroup.interactable = true;
        }
    }
}