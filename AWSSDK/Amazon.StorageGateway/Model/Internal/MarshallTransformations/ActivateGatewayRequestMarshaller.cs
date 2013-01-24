/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
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
    /// Activate Gateway Request Marshaller
    /// </summary>       
    internal class ActivateGatewayRequestMarshaller : IMarshaller<IRequest, ActivateGatewayRequest> 
    {
        

        public IRequest Marshall(ActivateGatewayRequest activateGatewayRequest) 
        {

            IRequest request = new DefaultRequest(activateGatewayRequest, "AmazonStorageGateway");
            string target = "StorageGateway_20120630.ActivateGateway";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";

            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (activateGatewayRequest != null && activateGatewayRequest.IsSetActivationKey()) 
                {
                    writer.WritePropertyName("ActivationKey");
                    writer.Write(activateGatewayRequest.ActivationKey);
                }
                if (activateGatewayRequest != null && activateGatewayRequest.IsSetGatewayName()) 
                {
                    writer.WritePropertyName("GatewayName");
                    writer.Write(activateGatewayRequest.GatewayName);
                }
                if (activateGatewayRequest != null && activateGatewayRequest.IsSetGatewayTimezone()) 
                {
                    writer.WritePropertyName("GatewayTimezone");
                    writer.Write(activateGatewayRequest.GatewayTimezone);
                }
                if (activateGatewayRequest != null && activateGatewayRequest.IsSetGatewayRegion()) 
                {
                    writer.WritePropertyName("GatewayRegion");
                    writer.Write(activateGatewayRequest.GatewayRegion);
                }
                if (activateGatewayRequest != null && activateGatewayRequest.IsSetGatewayType()) 
                {
                    writer.WritePropertyName("GatewayType");
                    writer.Write(activateGatewayRequest.GatewayType);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
