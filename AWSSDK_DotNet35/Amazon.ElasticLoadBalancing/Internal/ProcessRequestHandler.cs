/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Internal
{
    public class ProcessRequestHandler : GenericHandler
    {
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var originalRequest = executionContext.RequestContext.OriginalRequest;
            bool shouldSetPolicyNames =
                originalRequest is SetLoadBalancerPoliciesOfListenerRequest ||
                originalRequest is SetLoadBalancerPoliciesForBackendServerRequest;
            if (shouldSetPolicyNames)
            {
                SetPolicyNames(executionContext.RequestContext.Request);
            }
        }

        private static void SetPolicyNames(IRequest request)
        {
            if (request.Parameters.Where(x => x.Key.StartsWith("PolicyNames", StringComparison.Ordinal)).ToList().Count == 0)
            {
                request.Parameters.Add("PolicyNames", "");
            }
        }
    }
}
