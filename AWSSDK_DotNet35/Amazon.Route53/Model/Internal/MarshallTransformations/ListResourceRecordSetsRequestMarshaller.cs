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
using System.Xml;
using System.Xml.Serialization;

using Amazon.Route53.Model;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Resource Record Sets Request Marshaller
    /// </summary>       
    public class ListResourceRecordSetsRequestMarshaller : IMarshaller<IRequest, ListResourceRecordSetsRequest>
    {
        
    
        public IRequest Marshall(ListResourceRecordSetsRequest listResourceRecordSetsRequest)
        {
            IRequest request = new DefaultRequest(listResourceRecordSetsRequest, "AmazonRoute53");



            request.HttpMethod = "GET";
            string uriResourcePath = "/2012-12-12/hostedzone/{Id}/rrset?type={Type}&name={Name}&identifier={Identifier}&maxitems={MaxItems}"; 
            uriResourcePath = uriResourcePath.Replace("{Id}", listResourceRecordSetsRequest.IsSetHostedZoneId() ? listResourceRecordSetsRequest.HostedZoneId.ToString() : "" ); 
            uriResourcePath = uriResourcePath.Replace("{Name}", listResourceRecordSetsRequest.IsSetStartRecordName() ? listResourceRecordSetsRequest.StartRecordName.ToString() : "" ); 
            uriResourcePath = uriResourcePath.Replace("{Type}", listResourceRecordSetsRequest.IsSetStartRecordType() ? listResourceRecordSetsRequest.StartRecordType.ToString() : "" ); 
            uriResourcePath = uriResourcePath.Replace("{Identifier}", listResourceRecordSetsRequest.IsSetStartRecordIdentifier() ? listResourceRecordSetsRequest.StartRecordIdentifier.ToString() : "" ); 
            uriResourcePath = uriResourcePath.Replace("{MaxItems}", listResourceRecordSetsRequest.IsSetMaxItems() ? listResourceRecordSetsRequest.MaxItems.ToString() : "" ); 

            if (uriResourcePath.Contains("?")) 
            {
                int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryIndex + 1);
                
                uriResourcePath    = uriResourcePath.Substring(0, queryIndex);
                
        
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
            
        
            request.UseQueryString = true;
            
            
            return request;
        }
    }
}
    
