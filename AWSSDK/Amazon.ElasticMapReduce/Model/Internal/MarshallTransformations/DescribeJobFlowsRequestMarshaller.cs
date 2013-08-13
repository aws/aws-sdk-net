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
    /// Describe Job Flows Request Marshaller
    /// </summary>       
    internal class DescribeJobFlowsRequestMarshaller : IMarshaller<IRequest, DescribeJobFlowsRequest> 
    {
        

        public IRequest Marshall(DescribeJobFlowsRequest describeJobFlowsRequest) 
        {

            IRequest request = new DefaultRequest(describeJobFlowsRequest, "AmazonElasticMapReduce");
            string target = "ElasticMapReduce.DescribeJobFlows";
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
                
                if (describeJobFlowsRequest != null && describeJobFlowsRequest.IsSetCreatedAfter()) 
                {
                    writer.WritePropertyName("CreatedAfter");
                    writer.Write(describeJobFlowsRequest.CreatedAfter);
                }
                if (describeJobFlowsRequest != null && describeJobFlowsRequest.IsSetCreatedBefore()) 
                {
                    writer.WritePropertyName("CreatedBefore");
                    writer.Write(describeJobFlowsRequest.CreatedBefore);
                }

                if (describeJobFlowsRequest != null && describeJobFlowsRequest.JobFlowIds != null && describeJobFlowsRequest.JobFlowIds.Count > 0) 
                {
                    List<string> jobFlowIdsList = describeJobFlowsRequest.JobFlowIds;
                    writer.WritePropertyName("JobFlowIds");
                    writer.WriteArrayStart();

                    foreach (string jobFlowIdsListValue in jobFlowIdsList) 
                    { 
                        writer.Write(StringUtils.FromString(jobFlowIdsListValue));
                    }

                    writer.WriteArrayEnd();
                }

                if (describeJobFlowsRequest != null && describeJobFlowsRequest.JobFlowStates != null && describeJobFlowsRequest.JobFlowStates.Count > 0) 
                {
                    List<string> jobFlowStatesList = describeJobFlowsRequest.JobFlowStates;
                    writer.WritePropertyName("JobFlowStates");
                    writer.WriteArrayStart();

                    foreach (string jobFlowStatesListValue in jobFlowStatesList) 
                    { 
                        writer.Write(StringUtils.FromString(jobFlowStatesListValue));
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
