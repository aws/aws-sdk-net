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

using Amazon.ElasticBeanstalk.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeEnvironments Request Marshaller
    /// </summary>
    public partial class DescribeEnvironmentsRequestMarshaller : IMarshaller<IRequest, DescribeEnvironmentsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeEnvironmentsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeEnvironmentsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeEnvironments");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
            }
            if (publicRequest.IsSetEnvironmentIds())
            {
                if (publicRequest.EnvironmentIds.Count == 0)
                {
                    request.Parameters.Add("EnvironmentIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.EnvironmentIds)
                    {
                        request.Parameters.Add("EnvironmentIds" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetEnvironmentNames())
            {
                if (publicRequest.EnvironmentNames.Count == 0)
                {
                    request.Parameters.Add("EnvironmentNames", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.EnvironmentNames)
                    {
                        request.Parameters.Add("EnvironmentNames" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetIncludeDeleted())
            {
                request.Parameters.Add("IncludeDeleted", StringUtils.FromBool(publicRequest.IncludeDeleted.Value));
            }
            if (publicRequest.IsSetIncludedDeletedBackTo())
            {
                request.Parameters.Add("IncludedDeletedBackTo", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.IncludedDeletedBackTo.Value));
            }
            if (publicRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords.Value));
            }
            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            if (publicRequest.IsSetVersionLabel())
            {
                request.Parameters.Add("VersionLabel", StringUtils.FromString(publicRequest.VersionLabel));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeEnvironmentsRequestMarshaller _instance = new();

        internal static DescribeEnvironmentsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeEnvironmentsRequestMarshaller Instance => _instance;
    }
}
