/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.DynamoDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DynamoDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Item Request Marshaller
    /// </summary>       
    internal class PutItemRequestMarshaller : IMarshaller<IRequest<PutItemRequest>, PutItemRequest> 
    {
        public IRequest<PutItemRequest> Marshall(PutItemRequest putItemRequest) 
        {

            IRequest<PutItemRequest> request = new DefaultRequest<PutItemRequest>(putItemRequest, "AmazonDynamoDB");
            string target = "DynamoDB_20111205.PutItem";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (putItemRequest != null && putItemRequest.IsSetTableName()) 
                {
                    writer.WritePropertyName("TableName");
                    writer.Write(putItemRequest.TableName);
                }
                if (putItemRequest != null) 
                {
                    if (putItemRequest.Item != null) 
                    {
                        writer.WritePropertyName("Item");
                        writer.WriteObjectStart();
                        foreach (string key in putItemRequest.Item.Keys)
                        {
                            AttributeValue itemListValue;
                            bool hasValue = putItemRequest.Item.TryGetValue(key, out itemListValue);
                            writer.WritePropertyName(key);
                            writer.WriteObjectStart();
                            if (itemListValue != null && itemListValue.IsSetS()) 
                            {
                                writer.WritePropertyName("S");
                                writer.Write(itemListValue.S);
                            }
                            if (itemListValue != null && itemListValue.IsSetN()) 
                            {
                                writer.WritePropertyName("N");
                                writer.Write(itemListValue.N);
                            }

                            if (itemListValue != null && itemListValue.SS != null && itemListValue.SS.Count > 0) 
                            {
                                List<string> sSList = itemListValue.SS;
                                writer.WritePropertyName("SS");
                                writer.WriteArrayStart();

                                foreach (string sSListValue in sSList) 
                                { 
                                    writer.Write(StringUtils.FromString(sSListValue));
                                }

                                writer.WriteArrayEnd();
                            }

                            if (itemListValue != null && itemListValue.NS != null && itemListValue.NS.Count > 0) 
                            {
                                List<string> nSList = itemListValue.NS;
                                writer.WritePropertyName("NS");
                                writer.WriteArrayStart();

                                foreach (string nSListValue in nSList) 
                                { 
                                    writer.Write(StringUtils.FromString(nSListValue));
                                }

                                writer.WriteArrayEnd();
                            }
                            writer.WriteObjectEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (putItemRequest != null) 
                {
                    if (putItemRequest.Expected != null) 
                    {
                        writer.WritePropertyName("Expected");
                        writer.WriteObjectStart();
                        foreach (string key in putItemRequest.Expected.Keys)
                        {
                            ExpectedAttributeValue expectedListValue;
                            bool hasValue = putItemRequest.Expected.TryGetValue(key, out expectedListValue);
                            writer.WritePropertyName(key);
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
                if (putItemRequest != null && putItemRequest.IsSetReturnValues()) 
                {
                    writer.WritePropertyName("ReturnValues");
                    writer.Write(putItemRequest.ReturnValues);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
                return request;
            }
        }
    }
}
