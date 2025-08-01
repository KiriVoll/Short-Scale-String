# Short-Scale-String

`ShortScaleString` – utility for converting large numbers into compact string form (for example, `1.2K`, `5.6M`) with support for multiple language locales (English, Russian).

---

## 📄 Description (EN)

This Unity script provides:

* Conversion of `BigInteger`, `int`, `float` or `string` representations of numbers into a short format (K, M, B, etc.)
* Automatic selection of appropriate suffixes based on the current language (`en` or `ru`)
* Easy extensibility: simply add new suffix arrays for additional languages

**Key methods:**

| Method                                                 | Description                                            | Parameters                                         | Returns  |
| ------------------------------------------------------ | ------------------------------------------------------ | -------------------------------------------------- | -------- |
| `ParseBigInteger(BigInteger value, int precision = 2)` | Converts `BigInteger` to a short string representation | `value`: input number, `precision`: decimal places | `string` |
| `ParseInt(int value, int precision = 2)`               | Overload for `int` values                              | —                                                  | `string` |
| `ParseFloat(float value, int precision = 2)`           | Overload for `float` values (rounded to `int`)         | —                                                  | `string` |
| `ParseString(string value, int precision = 2)`         | Overload for numeric strings                           | `value`: string number                             | `string` |

**Locales:**

* `ShortScaleSymbolReferenceEN`: `{ "K", "M", "B", "T", ... }`
* `ShortScaleSymbolReferenceRU`: `{ "Т", "М", "Млрд", "Трлн", ... }`

**Usage example:**

```csharp
using System.Numerics;

// English locale
yg2.envir.language = "en";
Debug.Log(ShortScaleString.ParseBigInteger(new BigInteger(1234567))); // 1.23M

// Russian locale
yg2.envir.language = "ru";
Debug.Log(ShortScaleString.ParseInt(987654)); // 987.65Т
```

---

## 📖 Описание (RU)

Этот скрипт для Unity позволяет:

* Конвертировать числа типа `BigInteger`, `int`, `float` или `string` представления чисел в короткий формат (K, M, B и т.д.)
* Автоматически подставлять нужные суффиксы в зависимости от выбранного языка (`ru` или `en`)
* Легко расширять поддержку новых языков, добавляя массивы символов для каждой локали

**Основные методы:**

| Метод                                                  | Описание                                    | Параметры                                                  | Возвращает |
| ------------------------------------------------------ | ------------------------------------------- | ---------------------------------------------------------- | ---------- |
| `ParseBigInteger(BigInteger value, int precision = 2)` | Конвертирует `BigInteger` в короткую строку | `value` – число, `precision` – кол-во знаков после запятой | `string`   |
| `ParseInt(int value, int precision = 2)`               | Перегрузка для `int`                        | —                                                          | `string`   |
| `ParseFloat(float value, int precision = 2)`           | Перегрузка для `float` (округляет до `int`) | —                                                          | `string`   |
| `ParseString(string value, int precision = 2)`         | Перегрузка для строковых чисел              | `value` – строка с числом                                  | `string`   |

**Локали:**

* `ShortScaleSymbolReferenceEN` – `{ "K", "M", "B", "T", ... }`
* `ShortScaleSymbolReferenceRU` – `{ "Т", "М", "Млрд", "Трлн", ... }`

**Пример использования:**

```csharp
using System.Numerics;

// Английская локаль
yg2.envir.language = "en";
Debug.Log(ShortScaleString.ParseBigInteger(new BigInteger(1234567))); // 1.23M

// Русская локаль
yg2.envir.language = "ru";
Debug.Log(ShortScaleString.ParseInt(987654)); // 987.65Т
```

---

