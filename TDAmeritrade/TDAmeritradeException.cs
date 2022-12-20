using System;
using System.Runtime.Serialization;

namespace TDAmeritrade;

/// <summary>
/// TDA exceptions.
/// </summary>
[Serializable]
public class TDAmeritradeException : Exception
{
  /// <summary>
  /// Initializes a new instance of the <see cref="TDAmeritradeException"/> class.
  /// </summary>
  public TDAmeritradeException()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TDAmeritradeException"/> class.
  /// </summary>
  /// <param name="message">Message.</param>
  public TDAmeritradeException(string message)
      : base(message)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TDAmeritradeException"/> class.
  /// </summary>
  /// <param name="message">Message.</param>
  /// <param name="innerException">Inner exception.</param>
  public TDAmeritradeException(string message, Exception innerException)
      : base(message, innerException)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TDAmeritradeException"/> class.
  /// </summary>
  /// <param name="info">Serialization info.</param>
  /// <param name="context">Streaming context.</param>
  protected TDAmeritradeException(SerializationInfo info, StreamingContext context)
      : base(info, context)
  {
  }
}