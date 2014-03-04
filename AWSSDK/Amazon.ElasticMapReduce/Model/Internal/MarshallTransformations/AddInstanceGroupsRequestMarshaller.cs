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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Add Instance Groups Request Marshaller
    /// </summary>       
    internal class AddInstanceGroupsRequestMarshaller : IMarshaller<IRequest, AddInstanceGroupsRequest> 
    {
        

        public IRequest Marshall(AddInstanceGroupsRequest addInstanceGroupsRequest) 
        {

            IRequest request = new DefaultRequest(addInstanceGroupsRequest, "AmazonElasticMapReduce");
            string target = "ElasticMapReduce.AddInstanceGroups";
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
                

                if (addInstanceGroupsRequest != null && addInstanceGroupsRequest.InstanceGroups != null && addInstanceGroupsRequest.InstanceGroups.Count > 0)
                {
                    List<InstanceGroupConfig> instanceGroupsList = addInstanceGroupsRequest.InstanceGroups;
                    writer.WritePropertyName("InstanceGroups");
                    writer.WriteArrayStart();

                    foreach (InstanceGroupConfig instanceGroupsListValue in instanceGroupsList) 
                    {
                        writer.WriteObjectStart();
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetName()) 
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(instanceGroupsListValue.Name);
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetMarket()) 
                        {
                            writer.WritePropertyName("Market");
                            writer.Write(instanceGroupsListValue.Market);
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceRole()) 
                        {
                            writer.WritePropertyName("InstanceRole");
                            writer.Write(instanceGroupsListValue.InstanceRole);
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetBidPrice()) 
                        {
                            writer.WritePropertyName("BidPrice");
                            writer.Write(instanceGroupsListValue.BidPrice);
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceType()) 
                        {
                            writer.WritePropertyName("InstanceType");
                            writer.Write(instanceGroupsListValue.InstanceType);
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceCount()) 
                        {
                            writer.WritePropertyName("InstanceCount");
                            writer.Write(instanceGroupsListValue.InstanceCount);
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }
                if (addInstanceGroupsRequest != null && addInstanceGroupsRequest.IsSetJobFlowId()) 
                {
                    writer.WritePropertyName("JobFlowId");
                    writer.Write(addInstanceGroupsRequest.JobFlowId);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
