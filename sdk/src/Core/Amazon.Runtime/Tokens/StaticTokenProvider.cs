using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Util;

namespace Amazon.Runtime
{
    /// <summary>
    /// An <see cref="IAWSTokenProvider"/> implementation can be assigned to
    /// <see cref="IClientConfig.AWSTokenProvider"/> or added to a <see cref="AWSTokenProviderChain"/>.
    /// </summary>
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
                token = new AWSToken 
                { 
                    Token = _token,
                    Expiration = _expiration,
                };

                return true;
            }
            else
            {
                token = null;
                return false;
            }
        }
#endif

        public Task<TryResponse<AWSToken>> TryResolveTokenAsync(CancellationToken cancellationToken = default)
        {
            var isTokenUnexpired = IsTokenUnexpired();

            return Task.FromResult(
                new TryResponse<AWSToken>
                {
                    Success = isTokenUnexpired,
                    Value = isTokenUnexpired ? new AWSToken { Token = _token, Expiration = _expiration } : null
                });
        }

        private bool IsTokenUnexpired()
        {
            return (!_expiration.HasValue || _expiration.Value < AWSSDKUtils.CorrectedUtcNow);
        }
    }
}