# Uni String Appender

* StringBuilderでコレクション初期化子を使用できるようにするクラス

## 使用例

```cs
using UniStringAppender;
using UnityEngine;

public class Example : MonoBehaviour
{
	private void Start()
	{
		var appender = new StringAppender
		{
			"1. フシギダネ",
			{ "2. {0}", "フシギソウ" },
			{ "3. {0}", "フシギバナ" },
		};

		Debug.Log( appender.ToString() );
	}
}
```

## 関連記事

* http://baba-s.hatenablog.com/entry/2016/06/30/100000