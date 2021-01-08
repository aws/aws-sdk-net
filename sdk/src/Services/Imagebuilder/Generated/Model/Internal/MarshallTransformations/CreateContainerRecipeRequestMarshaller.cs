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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateContainerRecipe Request Marshaller
    /// </summary>       
    public class CreateContainerRecipeRequestMarshaller : IMarshaller<IRequest, CreateContainerRecipeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateContainerRecipeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateContainerRecipeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Imagebuilder");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";            
            request.HttpMethod = "PUT";

            request.ResourcePath = "/CreateContainerRecipe";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetComponents())
                {
                    context.Writer.WritePropertyName("components");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestComponentsListValue in publicRequest.Components)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ComponentConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestComponentsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetContainerType())
                {
                    context.Writer.WritePropertyName("containerType");
                    context.Writer.Write(publicRequest.ContainerType);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDockerfileTemplateData())
                {
                    context.Writer.WritePropertyName("dockerfileTemplateData");
                    context.Writer.Write(publicRequest.DockerfileTemplateData);
                }

                if(publicRequest.IsSetDockerfileTemplateUri())
                {
                    context.Writer.WritePropertyName("dockerfileTemplateUri");
                    context.Writer.Write(publicRequest.DockerfileTemplateUri);
                }

                if(publicRequest.IsSetImageOsVersionOverride())
                {
                    context.Writer.WritePropertyName("imageOsVersionOverride");
                    context.Writer.Write(publicRequest.ImageOsVersionOverride);
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("kmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetParentImage())
                {
                    context.Writer.WritePropertyName("parentImage");
                    context.Writer.Write(publicRequest.ParentImage);
                }

                if(publicRequest.IsSetPlatformOverride())
                {
                    context.Writer.WritePropertyName("platformOverride");
                    context.Writer.Write(publicRequest.PlatformOverride);
                }

                if(publicRequest.IsSetSemanticVersion())
                {
                    context.Writer.WritePropertyName("semanticVersion");
                    context.Writer.Write(publicRequest.SemanticVersion);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTargetRepository())
                {
                    context.Writer.WritePropertyName("targetRepository");
                    context.Writer.WriteObjectStart();

                    var marshaller = TargetContainerRepositoryMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TargetRepository, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWorkingDirectory())
                {
                    context.Writer.WritePropertyName("workingDirectory");
                    context.Writer.Write(publicRequest.WorkingDirectory);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateContainerRecipeRequestMarshaller _instance = new CreateContainerRecipeRequestMarshaller();        

        internal static CreateContainerRecipeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateContainerRecipeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}