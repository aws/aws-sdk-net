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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Comprehend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DetectEntities Request Marshaller
    /// </summary>       
    public class DetectEntitiesRequestMarshaller : IMarshaller<IRequest, DetectEntitiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DetectEntitiesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DetectEntitiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Comprehend");
            string target = "Comprehend_20171127.DetectEntities";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBytes())
                {
                    context.Writer.WritePropertyName("Bytes");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.Bytes));
                }

                if(publicRequest.IsSetDocumentReaderConfig())
                {
                    context.Writer.WritePropertyName("DocumentReaderConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DocumentReaderConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DocumentReaderConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEndpointArn())
                {
                    context.Writer.WritePropertyName("EndpointArn");
                    context.Writer.Write(publicRequest.EndpointArn);
                }

                if(publicRequest.IsSetLanguageCode())
                {
                    context.Writer.WritePropertyName("LanguageCode");
                    context.Writer.Write(publicRequest.LanguageCode);
                }

                if(publicRequest.IsSetText())
                {
                    context.Writer.WritePropertyName("Text");
                    context.Writer.Write(publicRequest.Text);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DetectEntitiesRequestMarshaller _instance = new DetectEntitiesRequestMarshaller();        

        internal static DetectEntitiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DetectEntitiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}