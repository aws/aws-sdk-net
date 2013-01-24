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

using Amazon.DataPipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Validate Pipeline Definition Request Marshaller
    /// </summary>       
    internal class ValidatePipelineDefinitionRequestMarshaller : IMarshaller<IRequest, ValidatePipelineDefinitionRequest> 
    {
        

        public IRequest Marshall(ValidatePipelineDefinitionRequest validatePipelineDefinitionRequest) 
        {

            IRequest request = new DefaultRequest(validatePipelineDefinitionRequest, "AmazonDataPipeline");
            string target = "DataPipeline.ValidatePipelineDefinition";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";

            
              
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
                
                if (validatePipelineDefinitionRequest != null && validatePipelineDefinitionRequest.IsSetPipelineId()) 
                {
                    writer.WritePropertyName("pipelineId");
                    writer.Write(validatePipelineDefinitionRequest.PipelineId);
                }

                if (validatePipelineDefinitionRequest != null && validatePipelineDefinitionRequest.PipelineObjects != null && validatePipelineDefinitionRequest.PipelineObjects.Count > 0)
                {
                    List<PipelineObject> pipelineObjectsList = validatePipelineDefinitionRequest.PipelineObjects;
                    writer.WritePropertyName("pipelineObjects");
                    writer.WriteArrayStart();
                    foreach (PipelineObject pipelineObjectsListValue in pipelineObjectsList) 
                    {
                        writer.WriteObjectStart();
                        if (pipelineObjectsListValue != null && pipelineObjectsListValue.IsSetId()) 
                        {
                            writer.WritePropertyName("id");
                            writer.Write(pipelineObjectsListValue.Id);
                        }
                        if (pipelineObjectsListValue != null && pipelineObjectsListValue.IsSetName()) 
                        {
                            writer.WritePropertyName("name");
                            writer.Write(pipelineObjectsListValue.Name);
                        }

                        if (pipelineObjectsListValue != null && pipelineObjectsListValue.Fields != null && pipelineObjectsListValue.Fields.Count > 0)
                        {
                            List<Field> fieldsList = pipelineObjectsListValue.Fields;
                            writer.WritePropertyName("fields");
                            writer.WriteArrayStart();
                            foreach (Field fieldsListValue in fieldsList) 
                            {
                                writer.WriteObjectStart();
                                if (fieldsListValue != null && fieldsListValue.IsSetKey()) 
                                {
                                    writer.WritePropertyName("key");
                                    writer.Write(fieldsListValue.Key);
                                }
                                if (fieldsListValue != null && fieldsListValue.IsSetStringValue()) 
                                {
                                    writer.WritePropertyName("stringValue");
                                    writer.Write(fieldsListValue.StringValue);
                                }
                                if (fieldsListValue != null && fieldsListValue.IsSetRefValue()) 
                                {
                                    writer.WritePropertyName("refValue");
                                    writer.Write(fieldsListValue.RefValue);
                                }
                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
