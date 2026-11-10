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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeScheduledInstanceAvailability Request Marshaller
    /// </summary>
    public partial class DescribeScheduledInstanceAvailabilityRequestMarshaller : IMarshaller<IRequest, DescribeScheduledInstanceAvailabilityRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeScheduledInstanceAvailabilityRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeScheduledInstanceAvailabilityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeScheduledInstanceAvailability");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetFilters())
            {
                if (publicRequest.Filters.Count == 0)
                {
                    request.Parameters.Add("Filter", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Filters)
                    {
                        if (item0.IsSetName())
                        {
                            request.Parameters.Add("Filter" + "." + index0 + ".Name", StringUtils.FromString(item0.Name));
                        }
                        if (item0.IsSetValues())
                        {
                            if (item0.Values.Count == 0)
                            {
                                request.Parameters.Add("Filter" + "." + index0 + ".Value", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Values)
                                {
                                    request.Parameters.Add("Filter" + "." + index0 + ".Value" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetFirstSlotStartTimeRange())
            {
                if (publicRequest.FirstSlotStartTimeRange.IsSetEarliestTime())
                {
                    request.Parameters.Add("FirstSlotStartTimeRange" + ".EarliestTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.FirstSlotStartTimeRange.EarliestTime.Value));
                }
                if (publicRequest.FirstSlotStartTimeRange.IsSetLatestTime())
                {
                    request.Parameters.Add("FirstSlotStartTimeRange" + ".LatestTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.FirstSlotStartTimeRange.LatestTime.Value));
                }
            }
            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }
            if (publicRequest.IsSetMaxSlotDurationInHours())
            {
                request.Parameters.Add("MaxSlotDurationInHours", StringUtils.FromInt(publicRequest.MaxSlotDurationInHours.Value));
            }
            if (publicRequest.IsSetMinSlotDurationInHours())
            {
                request.Parameters.Add("MinSlotDurationInHours", StringUtils.FromInt(publicRequest.MinSlotDurationInHours.Value));
            }
            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            if (publicRequest.IsSetRecurrence())
            {
                if (publicRequest.Recurrence.IsSetFrequency())
                {
                    request.Parameters.Add("Recurrence" + ".Frequency", StringUtils.FromString(publicRequest.Recurrence.Frequency));
                }
                if (publicRequest.Recurrence.IsSetInterval())
                {
                    request.Parameters.Add("Recurrence" + ".Interval", StringUtils.FromInt(publicRequest.Recurrence.Interval.Value));
                }
                if (publicRequest.Recurrence.IsSetOccurrenceDays())
                {
                    if (publicRequest.Recurrence.OccurrenceDays.Count == 0)
                    {
                        request.Parameters.Add("Recurrence" + ".OccurrenceDay", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.Recurrence.OccurrenceDays)
                        {
                            request.Parameters.Add("Recurrence" + ".OccurrenceDay" + "." + index1, StringUtils.FromInt(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.Recurrence.IsSetOccurrenceRelativeToEnd())
                {
                    request.Parameters.Add("Recurrence" + ".OccurrenceRelativeToEnd", StringUtils.FromBool(publicRequest.Recurrence.OccurrenceRelativeToEnd.Value));
                }
                if (publicRequest.Recurrence.IsSetOccurrenceUnit())
                {
                    request.Parameters.Add("Recurrence" + ".OccurrenceUnit", StringUtils.FromString(publicRequest.Recurrence.OccurrenceUnit));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeScheduledInstanceAvailabilityRequestMarshaller _instance = new();

        internal static DescribeScheduledInstanceAvailabilityRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeScheduledInstanceAvailabilityRequestMarshaller Instance => _instance;
    }
}
