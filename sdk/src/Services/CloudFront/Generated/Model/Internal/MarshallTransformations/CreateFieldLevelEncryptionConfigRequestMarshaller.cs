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
    /// CreateFieldLevelEncryptionConfig Request Marshaller
    /// </summary>       
    public partial class CreateFieldLevelEncryptionConfigRequestMarshaller : IMarshaller<IRequest, CreateFieldLevelEncryptionConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFieldLevelEncryptionConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFieldLevelEncryptionConfigRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/field-level-encryption";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetFieldLevelEncryptionConfig())
                {
                    xmlWriter.WriteStartElement("FieldLevelEncryptionConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if(publicRequest.FieldLevelEncryptionConfig.IsSetCallerReference())
                        xmlWriter.WriteElementString("CallerReference", StringUtils.FromString(publicRequest.FieldLevelEncryptionConfig.CallerReference));

                    if(publicRequest.FieldLevelEncryptionConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.FieldLevelEncryptionConfig.Comment));

                    if (publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig != null)
                    {
                        xmlWriter.WriteStartElement("ContentTypeProfileConfig");
                        if (publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.ContentTypeProfiles != null)
                        {
                            xmlWriter.WriteStartElement("ContentTypeProfiles");
                            var publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItems = publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.ContentTypeProfiles.Items;
                            if (publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItems != null && (publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue in publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItems) 
                                {
                                if (publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue != null)
                                {
                                    xmlWriter.WriteStartElement("ContentTypeProfile");
                                    if(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.IsSetContentType())
                                        xmlWriter.WriteElementString("ContentType", StringUtils.FromString(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.ContentType));
                                    if(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.IsSetFormat())
                                        xmlWriter.WriteElementString("Format", StringUtils.FromString(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.Format));
                                    if(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.IsSetProfileId())
                                        xmlWriter.WriteElementString("ProfileId", StringUtils.FromString(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.ProfileId));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.ContentTypeProfiles.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.ContentTypeProfiles.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.IsSetForwardWhenContentTypeIsUnknown())
                            xmlWriter.WriteElementString("ForwardWhenContentTypeIsUnknown", StringUtils.FromBool(publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.ForwardWhenContentTypeIsUnknown.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig != null)
                    {
                        xmlWriter.WriteStartElement("QueryArgProfileConfig");
                        if(publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.IsSetForwardWhenQueryArgProfileIsUnknown())
                            xmlWriter.WriteElementString("ForwardWhenQueryArgProfileIsUnknown", StringUtils.FromBool(publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.ForwardWhenQueryArgProfileIsUnknown.Value));
                        if (publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.QueryArgProfiles != null)
                        {
                            xmlWriter.WriteStartElement("QueryArgProfiles");
                            var publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems = publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.QueryArgProfiles.Items;
                            if (publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems != null && (publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue in publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems) 
                                {
                                if (publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue != null)
                                {
                                    xmlWriter.WriteStartElement("QueryArgProfile");
                                    if(publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue.IsSetProfileId())
                                        xmlWriter.WriteElementString("ProfileId", StringUtils.FromString(publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue.ProfileId));
                                    if(publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue.IsSetQueryArg())
                                        xmlWriter.WriteElementString("QueryArg", StringUtils.FromString(publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue.QueryArg));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.QueryArgProfiles.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.QueryArgProfiles.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
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
        private static CreateFieldLevelEncryptionConfigRequestMarshaller _instance = new CreateFieldLevelEncryptionConfigRequestMarshaller();        

        internal static CreateFieldLevelEncryptionConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFieldLevelEncryptionConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateFieldLevelEncryptionConfigRequest publicRequest);
    }    
}