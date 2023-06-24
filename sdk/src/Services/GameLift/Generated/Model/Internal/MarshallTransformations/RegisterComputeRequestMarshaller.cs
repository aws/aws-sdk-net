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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterCompute Request Marshaller
    /// </summary>       
    public class RegisterComputeRequestMarshaller : IMarshaller<IRequest, RegisterComputeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterComputeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterComputeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.RegisterCompute";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCertificatePath())
                {
                    context.Writer.WritePropertyName("CertificatePath");
                    context.Writer.Write(publicRequest.CertificatePath);
                }

                if(publicRequest.IsSetComputeName())
                {
                    context.Writer.WritePropertyName("ComputeName");
                    context.Writer.Write(publicRequest.ComputeName);
                }

                if(publicRequest.IsSetDnsName())
                {
                    context.Writer.WritePropertyName("DnsName");
                    context.Writer.Write(publicRequest.DnsName);
                }

                if(publicRequest.IsSetFleetId())
                {
                    context.Writer.WritePropertyName("FleetId");
                    context.Writer.Write(publicRequest.FleetId);
                }

                if(publicRequest.IsSetIpAddress())
                {
                    context.Writer.WritePropertyName("IpAddress");
                    context.Writer.Write(publicRequest.IpAddress);
                }

                if(publicRequest.IsSetLocation())
                {
                    context.Writer.WritePropertyName("Location");
                    context.Writer.Write(publicRequest.Location);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterComputeRequestMarshaller _instance = new RegisterComputeRequestMarshaller();        

        internal static RegisterComputeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterComputeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}