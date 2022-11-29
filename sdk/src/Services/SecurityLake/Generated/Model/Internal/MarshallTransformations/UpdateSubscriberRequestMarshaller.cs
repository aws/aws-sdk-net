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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSubscriber Request Marshaller
    /// </summary>       
    public class UpdateSubscriberRequestMarshaller : IMarshaller<IRequest, UpdateSubscriberRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSubscriberRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSubscriberRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityLake");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetId())
                throw new AmazonSecurityLakeException("Request object does not have required field Id set");
            request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/v1/subscribers/{id}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetExternalId())
                {
                    context.Writer.WritePropertyName("externalId");
                    context.Writer.Write(publicRequest.ExternalId);
                }

                if(publicRequest.IsSetSourceTypes())
                {
                    context.Writer.WritePropertyName("sourceTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourceTypesListValue in publicRequest.SourceTypes)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SourceTypeMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourceTypesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSubscriberDescription())
                {
                    context.Writer.WritePropertyName("subscriberDescription");
                    context.Writer.Write(publicRequest.SubscriberDescription);
                }

                if(publicRequest.IsSetSubscriberName())
                {
                    context.Writer.WritePropertyName("subscriberName");
                    context.Writer.Write(publicRequest.SubscriberName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSubscriberRequestMarshaller _instance = new UpdateSubscriberRequestMarshaller();        

        internal static UpdateSubscriberRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSubscriberRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}