using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zenject;

public class FontTestWindow : WindowBase
{
    [SerializeField] private TMP_FontAsset _lifeFont;
    [SerializeField] private Material _lifeBlack;
    [SerializeField] private Material _lifeWhite;

    [SerializeField] private TMP_FontAsset _royanaFont;
    [SerializeField] private Material _royanaBlack;
    [SerializeField] private Material _royanaWhite;

    [SerializeField] private TMP_FontAsset _scotchFont;
    [SerializeField] private Material _scotchBlack;
    [SerializeField] private Material _scotchWhite;

    [SerializeField] private TMP_Text[] _blackTexts;
    [SerializeField] private TMP_Text[] _whiteTexts;

    protected override void OnShow()
    {
    }

    public void OnChangeFontButton(int fontType)
    {
        TMP_FontAsset font = null;
        Material black, white;

        switch (fontType)
        {
            case (int)FontType.LifeIsStrangeRu:
                font = _lifeFont;
                black = _lifeBlack;
                white = _lifeWhite;
                break;

            case (int)FontType.Royana:
                font = _royanaFont;
                black = _royanaBlack;
                white = _royanaWhite;
                break;

            case (int)FontType.Scotch:
                font = _scotchFont;
                black = _scotchBlack;
                white = _scotchWhite;
                break;

            default:
                Debug.LogError("ERROR, MOTHERFUCKER!");
                return;
        }

        for (int i = 0; i < _blackTexts.Length; i++)
        {
            _blackTexts[i].font = font;
            _blackTexts[i].fontMaterial = black;
        }

        for (int i = 0; i < _whiteTexts.Length; i++)
        {
            _whiteTexts[i].font = font;
            _whiteTexts[i].fontMaterial = white;
        }
    }

    public enum FontType
    {
        LifeIsStrangeRu = 0,
        Royana = 1,
        Scotch = 2,
    }
}