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
    /// UpdateFieldLevelEncryptionProfile Request Marshaller
    /// </summary>       
    public partial class UpdateFieldLevelEncryptionProfileRequestMarshaller : IMarshaller<IRequest, UpdateFieldLevelEncryptionProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFieldLevelEncryptionProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFieldLevelEncryptionProfileRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
            if (!publicRequest.IsSetId())
                throw new AmazonCloudFrontException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/2020-05-31/field-level-encryption-profile/{Id}/config";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetFieldLevelEncryptionProfileConfig())
                {
                    xmlWriter.WriteStartElement("FieldLevelEncryptionProfileConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if(publicRequest.FieldLevelEncryptionProfileConfig.IsSetCallerReference())
                        xmlWriter.WriteElementString("CallerReference", StringUtils.FromString(publicRequest.FieldLevelEncryptionProfileConfig.CallerReference));

                    if(publicRequest.FieldLevelEncryptionProfileConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.FieldLevelEncryptionProfileConfig.Comment));

                    if (publicRequest.FieldLevelEncryptionProfileConfig.EncryptionEntities != null)
                    {
                        xmlWriter.WriteStartElement("EncryptionEntities");
                        var publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItems = publicRequest.FieldLevelEncryptionProfileConfig.EncryptionEntities.Items;
                        if (publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItems != null && (publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue in publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItems) 
                            {
                            if (publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue != null)
                            {
                                xmlWriter.WriteStartElement("EncryptionEntity");
                                if (publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.FieldPatterns != null)
                                {
                                    xmlWriter.WriteStartElement("FieldPatterns");
                                    var publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItems = publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.FieldPatterns.Items;
                                    if (publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItems != null && (publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItemsValue in publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItems) 
                                        {
                                            xmlWriter.WriteStartElement("FieldPattern");
                                            xmlWriter.WriteValue(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.FieldPatterns.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.FieldPatterns.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.IsSetProviderId())
                                    xmlWriter.WriteElementString("ProviderId", StringUtils.FromString(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.ProviderId));
                                if(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.IsSetPublicKeyId())
                                    xmlWriter.WriteElementString("PublicKeyId", StringUtils.FromString(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.PublicKeyId));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.FieldLevelEncryptionProfileConfig.EncryptionEntities.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.FieldLevelEncryptionProfileConfig.EncryptionEntities.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.FieldLevelEncryptionProfileConfig.IsSetName())
                        xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.FieldLevelEncryptionProfileConfig.Name));


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
        private static UpdateFieldLevelEncryptionProfileRequestMarshaller _instance = new UpdateFieldLevelEncryptionProfileRequestMarshaller();        

        internal static UpdateFieldLevelEncryptionProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFieldLevelEncryptionProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateFieldLevelEncryptionProfileRequest publicRequest);
    }    
}