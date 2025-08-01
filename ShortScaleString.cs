using System;
using System.Numerics; // Для BigInteger
using UnityEngine;
using YG; // Для YandexGame

public class ShortScaleString
{
    static readonly string[] ShortScaleSymbolReferenceEN = { "K", "M", "B", "T", "E", "N", "O", "A", "R", "S" };
    static readonly string[] ShortScaleSymbolReferenceRU = { "Т", "М", "Млрд", "Трлн", "Квн", "Квт", "Скт", "Септ", "Окт", "Нон" };

    private static string[] GetLanguageSymbols()
    {
        return YG2.envir.language == "ru" ? ShortScaleSymbolReferenceRU : ShortScaleSymbolReferenceEN;
    }

    /// <summary>
    /// Преобразует BigInteger в короткую форму ("1.2K", "5.6M").
    /// </summary>
    public static string ParseBigInteger(BigInteger value, int precision = 2)
    {
        if (value < 1000) return value.ToString();

        string[] symbols = GetLanguageSymbols();
        int index = 0;
        decimal newValue = (decimal)value;

        while (newValue >= 1000 && index < symbols.Length)
        {
            newValue /= 1000m;
            index++;
        }

        string formattedValue = newValue.ToString($"F{precision}").TrimEnd('0').TrimEnd(',');

        return (index > 0) ? $"{formattedValue}{symbols[index - 1]}" : formattedValue;
    }

    /// <summary>
    /// Перегрузка метода для int.
    /// </summary>
    public static string ParseInt(int value, int precision = 2)
    {
        return ParseBigInteger(new BigInteger(value), precision);
    }
    /// <summary>
    /// Перегрузка метода для строки. Принимает строку с числом и возвращает сокращённую форму.
    /// </summary>
    public static string ParseString(string value, int precision = 2)
    {
        if (BigInteger.TryParse(value, out BigInteger result))
        {
            return ParseBigInteger(result, precision);
        }
        return value; // Возвращает как есть, если не удалось распарсить
    }
    public static string ParseFloat(float value, int precision = 2)
    {
        return ParseBigInteger(new System.Numerics.BigInteger(Mathf.RoundToInt(value)), precision);
    }

}