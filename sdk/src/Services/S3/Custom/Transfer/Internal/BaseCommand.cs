/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Util;
using Amazon.Runtime.Internal.UserAgent;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Generic base command that returns a typed response
    /// </summary>
    /// <typeparam name="TResponse">Type of response returned by the command</typeparam>
    internal abstract partial class BaseCommand<TResponse> where TResponse : class
    {
        internal GetObjectRequest ConvertToGetObjectRequest(BaseDownloadRequest request)
        {
            // Use centralized request mapping
            GetObjectRequest getRequest = RequestMapper.MapToGetObjectRequest(request);
            
            // Add command-specific event handler
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)getRequest).AddBeforeRequestHandler(this.RequestEventHandler);

            return getRequest;
        }

        protected void RequestEventHandler(object sender, RequestEventArgs args)
        {
            WebServiceRequestEventArgs wsArgs = args as WebServiceRequestEventArgs;
            if (wsArgs != null)
            {
                ((Runtime.Internal.IAmazonWebServiceRequest)wsArgs.Request).UserAgentDetails.AddFeature(UserAgentFeatureId.S3_TRANSFER);
                ((Runtime.Internal.IAmazonWebServiceRequest)wsArgs.Request).UserAgentDetails.AddUserAgentComponent("md/" + this.GetType().Name);
            }
        }
    }
}
