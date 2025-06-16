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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpRequestWithLabelsAndTimestampFormat Request Marshaller
    /// </summary>       
    public partial class HttpRequestWithLabelsAndTimestampFormatRequestMarshaller : IMarshaller<IRequest, HttpRequestWithLabelsAndTimestampFormatRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((HttpRequestWithLabelsAndTimestampFormatRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(HttpRequestWithLabelsAndTimestampFormatRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "GET";
            if (!publicRequest.IsSetDefaultFormat())
                throw new AmazonRestXmlProtocolException("Request object does not have required field DefaultFormat set");
            request.AddPathResource("{defaultFormat}", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.DefaultFormat));
            if (!publicRequest.IsSetMemberDateTime())
                throw new AmazonRestXmlProtocolException("Request object does not have required field MemberDateTime set");
            request.AddPathResource("{memberDateTime}", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.MemberDateTime));
            if (!publicRequest.IsSetMemberEpochSeconds())
                throw new AmazonRestXmlProtocolException("Request object does not have required field MemberEpochSeconds set");
            request.AddPathResource("{memberEpochSeconds}", StringUtils.FromDateTimeToUnixTimestamp(publicRequest.MemberEpochSeconds));
            if (!publicRequest.IsSetMemberHttpDate())
                throw new AmazonRestXmlProtocolException("Request object does not have required field MemberHttpDate set");
            request.AddPathResource("{memberHttpDate}", StringUtils.FromDateTimeToRFC822(publicRequest.MemberHttpDate));
            if (!publicRequest.IsSetTargetDateTime())
                throw new AmazonRestXmlProtocolException("Request object does not have required field TargetDateTime set");
            request.AddPathResource("{targetDateTime}", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.TargetDateTime));
            if (!publicRequest.IsSetTargetEpochSeconds())
                throw new AmazonRestXmlProtocolException("Request object does not have required field TargetEpochSeconds set");
            request.AddPathResource("{targetEpochSeconds}", StringUtils.FromDateTimeToUnixTimestamp(publicRequest.TargetEpochSeconds));
            if (!publicRequest.IsSetTargetHttpDate())
                throw new AmazonRestXmlProtocolException("Request object does not have required field TargetHttpDate set");
            request.AddPathResource("{targetHttpDate}", StringUtils.FromDateTimeToRFC822(publicRequest.TargetHttpDate));
            request.ResourcePath = "/HttpRequestWithLabelsAndTimestampFormat/{memberEpochSeconds}/{memberHttpDate}/{memberDateTime}/{defaultFormat}/{targetEpochSeconds}/{targetHttpDate}/{targetDateTime}";


            PostMarshallCustomization(request, publicRequest);
            return request;
        }
        private static HttpRequestWithLabelsAndTimestampFormatRequestMarshaller _instance = new HttpRequestWithLabelsAndTimestampFormatRequestMarshaller();        

        internal static HttpRequestWithLabelsAndTimestampFormatRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HttpRequestWithLabelsAndTimestampFormatRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, HttpRequestWithLabelsAndTimestampFormatRequest publicRequest);
    }    
}