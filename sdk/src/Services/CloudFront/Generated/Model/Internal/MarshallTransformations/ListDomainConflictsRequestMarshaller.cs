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
    /// ListDomainConflicts Request Marshaller
    /// </summary>       
    public partial class ListDomainConflictsRequestMarshaller : IMarshaller<IRequest, ListDomainConflictsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListDomainConflictsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListDomainConflictsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/domain-conflicts";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("ListDomainConflictsRequest", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                if(publicRequest.IsSetDomain())
                    xmlWriter.WriteElementString("Domain", StringUtils.FromString(publicRequest.Domain));

                if (publicRequest.DomainControlValidationResource != null)
                {
                    xmlWriter.WriteStartElement("DomainControlValidationResource");
                    if(publicRequest.DomainControlValidationResource.IsSetDistributionId())
                        xmlWriter.WriteElementString("DistributionId", StringUtils.FromString(publicRequest.DomainControlValidationResource.DistributionId));
                    if(publicRequest.DomainControlValidationResource.IsSetDistributionTenantId())
                        xmlWriter.WriteElementString("DistributionTenantId", StringUtils.FromString(publicRequest.DomainControlValidationResource.DistributionTenantId));
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetMarker())
                    xmlWriter.WriteElementString("Marker", StringUtils.FromString(publicRequest.Marker));

                if(publicRequest.IsSetMaxItems())
                    xmlWriter.WriteElementString("MaxItems", StringUtils.FromInt(publicRequest.MaxItems.Value));


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
        private static ListDomainConflictsRequestMarshaller _instance = new ListDomainConflictsRequestMarshaller();        

        internal static ListDomainConflictsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListDomainConflictsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, ListDomainConflictsRequest publicRequest);
    }    
}