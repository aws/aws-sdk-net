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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTrustStore Request Marshaller
    /// </summary>       
    public partial class UpdateTrustStoreRequestMarshaller : IMarshaller<IRequest, UpdateTrustStoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTrustStoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTrustStoreRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
            if (!publicRequest.IsSetId())
                throw new AmazonCloudFrontException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/2020-05-31/trust-store/{Id}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetCaCertificatesBundleSource())
                {
                    xmlWriter.WriteStartElement("CaCertificatesBundleSource", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if (publicRequest.CaCertificatesBundleSource.IsSetCaCertificatesBundleS3Location())
                    {
                        xmlWriter.WriteStartElement("CaCertificatesBundleS3Location");
                        if(publicRequest.CaCertificatesBundleSource.CaCertificatesBundleS3Location.IsSetBucket())
                            xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.CaCertificatesBundleSource.CaCertificatesBundleS3Location.Bucket));
                        if(publicRequest.CaCertificatesBundleSource.CaCertificatesBundleS3Location.IsSetKey())
                            xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequest.CaCertificatesBundleSource.CaCertificatesBundleS3Location.Key));
                        if(publicRequest.CaCertificatesBundleSource.CaCertificatesBundleS3Location.IsSetRegion())
                            xmlWriter.WriteElementString("Region", StringUtils.FromString(publicRequest.CaCertificatesBundleSource.CaCertificatesBundleS3Location.Region));
                        if(publicRequest.CaCertificatesBundleSource.CaCertificatesBundleS3Location.IsSetVersion())
                            xmlWriter.WriteElementString("Version", StringUtils.FromString(publicRequest.CaCertificatesBundleSource.CaCertificatesBundleS3Location.Version));
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
                }
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-31";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static UpdateTrustStoreRequestMarshaller _instance = new UpdateTrustStoreRequestMarshaller();        

        internal static UpdateTrustStoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTrustStoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateTrustStoreRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, UpdateTrustStoreRequest publicRequest);
    }    
}