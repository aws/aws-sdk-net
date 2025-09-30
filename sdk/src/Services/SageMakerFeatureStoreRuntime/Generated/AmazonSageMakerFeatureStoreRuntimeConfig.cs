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

/*
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Endpoints;
using Amazon.SageMakerFeatureStoreRuntime.Internal;

namespace Amazon.SageMakerFeatureStoreRuntime
{
    /// <summary>
    /// Configuration for accessing Amazon SageMakerFeatureStoreRuntime service
    /// </summary>
    public partial class AmazonSageMakerFeatureStoreRuntimeConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("SageMaker FeatureStore Runtime", "4.0.0.25");

        private static readonly AmazonSageMakerFeatureStoreRuntimeEndpointResolver EndpointResolver =
            new AmazonSageMakerFeatureStoreRuntimeEndpointResolver();

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "SageMaker FeatureStore Runtime";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonSageMakerFeatureStoreRuntimeConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonSageMakerFeatureStoreRuntimeDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "SageMaker FeatureStore Runtime";
            this.AuthenticationServiceName = "sagemaker";
            this.EndpointProvider = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "featurestore-runtime.sagemaker";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2020-07-01";
            }
        }

        /// <summary>
        /// Gets the value of UserAgent property.
        /// </summary>
        public override string UserAgent
        {
            get
            {
                return _userAgent;
            }
        }

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="parameters">A Container class for parameters used for endpoint resolution.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public override Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
        {
            var requestContext = new RequestContext(false)
            {
                ClientConfig = this,
                OriginalRequest = parameters.Request,
                Request = new DefaultRequest(parameters.Request, ServiceId)
                {
                    AlternateEndpoint = parameters.AlternateEndpoint
                }
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            return EndpointResolver.GetEndpoint(executionContext);
        }


    }
}