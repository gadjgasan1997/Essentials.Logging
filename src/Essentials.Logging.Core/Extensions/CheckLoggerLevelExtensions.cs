using Microsoft.Extensions.Logging;
// ReSharper disable ConvertIfStatementToReturnStatement
// ReSharper disable MemberCanBePrivate.Global

namespace Essentials.Logging.Extensions;

/// <summary>
/// Методы расширения для проверки уровня логирования логгера <see cref="ILogger" />
/// </summary>
public static class CheckLoggerLevelExtensions
{
    #region Trace
    
    /// <summary>
    /// Определяет, что уровнем логирования логгера является <see cref="LogLevel.Trace" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsTrace(this ILogger logger) => logger.IsEnabled(LogLevel.Trace);
    
    #endregion

    #region Debug
    
    /// <summary>
    /// Определяет, что уровнем логирования логгера является <see cref="LogLevel.Debug" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsDebug(this ILogger logger)
    {
        // Все логгеры, уровень которых выше Debug
        if (logger.LogIsDisabled(LogLevel.Debug))
            return false;

        // Все логгеры, уровень которых равен Trace
        if (logger.IsEnabled(LogLevel.Trace))
            return false;

        return true;
    }
    
    /// <summary>
    /// Определяет, что уровень логирования логгера не превышает <see cref="LogLevel.Debug" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsDebugOrLow(this ILogger logger) => logger.IsEnabled(LogLevel.Debug);
    
    /// <summary>
    /// Определяет, что уровень логирования логгера не ниже <see cref="LogLevel.Debug" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsDebugOrHigher(this ILogger logger) => logger.LogIsDisabled(LogLevel.Trace);

    #endregion

    #region Info

    /// <summary>
    /// Определяет, что уровнем логирования логгера является <see cref="LogLevel.Information" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsInfo(this ILogger logger)
    {
        // Все логгеры, уровень которых выше Information
        if (logger.LogIsDisabled(LogLevel.Information))
            return false;

        // Все логгеры, уровень которых ниже или равен Debug
        if (logger.IsEnabled(LogLevel.Debug))
            return false;

        return true;
    }
    
    /// <summary>
    /// Определяет, что уровень логирования логгера не превышает <see cref="LogLevel.Information" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsInfoOrLow(this ILogger logger) => logger.IsEnabled(LogLevel.Information);
    
    /// <summary>
    /// Определяет, что уровень логирования логгера не ниже <see cref="LogLevel.Information" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsInfoOrHigher(this ILogger logger) => logger.LogIsDisabled(LogLevel.Debug);
    
    #endregion

    #region Warn

    /// <summary>
    /// Определяет, что уровнем логирования логгера является <see cref="LogLevel.Warning" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsWarn(this ILogger logger)
    {
        // Все логгеры, уровень которых выше Warning
        if (logger.LogIsDisabled(LogLevel.Warning))
            return false;

        // Все логгеры, уровень которых ниже или равен Information
        if (logger.IsEnabled(LogLevel.Information))
            return false;

        return true;
    }
    
    /// <summary>
    /// Определяет, что уровень логирования логгера не превышает <see cref="LogLevel.Warning" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsWarnOrLow(this ILogger logger) => logger.IsEnabled(LogLevel.Warning);
    
    /// <summary>
    /// Определяет, что уровень логирования логгера не ниже <see cref="LogLevel.Warning" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsWarnOrHigher(this ILogger logger) => logger.LogIsDisabled(LogLevel.Information);

    #endregion
    
    #region Error

    /// <summary>
    /// Определяет, что уровнем логирования логгера является <see cref="LogLevel.Error" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsError(this ILogger logger)
    {
        // Все логгеры, уровень которых равен Critical
        if (logger.LogIsDisabled(LogLevel.Error))
            return false;

        // Все логгеры, уровень которых ниже или равен Warning
        if (logger.IsEnabled(LogLevel.Warning))
            return false;

        return true;
    }
    
    /// <summary>
    /// Определяет, что уровень логирования логгера не превышает <see cref="LogLevel.Error" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsErrorOrLow(this ILogger logger) => logger.IsEnabled(LogLevel.Error);
    
    /// <summary>
    /// Определяет, что уровень логирования логгера не ниже <see cref="LogLevel.Error" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <returns></returns>
    public static bool LogLevelIsErrorOrHigher(this ILogger logger) => logger.LogIsDisabled(LogLevel.Warning);
    
    #endregion

    /// <summary>
    /// Определяет, что для логгера отключен указанный уровень логирования
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="level">Уровень</param>
    /// <returns></returns>
    public static bool LogIsDisabled(this ILogger logger, LogLevel level) => !logger.IsEnabled(level);
}