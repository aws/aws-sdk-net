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
    /// CreateReservedInstancesListing Request Marshaller
    /// </summary>
    public partial class CreateReservedInstancesListingRequestMarshaller : IMarshaller<IRequest, CreateReservedInstancesListingRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReservedInstancesListingRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateReservedInstancesListingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateReservedInstancesListing");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            if (publicRequest.IsSetInstanceCount())
            {
                request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount.Value));
            }
            if (publicRequest.IsSetPriceSchedules())
            {
                if (publicRequest.PriceSchedules.Count == 0)
                {
                    request.Parameters.Add("PriceSchedules", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PriceSchedules)
                    {
                        if (item0.IsSetCurrencyCode())
                        {
                            request.Parameters.Add("PriceSchedules" + "." + index0 + ".CurrencyCode", StringUtils.FromString(item0.CurrencyCode));
                        }
                        if (item0.IsSetPrice())
                        {
                            request.Parameters.Add("PriceSchedules" + "." + index0 + ".Price", StringUtils.FromDouble(item0.Price.Value));
                        }
                        if (item0.IsSetTerm())
                        {
                            request.Parameters.Add("PriceSchedules" + "." + index0 + ".Term", StringUtils.FromLong(item0.Term.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetReservedInstancesId())
            {
                request.Parameters.Add("ReservedInstancesId", StringUtils.FromString(publicRequest.ReservedInstancesId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateReservedInstancesListingRequestMarshaller _instance = new();

        internal static CreateReservedInstancesListingRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateReservedInstancesListingRequestMarshaller Instance => _instance;
    }
}
