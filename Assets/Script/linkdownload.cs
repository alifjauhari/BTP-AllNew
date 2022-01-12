using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class linkdownload : MonoBehaviour
{
	public void dw_A1()
	{
		#if !UNITY_EDITOR
		openWindow("https://mail.google.com/mail/u/0/?fs=1&tf=cm&source=mailto&to=andrya@telkomuniversity.ac.id");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}