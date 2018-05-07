using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExampleAPI : MonoBehaviour
{
	public string productID;
	public Text text;

	private string rootAPI = "https://www.barcodelookup.com/restapi?";
	private string apiKey = "&key=ytd87bb8k1z5cukpsz2f6bwzduhwvs";

	IEnumerator Search()
	{
		string url = rootAPI + "barcode=" + productID + apiKey;

		using (WWW www = new WWW(url))
		{
			yield return www;
			text.text = www.text;
		}
	}

	public void CodeSearch()
	{
		StartCoroutine(Search());
	}
}
