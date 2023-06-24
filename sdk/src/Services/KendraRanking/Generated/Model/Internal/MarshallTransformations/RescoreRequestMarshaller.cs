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
 * Do not modify this file. This file is generated from the kendra-ranking-2022-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KendraRanking.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KendraRanking.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Rescore Request Marshaller
    /// </summary>       
    public class RescoreRequestMarshaller : IMarshaller<IRequest, RescoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RescoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RescoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KendraRanking");
            string target = "AWSKendraRerankingFrontendService.Rescore";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-10-19";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDocuments())
                {
                    context.Writer.WritePropertyName("Documents");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDocumentsListValue in publicRequest.Documents)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DocumentMarshaller.Instance;
                        marshaller.Marshall(publicRequestDocumentsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRescoreExecutionPlanId())
                {
                    context.Writer.WritePropertyName("RescoreExecutionPlanId");
                    context.Writer.Write(publicRequest.RescoreExecutionPlanId);
                }

                if(publicRequest.IsSetSearchQuery())
                {
                    context.Writer.WritePropertyName("SearchQuery");
                    context.Writer.Write(publicRequest.SearchQuery);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RescoreRequestMarshaller _instance = new RescoreRequestMarshaller();        

        internal static RescoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RescoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}