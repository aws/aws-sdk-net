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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActivateGateway Request Marshaller
    /// </summary>       
    public class ActivateGatewayRequestMarshaller : IMarshaller<IRequest, ActivateGatewayRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ActivateGatewayRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ActivateGatewayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.ActivateGateway";
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
                if(publicRequest.IsSetActivationKey())
                {
                    context.Writer.WritePropertyName("ActivationKey");
                    context.Writer.Write(publicRequest.ActivationKey);
                }

                if(publicRequest.IsSetGatewayName())
                {
                    context.Writer.WritePropertyName("GatewayName");
                    context.Writer.Write(publicRequest.GatewayName);
                }

                if(publicRequest.IsSetGatewayRegion())
                {
                    context.Writer.WritePropertyName("GatewayRegion");
                    context.Writer.Write(publicRequest.GatewayRegion);
                }

                if(publicRequest.IsSetGatewayTimezone())
                {
                    context.Writer.WritePropertyName("GatewayTimezone");
                    context.Writer.Write(publicRequest.GatewayTimezone);
                }

                if(publicRequest.IsSetGatewayType())
                {
                    context.Writer.WritePropertyName("GatewayType");
                    context.Writer.Write(publicRequest.GatewayType);
                }

                if(publicRequest.IsSetMediumChangerType())
                {
                    context.Writer.WritePropertyName("MediumChangerType");
                    context.Writer.Write(publicRequest.MediumChangerType);
                }

                if(publicRequest.IsSetTapeDriveType())
                {
                    context.Writer.WritePropertyName("TapeDriveType");
                    context.Writer.Write(publicRequest.TapeDriveType);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ActivateGatewayRequestMarshaller _instance = new ActivateGatewayRequestMarshaller();        

        internal static ActivateGatewayRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActivateGatewayRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}