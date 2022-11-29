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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartResourceEvaluation Request Marshaller
    /// </summary>       
    public class StartResourceEvaluationRequestMarshaller : IMarshaller<IRequest, StartResourceEvaluationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartResourceEvaluationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartResourceEvaluationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConfigService");
            string target = "StarlingDoveService.StartResourceEvaluation";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetEvaluationContext())
                {
                    context.Writer.WritePropertyName("EvaluationContext");
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationContextMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EvaluationContext, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEvaluationMode())
                {
                    context.Writer.WritePropertyName("EvaluationMode");
                    context.Writer.Write(publicRequest.EvaluationMode);
                }

                if(publicRequest.IsSetEvaluationTimeout())
                {
                    context.Writer.WritePropertyName("EvaluationTimeout");
                    context.Writer.Write(publicRequest.EvaluationTimeout);
                }

                if(publicRequest.IsSetResourceDetails())
                {
                    context.Writer.WritePropertyName("ResourceDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ResourceDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartResourceEvaluationRequestMarshaller _instance = new StartResourceEvaluationRequestMarshaller();        

        internal static StartResourceEvaluationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartResourceEvaluationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}