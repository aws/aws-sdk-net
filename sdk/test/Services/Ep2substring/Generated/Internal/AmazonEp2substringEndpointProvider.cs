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
 * Do not modify this file. This file is generated from the ep2-substring-2022-08-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.Ep2substring.Internal
{
    /// <summary>
    /// Amazon Ep2substring endpoint provider.
    /// Resolves endpoint for given set of Ep2substringEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonEp2substringEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for Ep2substringEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["TestCaseId"] == null)
                throw new AmazonClientException("TestCaseId parameter must be set for endpoint resolution");
            if (parameters["Input"] == null)
                throw new AmazonClientException("Input parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["TestCaseId"] = parameters["TestCaseId"],
                ["Input"] = parameters["Input"],
            };
            if (Equals(Interpolate(@"{TestCaseId}", refs), "1") && (refs["output"] = Substring(Interpolate(@"{Input}", refs), 0, 4, false)) != null)
            {
                throw new AmazonClientException(Interpolate(@"The value is: `{output}`", refs));
            }
            if (Equals(Interpolate(@"{TestCaseId}", refs), "2") && (refs["output"] = Substring(Interpolate(@"{Input}", refs), 0, 4, true)) != null)
            {
                throw new AmazonClientException(Interpolate(@"The value is: `{output}`", refs));
            }
            if (Equals(Interpolate(@"{TestCaseId}", refs), "3") && (refs["output"] = Substring(Interpolate(@"{Input}", refs), 1, 3, false)) != null)
            {
                throw new AmazonClientException(Interpolate(@"The value is: `{output}`", refs));
            }
            throw new AmazonClientException("No tests matched");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}