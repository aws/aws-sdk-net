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
    /// Delete Item Request Marshaller
    /// </summary>       
    internal class DeleteItemRequestMarshaller : IMarshaller<IRequest, DeleteItemRequest> 
    {
        

        public IRequest Marshall(DeleteItemRequest deleteItemRequest) 
        {

            IRequest request = new DefaultRequest(deleteItemRequest, "AmazonDynamoDBv2");
            string target = "DynamoDB_20120810.DeleteItem";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            
              
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
                
                if (deleteItemRequest != null && deleteItemRequest.IsSetTableName()) 
                {
                    writer.WritePropertyName("TableName");
                    writer.Write(deleteItemRequest.TableName);
                }
                if (deleteItemRequest != null) 
                {
                    if (deleteItemRequest.Key != null && deleteItemRequest.Key.Count > 0)
                    {
                        writer.WritePropertyName("Key");
                        writer.WriteObjectStart();
                        foreach (string deleteItemRequestKeyKey in deleteItemRequest.Key.Keys)
                        {
                            AttributeValue keyListValue;
                            bool keyListValueHasValue = deleteItemRequest.Key.TryGetValue(deleteItemRequestKeyKey, out keyListValue);
                            writer.WritePropertyName(deleteItemRequestKeyKey);

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
                if (deleteItemRequest != null) 
                {
                    if (deleteItemRequest.Expected != null && deleteItemRequest.Expected.Count > 0)
                    {
                        writer.WritePropertyName("Expected");
                        writer.WriteObjectStart();
                        foreach (string deleteItemRequestExpectedKey in deleteItemRequest.Expected.Keys)
                        {
                            ExpectedAttributeValue expectedListValue;
                            bool expectedListValueHasValue = deleteItemRequest.Expected.TryGetValue(deleteItemRequestExpectedKey, out expectedListValue);
                            writer.WritePropertyName(deleteItemRequestExpectedKey);

                            writer.WriteObjectStart();

                            if (expectedListValue != null) 
                            {
                                AttributeValue value = expectedListValue.Value;
                                if (value != null)
                                {
                                    writer.WritePropertyName("Value");
                                    writer.WriteObjectStart();
                                    if (value != null && value.IsSetS()) 
                                    {
                                        writer.WritePropertyName("S");
                                        writer.Write(value.S);
                                    }
                                    if (value != null && value.IsSetN()) 
                                    {
                                        writer.WritePropertyName("N");
                                        writer.Write(value.N);
                                    }
                                    if (value != null && value.IsSetB()) 
                                    {
                                        writer.WritePropertyName("B");
                                        writer.Write(StringUtils.FromMemoryStream(value.B));
                                    }

                                    if (value != null && value.SS != null && value.SS.Count > 0) 
                                    {
                                        List<string> sSList = value.SS;
                                        writer.WritePropertyName("SS");
                                        writer.WriteArrayStart();

                                        foreach (string sSListValue in sSList) 
                                        { 
                                            writer.Write(StringUtils.FromString(sSListValue));
                                        }

                                        writer.WriteArrayEnd();
                                    }

                                    if (value != null && value.NS != null && value.NS.Count > 0) 
                                    {
                                        List<string> nSList = value.NS;
                                        writer.WritePropertyName("NS");
                                        writer.WriteArrayStart();

                                        foreach (string nSListValue in nSList) 
                                        { 
                                            writer.Write(StringUtils.FromString(nSListValue));
                                        }

                                        writer.WriteArrayEnd();
                                    }

                                    if (value != null && value.BS != null && value.BS.Count > 0) 
                                    {
                                        List<MemoryStream> bSList = value.BS;
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
                            }
                            if (expectedListValue != null && expectedListValue.IsSetExists()) 
                            {
                                writer.WritePropertyName("Exists");
                                writer.Write(expectedListValue.Exists);
                            }
                            writer.WriteObjectEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (deleteItemRequest != null && deleteItemRequest.IsSetReturnValues()) 
                {
                    writer.WritePropertyName("ReturnValues");
                    writer.Write(deleteItemRequest.ReturnValues);
                }
                if (deleteItemRequest != null && deleteItemRequest.IsSetReturnConsumedCapacity()) 
                {
                    writer.WritePropertyName("ReturnConsumedCapacity");
                    writer.Write(deleteItemRequest.ReturnConsumedCapacity);
                }
                if (deleteItemRequest != null && deleteItemRequest.IsSetReturnItemCollectionMetrics()) 
                {
                    writer.WritePropertyName("ReturnItemCollectionMetrics");
                    writer.Write(deleteItemRequest.ReturnItemCollectionMetrics);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
