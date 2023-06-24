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
    /// StartLendingAnalysis Request Marshaller
    /// </summary>       
    public class StartLendingAnalysisRequestMarshaller : IMarshaller<IRequest, StartLendingAnalysisRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartLendingAnalysisRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartLendingAnalysisRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Textract");
            string target = "Textract.StartLendingAnalysis";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
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
        private static StartLendingAnalysisRequestMarshaller _instance = new StartLendingAnalysisRequestMarshaller();        

        internal static StartLendingAnalysisRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartLendingAnalysisRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}