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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NotifyUpdateProvisionedProductEngineWorkflowResult Request Marshaller
    /// </summary>       
    public class NotifyUpdateProvisionedProductEngineWorkflowResultRequestMarshaller : IMarshaller<IRequest, NotifyUpdateProvisionedProductEngineWorkflowResultRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((NotifyUpdateProvisionedProductEngineWorkflowResultRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(NotifyUpdateProvisionedProductEngineWorkflowResultRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceCatalog");
            string target = "AWS242ServiceCatalogService.NotifyUpdateProvisionedProductEngineWorkflowResult";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-12-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFailureReason())
                {
                    context.Writer.WritePropertyName("FailureReason");
                    context.Writer.Write(publicRequest.FailureReason);
                }

                if(publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(publicRequest.IdempotencyToken);
                }

                else if(!(publicRequest.IsSetIdempotencyToken()))
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetOutputs())
                {
                    context.Writer.WritePropertyName("Outputs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOutputsListValue in publicRequest.Outputs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RecordOutputMarshaller.Instance;
                        marshaller.Marshall(publicRequestOutputsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRecordId())
                {
                    context.Writer.WritePropertyName("RecordId");
                    context.Writer.Write(publicRequest.RecordId);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetWorkflowToken())
                {
                    context.Writer.WritePropertyName("WorkflowToken");
                    context.Writer.Write(publicRequest.WorkflowToken);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static NotifyUpdateProvisionedProductEngineWorkflowResultRequestMarshaller _instance = new NotifyUpdateProvisionedProductEngineWorkflowResultRequestMarshaller();        

        internal static NotifyUpdateProvisionedProductEngineWorkflowResultRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NotifyUpdateProvisionedProductEngineWorkflowResultRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}