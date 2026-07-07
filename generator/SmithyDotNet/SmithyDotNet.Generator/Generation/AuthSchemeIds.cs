namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// The Smithy auth-scheme shape IDs read from a <c>smithy.api#auth</c> list. Single source of truth
/// shared by the scheme-list derivation (<see cref="ModeledAuth"/>) and the known-default mapping
/// (<see cref="AuthSchemeMapping"/>).
/// </summary>
internal static class AuthSchemeIds
{
    public const string SigV4 = "aws.auth#sigv4";
    public const string SigV4A = "aws.auth#sigv4a";
    public const string Bearer = "smithy.api#httpBearerAuth";
    public const string NoAuth = "smithy.api#noAuth";
}
