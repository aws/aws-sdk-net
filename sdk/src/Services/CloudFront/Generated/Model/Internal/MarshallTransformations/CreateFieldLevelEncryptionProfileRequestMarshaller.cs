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
    /// CreateFieldLevelEncryptionProfile Request Marshaller
    /// </summary>       
    public class CreateFieldLevelEncryptionProfileRequestMarshaller : IMarshaller<IRequest, CreateFieldLevelEncryptionProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFieldLevelEncryptionProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFieldLevelEncryptionProfileRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            string uriResourcePath = "/2017-10-30/field-level-encryption-profile";
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("FieldLevelEncryptionProfileConfig", "http://cloudfront.amazonaws.com/doc/2017-10-30/");                                
                if(publicRequest.FieldLevelEncryptionProfileConfig.IsSetCallerReference())
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.FieldLevelEncryptionProfileConfig.CallerReference));                    

                if(publicRequest.FieldLevelEncryptionProfileConfig.IsSetComment())
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.FieldLevelEncryptionProfileConfig.Comment));                    

                
                if (publicRequest.FieldLevelEncryptionProfileConfig.EncryptionEntities != null) 
                {
                    xmlWriter.WriteStartElement("EncryptionEntities", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                    var publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItems = publicRequest.FieldLevelEncryptionProfileConfig.EncryptionEntities.Items;
                    if (publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItems != null && publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                        foreach (var publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue in publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItems) 
                        {
                        
                        if (publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue != null) 
                        {
                            xmlWriter.WriteStartElement("EncryptionEntity", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                            
                            if (publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.FieldPatterns != null) 
                            {
                                xmlWriter.WriteStartElement("FieldPatterns", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                var publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItems = publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.FieldPatterns.Items;
                                if (publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItems != null && publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                    foreach (var publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItemsValue in publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItems) 
                                    {
                                        xmlWriter.WriteStartElement("FieldPattern", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                        xmlWriter.WriteValue(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValueFieldPatternsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.FieldPatterns.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.FieldPatterns.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.IsSetProviderId())
                                xmlWriter.WriteElementString("ProviderId", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.ProviderId));                 
            
                            if(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.IsSetPublicKeyId())
                                xmlWriter.WriteElementString("PublicKeyId", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestFieldLevelEncryptionProfileConfigEncryptionEntitiesItemsValue.PublicKeyId));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.FieldLevelEncryptionProfileConfig.EncryptionEntities.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.FieldLevelEncryptionProfileConfig.EncryptionEntities.Quantity));                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.FieldLevelEncryptionProfileConfig.IsSetName())
                    xmlWriter.WriteElementString("Name", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.FieldLevelEncryptionProfileConfig.Name));                    


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
        private static CreateFieldLevelEncryptionProfileRequestMarshaller _instance = new CreateFieldLevelEncryptionProfileRequestMarshaller();        

        internal static CreateFieldLevelEncryptionProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFieldLevelEncryptionProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}