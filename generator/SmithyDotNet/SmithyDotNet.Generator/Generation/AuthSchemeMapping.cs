namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Maps a modeled auth-scheme list to the corresponding <c>AuthSchemeOption.DEFAULT_*</c> constant
/// exposed by the SDK runtime. A list that matches one of the known combinations resolves to its
/// constant; any other list is emitted inline by the caller.
/// </summary>
public static class AuthSchemeMapping
{
    // Known scheme lists paired with the runtime constant the SDK exposes for them.
    private static readonly (string[] Schemes, string Constant)[] KnownLists =
    [
        ([AuthSchemeIds.SigV4], "AuthSchemeOption.DEFAULT_SIGV4"),
        ([AuthSchemeIds.SigV4A], "AuthSchemeOption.DEFAULT_SIGV4A"),
        ([AuthSchemeIds.SigV4, AuthSchemeIds.SigV4A], "AuthSchemeOption.DEFAULT_SIGV4_SIGV4A"),
        ([AuthSchemeIds.Bearer], "AuthSchemeOption.DEFAULT_BEARER"),
        ([AuthSchemeIds.NoAuth], "AuthSchemeOption.DEFAULT_NOAUTH"),
    ];

    /// <summary>
    /// Returns the <c>AuthSchemeOption.DEFAULT_*</c> constant for a known scheme list, or
    /// <c>false</c> when the list has no single-constant equivalent (the caller emits it inline).
    /// </summary>
    public static bool TryGetKnownDefault(IReadOnlyList<string> schemes, out string constant)
    {
        foreach (var (known, value) in KnownLists)
        {
            if (schemes.SequenceEqual(known))
            {
                constant = value;
                return true;
            }
        }

        constant = string.Empty;
        return false;
    }

    /// <summary>
    /// Whether a scheme list contains SigV4, which gates emitting the Region parameter.
    /// </summary>
    public static bool ContainsSigV4(IReadOnlyList<string> schemes) => schemes.Contains(AuthSchemeIds.SigV4);
}
