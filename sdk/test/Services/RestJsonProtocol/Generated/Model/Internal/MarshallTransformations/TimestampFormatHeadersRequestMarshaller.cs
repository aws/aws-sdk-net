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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
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
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TimestampFormatHeaders Request Marshaller
    /// </summary>       
    public class TimestampFormatHeadersRequestMarshaller : IMarshaller<IRequest, TimestampFormatHeadersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TimestampFormatHeadersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TimestampFormatHeadersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "POST";

            request.ResourcePath = "/TimestampFormatHeaders";
        
            if (publicRequest.IsSetDefaultFormat()) 
            {
                request.Headers["X-defaultFormat"] = StringUtils.FromDateTimeToRFC822(publicRequest.DefaultFormat);
            }
        
            if (publicRequest.IsSetMemberDateTime()) 
            {
                request.Headers["X-memberDateTime"] = StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.MemberDateTime);
            }
        
            if (publicRequest.IsSetMemberEpochSeconds()) 
            {
                request.Headers["X-memberEpochSeconds"] = StringUtils.FromDateTimeToUnixTimestamp(publicRequest.MemberEpochSeconds);
            }
        
            if (publicRequest.IsSetMemberHttpDate()) 
            {
                request.Headers["X-memberHttpDate"] = StringUtils.FromDateTimeToRFC822(publicRequest.MemberHttpDate);
            }
        
            if (publicRequest.IsSetTargetDateTime()) 
            {
                request.Headers["X-targetDateTime"] = StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.TargetDateTime);
            }
        
            if (publicRequest.IsSetTargetEpochSeconds()) 
            {
                request.Headers["X-targetEpochSeconds"] = StringUtils.FromDateTimeToUnixTimestamp(publicRequest.TargetEpochSeconds);
            }
        
            if (publicRequest.IsSetTargetHttpDate()) 
            {
                request.Headers["X-targetHttpDate"] = StringUtils.FromDateTimeToRFC822(publicRequest.TargetHttpDate);
            }

            return request;
        }
        private static TimestampFormatHeadersRequestMarshaller _instance = new TimestampFormatHeadersRequestMarshaller();        

        internal static TimestampFormatHeadersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TimestampFormatHeadersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}