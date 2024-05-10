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

#pragma warning disable CS0612,CS0618
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateStorageSystem Request Marshaller
    /// </summary>       
    public class UpdateStorageSystemRequestMarshaller : IMarshaller<IRequest, UpdateStorageSystemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStorageSystemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStorageSystemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            string target = "FmrsService.UpdateStorageSystem";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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

                if(publicRequest.IsSetCloudWatchLogGroupArn())
                {
                    context.Writer.WritePropertyName("CloudWatchLogGroupArn");
                    context.Writer.Write(publicRequest.CloudWatchLogGroupArn);
                }

                if(publicRequest.IsSetCredentials())
                {
                    context.Writer.WritePropertyName("Credentials");
                    context.Writer.WriteObjectStart();

                    var marshaller = CredentialsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Credentials, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetServerConfiguration())
                {
                    context.Writer.WritePropertyName("ServerConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DiscoveryServerConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ServerConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStorageSystemArn())
                {
                    context.Writer.WritePropertyName("StorageSystemArn");
                    context.Writer.Write(publicRequest.StorageSystemArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"discovery-";

            return request;
        }
        private static UpdateStorageSystemRequestMarshaller _instance = new UpdateStorageSystemRequestMarshaller();        

        internal static UpdateStorageSystemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStorageSystemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}