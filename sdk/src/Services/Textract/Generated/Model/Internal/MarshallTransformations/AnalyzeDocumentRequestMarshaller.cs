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
    /// AnalyzeDocument Request Marshaller
    /// </summary>       
    public class AnalyzeDocumentRequestMarshaller : IMarshaller<IRequest, AnalyzeDocumentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AnalyzeDocumentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AnalyzeDocumentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Textract");
            string target = "Textract.AnalyzeDocument";
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
                if(publicRequest.IsSetDocument())
                {
                    context.Writer.WritePropertyName("Document");
                    context.Writer.WriteObjectStart();

                    var marshaller = DocumentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Document, context);

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

                if(publicRequest.IsSetHumanLoopConfig())
                {
                    context.Writer.WritePropertyName("HumanLoopConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = HumanLoopConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HumanLoopConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AnalyzeDocumentRequestMarshaller _instance = new AnalyzeDocumentRequestMarshaller();        

        internal static AnalyzeDocumentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnalyzeDocumentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}