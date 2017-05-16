using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LogInManager: MonoBehaviour {

	//private reference which can be accessed by this class only
	private static LogInManager p_instance;
	//public static reference that can be accesd from anywhere
	public static LogInManager Instance {
		get{
			//check if instance has not been set yet and set it it is not set already
			//This takes place only on the first time usage of this reference
			if(p_instance==null){
				p_instance = GameObject.FindObjectOfType<LogInManager>();
				//DontDestroyOnLoad(p_instance.gameObject);
			}
			return p_instance;
		}

	}

	//public property which can be accessed using the instance
	public string someString = "some value";
	public InputField RegisterUsername;
	public InputField RegisterPassword;
	public InputField RegisterFirstName;
	public InputField RegisterLastName;
	public InputField RegisterMiddle;
	public InputField RegisterConfirmPassword;
	public InputField LoginUsername;
	public InputField LoginPassword;

	void Awake()
	{
		if(p_instance == null)
		{
			//make the current instance as the singleton
			p_instance = this;
			//make it persistent  
		//	DontDestroyOnLoad(this);
		}
		else
		{
			//If more than one singleton exists in the scene
			//find the existing reference from the scene and destroy it
			if(this != p_instance)
				Destroy(this.gameObject);
		}

	} 
	//public method accessed using the instance
	public void SomeFunction(){
		Application.Quit ();
	}

}