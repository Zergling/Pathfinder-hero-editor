using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Localization;

public class LocalizationConfigurator : MonoBehaviour 
{
	[SerializeField] private LeanLocalization _localization;
	public LeanLocalization Localization
	{
		get { return _localization; }
	}

	public void AddLanguage(string language)
	{
		_localization.AddLanguage(language);
	}

	public LeanPhrase AddPhrase(string phraseName)
	{
		return _localization.AddPhrase(phraseName);
	}
}
