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
    /// Create Table Request Marshaller
    /// </summary>       
    internal class CreateTableRequestMarshaller : IMarshaller<IRequest, CreateTableRequest> 
    {
        

        public IRequest Marshall(CreateTableRequest createTableRequest) 
        {

            IRequest request = new DefaultRequest(createTableRequest, "AmazonDynamoDBv2");
            string target = "DynamoDB_20120810.CreateTable";
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
                

                if (createTableRequest != null && createTableRequest.AttributeDefinitions != null && createTableRequest.AttributeDefinitions.Count > 0)
                {
                    List<AttributeDefinition> attributeDefinitionsList = createTableRequest.AttributeDefinitions;
                    writer.WritePropertyName("AttributeDefinitions");
                    writer.WriteArrayStart();

                    foreach (AttributeDefinition attributeDefinitionsListValue in attributeDefinitionsList) 
                    {
                        writer.WriteObjectStart();
                        if (attributeDefinitionsListValue != null && attributeDefinitionsListValue.IsSetAttributeName()) 
                        {
                            writer.WritePropertyName("AttributeName");
                            writer.Write(attributeDefinitionsListValue.AttributeName);
                        }
                        if (attributeDefinitionsListValue != null && attributeDefinitionsListValue.IsSetAttributeType()) 
                        {
                            writer.WritePropertyName("AttributeType");
                            writer.Write(attributeDefinitionsListValue.AttributeType);
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }
                if (createTableRequest != null && createTableRequest.IsSetTableName()) 
                {
                    writer.WritePropertyName("TableName");
                    writer.Write(createTableRequest.TableName);
                }

                if (createTableRequest != null && createTableRequest.KeySchema != null && createTableRequest.KeySchema.Count > 0)
                {
                    List<KeySchemaElement> keySchemaList = createTableRequest.KeySchema;
                    writer.WritePropertyName("KeySchema");
                    writer.WriteArrayStart();

                    foreach (KeySchemaElement keySchemaListValue in keySchemaList) 
                    {
                        writer.WriteObjectStart();
                        if (keySchemaListValue != null && keySchemaListValue.IsSetAttributeName()) 
                        {
                            writer.WritePropertyName("AttributeName");
                            writer.Write(keySchemaListValue.AttributeName);
                        }
                        if (keySchemaListValue != null && keySchemaListValue.IsSetKeyType()) 
                        {
                            writer.WritePropertyName("KeyType");
                            writer.Write(keySchemaListValue.KeyType);
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if (createTableRequest != null && createTableRequest.LocalSecondaryIndexes != null && createTableRequest.LocalSecondaryIndexes.Count > 0)
                {
                    List<LocalSecondaryIndex> localSecondaryIndexesList = createTableRequest.LocalSecondaryIndexes;
                    writer.WritePropertyName("LocalSecondaryIndexes");
                    writer.WriteArrayStart();

                    foreach (LocalSecondaryIndex localSecondaryIndexesListValue in localSecondaryIndexesList) 
                    {
                        writer.WriteObjectStart();
                        if (localSecondaryIndexesListValue != null && localSecondaryIndexesListValue.IsSetIndexName()) 
                        {
                            writer.WritePropertyName("IndexName");
                            writer.Write(localSecondaryIndexesListValue.IndexName);
                        }

                        if (localSecondaryIndexesListValue != null && localSecondaryIndexesListValue.KeySchema != null && localSecondaryIndexesListValue.KeySchema.Count > 0)
                        {
                            List<KeySchemaElement> keySchemaList = localSecondaryIndexesListValue.KeySchema;
                            writer.WritePropertyName("KeySchema");
                            writer.WriteArrayStart();

                            foreach (KeySchemaElement keySchemaListValue in keySchemaList) 
                            {
                                writer.WriteObjectStart();
                                if (keySchemaListValue != null && keySchemaListValue.IsSetAttributeName()) 
                                {
                                    writer.WritePropertyName("AttributeName");
                                    writer.Write(keySchemaListValue.AttributeName);
                                }
                                if (keySchemaListValue != null && keySchemaListValue.IsSetKeyType()) 
                                {
                                    writer.WritePropertyName("KeyType");
                                    writer.Write(keySchemaListValue.KeyType);
                                }
                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }

                        if (localSecondaryIndexesListValue != null) 
                        {
                            Projection projection = localSecondaryIndexesListValue.Projection;
                            if (projection != null)
                            {
                                writer.WritePropertyName("Projection");
                                writer.WriteObjectStart();
                                if (projection != null && projection.IsSetProjectionType()) 
                                {
                                    writer.WritePropertyName("ProjectionType");
                                    writer.Write(projection.ProjectionType);
                                }

                                if (projection != null && projection.NonKeyAttributes != null && projection.NonKeyAttributes.Count > 0) 
                                {
                                    List<string> nonKeyAttributesList = projection.NonKeyAttributes;
                                    writer.WritePropertyName("NonKeyAttributes");
                                    writer.WriteArrayStart();

                                    foreach (string nonKeyAttributesListValue in nonKeyAttributesList) 
                                    { 
                                        writer.Write(StringUtils.FromString(nonKeyAttributesListValue));
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
