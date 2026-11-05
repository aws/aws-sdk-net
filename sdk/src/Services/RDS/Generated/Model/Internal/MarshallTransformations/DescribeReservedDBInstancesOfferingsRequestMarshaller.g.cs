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
    /// DescribeReservedDBInstancesOfferings Request Marshaller
    /// </summary>
    public partial class DescribeReservedDBInstancesOfferingsRequestMarshaller : IMarshaller<IRequest, DescribeReservedDBInstancesOfferingsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeReservedDBInstancesOfferingsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeReservedDBInstancesOfferingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeReservedDBInstancesOfferings");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetDBInstanceClass())
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(publicRequest.DBInstanceClass));
            }
            if (publicRequest.IsSetDuration())
            {
                request.Parameters.Add("Duration", StringUtils.FromString(publicRequest.Duration));
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
            if (publicRequest.IsSetMultiAZ())
            {
                request.Parameters.Add("MultiAZ", StringUtils.FromBool(publicRequest.MultiAZ.Value));
            }
            if (publicRequest.IsSetOfferingType())
            {
                request.Parameters.Add("OfferingType", StringUtils.FromString(publicRequest.OfferingType));
            }
            if (publicRequest.IsSetProductDescription())
            {
                request.Parameters.Add("ProductDescription", StringUtils.FromString(publicRequest.ProductDescription));
            }
            if (publicRequest.IsSetReservedDBInstancesOfferingId())
            {
                request.Parameters.Add("ReservedDBInstancesOfferingId", StringUtils.FromString(publicRequest.ReservedDBInstancesOfferingId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeReservedDBInstancesOfferingsRequestMarshaller _instance = new();

        internal static DescribeReservedDBInstancesOfferingsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeReservedDBInstancesOfferingsRequestMarshaller Instance => _instance;
    }
}
