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
 * Do not modify this file. This file is generated from the ec2-instance-connect-2018-04-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2InstanceConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EC2InstanceConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendSerialConsoleSSHPublicKey Request Marshaller
    /// </summary>       
    public class SendSerialConsoleSSHPublicKeyRequestMarshaller : IMarshaller<IRequest, SendSerialConsoleSSHPublicKeyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendSerialConsoleSSHPublicKeyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendSerialConsoleSSHPublicKeyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2InstanceConnect");
            string target = "AWSEC2InstanceConnectService.SendSerialConsoleSSHPublicKey";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-02";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetInstanceId())
                {
                    context.Writer.WritePropertyName("InstanceId");
                    context.Writer.Write(publicRequest.InstanceId);
                }

                if(publicRequest.IsSetSerialPort())
                {
                    context.Writer.WritePropertyName("SerialPort");
                    context.Writer.Write(publicRequest.SerialPort);
                }

                if(publicRequest.IsSetSSHPublicKey())
                {
                    context.Writer.WritePropertyName("SSHPublicKey");
                    context.Writer.Write(publicRequest.SSHPublicKey);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SendSerialConsoleSSHPublicKeyRequestMarshaller _instance = new SendSerialConsoleSSHPublicKeyRequestMarshaller();        

        internal static SendSerialConsoleSSHPublicKeyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendSerialConsoleSSHPublicKeyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}