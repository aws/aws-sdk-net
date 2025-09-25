/*
* Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
* 
* Licensed under the Apache License, Version 2.0 (the "License").
* You may not use this file except in compliance with the License.
* A copy of the License is located at
* 
*  http://aws.amazon.com/apache2.0
* 
* or in the "license" file accompanying this file. This file is distributed
* on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
* express or implied. See the License for the specific language governing
* permissions and limitations under the License.
*/

using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.UserAgent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
    public abstract class BaseAuthResolverHandler : PipelineHandler
    {
        private readonly HashSet<IAuthScheme<BaseIdentity>> _supportedSchemes = new()
        {
            new AnonymousAuthScheme(),
            new AwsV4aAuthScheme(),
            new AwsV4AuthScheme(),
            new BearerAuthScheme(),
        };

        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

        public override async Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            await PreInvokeAsync(executionContext).ConfigureAwait(false);
            return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
        }

        protected void PreInvoke(IExecutionContext executionContext)
        {
            var authOptions = ResolveAuthOptions(executionContext);
            if (authOptions == null || authOptions.Count == 0)
            {
                throw new AmazonClientException($"No valid authentication schemes defined for {executionContext.RequestContext.RequestName}");
            }

            // Apply authentication scheme preferences if configured
            authOptions = ApplyAuthSchemePreferences(executionContext.RequestContext.ClientConfig, authOptions);

            var clientConfig = executionContext.RequestContext.ClientConfig;
            var defaultCredentials = executionContext.RequestContext.ExplicitAWSCredentials ?? clientConfig.DefaultAWSCredentials;

            for (int i = 0; i < authOptions.Count; i++)
            {
                var scheme = _supportedSchemes.FirstOrDefault(s => s.SchemeId == authOptions[i].SchemeId);
                if (scheme == null)
                {
                    Logger.DebugFormat($"{authOptions[i].SchemeId} scheme is not supported for {executionContext.RequestContext.RequestName}");
                    continue;
                }

                try
                {
                    executionContext.RequestContext.Signer = GetSigner(scheme);

                    if ((scheme is AwsV4aAuthScheme || scheme is AwsV4AuthScheme) && defaultCredentials != null)
                    {
                        // We can use DefaultAWSCredentials if it was set by the user for these schemes.
                        executionContext.RequestContext.Identity = defaultCredentials;
                        break;
                    }

                    if (scheme is BearerAuthScheme && clientConfig.AWSTokenProvider != null)
                    {
#if NETFRAMEWORK
                        var resolvedToken = clientConfig.AWSTokenProvider.TryResolveToken(out var token);
                        if (!resolvedToken)
                        {
                            continue;
                        }
#else
                        var resolvedToken = clientConfig.AWSTokenProvider.TryResolveTokenAsync().GetAwaiter().GetResult();
                        if (!resolvedToken.Success)
                        {
                            continue;
                        }

                        var token = resolvedToken.Value;
#endif

                        executionContext.RequestContext.Identity = token;
                        break;
                    }

                    var identityResolver = scheme.GetIdentityResolver(clientConfig.IdentityResolverConfiguration);
                    executionContext.RequestContext.Identity = identityResolver.ResolveIdentity(clientConfig);

                    if (executionContext.RequestContext.Identity != null)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    // Try next auth scheme if identity resolution fails
                    var areSchemesLeft = i < authOptions.Count - 1;
                    if (areSchemesLeft)
                    {
                        Logger.DebugFormat($"Could not resolve identity for {executionContext.RequestContext.RequestName} using {scheme.SchemeId} scheme: {ex.Message}");
                        continue;
                    }

                    throw;
                }
            }

            if (executionContext.RequestContext.Identity == null)
            {
                throw new AmazonClientException($"Could not determine which authentication scheme to use for {executionContext.RequestContext.RequestName}");
            }

            AddUserAgentDetails(executionContext);
        }

        protected async Task PreInvokeAsync(IExecutionContext executionContext)
        {
            var authOptions = ResolveAuthOptions(executionContext);
            if (authOptions == null || authOptions.Count == 0)
            {
                throw new AmazonClientException($"No valid authentication schemes defined for {executionContext.RequestContext.RequestName}");
            }

            // Apply authentication scheme preferences if configured
            authOptions = ApplyAuthSchemePreferences(executionContext.RequestContext.ClientConfig, authOptions);

            var clientConfig = executionContext.RequestContext.ClientConfig;
            var cancellationToken = executionContext.RequestContext.CancellationToken;
            var defaultCredentials = executionContext.RequestContext.ExplicitAWSCredentials ?? clientConfig.DefaultAWSCredentials;

            for (int i = 0; i < authOptions.Count; i++)
            {
                var scheme = _supportedSchemes.FirstOrDefault(s => s.SchemeId == authOptions[i].SchemeId);
                if (scheme == null)
                {
                    Logger.DebugFormat($"{authOptions[i].SchemeId} scheme is not supported for {executionContext.RequestContext.RequestName}");
                    continue;
                }

                try
                {
                    executionContext.RequestContext.Signer = GetSigner(scheme);

                    if ((scheme is AwsV4aAuthScheme || scheme is AwsV4AuthScheme) && defaultCredentials != null)
                    {
                        // We can use DefaultAWSCredentials if it was set by the user for these schemes.
                        executionContext.RequestContext.Identity = defaultCredentials;
                        break;
                    }

                    if (scheme is BearerAuthScheme && clientConfig.AWSTokenProvider != null)
                    {
                        var resolvedToken = await clientConfig.AWSTokenProvider
                            .TryResolveTokenAsync(cancellationToken)
                            .ConfigureAwait(false);

                        if (!resolvedToken.Success)
                        {
                            continue;
                        }

                        executionContext.RequestContext.Identity = resolvedToken.Value;
                        break;
                    }

                    var identityResolver = scheme.GetIdentityResolver(clientConfig.IdentityResolverConfiguration);
                    executionContext.RequestContext.Identity = await identityResolver
                        .ResolveIdentityAsync(clientConfig, cancellationToken)
                        .ConfigureAwait(false);

                    if (executionContext.RequestContext.Identity != null)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    // Try next auth scheme if identity resolution fails
                    var areSchemesLeft = i < authOptions.Count - 1;
                    if (areSchemesLeft)
                    {
                        Logger.DebugFormat($"Could not resolve identity for {executionContext.RequestContext.RequestName} using {scheme.SchemeId} scheme: {ex.Message}");
                        continue;
                    }

                    throw;
                }
            }

            if (executionContext.RequestContext.Identity == null)
            {
                throw new AmazonClientException($"Could not determine which authentication scheme to use for {executionContext.RequestContext.RequestName}");
            }

            AddUserAgentDetails(executionContext);
        }

        protected virtual ISigner GetSigner(IAuthScheme<BaseIdentity> scheme)
        {
            return scheme.Signer();
        }

        /// <summary>
        /// Certain allow-listed services contain auth schemes in their endpoint ruleset. For those, we'll attempt to
        /// retrieve the auth options from the attributes of the resolved endpoint.
        /// </summary>
        protected static List<IAuthSchemeOption> RetrieveSchemesFromEndpoint(Endpoint endpoint)
        {
            if (endpoint == null || endpoint.Attributes == null)
            {
                return null;
            }

            var authSchemes = endpoint.Attributes["authSchemes"] as IList;
            if (authSchemes == null)
            {
                return null;
            }

            var schemeNames = authSchemes.OfType<PropertyBag>().Select(scheme => (string)scheme["name"]).ToList();

            // If there's only one scheme, we'll try to return one of the default collections to avoid extra allocations.
            if (schemeNames.Count == 1)
            {
                var schemeName = schemeNames.First();
                switch (schemeName)
                {
                    case "sigv4":
                    case "sigv4-s3express":
                        return AuthSchemeOption.DEFAULT_SIGV4;
                    case "sigv4a":
                        return AuthSchemeOption.DEFAULT_SIGV4A;
                    default:
                        break;
                }
            }
            
            // If there's more than one scheme, we'll just return them as is (adding prefixes since the model doesn't have them).
            // Another important callout is that the BaseEndpointResolver will handle populating the request context with additional 
            // parameters from the endpoint attributes (e.g. whether to disable double encoding).
            var options = new List<IAuthSchemeOption>();
            foreach (var schemeName in schemeNames)
            {
                switch (schemeName)
                {
                    case "sigv4":
                    case "sigv4-s3express":
                        options.Add(new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 });
                        break;
                    case "sigv4a":
                        options.Add(new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A });
                        break;
                    default:
                        break;
                }
            }
            return options;
        }

        /// <summary>
        /// Invokes the service auth scheme resolver to determine which auth options we should consider for this request.
        /// </summary>
        protected abstract List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext);

        /// <summary>
        /// Applies authentication scheme preferences to reprioritize the auth options based on client configuration.
        /// </summary>
        /// <param name="clientConfig">The client configuration containing authentication scheme preferences.</param>
        /// <param name="authOptions">The original list of authentication scheme options from the service.</param>
        /// <returns>A reprioritized list of authentication scheme options based on preferences.</returns>
        protected virtual List<IAuthSchemeOption> ApplyAuthSchemePreferences(IClientConfig clientConfig, List<IAuthSchemeOption> authOptions)
        {
            if (authOptions == null || authOptions.Count == 0)
            {
                return authOptions;
            }

            // Resolve preference from configuration hierarchy
            string preferenceString = ResolveAuthSchemePreference(clientConfig);
            
            if (string.IsNullOrWhiteSpace(preferenceString))
            {
                return authOptions;
            }

            try
            {
                // Parse the comma-separated preference list
                var preferences = preferenceString.Split(',')
                    .Select(s => s.Trim())
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .ToList();

                if (preferences.Count == 0)
                {
                    return authOptions;
                }

                var reordered = new List<IAuthSchemeOption>();
                var remaining = new List<IAuthSchemeOption>(authOptions);

                // Add schemes in preference order
                foreach (var preferredName in preferences)
                {
                    var match = remaining.FirstOrDefault(opt =>
                    {
                        var shortName = AuthSchemeOption.GetNameFromSchemeId(opt.SchemeId);
                        return string.Equals(shortName, preferredName, StringComparison.Ordinal);
                    });
                    
                    if (match != null)
                    {
                        reordered.Add(match);
                        remaining.Remove(match);
                        Logger.DebugFormat("Applied preference for scheme: {0}", match.SchemeId);
                    }
                }

                // Add any remaining schemes not in the preference list
                foreach (var scheme in remaining)
                {
                    reordered.Add(scheme);
                    Logger.DebugFormat("Added non-preferred scheme: {0}", scheme.SchemeId);
                }

                return reordered;
            }
            catch (ArgumentException ex)
            {
                Logger.Error(ex, "Failed to apply auth scheme preferences due to invalid argument, falling back to service-defined order");
                return authOptions;
            }
            catch (InvalidOperationException ex)
            {
                Logger.Error(ex, "Failed to apply auth scheme preferences due to invalid operation, falling back to service-defined order");
                return authOptions;
            }
        }

        /// <summary>
        /// Resolves authentication scheme preference using configuration precedence hierarchy.
        /// </summary>
        private string ResolveAuthSchemePreference(IClientConfig clientConfig)
        {
            // Client configuration
            string clientPreference = clientConfig?.AuthSchemePreference;
            if (!string.IsNullOrWhiteSpace(clientPreference))
            {
                Logger.InfoFormat("Using auth scheme preference from client configuration: {0}", clientPreference);
                return clientPreference;
            }

            // Environment variable
            string envPreference = FallbackInternalConfigurationFactory.AuthSchemePreference;
            if (!string.IsNullOrWhiteSpace(envPreference))
            {
                Logger.InfoFormat("Using auth scheme preference from environment/config: {0}", envPreference);
                return envPreference;
            }

            // Global AWSConfigs
            if (!string.IsNullOrWhiteSpace(AWSConfigs.AuthSchemePreference))
            {
                Logger.InfoFormat("Using auth scheme preference from global AWSConfigs: {0}", 
                    AWSConfigs.AuthSchemePreference);
                return AWSConfigs.AuthSchemePreference;
            }

            Logger.DebugFormat("No auth scheme preference configured, using default resolution");
            return null;
        }

        private static void AddUserAgentDetails(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            if (requestContext.Identity == null || requestContext.Identity is not AWSCredentials credentials)
            {
                return;
            }

            foreach (var featureId in credentials.FeatureIdSources)
            {
                requestContext.UserAgentDetails.AddFeature(featureId);
            }
        }
    }
}
