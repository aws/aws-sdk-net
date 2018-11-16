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
    /// PutPublicAccessBlock Request Marshaller
    /// </summary>       
    public class PutPublicAccessBlockRequestMarshaller : IMarshaller<IRequest, PutPublicAccessBlockRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutPublicAccessBlockRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutPublicAccessBlockRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "PUT";
            string uriResourcePath = "/v20180820/configuration/publicAccessBlock";
        
            if(publicRequest.IsSetAccountId())
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                if (publicRequest.IsSetPublicAccessBlockConfiguration())
                {
                    xmlWriter.WriteStartElement("PublicAccessBlockConfiguration", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                    if(publicRequest.PublicAccessBlockConfiguration.IsSetBlockPublicAcls())
                        xmlWriter.WriteElementString("BlockPublicAcls", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.PublicAccessBlockConfiguration.BlockPublicAcls));                    
    
                    if(publicRequest.PublicAccessBlockConfiguration.IsSetBlockPublicPolicy())
                        xmlWriter.WriteElementString("BlockPublicPolicy", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.PublicAccessBlockConfiguration.BlockPublicPolicy));                    
    
                    if(publicRequest.PublicAccessBlockConfiguration.IsSetIgnorePublicAcls())
                        xmlWriter.WriteElementString("IgnorePublicAcls", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.PublicAccessBlockConfiguration.IgnorePublicAcls));                    
    
                    if(publicRequest.PublicAccessBlockConfiguration.IsSetRestrictPublicBuckets())
                        xmlWriter.WriteElementString("RestrictPublicBuckets", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.PublicAccessBlockConfiguration.RestrictPublicBuckets));                    
    
    
                    xmlWriter.WriteEndElement();
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
        private static PutPublicAccessBlockRequestMarshaller _instance = new PutPublicAccessBlockRequestMarshaller();        

        internal static PutPublicAccessBlockRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutPublicAccessBlockRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}