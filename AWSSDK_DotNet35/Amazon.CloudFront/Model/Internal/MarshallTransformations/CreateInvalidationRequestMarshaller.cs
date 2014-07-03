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
    /// CreateInvalidation Request Marshaller
    /// </summary>       
    public class CreateInvalidationRequestMarshaller : IMarshaller<IRequest, CreateInvalidationRequest> 
    {
        public IRequest Marshall(CreateInvalidationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            var uriResourcePath = "/2014-05-31/distribution/{DistributionId}/invalidation";

            uriResourcePath = uriResourcePath.Replace("{DistributionId}", publicRequest.IsSetDistributionId() ? StringUtils.FromString(publicRequest.DistributionId) : string.Empty);
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("InvalidationBatch", "http://cloudfront.amazonaws.com/doc/2014-05-31/");                                
                if(publicRequest.InvalidationBatch.IsSetCallerReference())
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2014-05-31/", StringUtils.FromString(publicRequest.InvalidationBatch.CallerReference));                    

                
                if (publicRequest.InvalidationBatch.Paths != null) 
                {
                    xmlWriter.WriteStartElement("Paths", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                    var publicRequestInvalidationBatchPathsItems = publicRequest.InvalidationBatch.Paths.Items;
                    if (publicRequestInvalidationBatchPathsItems != null && publicRequestInvalidationBatchPathsItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                        foreach (var publicRequestInvalidationBatchPathsItemsValue in publicRequestInvalidationBatchPathsItems) 
                        {
                            xmlWriter.WriteStartElement("Path", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                            xmlWriter.WriteValue(publicRequestInvalidationBatchPathsItemsValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.InvalidationBatch.Paths.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", StringUtils.FromInt(publicRequest.InvalidationBatch.Paths.Quantity));                 
    
                    xmlWriter.WriteEndElement();
                }

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