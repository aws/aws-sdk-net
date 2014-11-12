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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3.Util;
using System;

namespace Amazon.S3.Internal
{
    public class AmazonS3KmsHandler : GenericHandler
    {
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            EvaluateIfSigV4Required(request);
        }

        internal static void EvaluateIfSigV4Required(IRequest request)
        {
            
            if (request.OriginalRequest is S3.Model.GetObjectRequest)
            {
                var region = new AmazonS3Uri(request.Endpoint.OriginalString).Region;
                if(region != RegionEndpoint.USEast1)
                    request.RequireSigV4 = true;
            }
        }
    }
}
