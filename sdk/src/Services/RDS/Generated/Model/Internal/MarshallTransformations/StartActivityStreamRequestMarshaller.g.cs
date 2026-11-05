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

using Amazon.RDS.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartActivityStream Request Marshaller
    /// </summary>
    public partial class StartActivityStreamRequestMarshaller : IMarshaller<IRequest, StartActivityStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartActivityStreamRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartActivityStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "StartActivityStream");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately.Value));
            }
            if (publicRequest.IsSetEngineNativeAuditFieldsIncluded())
            {
                request.Parameters.Add("EngineNativeAuditFieldsIncluded", StringUtils.FromBool(publicRequest.EngineNativeAuditFieldsIncluded.Value));
            }
            if (publicRequest.IsSetKmsKeyId())
            {
                request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
            }
            if (publicRequest.IsSetMode())
            {
                request.Parameters.Add("Mode", StringUtils.FromString(publicRequest.Mode));
            }
            if (publicRequest.IsSetResourceArn())
            {
                request.Parameters.Add("ResourceArn", StringUtils.FromString(publicRequest.ResourceArn));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly StartActivityStreamRequestMarshaller _instance = new();

        internal static StartActivityStreamRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartActivityStreamRequestMarshaller Instance => _instance;
    }
}
