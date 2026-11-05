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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.CloudFormation.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SignalResource Request Marshaller
    /// </summary>
    public partial class SignalResourceRequestMarshaller : IMarshaller<IRequest, SignalResourceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SignalResourceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SignalResourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SignalResource");
            request.Parameters.Add("Version", "2010-05-15");

            if (publicRequest.IsSetLogicalResourceId())
            {
                request.Parameters.Add("LogicalResourceId", StringUtils.FromString(publicRequest.LogicalResourceId));
            }
            if (publicRequest.IsSetStackName())
            {
                request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
            }
            if (publicRequest.IsSetStatus())
            {
                request.Parameters.Add("Status", StringUtils.FromString(publicRequest.Status));
            }
            if (publicRequest.IsSetUniqueId())
            {
                request.Parameters.Add("UniqueId", StringUtils.FromString(publicRequest.UniqueId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly SignalResourceRequestMarshaller _instance = new();

        internal static SignalResourceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SignalResourceRequestMarshaller Instance => _instance;
    }
}
