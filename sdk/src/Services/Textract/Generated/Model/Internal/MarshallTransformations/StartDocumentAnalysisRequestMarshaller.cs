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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Textract.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Textract.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartDocumentAnalysis Request Marshaller
    /// </summary>       
    public class StartDocumentAnalysisRequestMarshaller : IMarshaller<IRequest, StartDocumentAnalysisRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDocumentAnalysisRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartDocumentAnalysisRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Textract");
            string target = "Textract.StartDocumentAnalysis";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-27";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                if(publicRequest.IsSetDocumentLocation())
                {
                    context.Writer.WritePropertyName("DocumentLocation");
                    context.Writer.WriteObjectStart();

                    var marshaller = DocumentLocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DocumentLocation, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFeatureTypes())
                {
                    context.Writer.WritePropertyName("FeatureTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFeatureTypesListValue in publicRequest.FeatureTypes)
                    {
                            context.Writer.Write(publicRequestFeatureTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetJobTag())
                {
                    context.Writer.WritePropertyName("JobTag");
                    context.Writer.Write(publicRequest.JobTag);
                }

                if(publicRequest.IsSetKMSKeyId())
                {
                    context.Writer.WritePropertyName("KMSKeyId");
                    context.Writer.Write(publicRequest.KMSKeyId);
                }

                if(publicRequest.IsSetNotificationChannel())
                {
                    context.Writer.WritePropertyName("NotificationChannel");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationChannelMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NotificationChannel, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputConfig())
                {
                    context.Writer.WritePropertyName("OutputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartDocumentAnalysisRequestMarshaller _instance = new StartDocumentAnalysisRequestMarshaller();        

        internal static StartDocumentAnalysisRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartDocumentAnalysisRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}