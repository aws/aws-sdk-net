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
    /// Query Request Marshaller
    /// </summary>       
    internal class QueryRequestMarshaller : IMarshaller<IRequest, QueryRequest> 
    {
        

        public IRequest Marshall(QueryRequest queryRequest) 
        {

            IRequest request = new DefaultRequest(queryRequest, "AmazonDynamoDBv2");
            string target = "DynamoDB_20120810.Query";
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
                
                if (queryRequest != null && queryRequest.IsSetTableName()) 
                {
                    writer.WritePropertyName("TableName");
                    writer.Write(queryRequest.TableName);
                }
                if (queryRequest != null && queryRequest.IsSetIndexName()) 
                {
                    writer.WritePropertyName("IndexName");
                    writer.Write(queryRequest.IndexName);
                }
                if (queryRequest != null && queryRequest.IsSetSelect()) 
                {
                    writer.WritePropertyName("Select");
                    writer.Write(queryRequest.Select);
                }

                if (queryRequest != null && queryRequest.AttributesToGet != null && queryRequest.AttributesToGet.Count > 0) 
                {
                    List<string> attributesToGetList = queryRequest.AttributesToGet;
                    writer.WritePropertyName("AttributesToGet");
                    writer.WriteArrayStart();

                    foreach (string attributesToGetListValue in attributesToGetList) 
                    { 
                        writer.Write(StringUtils.FromString(attributesToGetListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (queryRequest != null && queryRequest.IsSetLimit()) 
                {
                    writer.WritePropertyName("Limit");
                    writer.Write(queryRequest.Limit);
                }
                if (queryRequest != null && queryRequest.IsSetConsistentRead()) 
                {
                    writer.WritePropertyName("ConsistentRead");
                    writer.Write(queryRequest.ConsistentRead);
                }
                if (queryRequest != null) 
                {
                    if (queryRequest.KeyConditions != null && queryRequest.KeyConditions.Count > 0)
                    {
                        writer.WritePropertyName("KeyConditions");
                        writer.WriteObjectStart();
                        foreach (string queryRequestKeyConditionsKey in queryRequest.KeyConditions.Keys)
                        {
                            Condition keyConditionsListValue;
                            bool keyConditionsListValueHasValue = queryRequest.KeyConditions.TryGetValue(queryRequestKeyConditionsKey, out keyConditionsListValue);
                            writer.WritePropertyName(queryRequestKeyConditionsKey);

                            writer.WriteObjectStart();

                            if (keyConditionsListValue != null && keyConditionsListValue.AttributeValueList != null && keyConditionsListValue.AttributeValueList.Count > 0)
                            {
                                List<AttributeValue> attributeValueListList = keyConditionsListValue.AttributeValueList;
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
                            if (keyConditionsListValue != null && keyConditionsListValue.IsSetComparisonOperator()) 
                            {
                                writer.WritePropertyName("ComparisonOperator");
                                writer.Write(keyConditionsListValue.ComparisonOperator);
                            }
                            writer.WriteObjectEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (queryRequest != null && queryRequest.IsSetScanIndexForward()) 
                {
                    writer.WritePropertyName("ScanIndexForward");
                    writer.Write(queryRequest.ScanIndexForward);
                }
                if (queryRequest != null) 
                {
                    if (queryRequest.ExclusiveStartKey != null && queryRequest.ExclusiveStartKey.Count > 0)
                    {
                        writer.WritePropertyName("ExclusiveStartKey");
                        writer.WriteObjectStart();
                        foreach (string queryRequestExclusiveStartKeyKey in queryRequest.ExclusiveStartKey.Keys)
                        {
                            AttributeValue exclusiveStartKeyListValue;
                            bool exclusiveStartKeyListValueHasValue = queryRequest.ExclusiveStartKey.TryGetValue(queryRequestExclusiveStartKeyKey, out exclusiveStartKeyListValue);
                            writer.WritePropertyName(queryRequestExclusiveStartKeyKey);

                            writer.WriteObjectStart();
                            if (exclusiveStartKeyListValue != null && exclusiveStartKeyListValue.IsSetS()) 
                            {
                                writer.WritePropertyName("S");
                                writer.Write(exclusiveStartKeyListValue.S);
                            }
                            if (exclusiveStartKeyListValue != null && exclusiveStartKeyListValue.IsSetN()) 
                            {
                                writer.WritePropertyName("N");
                                writer.Write(exclusiveStartKeyListValue.N);
                            }
                            if (exclusiveStartKeyListValue != null && exclusiveStartKeyListValue.IsSetB()) 
                            {
                                writer.WritePropertyName("B");
                                writer.Write(StringUtils.FromMemoryStream(exclusiveStartKeyListValue.B));
                            }

                            if (exclusiveStartKeyListValue != null && exclusiveStartKeyListValue.SS != null && exclusiveStartKeyListValue.SS.Count > 0) 
                            {
                                List<string> sSList = exclusiveStartKeyListValue.SS;
                                writer.WritePropertyName("SS");
                                writer.WriteArrayStart();

                                foreach (string sSListValue in sSList) 
                                { 
                                    writer.Write(StringUtils.FromString(sSListValue));
                                }

                                writer.WriteArrayEnd();
                            }

                            if (exclusiveStartKeyListValue != null && exclusiveStartKeyListValue.NS != null && exclusiveStartKeyListValue.NS.Count > 0) 
                            {
                                List<string> nSList = exclusiveStartKeyListValue.NS;
                                writer.WritePropertyName("NS");
                                writer.WriteArrayStart();

                                foreach (string nSListValue in nSList) 
                                { 
                                    writer.Write(StringUtils.FromString(nSListValue));
                                }

                                writer.WriteArrayEnd();
                            }

                            if (exclusiveStartKeyListValue != null && exclusiveStartKeyListValue.BS != null && exclusiveStartKeyListValue.BS.Count > 0) 
                            {
                                List<MemoryStream> bSList = exclusiveStartKeyListValue.BS;
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
                if (queryRequest != null && queryRequest.IsSetReturnConsumedCapacity()) 
                {
                    writer.WritePropertyName("ReturnConsumedCapacity");
                    writer.Write(queryRequest.ReturnConsumedCapacity);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
