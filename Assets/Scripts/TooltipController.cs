using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TooltipController : MonoBehaviour
{
    UIDocument _document;
    
    VisualElement _tooltip;
    
    List<VisualElement> _skillButtons = new List<VisualElement>();

    private void Awake()
    {
        _document = GetComponent<UIDocument>();

        _tooltip = _document.rootVisualElement.Q("Tooltip");

        _skillButtons = _document.rootVisualElement.Query(className: "skill-button").ToList();
        for(int i = 0; i  < _skillButtons.Count; i++) 
        {
            _skillButtons[i].RegisterCallback<FocusInEvent>(OnFocusIn);
            _skillButtons[i].RegisterCallback<FocusOutEvent>(OnFocusOut);
        }
    }

    void OnFocusIn(FocusInEvent e)
    {
        _tooltip.style.display = DisplayStyle.Flex;
    }

    void OnFocusOut(FocusOutEvent e) 
    {
        _tooltip.style.display = DisplayStyle.None;
    }
}
