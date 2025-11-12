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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAuthenticationProfile Request Marshaller
    /// </summary>       
    public class UpdateAuthenticationProfileRequestMarshaller : IMarshaller<IRequest, UpdateAuthenticationProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAuthenticationProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAuthenticationProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAuthenticationProfileId())
                throw new AmazonConnectException("Request object does not have required field AuthenticationProfileId set");
            request.AddPathResource("{AuthenticationProfileId}", StringUtils.FromString(publicRequest.AuthenticationProfileId));
            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/authentication-profiles/{InstanceId}/{AuthenticationProfileId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowedIps())
                {
                    context.Writer.WritePropertyName("AllowedIps");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAllowedIpsListValue in publicRequest.AllowedIps)
                    {
                            context.Writer.Write(publicRequestAllowedIpsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBlockedIps())
                {
                    context.Writer.WritePropertyName("BlockedIps");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBlockedIpsListValue in publicRequest.BlockedIps)
                    {
                            context.Writer.Write(publicRequestBlockedIpsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPeriodicSessionDuration())
                {
                    context.Writer.WritePropertyName("PeriodicSessionDuration");
                    context.Writer.Write(publicRequest.PeriodicSessionDuration);
                }

                if(publicRequest.IsSetSessionInactivityDuration())
                {
                    context.Writer.WritePropertyName("SessionInactivityDuration");
                    context.Writer.Write(publicRequest.SessionInactivityDuration);
                }

                if(publicRequest.IsSetSessionInactivityHandlingEnabled())
                {
                    context.Writer.WritePropertyName("SessionInactivityHandlingEnabled");
                    context.Writer.Write(publicRequest.SessionInactivityHandlingEnabled);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAuthenticationProfileRequestMarshaller _instance = new UpdateAuthenticationProfileRequestMarshaller();        

        internal static UpdateAuthenticationProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAuthenticationProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}