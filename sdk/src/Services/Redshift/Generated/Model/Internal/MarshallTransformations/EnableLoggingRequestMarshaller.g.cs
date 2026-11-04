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

using Amazon.Redshift.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EnableLogging Request Marshaller
    /// </summary>
    public partial class EnableLoggingRequestMarshaller : IMarshaller<IRequest, EnableLoggingRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EnableLoggingRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(EnableLoggingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "EnableLogging");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetBucketName())
            {
                request.Parameters.Add("BucketName", StringUtils.FromString(publicRequest.BucketName));
            }
            if (publicRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
            }
            if (publicRequest.IsSetLogDestinationType())
            {
                request.Parameters.Add("LogDestinationType", StringUtils.FromString(publicRequest.LogDestinationType));
            }
            if (publicRequest.IsSetLogExports())
            {
                if (publicRequest.LogExports.Count == 0)
                {
                    request.Parameters.Add("LogExports", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.LogExports)
                    {
                        request.Parameters.Add("LogExports" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetS3KeyPrefix())
            {
                request.Parameters.Add("S3KeyPrefix", StringUtils.FromString(publicRequest.S3KeyPrefix));
            }
            if (publicRequest.IsSetS3TableGranularity())
            {
                request.Parameters.Add("S3TableGranularity", StringUtils.FromString(publicRequest.S3TableGranularity));
            }
            if (publicRequest.IsSetS3TableKmsKeyId())
            {
                request.Parameters.Add("S3TableKmsKeyId", StringUtils.FromString(publicRequest.S3TableKmsKeyId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly EnableLoggingRequestMarshaller _instance = new();

        internal static EnableLoggingRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static EnableLoggingRequestMarshaller Instance => _instance;
    }
}
