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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMLTransform Request Marshaller
    /// </summary>       
    public class CreateMLTransformRequestMarshaller : IMarshaller<IRequest, CreateMLTransformRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMLTransformRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMLTransformRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.CreateMLTransform";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetGlueVersion())
                {
                    context.Writer.WritePropertyName("GlueVersion");
                    context.Writer.Write(publicRequest.GlueVersion);
                }

                if(publicRequest.IsSetInputRecordTables())
                {
                    context.Writer.WritePropertyName("InputRecordTables");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInputRecordTablesListValue in publicRequest.InputRecordTables)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = GlueTableMarshaller.Instance;
                        marshaller.Marshall(publicRequestInputRecordTablesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxCapacity())
                {
                    context.Writer.WritePropertyName("MaxCapacity");
                    context.Writer.Write(publicRequest.MaxCapacity);
                }

                if(publicRequest.IsSetMaxRetries())
                {
                    context.Writer.WritePropertyName("MaxRetries");
                    context.Writer.Write(publicRequest.MaxRetries);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNumberOfWorkers())
                {
                    context.Writer.WritePropertyName("NumberOfWorkers");
                    context.Writer.Write(publicRequest.NumberOfWorkers);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("Parameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = TransformParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Parameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("Role");
                    context.Writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimeout())
                {
                    context.Writer.WritePropertyName("Timeout");
                    context.Writer.Write(publicRequest.Timeout);
                }

                if(publicRequest.IsSetTransformEncryption())
                {
                    context.Writer.WritePropertyName("TransformEncryption");
                    context.Writer.WriteObjectStart();

                    var marshaller = TransformEncryptionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TransformEncryption, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWorkerType())
                {
                    context.Writer.WritePropertyName("WorkerType");
                    context.Writer.Write(publicRequest.WorkerType);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateMLTransformRequestMarshaller _instance = new CreateMLTransformRequestMarshaller();        

        internal static CreateMLTransformRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMLTransformRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}