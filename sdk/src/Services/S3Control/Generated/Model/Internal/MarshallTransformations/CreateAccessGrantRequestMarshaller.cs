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

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAccessGrant Request Marshaller
    /// </summary>       
    public partial class CreateAccessGrantRequestMarshaller : IMarshaller<IRequest, CreateAccessGrantRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAccessGrantRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAccessGrantRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "POST";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            request.ResourcePath = "/v20180820/accessgrantsinstance/grant";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("CreateAccessGrantRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                if (publicRequest.AccessGrantsLocationConfiguration != null)
                {
                    xmlWriter.WriteStartElement("AccessGrantsLocationConfiguration");
                    if(publicRequest.AccessGrantsLocationConfiguration.IsSetS3SubPrefix())
                        xmlWriter.WriteElementString("S3SubPrefix", StringUtils.FromString(publicRequest.AccessGrantsLocationConfiguration.S3SubPrefix));
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetAccessGrantsLocationId())
                    xmlWriter.WriteElementString("AccessGrantsLocationId", StringUtils.FromString(publicRequest.AccessGrantsLocationId));

                if(publicRequest.IsSetApplicationArn())
                    xmlWriter.WriteElementString("ApplicationArn", StringUtils.FromString(publicRequest.ApplicationArn));

                if (publicRequest.Grantee != null)
                {
                    xmlWriter.WriteStartElement("Grantee");
                    if(publicRequest.Grantee.IsSetGranteeIdentifier())
                        xmlWriter.WriteElementString("GranteeIdentifier", StringUtils.FromString(publicRequest.Grantee.GranteeIdentifier));
                    if(publicRequest.Grantee.IsSetGranteeType())
                        xmlWriter.WriteElementString("GranteeType", StringUtils.FromString(publicRequest.Grantee.GranteeType));
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetPermission())
                    xmlWriter.WriteElementString("Permission", StringUtils.FromString(publicRequest.Permission));

                if(publicRequest.IsSetS3PrefixType())
                    xmlWriter.WriteElementString("S3PrefixType", StringUtils.FromString(publicRequest.S3PrefixType));

                var publicRequestTags = publicRequest.Tags;
                if (publicRequestTags != null && (publicRequestTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("Tags");
                    foreach (var publicRequestTagsValue in publicRequestTags) 
                    {
                    if (publicRequestTagsValue != null)
                    {
                        xmlWriter.WriteStartElement("Tag");
                        if(publicRequestTagsValue.IsSetKey())
                            xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestTagsValue.Key));
                        if(publicRequestTagsValue.IsSetValue())
                            xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestTagsValue.Value));
                        xmlWriter.WriteEndElement();
                    }
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
                ChecksumUtils.SetChecksumData(request);
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static CreateAccessGrantRequestMarshaller _instance = new CreateAccessGrantRequestMarshaller();        

        internal static CreateAccessGrantRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAccessGrantRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateAccessGrantRequest publicRequest);
    }    
}