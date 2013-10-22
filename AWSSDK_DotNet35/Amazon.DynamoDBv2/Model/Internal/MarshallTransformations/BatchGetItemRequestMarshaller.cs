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
    /// Batch Get Item Request Marshaller
    /// </summary>       
    internal class BatchGetItemRequestMarshaller : IMarshaller<IRequest, BatchGetItemRequest> 
    {
        

        public IRequest Marshall(BatchGetItemRequest batchGetItemRequest) 
        {

            IRequest request = new DefaultRequest(batchGetItemRequest, "AmazonDynamoDBv2");
            string target = "DynamoDB_20120810.BatchGetItem";
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
                
                if (batchGetItemRequest != null) 
                {
                    if (batchGetItemRequest.RequestItems != null && batchGetItemRequest.RequestItems.Count > 0)
                    {
                        writer.WritePropertyName("RequestItems");
                        writer.WriteObjectStart();
                        foreach (string batchGetItemRequestRequestItemsKey in batchGetItemRequest.RequestItems.Keys)
                        {
                            KeysAndAttributes requestItemsListValue;
                            bool requestItemsListValueHasValue = batchGetItemRequest.RequestItems.TryGetValue(batchGetItemRequestRequestItemsKey, out requestItemsListValue);
                            writer.WritePropertyName(batchGetItemRequestRequestItemsKey);

                            writer.WriteObjectStart();

                            if (requestItemsListValue != null && requestItemsListValue.Keys != null && requestItemsListValue.Keys.Count > 0)
                            {
                                List<Dictionary<string,AttributeValue>> keysList = requestItemsListValue.Keys;
                                writer.WritePropertyName("Keys");
                                writer.WriteArrayStart();

                                foreach (Dictionary<string,AttributeValue> keysListValue in keysList) 
                                {
                                    writer.WriteObjectStart();
                                    foreach (KeyValuePair<string, AttributeValue> memberListValue in keysListValue)
                                    {
                                        if (memberListValue.Key != null)
                                        {
                                            writer.WritePropertyName(memberListValue.Key);

                                                writer.WriteObjectStart();
                                                if (memberListValue.Value != null && memberListValue.Value.IsSetS()) 
                                                {
                                                    writer.WritePropertyName("S");
                                                    writer.Write(memberListValue.Value.S);
                                                }
                                                if (memberListValue.Value != null && memberListValue.Value.IsSetN()) 
                                                {
                                                    writer.WritePropertyName("N");
                                                    writer.Write(memberListValue.Value.N);
                                                }
                                                if (memberListValue.Value != null && memberListValue.Value.IsSetB()) 
                                                {
                                                    writer.WritePropertyName("B");
                                                    writer.Write(StringUtils.FromMemoryStream(memberListValue.Value.B));
                                                }

                                                if (memberListValue.Value != null && memberListValue.Value.SS != null && memberListValue.Value.SS.Count > 0) 
                                                {
                                                    List<string> sSList = memberListValue.Value.SS;
                                                    writer.WritePropertyName("SS");
                                                    writer.WriteArrayStart();

                                                    foreach (string sSListValue in sSList) 
                                                    { 
                                                        writer.Write(StringUtils.FromString(sSListValue));
                                                    }

                                                    writer.WriteArrayEnd();
                                                }

                                                if (memberListValue.Value != null && memberListValue.Value.NS != null && memberListValue.Value.NS.Count > 0) 
                                                {
                                                    List<string> nSList = memberListValue.Value.NS;
                                                    writer.WritePropertyName("NS");
                                                    writer.WriteArrayStart();

                                                    foreach (string nSListValue in nSList) 
                                                    { 
                                                        writer.Write(StringUtils.FromString(nSListValue));
                                                    }

                                                    writer.WriteArrayEnd();
                                                }

                                                if (memberListValue.Value != null && memberListValue.Value.BS != null && memberListValue.Value.BS.Count > 0) 
                                                {
                                                    List<MemoryStream> bSList = memberListValue.Value.BS;
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
                                    writer.WriteObjectEnd();
                                }
                                writer.WriteArrayEnd();
                            }

                            if (requestItemsListValue != null && requestItemsListValue.AttributesToGet != null && requestItemsListValue.AttributesToGet.Count > 0) 
                            {
                                List<string> attributesToGetList = requestItemsListValue.AttributesToGet;
                                writer.WritePropertyName("AttributesToGet");
                                writer.WriteArrayStart();

                                foreach (string attributesToGetListValue in attributesToGetList) 
                                { 
                                    writer.Write(StringUtils.FromString(attributesToGetListValue));
                                }

                                writer.WriteArrayEnd();
                            }
                            if (requestItemsListValue != null && requestItemsListValue.IsSetConsistentRead()) 
                            {
                                writer.WritePropertyName("ConsistentRead");
                                writer.Write(requestItemsListValue.ConsistentRead);
                            }
                            writer.WriteObjectEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (batchGetItemRequest != null && batchGetItemRequest.IsSetReturnConsumedCapacity()) 
                {
                    writer.WritePropertyName("ReturnConsumedCapacity");
                    writer.Write(batchGetItemRequest.ReturnConsumedCapacity);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
