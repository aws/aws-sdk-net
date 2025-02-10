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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEffectiveHoursOfOperations Request Marshaller
    /// </summary>       
    public class GetEffectiveHoursOfOperationsRequestMarshaller : IMarshaller<IRequest, GetEffectiveHoursOfOperationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEffectiveHoursOfOperationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetEffectiveHoursOfOperationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetHoursOfOperationId())
                throw new AmazonConnectException("Request object does not have required field HoursOfOperationId set");
            request.AddPathResource("{HoursOfOperationId}", StringUtils.FromString(publicRequest.HoursOfOperationId));
            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            
            if (publicRequest.IsSetFromDate())
                request.Parameters.Add("fromDate", StringUtils.FromString(publicRequest.FromDate));
            
            if (publicRequest.IsSetToDate())
                request.Parameters.Add("toDate", StringUtils.FromString(publicRequest.ToDate));
            request.ResourcePath = "/effective-hours-of-operations/{InstanceId}/{HoursOfOperationId}";
            request.UseQueryString = true;

            return request;
        }
        private static GetEffectiveHoursOfOperationsRequestMarshaller _instance = new GetEffectiveHoursOfOperationsRequestMarshaller();        

        internal static GetEffectiveHoursOfOperationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetEffectiveHoursOfOperationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}