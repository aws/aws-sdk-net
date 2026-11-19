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
    /// DescribeAvailabilityZones Request Marshaller
    /// </summary>
    public partial class DescribeAvailabilityZonesRequestMarshaller : IMarshaller<IRequest, DescribeAvailabilityZonesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAvailabilityZonesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeAvailabilityZonesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeAvailabilityZones");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAllAvailabilityZones())
            {
                request.Parameters.Add("AllAvailabilityZones", StringUtils.FromBool(publicRequest.AllAvailabilityZones.Value));
            }
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
            if (publicRequest.IsSetZoneIds())
            {
                if (publicRequest.ZoneIds.Count == 0)
                {
                    request.Parameters.Add("ZoneId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ZoneIds)
                    {
                        request.Parameters.Add("ZoneId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetZoneNames())
            {
                if (publicRequest.ZoneNames.Count == 0)
                {
                    request.Parameters.Add("ZoneName", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ZoneNames)
                    {
                        request.Parameters.Add("ZoneName" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeAvailabilityZonesRequestMarshaller _instance = new();

        internal static DescribeAvailabilityZonesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeAvailabilityZonesRequestMarshaller Instance => _instance;
    }
}
