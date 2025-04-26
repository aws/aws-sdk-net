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
 * Do not modify this file. This file is generated from the ep2-complex-parameters-2022-08-24.normal.json service model.
 */

using System;
using System.Linq;
using System.Collections.Generic;
using Amazon.Ep2complexparameters.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.Ep2complexparameters.Endpoints;

#pragma warning disable 1591

namespace Amazon.Ep2complexparameters.Internal
{
    /// <summary>
    /// Amazon Ep2complexparameters endpoint resolver.
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for Ep2complexparameters service requests.
    /// Collects values for Ep2complexparametersEndpointParameters and then tries to resolve endpoint by calling 
    /// ResolveEndpoint method on GlobalEndpoints.Provider if present, otherwise uses Ep2complexparametersEndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class AmazonEp2complexparametersEndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {

            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonEp2complexparametersConfig)requestContext.ClientConfig;
            var result = new Ep2complexparametersEndpointParameters();



            // Assign staticContextParams and contextParam per operation
            if (requestContext.RequestName == "EmptyStaticContextOperationRequest") {
                result.stringArrayParam = new List<string> {  };
                return result;
            }
            if (requestContext.RequestName == "ListOfObjectsOperationRequest") {
                var request = (ListOfObjectsOperationRequest)requestContext.OriginalRequest;
                result.stringArrayParam = request.Nested?.ListOfObjects?.Select(element => element?.Key);
                return result;
            }
            if (requestContext.RequestName == "ListOfUnionsOperationRequest") {
                var request = (ListOfUnionsOperationRequest)requestContext.OriginalRequest;
                result.stringArrayParam = request.ListOfUnions?.Select(element => new [] { element?.String, element?.Object?.Key })?.SelectMany(element => element).Where(element => element != null);
                return result;
            }
            if (requestContext.RequestName == "MapOperationRequest") {
                var request = (MapOperationRequest)requestContext.OriginalRequest;
                result.stringArrayParam = request.Map?.Keys.ToList();
                return result;
            }
            if (requestContext.RequestName == "StaticContextOperationRequest") {
                result.stringArrayParam = new List<string> { "staticValue1" };
                return result;
            }

            return result;
        }
    }
}