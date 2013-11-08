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
    /// Create Case Request Marshaller
    /// </summary>       
    internal class CreateCaseRequestMarshaller : IMarshaller<IRequest, CreateCaseRequest> 
    {
        

        public IRequest Marshall(CreateCaseRequest createCaseRequest) 
        {

            IRequest request = new DefaultRequest(createCaseRequest, "AmazonAWSSupport");
            string target = "AWSSupport_20130415.CreateCase";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
              
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
                
                if (createCaseRequest != null && createCaseRequest.IsSetSubject()) 
                {
                    writer.WritePropertyName("subject");
                    writer.Write(createCaseRequest.Subject);
                }
                if (createCaseRequest != null && createCaseRequest.IsSetServiceCode()) 
                {
                    writer.WritePropertyName("serviceCode");
                    writer.Write(createCaseRequest.ServiceCode);
                }
                if (createCaseRequest != null && createCaseRequest.IsSetSeverityCode()) 
                {
                    writer.WritePropertyName("severityCode");
                    writer.Write(createCaseRequest.SeverityCode);
                }
                if (createCaseRequest != null && createCaseRequest.IsSetCategoryCode()) 
                {
                    writer.WritePropertyName("categoryCode");
                    writer.Write(createCaseRequest.CategoryCode);
                }
                if (createCaseRequest != null && createCaseRequest.IsSetCommunicationBody()) 
                {
                    writer.WritePropertyName("communicationBody");
                    writer.Write(createCaseRequest.CommunicationBody);
                }

                if (createCaseRequest != null && createCaseRequest.CcEmailAddresses != null && createCaseRequest.CcEmailAddresses.Count > 0) 
                {
                    List<string> ccEmailAddressesList = createCaseRequest.CcEmailAddresses;
                    writer.WritePropertyName("ccEmailAddresses");
                    writer.WriteArrayStart();

                    foreach (string ccEmailAddressesListValue in ccEmailAddressesList) 
                    { 
                        writer.Write(StringUtils.FromString(ccEmailAddressesListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (createCaseRequest != null && createCaseRequest.IsSetLanguage()) 
                {
                    writer.WritePropertyName("language");
                    writer.Write(createCaseRequest.Language);
                }
                if (createCaseRequest != null && createCaseRequest.IsSetIssueType()) 
                {
                    writer.WritePropertyName("issueType");
                    writer.Write(createCaseRequest.IssueType);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
