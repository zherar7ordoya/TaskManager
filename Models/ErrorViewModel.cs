namespace TaskManager.Models;

public record ErrorViewModel(string? RequestId)
{
    /// <summary>
    /// Determines whether the RequestId is not null or empty.
    /// </summary>
    /// <returns>
    /// <c>true</c> if the RequestId is not null or empty; otherwise, <c>false</c>.
    /// </returns>
    public System.Boolean GetShowRequestId()
    {
        return !string.IsNullOrEmpty(RequestId);
    }
}
