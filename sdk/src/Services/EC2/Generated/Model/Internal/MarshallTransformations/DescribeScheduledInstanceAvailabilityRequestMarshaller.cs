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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeScheduledInstanceAvailability Request Marshaller
    /// </summary>       
    public class DescribeScheduledInstanceAvailabilityRequestMarshaller : IMarshaller<IRequest, DescribeScheduledInstanceAvailabilityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeScheduledInstanceAvailabilityRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeScheduledInstanceAvailabilityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "DescribeScheduledInstanceAvailability");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetFilters())
                {
                    if (publicRequest.Filters.Count == 0)
                        request.Parameters.Add("Filter", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Filters)
                         {
                            if(publicRequestlistValue.IsSetName())
                            {
                                request.Parameters.Add("Filter" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                            }
                            if(publicRequestlistValue.IsSetValues())
                            {
                                if (publicRequestlistValue.Values.Count == 0)
                                    request.Parameters.Add("Filter" + "." + publicRequestlistValueIndex + "." + "Value", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Values)
                                     {
                                         request.Parameters.Add("Filter" + "." + publicRequestlistValueIndex + "." + "Value" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetFirstSlotStartTimeRange())
                {
                    if(publicRequest.FirstSlotStartTimeRange.IsSetEarliestTime())
                    {
                        request.Parameters.Add("FirstSlotStartTimeRange" + "." + "EarliestTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.FirstSlotStartTimeRange.EarliestTime));
                    }
                    if(publicRequest.FirstSlotStartTimeRange.IsSetLatestTime())
                    {
                        request.Parameters.Add("FirstSlotStartTimeRange" + "." + "LatestTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.FirstSlotStartTimeRange.LatestTime));
                    }
                }
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetMaxSlotDurationInHours())
                {
                    request.Parameters.Add("MaxSlotDurationInHours", StringUtils.FromInt(publicRequest.MaxSlotDurationInHours));
                }
                if(publicRequest.IsSetMinSlotDurationInHours())
                {
                    request.Parameters.Add("MinSlotDurationInHours", StringUtils.FromInt(publicRequest.MinSlotDurationInHours));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetRecurrence())
                {
                    if(publicRequest.Recurrence.IsSetFrequency())
                    {
                        request.Parameters.Add("Recurrence" + "." + "Frequency", StringUtils.FromString(publicRequest.Recurrence.Frequency));
                    }
                    if(publicRequest.Recurrence.IsSetInterval())
                    {
                        request.Parameters.Add("Recurrence" + "." + "Interval", StringUtils.FromInt(publicRequest.Recurrence.Interval));
                    }
                    if(publicRequest.Recurrence.IsSetOccurrenceDays())
                    {
                        if (publicRequest.Recurrence.OccurrenceDays.Count == 0)
                            request.Parameters.Add("Recurrence" + "." + "OccurrenceDay", "");
                        else
                        {
                             int publicRequestRecurrencelistValueIndex = 1;
                             foreach(var publicRequestRecurrencelistValue in publicRequest.Recurrence.OccurrenceDays)
                             {
                                 request.Parameters.Add("Recurrence" + "." + "OccurrenceDay" + "." + publicRequestRecurrencelistValueIndex, StringUtils.FromInt(publicRequestRecurrencelistValue));
                                 publicRequestRecurrencelistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.Recurrence.IsSetOccurrenceRelativeToEnd())
                    {
                        request.Parameters.Add("Recurrence" + "." + "OccurrenceRelativeToEnd", StringUtils.FromBool(publicRequest.Recurrence.OccurrenceRelativeToEnd));
                    }
                    if(publicRequest.Recurrence.IsSetOccurrenceUnit())
                    {
                        request.Parameters.Add("Recurrence" + "." + "OccurrenceUnit", StringUtils.FromString(publicRequest.Recurrence.OccurrenceUnit));
                    }
                }
            }
            return request;
        }
                    private static DescribeScheduledInstanceAvailabilityRequestMarshaller _instance = new DescribeScheduledInstanceAvailabilityRequestMarshaller();        

        internal static DescribeScheduledInstanceAvailabilityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeScheduledInstanceAvailabilityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}