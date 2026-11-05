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
    /// DetectStackDrift Request Marshaller
    /// </summary>
    public partial class DetectStackDriftRequestMarshaller : IMarshaller<IRequest, DetectStackDriftRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DetectStackDriftRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DetectStackDriftRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DetectStackDrift");
            request.Parameters.Add("Version", "2010-05-15");

            if (publicRequest.IsSetLogicalResourceIds())
            {
                if (publicRequest.LogicalResourceIds.Count == 0)
                {
                    request.Parameters.Add("LogicalResourceIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.LogicalResourceIds)
                    {
                        request.Parameters.Add("LogicalResourceIds" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetStackName())
            {
                request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DetectStackDriftRequestMarshaller _instance = new();

        internal static DetectStackDriftRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DetectStackDriftRequestMarshaller Instance => _instance;
    }
}
