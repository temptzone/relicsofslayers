using UnityEngine;
using System.Collections;
using System;

public class LocalDataManager : AutoSingletonManager<LocalDataManager> {

	public static string TYPE_BOOLEAN = "Boolean";
	public static string TYPE_INT = "Int";
	public static string TYPE_FLOAT = "Float";
	public static string TYPE_STRING = "String";



	private void setData(string key, object value, string type){

		if (type == TYPE_BOOLEAN) {
			bool convertedValue = Convert.ToBoolean(value);
			PlayerPrefs.SetInt (key, convertedValue == true ? 1 : 0);
		} else if (type == TYPE_INT) {
			int convertedValue = Convert.ToInt32(value);
			PlayerPrefs.SetInt (key, convertedValue);
		} else if (type == TYPE_FLOAT) {
			float convertedValue = (float) value;
			PlayerPrefs.SetFloat (key, convertedValue);
		} else {
			string convertedValue = Convert.ToString(value);
			PlayerPrefs.SetString (key, convertedValue);
		}
	}

	private object getData(string key, string type){

		if (type == TYPE_BOOLEAN) {
			return PlayerPrefs.GetInt (key) == 1 ? true : false;
		} else if (type == TYPE_INT) {
			return PlayerPrefs.GetInt (key);
		} else if (type == TYPE_FLOAT) {
			return PlayerPrefs.GetFloat (key);
		} else {
			return PlayerPrefs.GetString (key);
		}
	}
}
