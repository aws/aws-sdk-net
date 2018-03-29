/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateInstance Request Marshaller
    /// </summary>       
    public class UpdateInstanceRequestMarshaller : IMarshaller<IRequest, UpdateInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateInstanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.UpdateInstance";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAgentVersion())
                {
                    context.Writer.WritePropertyName("AgentVersion");
                    context.Writer.Write(publicRequest.AgentVersion);
                }

                if(publicRequest.IsSetAmiId())
                {
                    context.Writer.WritePropertyName("AmiId");
                    context.Writer.Write(publicRequest.AmiId);
                }

                if(publicRequest.IsSetArchitecture())
                {
                    context.Writer.WritePropertyName("Architecture");
                    context.Writer.Write(publicRequest.Architecture);
                }

                if(publicRequest.IsSetAutoScalingType())
                {
                    context.Writer.WritePropertyName("AutoScalingType");
                    context.Writer.Write(publicRequest.AutoScalingType);
                }

                if(publicRequest.IsSetEbsOptimized())
                {
                    context.Writer.WritePropertyName("EbsOptimized");
                    context.Writer.Write(publicRequest.EbsOptimized);
                }

                if(publicRequest.IsSetHostname())
                {
                    context.Writer.WritePropertyName("Hostname");
                    context.Writer.Write(publicRequest.Hostname);
                }

                if(publicRequest.IsSetInstallUpdatesOnBoot())
                {
                    context.Writer.WritePropertyName("InstallUpdatesOnBoot");
                    context.Writer.Write(publicRequest.InstallUpdatesOnBoot);
                }

                if(publicRequest.IsSetInstanceId())
                {
                    context.Writer.WritePropertyName("InstanceId");
                    context.Writer.Write(publicRequest.InstanceId);
                }

                if(publicRequest.IsSetInstanceType())
                {
                    context.Writer.WritePropertyName("InstanceType");
                    context.Writer.Write(publicRequest.InstanceType);
                }

                if(publicRequest.IsSetLayerIds())
                {
                    context.Writer.WritePropertyName("LayerIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLayerIdsListValue in publicRequest.LayerIds)
                    {
                            context.Writer.Write(publicRequestLayerIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOs())
                {
                    context.Writer.WritePropertyName("Os");
                    context.Writer.Write(publicRequest.Os);
                }

                if(publicRequest.IsSetSshKeyName())
                {
                    context.Writer.WritePropertyName("SshKeyName");
                    context.Writer.Write(publicRequest.SshKeyName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateInstanceRequestMarshaller _instance = new UpdateInstanceRequestMarshaller();        

        internal static UpdateInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}