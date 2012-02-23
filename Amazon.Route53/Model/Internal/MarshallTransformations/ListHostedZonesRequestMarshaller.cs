/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml;
using System.Xml.Serialization;
using System.Text;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Hosted Zones Request Marshaller
    /// </summary>       
    public class ListHostedZonesRequestMarshaller : IMarshaller<IRequest<ListHostedZonesRequest>, ListHostedZonesRequest>
    {
        
    
        public IRequest<ListHostedZonesRequest> Marshall(ListHostedZonesRequest listHostedZonesRequest)
        {
            IRequest<ListHostedZonesRequest> request = new DefaultRequest<ListHostedZonesRequest>(listHostedZonesRequest, "AmazonRoute53");
            request.HttpMethod = "GET";
              
            string uriResourcePath = "/2011-05-05/hostedzone?marker={Marker}&maxitems={MaxItems}"; 
            uriResourcePath = uriResourcePath.Replace("{Marker}", listHostedZonesRequest.Marker ?? "" ); 
            uriResourcePath = uriResourcePath.Replace("{MaxItems}", listHostedZonesRequest.MaxItems ?? "" ); 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
                    
            
            return request;
        }
    }
}
    
