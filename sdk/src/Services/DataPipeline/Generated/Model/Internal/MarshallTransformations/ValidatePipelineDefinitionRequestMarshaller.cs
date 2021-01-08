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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataPipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ValidatePipelineDefinition Request Marshaller
    /// </summary>       
    public class ValidatePipelineDefinitionRequestMarshaller : IMarshaller<IRequest, ValidatePipelineDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ValidatePipelineDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ValidatePipelineDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataPipeline");
            string target = "DataPipeline.ValidatePipelineDefinition";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-10-29";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetParameterObjects())
                {
                    context.Writer.WritePropertyName("parameterObjects");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestParameterObjectsListValue in publicRequest.ParameterObjects)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ParameterObjectMarshaller.Instance;
                        marshaller.Marshall(publicRequestParameterObjectsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetParameterValues())
                {
                    context.Writer.WritePropertyName("parameterValues");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestParameterValuesListValue in publicRequest.ParameterValues)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ParameterValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestParameterValuesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPipelineId())
                {
                    context.Writer.WritePropertyName("pipelineId");
                    context.Writer.Write(publicRequest.PipelineId);
                }

                if(publicRequest.IsSetPipelineObjects())
                {
                    context.Writer.WritePropertyName("pipelineObjects");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPipelineObjectsListValue in publicRequest.PipelineObjects)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PipelineObjectMarshaller.Instance;
                        marshaller.Marshall(publicRequestPipelineObjectsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ValidatePipelineDefinitionRequestMarshaller _instance = new ValidatePipelineDefinitionRequestMarshaller();        

        internal static ValidatePipelineDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ValidatePipelineDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}