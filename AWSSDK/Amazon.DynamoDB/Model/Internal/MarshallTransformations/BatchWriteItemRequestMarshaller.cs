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

using Amazon.DynamoDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DynamoDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Batch Write Item Request Marshaller
    /// </summary>       
    internal class BatchWriteItemRequestMarshaller : IMarshaller<IRequest, BatchWriteItemRequest> 
    {
        

        public IRequest Marshall(BatchWriteItemRequest batchWriteItemRequest) 
        {

            IRequest request = new DefaultRequest(batchWriteItemRequest, "AmazonDynamoDB");
            string target = "DynamoDB_20111205.BatchWriteItem";
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
                
                if (batchWriteItemRequest != null) 
                {
                    if (batchWriteItemRequest.RequestItems != null) 
                    {
                        writer.WritePropertyName("RequestItems");
                        writer.WriteObjectStart();
                        foreach (string batchWriteItemRequestRequestItemsKey in batchWriteItemRequest.RequestItems.Keys)
                        {
                            List<WriteRequest> requestItemsListValue;
                            bool requestItemsListValueHasValue = batchWriteItemRequest.RequestItems.TryGetValue(batchWriteItemRequestRequestItemsKey, out requestItemsListValue);
                            writer.WritePropertyName(batchWriteItemRequestRequestItemsKey);

                            writer.WriteArrayStart();
                            if (requestItemsListValue != null)
                            {
                                foreach (WriteRequest valueListValue in requestItemsListValue) 
                                {
                                    writer.WriteObjectStart();

                                    if (valueListValue != null) 
                                    {
                                        PutRequest putRequest = valueListValue.PutRequest;
                                        if (putRequest != null)
                                        {
                                            writer.WritePropertyName("PutRequest");
                                            writer.WriteObjectStart();
                                            if (putRequest != null) 
                                            {
                                                if (putRequest.Item != null) 
                                                {
                                                    writer.WritePropertyName("Item");
                                                    writer.WriteObjectStart();
                                                    foreach (string putRequestItemKey in putRequest.Item.Keys)
                                                    {
                                                        AttributeValue itemListValue;
                                                        bool itemListValueHasValue = putRequest.Item.TryGetValue(putRequestItemKey, out itemListValue);
                                                        writer.WritePropertyName(putRequestItemKey);

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
                                                        if (itemListValue != null && itemListValue.IsSetB()) 
                                                        {
                                                            writer.WritePropertyName("B");
                                                            writer.Write(StringUtils.FromMemoryStream(itemListValue.B));
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

                                                        if (itemListValue != null && itemListValue.BS != null && itemListValue.BS.Count > 0) 
                                                        {
                                                            List<MemoryStream> bSList = itemListValue.BS;
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
                                            writer.WriteObjectEnd();
                                        }
                                    }

                                    if (valueListValue != null) 
                                    {
                                        DeleteRequest deleteRequest = valueListValue.DeleteRequest;
                                        if (deleteRequest != null)
                                        {
                                            writer.WritePropertyName("DeleteRequest");
                                            writer.WriteObjectStart();

                                            if (deleteRequest != null) 
                                            {
                                                Key key = deleteRequest.Key;
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
                                                            if (hashKeyElement != null && hashKeyElement.IsSetB()) 
                                                            {
                                                                writer.WritePropertyName("B");
                                                                writer.Write(StringUtils.FromMemoryStream(hashKeyElement.B));
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

                                                            if (hashKeyElement != null && hashKeyElement.BS != null && hashKeyElement.BS.Count > 0) 
                                                            {
                                                                List<MemoryStream> bSList = hashKeyElement.BS;
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
                                                            if (rangeKeyElement != null && rangeKeyElement.IsSetB()) 
                                                            {
                                                                writer.WritePropertyName("B");
                                                                writer.Write(StringUtils.FromMemoryStream(rangeKeyElement.B));
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

                                                            if (rangeKeyElement != null && rangeKeyElement.BS != null && rangeKeyElement.BS.Count > 0) 
                                                            {
                                                                List<MemoryStream> bSList = rangeKeyElement.BS;
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
                                            }
                                            writer.WriteObjectEnd();
                                        }
                                    }
                                    writer.WriteObjectEnd();
                                }
                            }
                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
