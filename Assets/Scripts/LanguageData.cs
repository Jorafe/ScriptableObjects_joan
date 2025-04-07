using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LanguageData", menuName = "Localization/LanguageData")]
public class LanguageData : ScriptableObject
{
    [TextArea] public string player1Description;
    [TextArea] public string player2Description;
    [TextArea] public string player3Description;
    [TextArea] public string player4Description;
}