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

using Amazon.CloudFront.Model;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Invalidation Request Marshaller
    /// </summary>       
    public class CreateInvalidationRequestMarshaller : IMarshaller<IRequest, CreateInvalidationRequest>
    {
        
    
        public IRequest Marshall(CreateInvalidationRequest createInvalidationRequest)
        {
            IRequest request = new DefaultRequest(createInvalidationRequest, "AmazonCloudFront");



            request.HttpMethod = "POST";
            string uriResourcePath = "2013-11-11/distribution/{DistributionId}/invalidation"; 
            uriResourcePath = uriResourcePath.Replace("{DistributionId}", createInvalidationRequest.IsSetDistributionId() ? createInvalidationRequest.DistributionId.ToString() : "" ); 

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
            
             
            StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
                {
                       
                    if (createInvalidationRequest != null) 
        {
            InvalidationBatch invalidationBatchInvalidationBatch = createInvalidationRequest.InvalidationBatch;
            if (invalidationBatchInvalidationBatch != null) 
            {
                xmlWriter.WriteStartElement("InvalidationBatch", "http://cloudfront.amazonaws.com/doc/2013-11-11/");
                if (invalidationBatchInvalidationBatch != null) 
                {
                    Paths pathsPaths = invalidationBatchInvalidationBatch.Paths;
                    if (pathsPaths != null) 
                    {
                        xmlWriter.WriteStartElement("Paths", "http://cloudfront.amazonaws.com/doc/2013-11-11/");
                        if (pathsPaths.IsSetQuantity()) 
                        {
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2013-11-11/", pathsPaths.Quantity.ToString(CultureInfo.InvariantCulture));
                          }

                        if (pathsPaths != null) 
                        {
                            List<string> pathsPathsitemsList = pathsPaths.Items;
                            if (pathsPathsitemsList != null && pathsPathsitemsList.Count > 0) 
                            {
                                int pathsPathsitemsListIndex = 1;
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2013-11-11/");
                                foreach (string pathsPathsitemsListValue in pathsPathsitemsList) 
                                {
                                    xmlWriter.WriteStartElement("Path", "http://cloudfront.amazonaws.com/doc/2013-11-11/");
                                    xmlWriter.WriteValue(pathsPathsitemsListValue);
                                xmlWriter.WriteEndElement();


                                    pathsPathsitemsListIndex++;
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if (invalidationBatchInvalidationBatch.IsSetCallerReference()) 
                {
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2013-11-11/", invalidationBatchInvalidationBatch.CallerReference.ToString(CultureInfo.InvariantCulture));
                  }
                xmlWriter.WriteEndElement();
            }
        }

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
    
