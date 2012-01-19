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
    /// Delete Item Request Marshaller
    /// </summary>       
    internal class DeleteItemRequestMarshaller : IMarshaller<IRequest<DeleteItemRequest>, DeleteItemRequest> 
    {
        public IRequest<DeleteItemRequest> Marshall(DeleteItemRequest deleteItemRequest) 
        {

            IRequest<DeleteItemRequest> request = new DefaultRequest<DeleteItemRequest>(deleteItemRequest, "AmazonDynamoDB");
            string target = "DynamoDB_20111205.DeleteItem";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            using (StringWriter stringWriter = new StringWriter())
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
                    Key key = deleteItemRequest.Key;
                    if (key != null)
                    {
                        writer.WritePropertyName("Key");
                        writer.WriteObjectStart();

                        if (key != null) 
                        {
                            AttributeValue hashKeyElement = key.HashKeyElement;
                            if (hashKeyElement != null)
                            {
                                writer.WritePropertyName("HashKeyElement");
                                writer.WriteObjectStart();
                                if (hashKeyElement != null && hashKeyElement.IsSetS()) 
                                {
                                    writer.WritePropertyName("S");
                                    writer.Write(hashKeyElement.S);
                                }
                                if (hashKeyElement != null && hashKeyElement.IsSetN()) 
                                {
                                    writer.WritePropertyName("N");
                                    writer.Write(hashKeyElement.N);
                                }

                                if (hashKeyElement != null && hashKeyElement.SS != null && hashKeyElement.SS.Count > 0) 
                                {
                                    List<string> sSList = hashKeyElement.SS;
                                    writer.WritePropertyName("SS");
                                    writer.WriteArrayStart();

                                    foreach (string sSListValue in sSList) 
                                    { 
                                        writer.Write(StringUtils.FromString(sSListValue));
                                    }

                                    writer.WriteArrayEnd();
                                }

                                if (hashKeyElement != null && hashKeyElement.NS != null && hashKeyElement.NS.Count > 0) 
                                {
                                    List<string> nSList = hashKeyElement.NS;
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

                        if (key != null) 
                        {
                            AttributeValue rangeKeyElement = key.RangeKeyElement;
                            if (rangeKeyElement != null)
                            {
                                writer.WritePropertyName("RangeKeyElement");
                                writer.WriteObjectStart();
                                if (rangeKeyElement != null && rangeKeyElement.IsSetS()) 
                                {
                                    writer.WritePropertyName("S");
                                    writer.Write(rangeKeyElement.S);
                                }
                                if (rangeKeyElement != null && rangeKeyElement.IsSetN()) 
                                {
                                    writer.WritePropertyName("N");
                                    writer.Write(rangeKeyElement.N);
                                }

                                if (rangeKeyElement != null && rangeKeyElement.SS != null && rangeKeyElement.SS.Count > 0) 
                                {
                                    List<string> sSList = rangeKeyElement.SS;
                                    writer.WritePropertyName("SS");
                                    writer.WriteArrayStart();

                                    foreach (string sSListValue in sSList) 
                                    { 
                                        writer.Write(StringUtils.FromString(sSListValue));
                                    }

                                    writer.WriteArrayEnd();
                                }

                                if (rangeKeyElement != null && rangeKeyElement.NS != null && rangeKeyElement.NS.Count > 0) 
                                {
                                    List<string> nSList = rangeKeyElement.NS;
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
                        writer.WriteObjectEnd();
                    }
                }
                if (deleteItemRequest != null) 
                {
                    if (deleteItemRequest.Expected != null) 
                    {
                        writer.WritePropertyName("Expected");
                        writer.WriteObjectStart();
                        foreach (string key in deleteItemRequest.Expected.Keys)
                        {
                            ExpectedAttributeValue expectedListValue;
                            bool hasValue = deleteItemRequest.Expected.TryGetValue(key, out expectedListValue);
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
                if (deleteItemRequest != null && deleteItemRequest.IsSetReturnValues()) 
                {
                    writer.WritePropertyName("ReturnValues");
                    writer.Write(deleteItemRequest.ReturnValues);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
                return request;
            }
        }
    }
}
