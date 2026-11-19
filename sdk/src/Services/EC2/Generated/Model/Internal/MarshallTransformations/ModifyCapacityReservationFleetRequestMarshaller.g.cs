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
    /// ModifyCapacityReservationFleet Request Marshaller
    /// </summary>
    public partial class ModifyCapacityReservationFleetRequestMarshaller : IMarshaller<IRequest, ModifyCapacityReservationFleetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyCapacityReservationFleetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyCapacityReservationFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyCapacityReservationFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetCapacityReservationFleetId())
            {
                request.Parameters.Add("CapacityReservationFleetId", StringUtils.FromString(publicRequest.CapacityReservationFleetId));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEndDate())
            {
                request.Parameters.Add("EndDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDate.Value));
            }
            if (publicRequest.IsSetRemoveEndDate())
            {
                request.Parameters.Add("RemoveEndDate", StringUtils.FromBool(publicRequest.RemoveEndDate.Value));
            }
            if (publicRequest.IsSetTotalTargetCapacity())
            {
                request.Parameters.Add("TotalTargetCapacity", StringUtils.FromInt(publicRequest.TotalTargetCapacity.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyCapacityReservationFleetRequestMarshaller _instance = new();

        internal static ModifyCapacityReservationFleetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyCapacityReservationFleetRequestMarshaller Instance => _instance;
    }
}
