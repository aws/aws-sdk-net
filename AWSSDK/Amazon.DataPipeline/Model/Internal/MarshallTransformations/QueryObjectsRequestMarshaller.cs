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
    /// Query Objects Request Marshaller
    /// </summary>       
    internal class QueryObjectsRequestMarshaller : IMarshaller<IRequest, QueryObjectsRequest> 
    {
        

        public IRequest Marshall(QueryObjectsRequest queryObjectsRequest) 
        {

            IRequest request = new DefaultRequest(queryObjectsRequest, "AmazonDataPipeline");
            string target = "DataPipeline.QueryObjects";
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
                
                if (queryObjectsRequest != null && queryObjectsRequest.IsSetPipelineId()) 
                {
                    writer.WritePropertyName("pipelineId");
                    writer.Write(queryObjectsRequest.PipelineId);
                }

                if (queryObjectsRequest != null) 
                {
                    Query query = queryObjectsRequest.Query;
                    if (query != null)
                    {
                        writer.WritePropertyName("query");
                        writer.WriteObjectStart();

                        if (query != null && query.Selectors != null && query.Selectors.Count > 0)
                        {
                            List<Selector> selectorsList = query.Selectors;
                            writer.WritePropertyName("selectors");
                            writer.WriteArrayStart();
                            foreach (Selector selectorsListValue in selectorsList) 
                            {
                                writer.WriteObjectStart();
                                if (selectorsListValue != null && selectorsListValue.IsSetFieldName()) 
                                {
                                    writer.WritePropertyName("fieldName");
                                    writer.Write(selectorsListValue.FieldName);
                                }

                                if (selectorsListValue != null) 
                                {
                                    Operator operatorValue = selectorsListValue.Operator;
                                    if (operatorValue != null)
                                    {
                                        writer.WritePropertyName("operator");
                                        writer.WriteObjectStart();
                                        if (operatorValue != null && operatorValue.IsSetType()) 
                                        {
                                            writer.WritePropertyName("type");
                                            writer.Write(operatorValue.Type);
                                        }

                                        if (operatorValue != null && operatorValue.Values != null && operatorValue.Values.Count > 0) 
                                        {
                                            List<string> valuesList = operatorValue.Values;
                                            writer.WritePropertyName("values");
                                            writer.WriteArrayStart();

                                            foreach (string valuesListValue in valuesList) 
                                            { 
                                                writer.Write(StringUtils.FromString(valuesListValue));
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
                        writer.WriteObjectEnd();
                    }
                }
                if (queryObjectsRequest != null && queryObjectsRequest.IsSetSphere()) 
                {
                    writer.WritePropertyName("sphere");
                    writer.Write(queryObjectsRequest.Sphere);
                }
                if (queryObjectsRequest != null && queryObjectsRequest.IsSetMarker()) 
                {
                    writer.WritePropertyName("marker");
                    writer.Write(queryObjectsRequest.Marker);
                }
                if (queryObjectsRequest != null && queryObjectsRequest.IsSetLimit()) 
                {
                    writer.WritePropertyName("limit");
                    writer.Write(queryObjectsRequest.Limit);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
