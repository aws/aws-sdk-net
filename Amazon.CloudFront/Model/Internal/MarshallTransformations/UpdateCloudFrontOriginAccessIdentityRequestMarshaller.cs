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

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Update Cloud Front Origin Access Identity Request Marshaller
    /// </summary>       
    public class UpdateCloudFrontOriginAccessIdentityRequestMarshaller : IMarshaller<IRequest, UpdateCloudFrontOriginAccessIdentityRequest>
    {
        
    
        public IRequest Marshall(UpdateCloudFrontOriginAccessIdentityRequest updateCloudFrontOriginAccessIdentityRequest)
        {
            IRequest request = new DefaultRequest(updateCloudFrontOriginAccessIdentityRequest, "AmazonCloudFront");
            request.HttpMethod = "PUT";
            request.Headers.Add("If-Match", updateCloudFrontOriginAccessIdentityRequest.IfMatch);
            
              
            string uriResourcePath = "2012-05-05/origin-access-identity/cloudfront/{Id}/config"; 
            uriResourcePath = uriResourcePath.Replace("{Id}", updateCloudFrontOriginAccessIdentityRequest.Id ?? "" ); 
            
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
            
             
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter);
            xmlWriter.Namespaces = true;
                       
                    if (updateCloudFrontOriginAccessIdentityRequest != null) 
        {
            CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfigCloudFrontOriginAccessIdentityConfig = updateCloudFrontOriginAccessIdentityRequest.CloudFrontOriginAccessIdentityConfig;
            if (cloudFrontOriginAccessIdentityConfigCloudFrontOriginAccessIdentityConfig != null) 
            {
                xmlWriter.WriteStartElement("CloudFrontOriginAccessIdentityConfig", "http://cloudfront.amazonaws.com/doc/2012-05-05/");
                if (cloudFrontOriginAccessIdentityConfigCloudFrontOriginAccessIdentityConfig.IsSetCallerReference()) 
                {
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2012-05-05/", cloudFrontOriginAccessIdentityConfigCloudFrontOriginAccessIdentityConfig.CallerReference.ToString());
                  }
                if (cloudFrontOriginAccessIdentityConfigCloudFrontOriginAccessIdentityConfig.IsSetComment()) 
                {
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2012-05-05/", cloudFrontOriginAccessIdentityConfigCloudFrontOriginAccessIdentityConfig.Comment.ToString());
                  }
                xmlWriter.WriteEndElement();
            }
        }

    
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
    
