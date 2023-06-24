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

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateUpdatedImage Request Marshaller
    /// </summary>       
    public class CreateUpdatedImageRequestMarshaller : IMarshaller<IRequest, CreateUpdatedImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateUpdatedImageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateUpdatedImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.CreateUpdatedImage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDryRun())
                {
                    context.Writer.WritePropertyName("dryRun");
                    context.Writer.Write(publicRequest.DryRun);
                }

                if(publicRequest.IsSetExistingImageName())
                {
                    context.Writer.WritePropertyName("existingImageName");
                    context.Writer.Write(publicRequest.ExistingImageName);
                }

                if(publicRequest.IsSetNewImageDescription())
                {
                    context.Writer.WritePropertyName("newImageDescription");
                    context.Writer.Write(publicRequest.NewImageDescription);
                }

                if(publicRequest.IsSetNewImageDisplayName())
                {
                    context.Writer.WritePropertyName("newImageDisplayName");
                    context.Writer.Write(publicRequest.NewImageDisplayName);
                }

                if(publicRequest.IsSetNewImageName())
                {
                    context.Writer.WritePropertyName("newImageName");
                    context.Writer.Write(publicRequest.NewImageName);
                }

                if(publicRequest.IsSetNewImageTags())
                {
                    context.Writer.WritePropertyName("newImageTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestNewImageTagsKvp in publicRequest.NewImageTags)
                    {
                        context.Writer.WritePropertyName(publicRequestNewImageTagsKvp.Key);
                        var publicRequestNewImageTagsValue = publicRequestNewImageTagsKvp.Value;

                            context.Writer.Write(publicRequestNewImageTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateUpdatedImageRequestMarshaller _instance = new CreateUpdatedImageRequestMarshaller();        

        internal static CreateUpdatedImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateUpdatedImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}