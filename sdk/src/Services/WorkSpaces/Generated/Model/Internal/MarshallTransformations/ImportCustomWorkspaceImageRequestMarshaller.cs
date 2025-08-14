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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportCustomWorkspaceImage Request Marshaller
    /// </summary>       
    public class ImportCustomWorkspaceImageRequestMarshaller : IMarshaller<IRequest, ImportCustomWorkspaceImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportCustomWorkspaceImageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportCustomWorkspaceImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            string target = "WorkspacesService.ImportCustomWorkspaceImage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComputeType())
                {
                    context.Writer.WritePropertyName("ComputeType");
                    context.Writer.Write(publicRequest.ComputeType);
                }

                if(publicRequest.IsSetImageDescription())
                {
                    context.Writer.WritePropertyName("ImageDescription");
                    context.Writer.Write(publicRequest.ImageDescription);
                }

                if(publicRequest.IsSetImageName())
                {
                    context.Writer.WritePropertyName("ImageName");
                    context.Writer.Write(publicRequest.ImageName);
                }

                if(publicRequest.IsSetImageSource())
                {
                    context.Writer.WritePropertyName("ImageSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = ImageSourceIdentifierMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ImageSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInfrastructureConfigurationArn())
                {
                    context.Writer.WritePropertyName("InfrastructureConfigurationArn");
                    context.Writer.Write(publicRequest.InfrastructureConfigurationArn);
                }

                if(publicRequest.IsSetOsVersion())
                {
                    context.Writer.WritePropertyName("OsVersion");
                    context.Writer.Write(publicRequest.OsVersion);
                }

                if(publicRequest.IsSetPlatform())
                {
                    context.Writer.WritePropertyName("Platform");
                    context.Writer.Write(publicRequest.Platform);
                }

                if(publicRequest.IsSetProtocol())
                {
                    context.Writer.WritePropertyName("Protocol");
                    context.Writer.Write(publicRequest.Protocol);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
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
        private static ImportCustomWorkspaceImageRequestMarshaller _instance = new ImportCustomWorkspaceImageRequestMarshaller();        

        internal static ImportCustomWorkspaceImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportCustomWorkspaceImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}