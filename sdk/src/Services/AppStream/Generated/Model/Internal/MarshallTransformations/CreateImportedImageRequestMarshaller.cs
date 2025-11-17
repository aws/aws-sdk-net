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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateImportedImage Request Marshaller
    /// </summary>       
    public class CreateImportedImageRequestMarshaller : IMarshaller<IRequest, CreateImportedImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateImportedImageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateImportedImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.CreateImportedImage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAgentSoftwareVersion())
                {
                    context.Writer.WritePropertyName("AgentSoftwareVersion");
                    context.Writer.Write(publicRequest.AgentSoftwareVersion);
                }

                if(publicRequest.IsSetAppCatalogConfig())
                {
                    context.Writer.WritePropertyName("AppCatalogConfig");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAppCatalogConfigListValue in publicRequest.AppCatalogConfig)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ApplicationConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestAppCatalogConfigListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("DisplayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetDryRun())
                {
                    context.Writer.WritePropertyName("DryRun");
                    context.Writer.Write(publicRequest.DryRun);
                }

                if(publicRequest.IsSetIamRoleArn())
                {
                    context.Writer.WritePropertyName("IamRoleArn");
                    context.Writer.Write(publicRequest.IamRoleArn);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRuntimeValidationConfig())
                {
                    context.Writer.WritePropertyName("RuntimeValidationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = RuntimeValidationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RuntimeValidationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceAmiId())
                {
                    context.Writer.WritePropertyName("SourceAmiId");
                    context.Writer.Write(publicRequest.SourceAmiId);
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateImportedImageRequestMarshaller _instance = new CreateImportedImageRequestMarshaller();        

        internal static CreateImportedImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateImportedImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}