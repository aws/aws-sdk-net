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
    /// Scan Request Marshaller
    /// </summary>       
    internal class ScanRequestMarshaller : IMarshaller<IRequest, ScanRequest> 
    {
        

        public IRequest Marshall(ScanRequest scanRequest) 
        {

            IRequest request = new DefaultRequest(scanRequest, "AmazonDynamoDBv2");
            string target = "DynamoDB_20120810.Scan";
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
                
                if (scanRequest != null && scanRequest.IsSetTableName()) 
                {
                    writer.WritePropertyName("TableName");
                    writer.Write(scanRequest.TableName);
                }

                if (scanRequest != null && scanRequest.AttributesToGet != null && scanRequest.AttributesToGet.Count > 0) 
                {
                    List<string> attributesToGetList = scanRequest.AttributesToGet;
                    writer.WritePropertyName("AttributesToGet");
                    writer.WriteArrayStart();

                    foreach (string attributesToGetListValue in attributesToGetList) 
                    { 
                        writer.Write(StringUtils.FromString(attributesToGetListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (scanRequest != null && scanRequest.IsSetLimit()) 
                {
                    writer.WritePropertyName("Limit");
                    writer.Write(scanRequest.Limit);
                }
                if (scanRequest != null && scanRequest.IsSetSelect()) 
                {
                    writer.WritePropertyName("Select");
                    writer.Write(scanRequest.Select);
                }
                if (scanRequest != null) 
                {
                    if (scanRequest.ScanFilter != null && scanRequest.ScanFilter.Count > 0)
                    {
                        writer.WritePropertyName("ScanFilter");
                        writer.WriteObjectStart();
                        foreach (string scanRequestScanFilterKey in scanRequest.ScanFilter.Keys)
                        {
                            Condition scanFilterListValue;
                            bool scanFilterListValueHasValue = scanRequest.ScanFilter.TryGetValue(scanRequestScanFilterKey, out scanFilterListValue);
                            writer.WritePropertyName(scanRequestScanFilterKey);

                            writer.WriteObjectStart();

                            if (scanFilterListValue != null && scanFilterListValue.AttributeValueList != null && scanFilterListValue.AttributeValueList.Count > 0)
                            {
                                List<AttributeValue> attributeValueListList = scanFilterListValue.AttributeValueList;
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
                            if (scanFilterListValue != null && scanFilterListValue.IsSetComparisonOperator()) 
                            {
                                writer.WritePropertyName("ComparisonOperator");
                                writer.Write(scanFilterListValue.ComparisonOperator);
                            }
                            writer.WriteObjectEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (scanRequest != null) 
                {
                    if (scanRequest.ExclusiveStartKey != null && scanRequest.ExclusiveStartKey.Count > 0)
                    {
                        writer.WritePropertyName("ExclusiveStartKey");
                        writer.WriteObjectStart();
                        foreach (string scanRequestExclusiveStartKeyKey in scanRequest.ExclusiveStartKey.Keys)
                        {
                            AttributeValue exclusiveStartKeyListValue;
                            bool exclusiveStartKeyListValueHasValue = scanRequest.ExclusiveStartKey.TryGetValue(scanRequestExclusiveStartKeyKey, out exclusiveStartKeyListValue);
                            writer.WritePropertyName(scanRequestExclusiveStartKeyKey);

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
                if (scanRequest != null && scanRequest.IsSetReturnConsumedCapacity()) 
                {
                    writer.WritePropertyName("ReturnConsumedCapacity");
                    writer.Write(scanRequest.ReturnConsumedCapacity);
                }
                if (scanRequest != null && scanRequest.IsSetTotalSegments()) 
                {
                    writer.WritePropertyName("TotalSegments");
                    writer.Write(scanRequest.TotalSegments);
                }
                if (scanRequest != null && scanRequest.IsSetSegment()) 
                {
                    writer.WritePropertyName("Segment");
                    writer.Write(scanRequest.Segment);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
