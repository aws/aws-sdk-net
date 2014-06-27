/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCloudFrontOriginAccessIdentity Request Marshaller
    /// </summary>       
    public class CreateCloudFrontOriginAccessIdentityRequestMarshaller : IMarshaller<IRequest, CreateCloudFrontOriginAccessIdentityRequest> 
    {
        public IRequest Marshall(CreateCloudFrontOriginAccessIdentityRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            var uriResourcePath = "/2014-05-31/origin-access-identity/cloudfront";

            request.ResourcePath = uriResourcePath;

            
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter);
            xmlWriter.Namespaces = true;

            using (xmlWriter)
            {   
                xmlWriter.WriteStartElement("CloudFrontOriginAccessIdentityConfig", "http://cloudfront.amazonaws.com/doc/2014-05-31/");                                
                if(publicRequest.CloudFrontOriginAccessIdentityConfig.IsSetCallerReference())
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.CloudFrontOriginAccessIdentityConfig.CallerReference.ToString());                    

                if(publicRequest.CloudFrontOriginAccessIdentityConfig.IsSetComment())
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.CloudFrontOriginAccessIdentityConfig.Comment.ToString());                    


                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

        
    }    
}