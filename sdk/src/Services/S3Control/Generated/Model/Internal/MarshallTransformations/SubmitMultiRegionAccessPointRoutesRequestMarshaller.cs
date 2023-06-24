/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SubmitMultiRegionAccessPointRoutes Request Marshaller
    /// </summary>       
    public class SubmitMultiRegionAccessPointRoutesRequestMarshaller : IMarshaller<IRequest, SubmitMultiRegionAccessPointRoutesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SubmitMultiRegionAccessPointRoutesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SubmitMultiRegionAccessPointRoutesRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "PATCH";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            if (!publicRequest.IsSetMrap())
                throw new AmazonS3ControlException("Request object does not have required field Mrap set");
            request.AddPathResource("{mrap+}", StringUtils.FromString(publicRequest.Mrap.TrimStart('/')));
            request.ResourcePath = "/v20180820/mrap/instances/{mrap+}/routes";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("SubmitMultiRegionAccessPointRoutesRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");    
                var publicRequestRouteUpdates = publicRequest.RouteUpdates;
                if (publicRequestRouteUpdates != null && publicRequestRouteUpdates.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("RouteUpdates", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                    foreach (var publicRequestRouteUpdatesValue in publicRequestRouteUpdates) 
                    {
                    
                    if (publicRequestRouteUpdatesValue != null) 
                    {
                        xmlWriter.WriteStartElement("Route", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        if(publicRequestRouteUpdatesValue.IsSetBucket())
                            xmlWriter.WriteElementString("Bucket", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestRouteUpdatesValue.Bucket));                 
        
                        if(publicRequestRouteUpdatesValue.IsSetRegion())
                            xmlWriter.WriteElementString("Region", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestRouteUpdatesValue.Region));                 
        
                        if(publicRequestRouteUpdatesValue.IsSetTrafficDialPercentage())
                            xmlWriter.WriteElementString("TrafficDialPercentage", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromInt(publicRequestRouteUpdatesValue.TrafficDialPercentage));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    }            
                    xmlWriter.WriteEndElement();            
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                ChecksumUtils.SetRequestChecksumMD5(request);
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static SubmitMultiRegionAccessPointRoutesRequestMarshaller _instance = new SubmitMultiRegionAccessPointRoutesRequestMarshaller();        

        internal static SubmitMultiRegionAccessPointRoutesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubmitMultiRegionAccessPointRoutesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}