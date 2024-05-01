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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JsonTimestamps Request Marshaller
    /// </summary>       
    public class JsonTimestampsRequestMarshaller : IMarshaller<IRequest, JsonTimestampsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((JsonTimestampsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(JsonTimestampsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "POST";

            request.ResourcePath = "/JsonTimestamps";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDateTime())
                {
                    context.Writer.WritePropertyName("dateTime");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.DateTime));
                }

                if(publicRequest.IsSetDateTimeOnTarget())
                {
                    context.Writer.WritePropertyName("dateTimeOnTarget");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.DateTimeOnTarget));
                }

                if(publicRequest.IsSetEpochSeconds())
                {
                    context.Writer.WritePropertyName("epochSeconds");
                    context.Writer.Write(publicRequest.EpochSeconds);
                }

                if(publicRequest.IsSetEpochSecondsOnTarget())
                {
                    context.Writer.WritePropertyName("epochSecondsOnTarget");
                    context.Writer.Write(publicRequest.EpochSecondsOnTarget);
                }

                if(publicRequest.IsSetHttpDate())
                {
                    context.Writer.WritePropertyName("httpDate");
                    context.Writer.Write(StringUtils.FromDateTimeToRFC822(publicRequest.HttpDate));
                }

                if(publicRequest.IsSetHttpDateOnTarget())
                {
                    context.Writer.WritePropertyName("httpDateOnTarget");
                    context.Writer.Write(StringUtils.FromDateTimeToRFC822(publicRequest.HttpDateOnTarget));
                }

                if(publicRequest.IsSetNormal())
                {
                    context.Writer.WritePropertyName("normal");
                    context.Writer.Write(publicRequest.Normal);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static JsonTimestampsRequestMarshaller _instance = new JsonTimestampsRequestMarshaller();        

        internal static JsonTimestampsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JsonTimestampsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}