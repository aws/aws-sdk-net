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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.BackupGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateHypervisor Request Marshaller
    /// </summary>       
    public class UpdateHypervisorRequestMarshaller : IMarshaller<IRequest, UpdateHypervisorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateHypervisorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateHypervisorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BackupGateway");
            string target = "BackupOnPremises_v20210101.UpdateHypervisor";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetHost())
                {
                    context.Writer.WritePropertyName("Host");
                    context.Writer.Write(publicRequest.Host);
                }

                if(publicRequest.IsSetHypervisorArn())
                {
                    context.Writer.WritePropertyName("HypervisorArn");
                    context.Writer.Write(publicRequest.HypervisorArn);
                }

                if(publicRequest.IsSetPassword())
                {
                    context.Writer.WritePropertyName("Password");
                    context.Writer.Write(publicRequest.Password);
                }

                if(publicRequest.IsSetUsername())
                {
                    context.Writer.WritePropertyName("Username");
                    context.Writer.Write(publicRequest.Username);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateHypervisorRequestMarshaller _instance = new UpdateHypervisorRequestMarshaller();        

        internal static UpdateHypervisorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateHypervisorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}