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
    /// DescribeExportTasks Request Marshaller
    /// </summary>
    public partial class DescribeExportTasksRequestMarshaller : IMarshaller<IRequest, DescribeExportTasksRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeExportTasksRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeExportTasksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeExportTasks");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetExportTaskIdentifier())
            {
                request.Parameters.Add("ExportTaskIdentifier", StringUtils.FromString(publicRequest.ExportTaskIdentifier));
            }
            if (publicRequest.IsSetFilters())
            {
                if (publicRequest.Filters.Count == 0)
                {
                    request.Parameters.Add("Filters", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Filters)
                    {
                        if (item0.IsSetName())
                        {
                            request.Parameters.Add("Filters" + ".Filter" + "." + index0 + ".Name", StringUtils.FromString(item0.Name));
                        }
                        if (item0.IsSetValues())
                        {
                            if (item0.Values.Count == 0)
                            {
                                request.Parameters.Add("Filters" + ".Filter" + "." + index0 + ".Values", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Values)
                                {
                                    request.Parameters.Add("Filters" + ".Filter" + "." + index0 + ".Values" + ".Value" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            }
            if (publicRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords.Value));
            }
            if (publicRequest.IsSetSourceArn())
            {
                request.Parameters.Add("SourceArn", StringUtils.FromString(publicRequest.SourceArn));
            }
            if (publicRequest.IsSetSourceType())
            {
                request.Parameters.Add("SourceType", StringUtils.FromString(publicRequest.SourceType));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeExportTasksRequestMarshaller _instance = new();

        internal static DescribeExportTasksRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeExportTasksRequestMarshaller Instance => _instance;
    }
}
