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

using Amazon.AWSSupport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Cases Request Marshaller
    /// </summary>       
    internal class DescribeCasesRequestMarshaller : IMarshaller<IRequest, DescribeCasesRequest> 
    {
        

        public IRequest Marshall(DescribeCasesRequest describeCasesRequest) 
        {

            IRequest request = new DefaultRequest(describeCasesRequest, "AmazonAWSSupport");
            string target = "AWSSupport_20130415.DescribeCases";
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
                

                if (describeCasesRequest != null && describeCasesRequest.CaseIdList != null && describeCasesRequest.CaseIdList.Count > 0) 
                {
                    List<string> caseIdListList = describeCasesRequest.CaseIdList;
                    writer.WritePropertyName("caseIdList");
                    writer.WriteArrayStart();

                    foreach (string caseIdListListValue in caseIdListList) 
                    { 
                        writer.Write(StringUtils.FromString(caseIdListListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (describeCasesRequest != null && describeCasesRequest.IsSetDisplayId()) 
                {
                    writer.WritePropertyName("displayId");
                    writer.Write(describeCasesRequest.DisplayId);
                }
                if (describeCasesRequest != null && describeCasesRequest.IsSetAfterTime()) 
                {
                    writer.WritePropertyName("afterTime");
                    writer.Write(describeCasesRequest.AfterTime);
                }
                if (describeCasesRequest != null && describeCasesRequest.IsSetBeforeTime()) 
                {
                    writer.WritePropertyName("beforeTime");
                    writer.Write(describeCasesRequest.BeforeTime);
                }
                if (describeCasesRequest != null && describeCasesRequest.IsSetIncludeResolvedCases()) 
                {
                    writer.WritePropertyName("includeResolvedCases");
                    writer.Write(describeCasesRequest.IncludeResolvedCases);
                }
                if (describeCasesRequest != null && describeCasesRequest.IsSetNextToken()) 
                {
                    writer.WritePropertyName("nextToken");
                    writer.Write(describeCasesRequest.NextToken);
                }
                if (describeCasesRequest != null && describeCasesRequest.IsSetMaxResults()) 
                {
                    writer.WritePropertyName("maxResults");
                    writer.Write(describeCasesRequest.MaxResults);
                }
                if (describeCasesRequest != null && describeCasesRequest.IsSetLanguage()) 
                {
                    writer.WritePropertyName("language");
                    writer.Write(describeCasesRequest.Language);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
