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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateResourceProfileDetections Request Marshaller
    /// </summary>       
    public class UpdateResourceProfileDetectionsRequestMarshaller : IMarshaller<IRequest, UpdateResourceProfileDetectionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateResourceProfileDetectionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateResourceProfileDetectionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Macie2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-01-01";
            request.HttpMethod = "PATCH";

            
            if (publicRequest.IsSetResourceArn())
                request.Parameters.Add("resourceArn", StringUtils.FromString(publicRequest.ResourceArn));
            request.ResourcePath = "/resource-profiles/detections";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetSuppressDataIdentifiers())
                {
                    context.Writer.WritePropertyName("suppressDataIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSuppressDataIdentifiersListValue in publicRequest.SuppressDataIdentifiers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SuppressDataIdentifierMarshaller.Instance;
                        marshaller.Marshall(publicRequestSuppressDataIdentifiersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static UpdateResourceProfileDetectionsRequestMarshaller _instance = new UpdateResourceProfileDetectionsRequestMarshaller();        

        internal static UpdateResourceProfileDetectionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateResourceProfileDetectionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}