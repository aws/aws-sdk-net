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
    /// DescribeScheduledActions Request Marshaller
    /// </summary>
    public partial class DescribeScheduledActionsRequestMarshaller : IMarshaller<IRequest, DescribeScheduledActionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeScheduledActionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeScheduledActionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeScheduledActions");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetActive())
            {
                request.Parameters.Add("Active", StringUtils.FromBool(publicRequest.Active.Value));
            }
            if (publicRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime.Value));
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
                            request.Parameters.Add("Filters" + ".ScheduledActionFilter" + "." + index0 + ".Name", StringUtils.FromString(item0.Name));
                        }
                        if (item0.IsSetValues())
                        {
                            if (item0.Values.Count == 0)
                            {
                                request.Parameters.Add("Filters" + ".ScheduledActionFilter" + "." + index0 + ".Values", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Values)
                                {
                                    request.Parameters.Add("Filters" + ".ScheduledActionFilter" + "." + index0 + ".Values" + ".item" + "." + index1, StringUtils.FromString(item1));
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
            if (publicRequest.IsSetScheduledActionName())
            {
                request.Parameters.Add("ScheduledActionName", StringUtils.FromString(publicRequest.ScheduledActionName));
            }
            if (publicRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime.Value));
            }
            if (publicRequest.IsSetTargetActionType())
            {
                request.Parameters.Add("TargetActionType", StringUtils.FromString(publicRequest.TargetActionType));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeScheduledActionsRequestMarshaller _instance = new();

        internal static DescribeScheduledActionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeScheduledActionsRequestMarshaller Instance => _instance;
    }
}
