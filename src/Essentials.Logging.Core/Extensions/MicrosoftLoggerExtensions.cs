using Microsoft.Extensions.Logging;
#pragma warning disable CA2254
// ReSharper disable MemberCanBePrivate.Global

namespace Essentials.Logging.Extensions;

/// <summary>
/// Методы расширения для <see cref="ILogger" />
/// </summary>
public static class MicrosoftLoggerExtensions
{
    #region Trace
    
    /// <summary>
    /// Осуществляет логирование если уровень логгера является строго уровнем <see cref="LogLevel.Trace" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsTrace(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsTrace())
            return logger;

        logAction();
        return logger;
    }

    /// <summary>
    /// Осуществляет логирование если уровень логгера является строго уровнем <see cref="LogLevel.Trace" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsTrace(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsTrace(() => logger.LogTrace(message, args));
    }

    #endregion

    #region Debug
    
    /// <summary>
    /// Осуществляет логирование если уровень логгера является строго уровнем <see cref="LogLevel.Debug" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsDebug(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsDebug())
            return logger;

        logAction();
        return logger;
    }

    /// <summary>
    /// Осуществляет логирование если уровень логгера является строго уровнем <see cref="LogLevel.Debug" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsDebug(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsDebug(() => logger.LogDebug(message, args));
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не превышает <see cref="LogLevel.Debug" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsDebugOrLow(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsDebugOrLow())
            return logger;

        logAction();
        return logger;
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не превышает <see cref="LogLevel.Debug" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsDebugOrLow(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsDebugOrLow(() => logger.LogDebug(message, args));
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не ниже <see cref="LogLevel.Debug" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsDebugOrHigher(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsDebugOrHigher())
            return logger;

        logAction();
        return logger;
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не ниже <see cref="LogLevel.Debug" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsDebugOrHigher(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsDebugOrHigher(() => logger.LogDebug(message, args));
    }

    #endregion

    #region Info
    
    /// <summary>
    /// Осуществляет логирование если уровень логгера является строго уровнем <see cref="LogLevel.Information" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsInfo(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsInfo())
            return logger;

        logAction();
        return logger;
    }

    /// <summary>
    /// Осуществляет логирование если уровень логгера является строго уровнем <see cref="LogLevel.Information" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsInfo(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsInfo(() => logger.LogInformation(message, args));
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не превышает <see cref="LogLevel.Information" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsInfoOrLow(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsInfoOrLow())
            return logger;

        logAction();
        return logger;
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не превышает <see cref="LogLevel.Information" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsInfoOrLow(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsInfoOrLow(() => logger.LogInformation(message, args));
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не ниже <see cref="LogLevel.Information" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsInfoOrHigher(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsInfoOrHigher())
            return logger;

        logAction();
        return logger;
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не ниже <see cref="LogLevel.Information" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsInfoOrHigher(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsInfoOrHigher(() => logger.LogInformation(message, args));
    }

    #endregion

    #region Warn
    
    /// <summary>
    /// Осуществляет логирование если уровень логгера является строго уровнем <see cref="LogLevel.Warning" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsWarn(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsWarn())
            return logger;

        logAction();
        return logger;
    }

    /// <summary>
    /// Осуществляет логирование если уровень логгера является строго уровнем <see cref="LogLevel.Warning" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsWarn(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsWarn(() => logger.LogWarning(message, args));
    }

    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не превышает <see cref="LogLevel.Warning" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsWarnOrLow(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsWarnOrLow())
            return logger;

        logAction();
        return logger;
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не превышает <see cref="LogLevel.Warning" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsWarnOrLow(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsWarnOrLow(() => logger.LogWarning(message, args));
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не ниже <see cref="LogLevel.Warning" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsWarnOrHigher(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsWarnOrHigher())
            return logger;

        logAction();
        return logger;
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не ниже <see cref="LogLevel.Warning" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsWarnOrHigher(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsWarnOrHigher(() => logger.LogWarning(message, args));
    }

    #endregion

    #region Error
    
    /// <summary>
    /// Осуществляет логирование если уровень логгера является строго уровнем <see cref="LogLevel.Error" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsError(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsError())
            return logger;

        logAction();
        return logger;
    }

    /// <summary>
    /// Осуществляет логирование если уровень логгера является строго уровнем <see cref="LogLevel.Error" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsError(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsError(() => logger.LogError(message, args));
    }

    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не превышает <see cref="LogLevel.Error" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsErrorOrLow(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsErrorOrLow())
            return logger;

        logAction();
        return logger;
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не превышает <see cref="LogLevel.Error" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsErrorOrLow(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsErrorOrLow(() => logger.LogError(message, args));
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не ниже <see cref="LogLevel.Error" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logAction">Действие логирования</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsErrorOrHigher(this ILogger logger, Action logAction)
    {
        if (!logger.LogLevelIsErrorOrHigher())
            return logger;

        logAction();
        return logger;
    }
    
    /// <summary>
    /// Осуществляет логирование, если уровень логирования логгера не ниже <see cref="LogLevel.Error" />
    /// </summary>
    /// <param name="logger">Логгер</param>
    /// <param name="message">Сообщение для логирования</param>
    /// <param name="args">Аргументы</param>
    /// <returns>Логгер</returns>
    public static ILogger LogIfLevelIsErrorOrHigher(
        this ILogger logger,
        string? message,
        params object?[] args)
    {
        return logger.LogIfLevelIsErrorOrHigher(() => logger.LogError(message, args));
    }
    
    #endregion
}