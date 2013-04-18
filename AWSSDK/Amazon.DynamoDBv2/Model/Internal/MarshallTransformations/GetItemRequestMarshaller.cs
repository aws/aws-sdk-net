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

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Item Request Marshaller
    /// </summary>       
    internal class GetItemRequestMarshaller : IMarshaller<IRequest, GetItemRequest> 
    {
        

        public IRequest Marshall(GetItemRequest getItemRequest) 
        {

            IRequest request = new DefaultRequest(getItemRequest, "AmazonDynamoDBv2");
            string target = "DynamoDB_20120810.GetItem";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            
              
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
                
                if (getItemRequest != null && getItemRequest.IsSetTableName()) 
                {
                    writer.WritePropertyName("TableName");
                    writer.Write(getItemRequest.TableName);
                }
                if (getItemRequest != null) 
                {
                    if (getItemRequest.Key != null && getItemRequest.Key.Count > 0)
                    {
                        writer.WritePropertyName("Key");
                        writer.WriteObjectStart();
                        foreach (string getItemRequestKeyKey in getItemRequest.Key.Keys)
                        {
                            AttributeValue keyListValue;
                            bool keyListValueHasValue = getItemRequest.Key.TryGetValue(getItemRequestKeyKey, out keyListValue);
                            writer.WritePropertyName(getItemRequestKeyKey);

                            writer.WriteObjectStart();
                            if (keyListValue != null && keyListValue.IsSetS()) 
                            {
                                writer.WritePropertyName("S");
                                writer.Write(keyListValue.S);
                            }
                            if (keyListValue != null && keyListValue.IsSetN()) 
                            {
                                writer.WritePropertyName("N");
                                writer.Write(keyListValue.N);
                            }
                            if (keyListValue != null && keyListValue.IsSetB()) 
                            {
                                writer.WritePropertyName("B");
                                writer.Write(StringUtils.FromMemoryStream(keyListValue.B));
                            }

                            if (keyListValue != null && keyListValue.SS != null && keyListValue.SS.Count > 0) 
                            {
                                List<string> sSList = keyListValue.SS;
                                writer.WritePropertyName("SS");
                                writer.WriteArrayStart();

                                foreach (string sSListValue in sSList) 
                                { 
                                    writer.Write(StringUtils.FromString(sSListValue));
                                }

                                writer.WriteArrayEnd();
                            }

                            if (keyListValue != null && keyListValue.NS != null && keyListValue.NS.Count > 0) 
                            {
                                List<string> nSList = keyListValue.NS;
                                writer.WritePropertyName("NS");
                                writer.WriteArrayStart();

                                foreach (string nSListValue in nSList) 
                                { 
                                    writer.Write(StringUtils.FromString(nSListValue));
                                }

                                writer.WriteArrayEnd();
                            }

                            if (keyListValue != null && keyListValue.BS != null && keyListValue.BS.Count > 0) 
                            {
                                List<MemoryStream> bSList = keyListValue.BS;
                                writer.WritePropertyName("BS");
                                writer.WriteArrayStart();

                                foreach (MemoryStream bSListValue in bSList) 
                                { 
                                    writer.Write(StringUtils.FromMemoryStream(bSListValue));
                                }

                                writer.WriteArrayEnd();
                            }
                            writer.WriteObjectEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (getItemRequest != null && getItemRequest.AttributesToGet != null && getItemRequest.AttributesToGet.Count > 0) 
                {
                    List<string> attributesToGetList = getItemRequest.AttributesToGet;
                    writer.WritePropertyName("AttributesToGet");
                    writer.WriteArrayStart();

                    foreach (string attributesToGetListValue in attributesToGetList) 
                    { 
                        writer.Write(StringUtils.FromString(attributesToGetListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (getItemRequest != null && getItemRequest.IsSetConsistentRead()) 
                {
                    writer.WritePropertyName("ConsistentRead");
                    writer.Write(getItemRequest.ConsistentRead);
                }
                if (getItemRequest != null && getItemRequest.IsSetReturnConsumedCapacity()) 
                {
                    writer.WritePropertyName("ReturnConsumedCapacity");
                    writer.Write(getItemRequest.ReturnConsumedCapacity);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
