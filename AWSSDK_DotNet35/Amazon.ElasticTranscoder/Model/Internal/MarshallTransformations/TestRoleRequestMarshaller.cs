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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Test Role Request Marshaller
    /// </summary>       
    internal class TestRoleRequestMarshaller : IMarshaller<IRequest, TestRoleRequest> 
    {
        

        public IRequest Marshall(TestRoleRequest testRoleRequest) 
        {

            IRequest request = new DefaultRequest(testRoleRequest, "AmazonElasticTranscoder");
            string target = "EtsCustomerService.TestRole";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.HttpMethod = "POST";
              
            string uriResourcePath = "2012-09-25/roleTests"; 
            
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
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (testRoleRequest != null && testRoleRequest.IsSetRole()) 
                {
                    writer.WritePropertyName("Role");
                    writer.Write(testRoleRequest.Role);
                }
                if (testRoleRequest != null && testRoleRequest.IsSetInputBucket()) 
                {
                    writer.WritePropertyName("InputBucket");
                    writer.Write(testRoleRequest.InputBucket);
                }
                if (testRoleRequest != null && testRoleRequest.IsSetOutputBucket()) 
                {
                    writer.WritePropertyName("OutputBucket");
                    writer.Write(testRoleRequest.OutputBucket);
                }

                if (testRoleRequest != null && testRoleRequest.Topics != null && testRoleRequest.Topics.Count > 0) 
                {
                    List<string> topicsList = testRoleRequest.Topics;
                    writer.WritePropertyName("Topics");
                    writer.WriteArrayStart();

                    foreach (string topicsListValue in topicsList) 
                    { 
                        writer.Write(StringUtils.FromString(topicsListValue));
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
