using System;
using System.Collections;
using System.Text;
using JetBrains.Annotations;

namespace UniStringAppender
{
	/// <summary>
	/// 可変型の文字列を管理するクラス
	/// </summary>
	public class StringAppender : IEnumerable
	{
		//================================================================================
		// 変数（readonly）
		//================================================================================
		private readonly StringBuilder m_builder = new StringBuilder();

		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// 指定された文字列を追加します
		/// </summary>
		public void Add( string value )
		{
			m_builder.AppendLine( value );
		}

		/// <summary>
		/// 指定された文字列を追加します
		/// </summary>
		[StringFormatMethod( "format" )]
		public void Add( string format, params object[] args )
		{
			m_builder.AppendFormat( format, args ).AppendLine();
		}

		/// <summary>
		/// 指定された文字列を追加します
		/// </summary>
		[StringFormatMethod( "format" )]
		public void Add( string format, object arg0 )
		{
			m_builder.AppendFormat( format, arg0 ).AppendLine();
		}

		/// <summary>
		/// 指定された文字列を追加します
		/// </summary>
		[StringFormatMethod( "format" )]
		public void Add( string format, object arg0, object arg1 )
		{
			m_builder.AppendFormat( format, arg0, arg1 ).AppendLine();
		}

		/// <summary>
		/// 指定された文字列を追加します
		/// </summary>
		[StringFormatMethod( "format" )]
		public void Add( string format, object arg0, object arg1, object arg2 )
		{
			m_builder.AppendFormat( format, arg0, arg1, arg2 ).AppendLine();
		}

		/// <summary>
		/// 文字列を返します
		/// </summary>
		public override string ToString()
		{
			return m_builder.ToString();
		}

		/// <summary>
		/// コレクションを反復処理する列挙子を返します
		/// </summary>
		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}