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
    /// DescribeCapacityBlockOfferings Request Marshaller
    /// </summary>
    public partial class DescribeCapacityBlockOfferingsRequestMarshaller : IMarshaller<IRequest, DescribeCapacityBlockOfferingsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeCapacityBlockOfferingsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeCapacityBlockOfferingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeCapacityBlockOfferings");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAllAvailabilityZones())
            {
                request.Parameters.Add("AllAvailabilityZones", StringUtils.FromBool(publicRequest.AllAvailabilityZones.Value));
            }
            if (publicRequest.IsSetCapacityDurationHours())
            {
                request.Parameters.Add("CapacityDurationHours", StringUtils.FromInt(publicRequest.CapacityDurationHours.Value));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEndDateRange())
            {
                request.Parameters.Add("EndDateRange", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDateRange.Value));
            }
            if (publicRequest.IsSetInstanceCount())
            {
                request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount.Value));
            }
            if (publicRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
            }
            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }
            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            if (publicRequest.IsSetStartDateRange())
            {
                request.Parameters.Add("StartDateRange", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartDateRange.Value));
            }
            if (publicRequest.IsSetUltraserverCount())
            {
                request.Parameters.Add("UltraserverCount", StringUtils.FromInt(publicRequest.UltraserverCount.Value));
            }
            if (publicRequest.IsSetUltraserverType())
            {
                request.Parameters.Add("UltraserverType", StringUtils.FromString(publicRequest.UltraserverType));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeCapacityBlockOfferingsRequestMarshaller _instance = new();

        internal static DescribeCapacityBlockOfferingsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeCapacityBlockOfferingsRequestMarshaller Instance => _instance;
    }
}
