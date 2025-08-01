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
    /// CreateDistributionTenant Request Marshaller
    /// </summary>       
    public partial class CreateDistributionTenantRequestMarshaller : IMarshaller<IRequest, CreateDistributionTenantRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDistributionTenantRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDistributionTenantRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/distribution-tenant";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("CreateDistributionTenantRequest", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                if(publicRequest.IsSetConnectionGroupId())
                    xmlWriter.WriteElementString("ConnectionGroupId", StringUtils.FromString(publicRequest.ConnectionGroupId));

                if (publicRequest.Customizations != null)
                {
                    xmlWriter.WriteStartElement("Customizations");
                    if (publicRequest.Customizations.Certificate != null)
                    {
                        xmlWriter.WriteStartElement("Certificate");
                        if(publicRequest.Customizations.Certificate.IsSetArn())
                            xmlWriter.WriteElementString("Arn", StringUtils.FromString(publicRequest.Customizations.Certificate.Arn));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Customizations.GeoRestrictions != null)
                    {
                        xmlWriter.WriteStartElement("GeoRestrictions");
                        var publicRequestCustomizationsGeoRestrictionsLocations = publicRequest.Customizations.GeoRestrictions.Locations;
                        if (publicRequestCustomizationsGeoRestrictionsLocations != null && (publicRequestCustomizationsGeoRestrictionsLocations.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Locations");
                            foreach (var publicRequestCustomizationsGeoRestrictionsLocationsValue in publicRequestCustomizationsGeoRestrictionsLocations) 
                            {
                                xmlWriter.WriteStartElement("Location");
                                xmlWriter.WriteValue(publicRequestCustomizationsGeoRestrictionsLocationsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.Customizations.GeoRestrictions.IsSetRestrictionType())
                            xmlWriter.WriteElementString("RestrictionType", StringUtils.FromString(publicRequest.Customizations.GeoRestrictions.RestrictionType));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Customizations.WebAcl != null)
                    {
                        xmlWriter.WriteStartElement("WebAcl");
                        if(publicRequest.Customizations.WebAcl.IsSetAction())
                            xmlWriter.WriteElementString("Action", StringUtils.FromString(publicRequest.Customizations.WebAcl.Action));
                        if(publicRequest.Customizations.WebAcl.IsSetArn())
                            xmlWriter.WriteElementString("Arn", StringUtils.FromString(publicRequest.Customizations.WebAcl.Arn));
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetDistributionId())
                    xmlWriter.WriteElementString("DistributionId", StringUtils.FromString(publicRequest.DistributionId));

                var publicRequestDomains = publicRequest.Domains;
                if (publicRequestDomains != null && (publicRequestDomains.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("Domains");
                    foreach (var publicRequestDomainsValue in publicRequestDomains) 
                    {
                    if (publicRequestDomainsValue != null)
                    {
                        xmlWriter.WriteStartElement("member");
                        if(publicRequestDomainsValue.IsSetDomain())
                            xmlWriter.WriteElementString("Domain", StringUtils.FromString(publicRequestDomainsValue.Domain));
                        xmlWriter.WriteEndElement();
                    }
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetEnabled())
                    xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.Enabled.Value));

                if (publicRequest.ManagedCertificateRequest != null)
                {
                    xmlWriter.WriteStartElement("ManagedCertificateRequest");
                    if(publicRequest.ManagedCertificateRequest.IsSetCertificateTransparencyLoggingPreference())
                        xmlWriter.WriteElementString("CertificateTransparencyLoggingPreference", StringUtils.FromString(publicRequest.ManagedCertificateRequest.CertificateTransparencyLoggingPreference));
                    if(publicRequest.ManagedCertificateRequest.IsSetPrimaryDomainName())
                        xmlWriter.WriteElementString("PrimaryDomainName", StringUtils.FromString(publicRequest.ManagedCertificateRequest.PrimaryDomainName));
                    if(publicRequest.ManagedCertificateRequest.IsSetValidationTokenHost())
                        xmlWriter.WriteElementString("ValidationTokenHost", StringUtils.FromString(publicRequest.ManagedCertificateRequest.ValidationTokenHost));
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetName())
                    xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.Name));

                var publicRequestParameters = publicRequest.Parameters;
                if (publicRequestParameters != null && (publicRequestParameters.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("Parameters");
                    foreach (var publicRequestParametersValue in publicRequestParameters) 
                    {
                    if (publicRequestParametersValue != null)
                    {
                        xmlWriter.WriteStartElement("member");
                        if(publicRequestParametersValue.IsSetName())
                            xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestParametersValue.Name));
                        if(publicRequestParametersValue.IsSetValue())
                            xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestParametersValue.Value));
                        xmlWriter.WriteEndElement();
                    }
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if (publicRequest.Tags != null)
                {
                    xmlWriter.WriteStartElement("Tags");
                    var publicRequestTagsItems = publicRequest.Tags.Items;
                    if (publicRequestTagsItems != null && (publicRequestTagsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("Items");
                        foreach (var publicRequestTagsItemsValue in publicRequestTagsItems) 
                        {
                        if (publicRequestTagsItemsValue != null)
                        {
                            xmlWriter.WriteStartElement("Tag");
                            if(publicRequestTagsItemsValue.IsSetKey())
                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestTagsItemsValue.Key));
                            if(publicRequestTagsItemsValue.IsSetValue())
                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestTagsItemsValue.Value));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    xmlWriter.WriteEndElement();
                }

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
        private static CreateDistributionTenantRequestMarshaller _instance = new CreateDistributionTenantRequestMarshaller();        

        internal static CreateDistributionTenantRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDistributionTenantRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateDistributionTenantRequest publicRequest);
    }    
}