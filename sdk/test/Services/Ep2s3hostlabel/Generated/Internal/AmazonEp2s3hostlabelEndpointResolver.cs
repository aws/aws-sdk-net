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
 * Do not modify this file. This file is generated from the ep2-s3-host-label-2022-08-24.normal.json service model.
 */

using System;
using System.Linq;
using System.Collections.Generic;
using Amazon.Ep2s3hostlabel.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.Ep2s3hostlabel.Endpoints;

#pragma warning disable 1591

namespace Amazon.Ep2s3hostlabel.Internal
{
    /// <summary>
    /// Amazon Ep2s3hostlabel endpoint resolver.
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for Ep2s3hostlabel service requests.
    /// Collects values for Ep2s3hostlabelEndpointParameters and then tries to resolve endpoint by calling 
    /// ResolveEndpoint method on GlobalEndpoints.Provider if present, otherwise uses Ep2s3hostlabelEndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class AmazonEp2s3hostlabelEndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {

            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonEp2s3hostlabelConfig)requestContext.ClientConfig;
            var result = new Ep2s3hostlabelEndpointParameters();



            // Assign staticContextParams and contextParam per operation

            return result;
        }
    }
}