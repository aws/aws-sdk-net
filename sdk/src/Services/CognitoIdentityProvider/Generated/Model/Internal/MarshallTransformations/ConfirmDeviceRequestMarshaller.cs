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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConfirmDevice Request Marshaller
    /// </summary>       
    public class ConfirmDeviceRequestMarshaller : IMarshaller<IRequest, ConfirmDeviceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ConfirmDeviceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ConfirmDeviceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.ConfirmDevice";
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
                if(publicRequest.IsSetAccessToken())
                {
                    context.Writer.WritePropertyName("AccessToken");
                    context.Writer.Write(publicRequest.AccessToken);
                }

                if(publicRequest.IsSetDeviceKey())
                {
                    context.Writer.WritePropertyName("DeviceKey");
                    context.Writer.Write(publicRequest.DeviceKey);
                }

                if(publicRequest.IsSetDeviceName())
                {
                    context.Writer.WritePropertyName("DeviceName");
                    context.Writer.Write(publicRequest.DeviceName);
                }

                if(publicRequest.IsSetDeviceSecretVerifierConfig())
                {
                    context.Writer.WritePropertyName("DeviceSecretVerifierConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeviceSecretVerifierConfigTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceSecretVerifierConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ConfirmDeviceRequestMarshaller _instance = new ConfirmDeviceRequestMarshaller();        

        internal static ConfirmDeviceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfirmDeviceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}