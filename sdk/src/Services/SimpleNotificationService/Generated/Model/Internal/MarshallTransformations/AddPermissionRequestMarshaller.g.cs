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
    /// AddPermission Request Marshaller
    /// </summary>
    public partial class AddPermissionRequestMarshaller : IMarshaller<IRequest, AddPermissionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddPermissionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AddPermissionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleNotificationService");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "AddPermission");
            request.Parameters.Add("Version", "2010-03-31");

            if (publicRequest.IsSetAWSAccountId())
            {
                if (publicRequest.AWSAccountId.Count == 0)
                {
                    request.Parameters.Add("AWSAccountId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AWSAccountId)
                    {
                        request.Parameters.Add("AWSAccountId" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetActionName())
            {
                if (publicRequest.ActionName.Count == 0)
                {
                    request.Parameters.Add("ActionName", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ActionName)
                    {
                        request.Parameters.Add("ActionName" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetLabel())
            {
                request.Parameters.Add("Label", StringUtils.FromString(publicRequest.Label));
            }
            if (publicRequest.IsSetTopicArn())
            {
                request.Parameters.Add("TopicArn", StringUtils.FromString(publicRequest.TopicArn));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly AddPermissionRequestMarshaller _instance = new();

        internal static AddPermissionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AddPermissionRequestMarshaller Instance => _instance;
    }
}
