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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStudio Request Marshaller
    /// </summary>       
    public class CreateStudioRequestMarshaller : IMarshaller<IRequest, CreateStudioRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStudioRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStudioRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NimbleStudio");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2020-08-01/studios";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdminRoleArn())
                {
                    context.Writer.WritePropertyName("adminRoleArn");
                    context.Writer.Write(publicRequest.AdminRoleArn);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("displayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetStudioEncryptionConfiguration())
                {
                    context.Writer.WritePropertyName("studioEncryptionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = StudioEncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StudioEncryptionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStudioName())
                {
                    context.Writer.WritePropertyName("studioName");
                    context.Writer.Write(publicRequest.StudioName);
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

                if(publicRequest.IsSetUserRoleArn())
                {
                    context.Writer.WritePropertyName("userRoleArn");
                    context.Writer.Write(publicRequest.UserRoleArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["X-Amz-Client-Token"] = publicRequest.ClientToken;
            }

            return request;
        }
        private static CreateStudioRequestMarshaller _instance = new CreateStudioRequestMarshaller();        

        internal static CreateStudioRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStudioRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}