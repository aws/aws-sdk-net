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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCustomActionType Request Marshaller
    /// </summary>       
    public class CreateCustomActionTypeRequestMarshaller : IMarshaller<IRequest, CreateCustomActionTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCustomActionTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCustomActionTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodePipeline");
            string target = "CodePipeline_20150709.CreateCustomActionType";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCategory())
                {
                    context.Writer.WritePropertyName("category");
                    context.Writer.Write(publicRequest.Category);
                }

                if(publicRequest.IsSetConfigurationProperties())
                {
                    context.Writer.WritePropertyName("configurationProperties");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestConfigurationPropertiesListValue in publicRequest.ConfigurationProperties)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ActionConfigurationPropertyMarshaller.Instance;
                        marshaller.Marshall(publicRequestConfigurationPropertiesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInputArtifactDetails())
                {
                    context.Writer.WritePropertyName("inputArtifactDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = ArtifactDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputArtifactDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputArtifactDetails())
                {
                    context.Writer.WritePropertyName("outputArtifactDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = ArtifactDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputArtifactDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProvider())
                {
                    context.Writer.WritePropertyName("provider");
                    context.Writer.Write(publicRequest.Provider);
                }

                if(publicRequest.IsSetSettings())
                {
                    context.Writer.WritePropertyName("settings");
                    context.Writer.WriteObjectStart();

                    var marshaller = ActionTypeSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Settings, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetVersion())
                {
                    context.Writer.WritePropertyName("version");
                    context.Writer.Write(publicRequest.Version);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCustomActionTypeRequestMarshaller _instance = new CreateCustomActionTypeRequestMarshaller();        

        internal static CreateCustomActionTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCustomActionTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}