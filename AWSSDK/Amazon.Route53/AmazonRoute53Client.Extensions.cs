/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;

using Amazon.Route53.Model;
using Amazon.Route53.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.Route53
{
    /// <summary>
    /// Implementation for accessing AmazonRoute53.
    ///  
    /// 
    /// </summary>
    public partial class AmazonRoute53Client : AmazonWebServiceClient, AmazonRoute53
    {
        /// <summary>
        /// Remove duplicates in resource path which can happen if the exact return values from the CreateHostedZone
        /// operation are used.
        /// </summary>
        /// <param name="request"></param>
        protected override void ProcessRequestHandlers(IRequest request)
        {
            base.ProcessRequestHandlers(request);


            if (request.ResourcePath.Contains("/hostedzone//hostedzone/"))
            {
                request.ResourcePath = request.ResourcePath.Replace("/hostedzone//hostedzone/", "/hostedzone/");
            }
            if (request.ResourcePath.Contains("/change//change/"))
            {
                request.ResourcePath = request.ResourcePath.Replace("/change//change/", "/change/");
            }
        }
    }
}
