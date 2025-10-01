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

            // Apply auth scheme preference if configured
            authOptions = ApplyAuthSchemePreference(authOptions, executionContext.RequestContext.ClientConfig);

            var clientConfig = executionContext.RequestContext.ClientConfig;
            var defaultCredentials = executionContext.RequestContext.ExplicitAWSCredentials ?? clientConfig.DefaultAWSCredentials;

            for (int i = 0; i < authOptions.Count; i++)
            {
                var scheme = _supportedSchemes.FirstOrDefault(s => s.SchemeId == authOptions[i].SchemeId);
                if (scheme == null)
                {
                    // Current auth scheme option is not enabled / supported, continue iterating.
                    Logger?.DebugFormat($"{authOptions[i].SchemeId} scheme is not supported for {executionContext.RequestContext.RequestName}");
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
                        // If the legacy token provider is set, we'll use it to resolve the identity.
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
                    // If there are multiple authentication schemes and we cannot resolve the identity for some reason (e.g. the CRT is
                    // required for SigV4A signing), we'll attempt the next option (if there are any left) before returning.
                    var areSchemesLeft = i < authOptions.Count - 1;
                    if (areSchemesLeft)
                    {
                        Logger?.DebugFormat($"Could not resolve identity for {executionContext.RequestContext.RequestName} using {scheme.SchemeId} scheme: {ex.Message}");
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

            // Apply auth scheme preference if configured
            authOptions = ApplyAuthSchemePreference(authOptions, executionContext.RequestContext.ClientConfig);

            var clientConfig = executionContext.RequestContext.ClientConfig;
            var cancellationToken = executionContext.RequestContext.CancellationToken;
            var defaultCredentials = executionContext.RequestContext.ExplicitAWSCredentials ?? clientConfig.DefaultAWSCredentials;

            for (int i = 0; i < authOptions.Count; i++)
            {
                var scheme = _supportedSchemes.FirstOrDefault(s => s.SchemeId == authOptions[i].SchemeId);
                if (scheme == null)
                {
                    // Current auth scheme option is not enabled / supported, continue iterating.
                    Logger?.DebugFormat($"{authOptions[i].SchemeId} scheme is not supported for {executionContext.RequestContext.RequestName}");
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
                        // If the legacy token provider is set, we'll use it to resolve the identity.
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
                    // If there are multiple authentication schemes and we cannot resolve the identity for some reason (e.g. the CRT is
                    // required for SigV4A signing), we'll attempt the next option (if there are any left) before returning.
                    var areSchemesLeft = i < authOptions.Count - 1;
                    if (areSchemesLeft)
                    {
                        Logger?.DebugFormat($"Could not resolve identity for {executionContext.RequestContext.RequestName} using {scheme.SchemeId} scheme: {ex.Message}");
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
        /// Applies the configured auth scheme preference to reorder the auth options.
        /// </summary>
        private static List<IAuthSchemeOption> ApplyAuthSchemePreference(List<IAuthSchemeOption> authOptions, IClientConfig clientConfig)
        {
            var preferenceList = clientConfig.AuthSchemePreference;
            if (string.IsNullOrEmpty(preferenceList))
            {
                return authOptions;
            }

            // Parse the preference list (comma-separated, trimming spaces and tabs between names)
            var preferences = preferenceList
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim(' ', '\t'))  // Trim spaces and tabs between auth scheme names
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList();

            if (preferences.Count == 0)
            {
                return authOptions;
            }

            // Reorder auth options based on preferences
            var reorderedOptions = new List<IAuthSchemeOption>();
            
            // First, add options that match the preference order
            foreach (var preferredScheme in preferences)
            {
                // Convert short name to full scheme ID (e.g., "sigv4" -> "aws.auth#sigv4")
                var fullSchemeId = GetFullSchemeId(preferredScheme);
                
                foreach (var option in authOptions)
                {
                    if (option.SchemeId == fullSchemeId && !reorderedOptions.Contains(option))
                    {
                        reorderedOptions.Add(option);
                    }
                }
            }

            // Then add any remaining options that weren't in the preference list
            foreach (var option in authOptions)
            {
                if (!reorderedOptions.Contains(option))
                {
                    reorderedOptions.Add(option);
                }
            }

            // CRITICAL: Ensure NoAuth/Anonymous is always last in the list.
            // This prevents unauthenticated requests when authentication is available.
            var noAuthOption = reorderedOptions.FirstOrDefault(o =>
                o.SchemeId == "smithy.api#noAuth" ||
                o.SchemeId.EndsWith("#noAuth"));
            
            if (noAuthOption != null)
            {
                reorderedOptions.Remove(noAuthOption);
                reorderedOptions.Add(noAuthOption);
            }

            return reorderedOptions;
        }

        /// <summary>
        /// Converts a short auth scheme name to its full scheme ID.
        /// </summary>
        private static string GetFullSchemeId(string schemeName)
        {
            // Handle common auth scheme names (case-sensitive as per specification)
            if (schemeName == "sigv4")
                return "aws.auth#sigv4";
            if (schemeName == "sigv4a")
                return "aws.auth#sigv4a";
            if (schemeName == "httpBearerAuth" || schemeName == "bearer")
                return "smithy.api#httpBearerAuth";
            if (schemeName == "noAuth")
                return "smithy.api#noAuth";
            
            // If it already looks like a full ID (contains #), return as-is
            if (schemeName.Contains("#"))
                return schemeName;
                
            // Otherwise, assume it's an AWS auth scheme
            return $"aws.auth#{schemeName}";
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
