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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLocationObjectStorage Request Marshaller
    /// </summary>       
    public class CreateLocationObjectStorageRequestMarshaller : IMarshaller<IRequest, CreateLocationObjectStorageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLocationObjectStorageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLocationObjectStorageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            string target = "FmrsService.CreateLocationObjectStorage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessKey())
                {
                    context.Writer.WritePropertyName("AccessKey");
                    context.Writer.Write(publicRequest.AccessKey);
                }

                if(publicRequest.IsSetAgentArns())
                {
                    context.Writer.WritePropertyName("AgentArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAgentArnsListValue in publicRequest.AgentArns)
                    {
                            context.Writer.Write(publicRequestAgentArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBucketName())
                {
                    context.Writer.WritePropertyName("BucketName");
                    context.Writer.Write(publicRequest.BucketName);
                }

                if(publicRequest.IsSetSecretKey())
                {
                    context.Writer.WritePropertyName("SecretKey");
                    context.Writer.Write(publicRequest.SecretKey);
                }

                if(publicRequest.IsSetServerCertificate())
                {
                    context.Writer.WritePropertyName("ServerCertificate");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.ServerCertificate));
                }

                if(publicRequest.IsSetServerHostname())
                {
                    context.Writer.WritePropertyName("ServerHostname");
                    context.Writer.Write(publicRequest.ServerHostname);
                }

                if(publicRequest.IsSetServerPort())
                {
                    context.Writer.WritePropertyName("ServerPort");
                    context.Writer.Write(publicRequest.ServerPort);
                }

                if(publicRequest.IsSetServerProtocol())
                {
                    context.Writer.WritePropertyName("ServerProtocol");
                    context.Writer.Write(publicRequest.ServerProtocol);
                }

                if(publicRequest.IsSetSubdirectory())
                {
                    context.Writer.WritePropertyName("Subdirectory");
                    context.Writer.Write(publicRequest.Subdirectory);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagListEntryMarshaller.Instance;
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
        private static CreateLocationObjectStorageRequestMarshaller _instance = new CreateLocationObjectStorageRequestMarshaller();        

        internal static CreateLocationObjectStorageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLocationObjectStorageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}