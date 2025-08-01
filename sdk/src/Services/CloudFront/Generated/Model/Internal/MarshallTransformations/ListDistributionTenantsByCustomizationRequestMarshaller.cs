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
    /// ListDistributionTenantsByCustomization Request Marshaller
    /// </summary>       
    public partial class ListDistributionTenantsByCustomizationRequestMarshaller : IMarshaller<IRequest, ListDistributionTenantsByCustomizationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListDistributionTenantsByCustomizationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListDistributionTenantsByCustomizationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/distribution-tenants-by-customization";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("ListDistributionTenantsByCustomizationRequest", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                if(publicRequest.IsSetCertificateArn())
                    xmlWriter.WriteElementString("CertificateArn", StringUtils.FromString(publicRequest.CertificateArn));

                if(publicRequest.IsSetMarker())
                    xmlWriter.WriteElementString("Marker", StringUtils.FromString(publicRequest.Marker));

                if(publicRequest.IsSetMaxItems())
                    xmlWriter.WriteElementString("MaxItems", StringUtils.FromInt(publicRequest.MaxItems.Value));

                if(publicRequest.IsSetWebACLArn())
                    xmlWriter.WriteElementString("WebACLArn", StringUtils.FromString(publicRequest.WebACLArn));


                xmlWriter.WriteEndElement();
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
        private static ListDistributionTenantsByCustomizationRequestMarshaller _instance = new ListDistributionTenantsByCustomizationRequestMarshaller();        

        internal static ListDistributionTenantsByCustomizationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListDistributionTenantsByCustomizationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, ListDistributionTenantsByCustomizationRequest publicRequest);
    }    
}