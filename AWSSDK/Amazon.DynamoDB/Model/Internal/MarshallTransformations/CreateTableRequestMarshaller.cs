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
    /// Create Table Request Marshaller
    /// </summary>       
    internal class CreateTableRequestMarshaller : IMarshaller<IRequest, CreateTableRequest> 
    {
        

        public IRequest Marshall(CreateTableRequest createTableRequest) 
        {

            IRequest request = new DefaultRequest(createTableRequest, "AmazonDynamoDB");
            string target = "DynamoDB_20111205.CreateTable";
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
                
                if (createTableRequest != null && createTableRequest.IsSetTableName()) 
                {
                    writer.WritePropertyName("TableName");
                    writer.Write(createTableRequest.TableName);
                }

                if (createTableRequest != null) 
                {
                    KeySchema keySchema = createTableRequest.KeySchema;
                    if (keySchema != null)
                    {
                        writer.WritePropertyName("KeySchema");
                        writer.WriteObjectStart();

                        if (keySchema != null) 
                        {
                            KeySchemaElement hashKeyElement = keySchema.HashKeyElement;
                            if (hashKeyElement != null)
                            {
                                writer.WritePropertyName("HashKeyElement");
                                writer.WriteObjectStart();
                                if (hashKeyElement != null && hashKeyElement.IsSetAttributeName()) 
                                {
                                    writer.WritePropertyName("AttributeName");
                                    writer.Write(hashKeyElement.AttributeName);
                                }
                                if (hashKeyElement != null && hashKeyElement.IsSetAttributeType()) 
                                {
                                    writer.WritePropertyName("AttributeType");
                                    writer.Write(hashKeyElement.AttributeType);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (keySchema != null) 
                        {
                            KeySchemaElement rangeKeyElement = keySchema.RangeKeyElement;
                            if (rangeKeyElement != null)
                            {
                                writer.WritePropertyName("RangeKeyElement");
                                writer.WriteObjectStart();
                                if (rangeKeyElement != null && rangeKeyElement.IsSetAttributeName()) 
                                {
                                    writer.WritePropertyName("AttributeName");
                                    writer.Write(rangeKeyElement.AttributeName);
                                }
                                if (rangeKeyElement != null && rangeKeyElement.IsSetAttributeType()) 
                                {
                                    writer.WritePropertyName("AttributeType");
                                    writer.Write(rangeKeyElement.AttributeType);
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (createTableRequest != null) 
                {
                    ProvisionedThroughput provisionedThroughput = createTableRequest.ProvisionedThroughput;
                    if (provisionedThroughput != null)
                    {
                        writer.WritePropertyName("ProvisionedThroughput");
                        writer.WriteObjectStart();
                        if (provisionedThroughput != null && provisionedThroughput.IsSetReadCapacityUnits()) 
                        {
                            writer.WritePropertyName("ReadCapacityUnits");
                            writer.Write(provisionedThroughput.ReadCapacityUnits);
                        }
                        if (provisionedThroughput != null && provisionedThroughput.IsSetWriteCapacityUnits()) 
                        {
                            writer.WritePropertyName("WriteCapacityUnits");
                            writer.Write(provisionedThroughput.WriteCapacityUnits);
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
