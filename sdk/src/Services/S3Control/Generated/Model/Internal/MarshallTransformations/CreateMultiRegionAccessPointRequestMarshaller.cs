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
    /// CreateMultiRegionAccessPoint Request Marshaller
    /// </summary>       
    public class CreateMultiRegionAccessPointRequestMarshaller : IMarshaller<IRequest, CreateMultiRegionAccessPointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMultiRegionAccessPointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMultiRegionAccessPointRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "POST";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            request.ResourcePath = "/v20180820/async-requests/mrap/create";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("CreateMultiRegionAccessPointRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");    
                if(publicRequest.IsSetClientToken())
                    xmlWriter.WriteElementString("ClientToken", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.ClientToken));                    
                else                
                    xmlWriter.WriteElementString("ClientToken", "http://awss3control.amazonaws.com/doc/2018-08-20/", Guid.NewGuid().ToString());                

                
                if (publicRequest.Details != null) 
                {
                    xmlWriter.WriteStartElement("Details", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                    if(publicRequest.Details.IsSetName())
                        xmlWriter.WriteElementString("Name", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Details.Name));                 
    
                    
                    if (publicRequest.Details.PublicAccessBlock != null) 
                    {
                        xmlWriter.WriteStartElement("PublicAccessBlock", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        if(publicRequest.Details.PublicAccessBlock.IsSetBlockPublicAcls())
                            xmlWriter.WriteElementString("BlockPublicAcls", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.Details.PublicAccessBlock.BlockPublicAcls));                 
        
                        if(publicRequest.Details.PublicAccessBlock.IsSetBlockPublicPolicy())
                            xmlWriter.WriteElementString("BlockPublicPolicy", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.Details.PublicAccessBlock.BlockPublicPolicy));                 
        
                        if(publicRequest.Details.PublicAccessBlock.IsSetIgnorePublicAcls())
                            xmlWriter.WriteElementString("IgnorePublicAcls", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.Details.PublicAccessBlock.IgnorePublicAcls));                 
        
                        if(publicRequest.Details.PublicAccessBlock.IsSetRestrictPublicBuckets())
                            xmlWriter.WriteElementString("RestrictPublicBuckets", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.Details.PublicAccessBlock.RestrictPublicBuckets));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    var publicRequestDetailsRegions = publicRequest.Details.Regions;
                    if (publicRequestDetailsRegions != null && publicRequestDetailsRegions.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Regions", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                        foreach (var publicRequestDetailsRegionsValue in publicRequestDetailsRegions) 
                        {
                        
                        if (publicRequestDetailsRegionsValue != null) 
                        {
                            xmlWriter.WriteStartElement("Region", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            if(publicRequestDetailsRegionsValue.IsSetBucket())
                                xmlWriter.WriteElementString("Bucket", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestDetailsRegionsValue.Bucket));                 
            
                            if(publicRequestDetailsRegionsValue.IsSetBucketAccountId())
                                xmlWriter.WriteElementString("BucketAccountId", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestDetailsRegionsValue.BucketAccountId));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
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
        private static CreateMultiRegionAccessPointRequestMarshaller _instance = new CreateMultiRegionAccessPointRequestMarshaller();        

        internal static CreateMultiRegionAccessPointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMultiRegionAccessPointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}