using UnityEngine;
using UnityEngine.Events;

public class ResetButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public UnityEvent ResetEvent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnMouseDown()
	{
        ResetEvent.Invoke();
	}
}
