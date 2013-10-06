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
    /// Create Health Check Request Marshaller
    /// </summary>       
    public class CreateHealthCheckRequestMarshaller : IMarshaller<IRequest, CreateHealthCheckRequest>
    {
        
    
        public IRequest Marshall(CreateHealthCheckRequest createHealthCheckRequest)
        {
            IRequest request = new DefaultRequest(createHealthCheckRequest, "AmazonRoute53");



            request.HttpMethod = "POST";
              
            string uriResourcePath = "/2012-12-12/healthcheck"; 
            
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
            
             
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter);
            xmlWriter.Namespaces = true;
                       
            
            xmlWriter.WriteStartElement("CreateHealthCheckRequest", "https://route53.amazonaws.com/doc/2012-12-12/");
                    if (createHealthCheckRequest.IsSetCallerReference()) 
        {
            xmlWriter.WriteElementString("CallerReference", "https://route53.amazonaws.com/doc/2012-12-12/", createHealthCheckRequest.CallerReference.ToString());
          }
        if (createHealthCheckRequest != null) 
        {
            HealthCheckConfig healthCheckConfigHealthCheckConfig = createHealthCheckRequest.HealthCheckConfig;
            if (healthCheckConfigHealthCheckConfig != null) 
            {
                xmlWriter.WriteStartElement("HealthCheckConfig", "https://route53.amazonaws.com/doc/2012-12-12/");
                if (healthCheckConfigHealthCheckConfig.IsSetIPAddress()) 
                {
                    xmlWriter.WriteElementString("IPAddress", "https://route53.amazonaws.com/doc/2012-12-12/", healthCheckConfigHealthCheckConfig.IPAddress.ToString());
                  }
                if (healthCheckConfigHealthCheckConfig.IsSetPort()) 
                {
                    xmlWriter.WriteElementString("Port", "https://route53.amazonaws.com/doc/2012-12-12/", healthCheckConfigHealthCheckConfig.Port.ToString());
                  }
                if (healthCheckConfigHealthCheckConfig.IsSetType()) 
                {
                    xmlWriter.WriteElementString("Type", "https://route53.amazonaws.com/doc/2012-12-12/", healthCheckConfigHealthCheckConfig.Type.ToString());
                  }
                if (healthCheckConfigHealthCheckConfig.IsSetResourcePath()) 
                {
                    xmlWriter.WriteElementString("ResourcePath", "https://route53.amazonaws.com/doc/2012-12-12/", healthCheckConfigHealthCheckConfig.ResourcePath.ToString());
                  }
                if (healthCheckConfigHealthCheckConfig.IsSetFullyQualifiedDomainName()) 
                {
                    xmlWriter.WriteElementString("FullyQualifiedDomainName", "https://route53.amazonaws.com/doc/2012-12-12/", healthCheckConfigHealthCheckConfig.FullyQualifiedDomainName.ToString());
                  }
                xmlWriter.WriteEndElement();
            }
        }

            xmlWriter.WriteEndElement();
            
    
            try 
            {
                request.Content = System.Text.Encoding.UTF8.GetBytes(stringWriter.ToString());
                request.Headers.Add("Content-Type", "application/xml");
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
        
            
            return request;
        }
    }
}
    
