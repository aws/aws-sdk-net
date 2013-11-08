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
    /// Describe Tapes Request Marshaller
    /// </summary>       
    internal class DescribeTapesRequestMarshaller : IMarshaller<IRequest, DescribeTapesRequest> 
    {
        

        public IRequest Marshall(DescribeTapesRequest describeTapesRequest) 
        {

            IRequest request = new DefaultRequest(describeTapesRequest, "AmazonStorageGateway");
            string target = "StorageGateway_20130630.DescribeTapes";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
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
            
             
            using (StringWriter stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (describeTapesRequest != null && describeTapesRequest.IsSetGatewayARN()) 
                {
                    writer.WritePropertyName("GatewayARN");
                    writer.Write(describeTapesRequest.GatewayARN);
                }

                if (describeTapesRequest != null && describeTapesRequest.TapeARNs != null && describeTapesRequest.TapeARNs.Count > 0) 
                {
                    List<string> tapeARNsList = describeTapesRequest.TapeARNs;
                    writer.WritePropertyName("TapeARNs");
                    writer.WriteArrayStart();

                    foreach (string tapeARNsListValue in tapeARNsList) 
                    { 
                        writer.Write(StringUtils.FromString(tapeARNsListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (describeTapesRequest != null && describeTapesRequest.IsSetMarker()) 
                {
                    writer.WritePropertyName("Marker");
                    writer.Write(describeTapesRequest.Marker);
                }
                if (describeTapesRequest != null && describeTapesRequest.IsSetLimit()) 
                {
                    writer.WritePropertyName("Limit");
                    writer.Write(describeTapesRequest.Limit);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
