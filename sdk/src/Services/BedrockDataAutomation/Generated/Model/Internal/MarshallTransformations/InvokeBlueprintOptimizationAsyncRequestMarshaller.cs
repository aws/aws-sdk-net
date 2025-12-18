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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeBlueprintOptimizationAsync Request Marshaller
    /// </summary>       
    public class InvokeBlueprintOptimizationAsyncRequestMarshaller : IMarshaller<IRequest, InvokeBlueprintOptimizationAsyncRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeBlueprintOptimizationAsyncRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeBlueprintOptimizationAsyncRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockDataAutomation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/invokeBlueprintOptimizationAsync";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBlueprint())
                {
                    context.Writer.WritePropertyName("blueprint");
                    context.Writer.WriteObjectStart();

                    var marshaller = BlueprintOptimizationObjectMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Blueprint, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataAutomationProfileArn())
                {
                    context.Writer.WritePropertyName("dataAutomationProfileArn");
                    context.Writer.Write(publicRequest.DataAutomationProfileArn);
                }

                if(publicRequest.IsSetEncryptionConfiguration())
                {
                    context.Writer.WritePropertyName("encryptionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputConfiguration())
                {
                    context.Writer.WritePropertyName("outputConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = BlueprintOptimizationOutputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSamples())
                {
                    context.Writer.WritePropertyName("samples");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSamplesListValue in publicRequest.Samples)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BlueprintOptimizationSampleMarshaller.Instance;
                        marshaller.Marshall(publicRequestSamplesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static InvokeBlueprintOptimizationAsyncRequestMarshaller _instance = new InvokeBlueprintOptimizationAsyncRequestMarshaller();        

        internal static InvokeBlueprintOptimizationAsyncRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeBlueprintOptimizationAsyncRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}