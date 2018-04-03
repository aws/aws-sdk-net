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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRemoteAccessSession Request Marshaller
    /// </summary>       
    public class CreateRemoteAccessSessionRequestMarshaller : IMarshaller<IRequest, CreateRemoteAccessSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRemoteAccessSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRemoteAccessSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DeviceFarm");
            string target = "DeviceFarm_20150623.CreateRemoteAccessSession";
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
                if(publicRequest.IsSetClientId())
                {
                    context.Writer.WritePropertyName("clientId");
                    context.Writer.Write(publicRequest.ClientId);
                }

                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("configuration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CreateRemoteAccessSessionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDeviceArn())
                {
                    context.Writer.WritePropertyName("deviceArn");
                    context.Writer.Write(publicRequest.DeviceArn);
                }

                if(publicRequest.IsSetInstanceArn())
                {
                    context.Writer.WritePropertyName("instanceArn");
                    context.Writer.Write(publicRequest.InstanceArn);
                }

                if(publicRequest.IsSetInteractionMode())
                {
                    context.Writer.WritePropertyName("interactionMode");
                    context.Writer.Write(publicRequest.InteractionMode);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetProjectArn())
                {
                    context.Writer.WritePropertyName("projectArn");
                    context.Writer.Write(publicRequest.ProjectArn);
                }

                if(publicRequest.IsSetRemoteDebugEnabled())
                {
                    context.Writer.WritePropertyName("remoteDebugEnabled");
                    context.Writer.Write(publicRequest.RemoteDebugEnabled);
                }

                if(publicRequest.IsSetRemoteRecordAppArn())
                {
                    context.Writer.WritePropertyName("remoteRecordAppArn");
                    context.Writer.Write(publicRequest.RemoteRecordAppArn);
                }

                if(publicRequest.IsSetRemoteRecordEnabled())
                {
                    context.Writer.WritePropertyName("remoteRecordEnabled");
                    context.Writer.Write(publicRequest.RemoteRecordEnabled);
                }

                if(publicRequest.IsSetSkipAppResign())
                {
                    context.Writer.WritePropertyName("skipAppResign");
                    context.Writer.Write(publicRequest.SkipAppResign);
                }

                if(publicRequest.IsSetSshPublicKey())
                {
                    context.Writer.WritePropertyName("sshPublicKey");
                    context.Writer.Write(publicRequest.SshPublicKey);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateRemoteAccessSessionRequestMarshaller _instance = new CreateRemoteAccessSessionRequestMarshaller();        

        internal static CreateRemoteAccessSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRemoteAccessSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}