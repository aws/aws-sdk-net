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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PaymentCryptography.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptography.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveKeyReplicationRegions Request Marshaller
    /// </summary>       
    public class RemoveKeyReplicationRegionsRequestMarshaller : IMarshaller<IRequest, RemoveKeyReplicationRegionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveKeyReplicationRegionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RemoveKeyReplicationRegionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PaymentCryptography");
            string target = "PaymentCryptographyControlPlane.RemoveKeyReplicationRegions";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-09-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetKeyIdentifier())
                {
                    context.Writer.WritePropertyName("KeyIdentifier");
                    context.Writer.Write(publicRequest.KeyIdentifier);
                }

                if(publicRequest.IsSetReplicationRegions())
                {
                    context.Writer.WritePropertyName("ReplicationRegions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestReplicationRegionsListValue in publicRequest.ReplicationRegions)
                    {
                            context.Writer.Write(publicRequestReplicationRegionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RemoveKeyReplicationRegionsRequestMarshaller _instance = new RemoveKeyReplicationRegionsRequestMarshaller();        

        internal static RemoveKeyReplicationRegionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemoveKeyReplicationRegionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}