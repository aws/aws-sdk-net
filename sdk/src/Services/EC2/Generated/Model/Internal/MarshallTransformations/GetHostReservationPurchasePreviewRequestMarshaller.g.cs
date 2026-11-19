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
    /// GetHostReservationPurchasePreview Request Marshaller
    /// </summary>
    public partial class GetHostReservationPurchasePreviewRequestMarshaller : IMarshaller<IRequest, GetHostReservationPurchasePreviewRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetHostReservationPurchasePreviewRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetHostReservationPurchasePreviewRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "GetHostReservationPurchasePreview");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetHostIdSet())
            {
                if (publicRequest.HostIdSet.Count == 0)
                {
                    request.Parameters.Add("HostIdSet", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.HostIdSet)
                    {
                        request.Parameters.Add("HostIdSet" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetOfferingId())
            {
                request.Parameters.Add("OfferingId", StringUtils.FromString(publicRequest.OfferingId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly GetHostReservationPurchasePreviewRequestMarshaller _instance = new();

        internal static GetHostReservationPurchasePreviewRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetHostReservationPurchasePreviewRequestMarshaller Instance => _instance;
    }
}
