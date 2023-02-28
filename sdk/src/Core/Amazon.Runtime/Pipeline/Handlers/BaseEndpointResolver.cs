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
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Amazon.Runtime.Endpoints;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for service requests.
    /// Collects values for EndpointParameters and then resolves endpoint via global or service-specific EndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class BaseEndpointResolver : PipelineHandler
    {
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

#if AWS_ASYNC_API
        public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            return base.InvokeAsync<T>(executionContext);
        }
#elif AWS_APM_API
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            PreInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            return base.InvokeAsync(executionContext);
        }
#endif

        protected virtual void PreInvoke(IExecutionContext executionContext)
        { 
            ProcessRequestHandlers(executionContext);
        }

        public virtual void ProcessRequestHandlers(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            var parameters = MapEndpointsParameters(requestContext);
            var config = requestContext.ClientConfig;
            
            Endpoint endpoint = null;
            if (GlobalEndpoints.Provider != null)
            {
                endpoint = GlobalEndpoints.Provider.ResolveEndpoint(requestContext.ServiceMetaData?.ServiceId, parameters);
            }
            else if (endpoint == null && config.EndpointProvider != null)
            {
                endpoint = config.EndpointProvider.ResolveEndpoint(parameters);
            }
            
            // Ensure url ends with "/" to avoid signature mismatch issues.
            if (!endpoint.URL.EndsWith("/") && (string.IsNullOrEmpty(requestContext.Request.ResourcePath) || requestContext.Request.ResourcePath == "/"))
            {
                endpoint.URL += "/";
            }
            requestContext.Request.Endpoint = new Uri(endpoint.URL);

            // If an explicit ServiceURL was provided, do not manipulate it based on UseHttp
            // This preserves existing behavior prior to 3.7.100
            if (config.UseHttp && string.IsNullOrEmpty(requestContext.ClientConfig.ServiceURL))
            {
                var uriBuilder = new UriBuilder(requestContext.Request.Endpoint)
                {
                    Scheme = Uri.UriSchemeHttp,
                    Port = requestContext.Request.Endpoint.IsDefaultPort ? -1 : requestContext.Request.Endpoint.Port
                };
                requestContext.Request.Endpoint = uriBuilder.Uri;
            }

            // set authentication parameters and headers
            SetAuthenticationAndHeaders(requestContext.Request, endpoint);
            
            // service-specific handling, code-generated
            ServiceSpecificHandler(executionContext, parameters);

            // override AuthenticationRegion from ClientConfig if specified
            if (!string.IsNullOrEmpty(config.AuthenticationRegion))
            {
                requestContext.Request.AuthenticationRegion = config.AuthenticationRegion;
            }
        }

        /// <summary>
        /// Service-specific handling, we code-gen override per service.
        /// </summary>
        protected virtual void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {
        }

        private static readonly string[] SupportedAuthSchemas = { "sigv4", "sigv4a" };
        private static void SetAuthenticationAndHeaders(IRequest request, Endpoint endpoint)
        {
            if (endpoint.Attributes != null)
            {
                var authSchemes = (IList)endpoint.Attributes["authSchemes"];
                if (authSchemes != null)
                {
                    var schemaFound = false;
                    foreach (PropertyBag schema in authSchemes)
                    {
                        var schemaName = (string)schema["name"];
                        if (SupportedAuthSchemas.Contains(schemaName))
                        {
                            switch (schemaName)
                            {
                                case "sigv4":
                                    {
                                        request.SignatureVersion = SignatureVersion.SigV4;

                                        var signingRegion = (string)schema["signingRegion"];
                                        if (!string.IsNullOrEmpty(signingRegion))
                                        {
                                            request.AuthenticationRegion = signingRegion;
                                        }

                                        ApplyCommonSchema(request, schema);
                                        break;
                                    }
                                case "sigv4a":
                                    {
                                        request.SignatureVersion = SignatureVersion.SigV4a;

                                        var signingRegions = ((List<object>)schema["signingRegionSet"]).OfType<string>().ToArray();
                                        var authenticationRegion = string.Join(",", signingRegions);
                                        if (!string.IsNullOrEmpty(authenticationRegion))
                                        {
                                            request.AuthenticationRegion = authenticationRegion;
                                        }

                                        ApplyCommonSchema(request, schema);
                                        break;
                                    }
                            }
                            schemaFound = true;
                            break;
                        }
                    }
                    if (!schemaFound && authSchemes.Count > 0)
                    {
                        throw new AmazonClientException("Cannot find supported authentication schema");
                    }
                }
            }

            if (endpoint.Headers != null)
            {
                foreach (var header in endpoint.Headers)
                {
                    request.Headers[header.Key] = string.Join(",", header.Value.ToArray());
                }
            }
        }

        private static void ApplyCommonSchema(IRequest request, PropertyBag schema)
        {
            var signingName = (string)schema["signingName"];
            if (!string.IsNullOrEmpty(signingName))
            {
                request.OverrideSigningServiceName = signingName;
            }

            var disableDoubleEncoding = schema["disableDoubleEncoding"];
            if (disableDoubleEncoding != null)
            {
                request.UseDoubleEncoding = !(bool)disableDoubleEncoding;
            }
        }

        /// <summary>
        /// Inject host prefix into request endpoint.
        /// </summary>
        protected static void InjectHostPrefix(IRequestContext requestContext)
        {
            if (requestContext.ClientConfig.DisableHostPrefixInjection || 
                string.IsNullOrEmpty(requestContext.Request.HostPrefix))
            {
                return;
            }

            var hostPrefixUri = new UriBuilder(requestContext.Request.Endpoint);
            hostPrefixUri.Host = requestContext.Request.HostPrefix + hostPrefixUri.Host;
            requestContext.Request.Endpoint = hostPrefixUri.Uri;
        }

        /// <summary>
        /// Service-specific mapping of endpoints parameters, we code-gen override per service.
        /// </summary>
        protected virtual EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            return null;
        }
    }
}