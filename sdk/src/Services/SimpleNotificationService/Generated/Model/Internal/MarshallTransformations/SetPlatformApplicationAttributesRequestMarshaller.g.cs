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

using Amazon.SimpleNotificationService.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetPlatformApplicationAttributes Request Marshaller
    /// </summary>
    public partial class SetPlatformApplicationAttributesRequestMarshaller : IMarshaller<IRequest, SetPlatformApplicationAttributesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetPlatformApplicationAttributesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SetPlatformApplicationAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleNotificationService");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SetPlatformApplicationAttributes");
            request.Parameters.Add("Version", "2010-03-31");

            if (publicRequest.IsSetAttributes())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.Attributes)
                {
                    request.Parameters.Add("Attributes" + ".entry" + "." + index0 + ".key", StringUtils.FromString(kvp0.Key));
                    request.Parameters.Add("Attributes" + ".entry" + "." + index0 + ".value", StringUtils.FromString(kvp0.Value));
                    index0++;
                }
            }
            if (publicRequest.IsSetPlatformApplicationArn())
            {
                request.Parameters.Add("PlatformApplicationArn", StringUtils.FromString(publicRequest.PlatformApplicationArn));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly SetPlatformApplicationAttributesRequestMarshaller _instance = new();

        internal static SetPlatformApplicationAttributesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SetPlatformApplicationAttributesRequestMarshaller Instance => _instance;
    }
}
