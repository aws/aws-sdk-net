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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
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
    /// CreatePublicKey Request Marshaller
    /// </summary>       
    public class CreatePublicKeyRequestMarshaller : IMarshaller<IRequest, CreatePublicKeyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePublicKeyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePublicKeyRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            string uriResourcePath = "/2017-10-30/public-key";
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("PublicKeyConfig", "http://cloudfront.amazonaws.com/doc/2017-10-30/");                                
                if(publicRequest.PublicKeyConfig.IsSetCallerReference())
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.PublicKeyConfig.CallerReference));                    

                if(publicRequest.PublicKeyConfig.IsSetComment())
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.PublicKeyConfig.Comment));                    

                if(publicRequest.PublicKeyConfig.IsSetEncodedKey())
                    xmlWriter.WriteElementString("EncodedKey", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.PublicKeyConfig.EncodedKey));                    

                if(publicRequest.PublicKeyConfig.IsSetName())
                    xmlWriter.WriteElementString("Name", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.PublicKeyConfig.Name));                    


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
        private static CreatePublicKeyRequestMarshaller _instance = new CreatePublicKeyRequestMarshaller();        

        internal static CreatePublicKeyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePublicKeyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}