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
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Update Item Request Marshaller
    /// </summary>       
    internal class UpdateItemRequestMarshaller : IMarshaller<IRequest, UpdateItemRequest> 
    {
        

        public IRequest Marshall(UpdateItemRequest updateItemRequest) 
        {

            IRequest request = new DefaultRequest(updateItemRequest, "AmazonDynamoDBv2");
            string target = "DynamoDB_20120810.UpdateItem";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            
            string uriResourcePath = ""; 
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (updateItemRequest != null && updateItemRequest.IsSetTableName()) 
                {
                    writer.WritePropertyName("TableName");
                    writer.Write(updateItemRequest.TableName);
                }
                if (updateItemRequest != null) 
                {
                    if (updateItemRequest.Key != null && updateItemRequest.Key.Count > 0)
                    {
                        writer.WritePropertyName("Key");
                        writer.WriteObjectStart();
                        foreach (string updateItemRequestKeyKey in updateItemRequest.Key.Keys)
                        {
                            AttributeValue keyListValue;
                            bool keyListValueHasValue = updateItemRequest.Key.TryGetValue(updateItemRequestKeyKey, out keyListValue);
                            writer.WritePropertyName(updateItemRequestKeyKey);

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
                if (updateItemRequest != null) 
                {
                    if (updateItemRequest.AttributeUpdates != null && updateItemRequest.AttributeUpdates.Count > 0)
                    {
                        writer.WritePropertyName("AttributeUpdates");
                        writer.WriteObjectStart();
                        foreach (string updateItemRequestAttributeUpdatesKey in updateItemRequest.AttributeUpdates.Keys)
                        {
                            AttributeValueUpdate attributeUpdatesListValue;
                            bool attributeUpdatesListValueHasValue = updateItemRequest.AttributeUpdates.TryGetValue(updateItemRequestAttributeUpdatesKey, out attributeUpdatesListValue);
                            writer.WritePropertyName(updateItemRequestAttributeUpdatesKey);

                            writer.WriteObjectStart();

                            if (attributeUpdatesListValue != null) 
                            {
                                AttributeValue value = attributeUpdatesListValue.Value;
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
                            if (attributeUpdatesListValue != null && attributeUpdatesListValue.IsSetAction()) 
                            {
                                writer.WritePropertyName("Action");
                                writer.Write(attributeUpdatesListValue.Action);
                            }
                            writer.WriteObjectEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (updateItemRequest != null) 
                {
                    if (updateItemRequest.Expected != null && updateItemRequest.Expected.Count > 0)
                    {
                        writer.WritePropertyName("Expected");
                        writer.WriteObjectStart();
                        foreach (string updateItemRequestExpectedKey in updateItemRequest.Expected.Keys)
                        {
                            ExpectedAttributeValue expectedListValue;
                            bool expectedListValueHasValue = updateItemRequest.Expected.TryGetValue(updateItemRequestExpectedKey, out expectedListValue);
                            writer.WritePropertyName(updateItemRequestExpectedKey);

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
                            if (expectedListValue != null && expectedListValue.IsSetComparisonOperator()) 
                            {
                                writer.WritePropertyName("ComparisonOperator");
                                writer.Write(expectedListValue.ComparisonOperator);
                            }

                            if (expectedListValue != null && expectedListValue.AttributeValueList != null && expectedListValue.AttributeValueList.Count > 0)
                            {
                                List<AttributeValue> attributeValueListList = expectedListValue.AttributeValueList;
                                writer.WritePropertyName("AttributeValueList");
                                writer.WriteArrayStart();

                                foreach (AttributeValue attributeValueListListValue in attributeValueListList) 
                                {
                                    writer.WriteObjectStart();
                                    if (attributeValueListListValue != null && attributeValueListListValue.IsSetS()) 
                                    {
                                        writer.WritePropertyName("S");
                                        writer.Write(attributeValueListListValue.S);
                                    }
                                    if (attributeValueListListValue != null && attributeValueListListValue.IsSetN()) 
                                    {
                                        writer.WritePropertyName("N");
                                        writer.Write(attributeValueListListValue.N);
                                    }
                                    if (attributeValueListListValue != null && attributeValueListListValue.IsSetB()) 
                                    {
                                        writer.WritePropertyName("B");
                                        writer.Write(StringUtils.FromMemoryStream(attributeValueListListValue.B));
                                    }

                                    if (attributeValueListListValue != null && attributeValueListListValue.SS != null && attributeValueListListValue.SS.Count > 0) 
                                    {
                                        List<string> sSList = attributeValueListListValue.SS;
                                        writer.WritePropertyName("SS");
                                        writer.WriteArrayStart();

                                        foreach (string sSListValue in sSList) 
                                        { 
                                            writer.Write(StringUtils.FromString(sSListValue));
                                        }

                                        writer.WriteArrayEnd();
                                    }

                                    if (attributeValueListListValue != null && attributeValueListListValue.NS != null && attributeValueListListValue.NS.Count > 0) 
                                    {
                                        List<string> nSList = attributeValueListListValue.NS;
                                        writer.WritePropertyName("NS");
                                        writer.WriteArrayStart();

                                        foreach (string nSListValue in nSList) 
                                        { 
                                            writer.Write(StringUtils.FromString(nSListValue));
                                        }

                                        writer.WriteArrayEnd();
                                    }

                                    if (attributeValueListListValue != null && attributeValueListListValue.BS != null && attributeValueListListValue.BS.Count > 0) 
                                    {
                                        List<MemoryStream> bSList = attributeValueListListValue.BS;
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
                                writer.WriteArrayEnd();
                            }
                            writer.WriteObjectEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (updateItemRequest != null && updateItemRequest.IsSetConditionalOperator()) 
                {
                    writer.WritePropertyName("ConditionalOperator");
                    writer.Write(updateItemRequest.ConditionalOperator);
                }
                if (updateItemRequest != null && updateItemRequest.IsSetReturnValues()) 
                {
                    writer.WritePropertyName("ReturnValues");
                    writer.Write(updateItemRequest.ReturnValues);
                }
                if (updateItemRequest != null && updateItemRequest.IsSetReturnConsumedCapacity()) 
                {
                    writer.WritePropertyName("ReturnConsumedCapacity");
                    writer.Write(updateItemRequest.ReturnConsumedCapacity);
                }
                if (updateItemRequest != null && updateItemRequest.IsSetReturnItemCollectionMetrics()) 
                {
                    writer.WritePropertyName("ReturnItemCollectionMetrics");
                    writer.Write(updateItemRequest.ReturnItemCollectionMetrics);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
