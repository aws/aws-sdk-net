using System;
#if AWS_ASYNC_API
using System.Threading;
using System.Threading.Tasks;
#endif
using Amazon.Util;

namespace Amazon.Runtime
{
    /// <inheritdoc cref="StaticTokenProvider(string, DateTime?)"/>
    public class StaticTokenProvider : IAWSTokenProvider
    {
        private readonly string _token;
        private readonly DateTime? _expiration;

        /// <summary>
        /// Creates a new <see cref="StaticTokenProvider"/> that can be assigned to
        /// <see cref="IClientConfig.AWSTokenProvider"/> or added to a <see cref="AWSTokenProviderChain"/>.
        /// </summary>
        /// <param name="token">
        /// Bearer token to use to authorize AWS SDK requests.
        /// </param>
        /// <param name="expiration">
        /// An optional <see cref="DateTime"/> in UTC for which <paramref name="token"/> will no longer be
        /// valid.  Attempting to retrieve <paramref name="token"/> after <paramref name="expiration"/> will cause
        /// a <see cref="AmazonClientException"/> to be thrown.
        /// </param>
        public StaticTokenProvider(string token, DateTime? expiration = null)
        {
            _token = token;
            _expiration = expiration;
        }

#if BCL
        public bool TryResolveToken(out AWSToken token)
        {
            if (IsTokenUnexpired())
            {
                token = new AWSToken {Token = _token};
                return true;
            }
            else
            {
                token = null;
                return false;
            }
        }
#endif

#if AWS_ASYNC_API
        public Task<TryResponse<AWSToken>> TryResolveTokenAsync(CancellationToken cancellationToken = default)
        {
            var isTokenUnexpired = IsTokenUnexpired();

            return Task.FromResult(
                new TryResponse<AWSToken>
                {
                    Success = isTokenUnexpired,
                    Value = isTokenUnexpired ? new AWSToken { Token = _token } : null
                });
        }
#endif

        private bool IsTokenUnexpired()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            return (!_expiration.HasValue || _expiration.Value < AWSSDKUtils.CorrectedUtcNow);
#pragma warning restore CS0618 // Type or member is obsolete

        }
    }
}