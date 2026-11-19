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
    /// PurchaseReservedInstancesOffering Request Marshaller
    /// </summary>
    public partial class PurchaseReservedInstancesOfferingRequestMarshaller : IMarshaller<IRequest, PurchaseReservedInstancesOfferingRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PurchaseReservedInstancesOfferingRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PurchaseReservedInstancesOfferingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "PurchaseReservedInstancesOffering");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetInstanceCount())
            {
                request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount.Value));
            }
            if (publicRequest.IsSetLimitPrice())
            {
                if (publicRequest.LimitPrice.IsSetAmount())
                {
                    request.Parameters.Add("LimitPrice" + ".Amount", StringUtils.FromDouble(publicRequest.LimitPrice.Amount.Value));
                }
                if (publicRequest.LimitPrice.IsSetCurrencyCode())
                {
                    request.Parameters.Add("LimitPrice" + ".CurrencyCode", StringUtils.FromString(publicRequest.LimitPrice.CurrencyCode));
                }
            }
            if (publicRequest.IsSetPurchaseTime())
            {
                request.Parameters.Add("PurchaseTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.PurchaseTime.Value));
            }
            if (publicRequest.IsSetReservedInstancesOfferingId())
            {
                request.Parameters.Add("ReservedInstancesOfferingId", StringUtils.FromString(publicRequest.ReservedInstancesOfferingId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly PurchaseReservedInstancesOfferingRequestMarshaller _instance = new();

        internal static PurchaseReservedInstancesOfferingRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PurchaseReservedInstancesOfferingRequestMarshaller Instance => _instance;
    }
}
