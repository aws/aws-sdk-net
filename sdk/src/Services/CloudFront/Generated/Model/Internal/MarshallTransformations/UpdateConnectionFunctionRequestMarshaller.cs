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
    /// UpdateConnectionFunction Request Marshaller
    /// </summary>       
    public partial class UpdateConnectionFunctionRequestMarshaller : IMarshaller<IRequest, UpdateConnectionFunctionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateConnectionFunctionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateConnectionFunctionRequest publicRequest)
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
            request.ResourcePath = "/2020-05-31/connection-function/{Id}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("UpdateConnectionFunctionRequest", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                if(publicRequest.IsSetConnectionFunctionCode())
                    xmlWriter.WriteElementString("ConnectionFunctionCode", StringUtils.FromMemoryStream(publicRequest.ConnectionFunctionCode));

                if (publicRequest.IsSetConnectionFunctionConfig())
                {
                    xmlWriter.WriteStartElement("ConnectionFunctionConfig");
                    if(publicRequest.ConnectionFunctionConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.ConnectionFunctionConfig.Comment));
                    if (publicRequest.ConnectionFunctionConfig.IsSetKeyValueStoreAssociations())
                    {
                        xmlWriter.WriteStartElement("KeyValueStoreAssociations");
                        var publicRequestConnectionFunctionConfigKeyValueStoreAssociationsItems = publicRequest.ConnectionFunctionConfig.KeyValueStoreAssociations.Items;
                        if (publicRequest.ConnectionFunctionConfig.KeyValueStoreAssociations.IsSetItems()) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestConnectionFunctionConfigKeyValueStoreAssociationsItemsValue in publicRequestConnectionFunctionConfigKeyValueStoreAssociationsItems) 
                            {
                            if (publicRequestConnectionFunctionConfigKeyValueStoreAssociationsItemsValue != null)
                            {
                                xmlWriter.WriteStartElement("KeyValueStoreAssociation");
                                if(publicRequestConnectionFunctionConfigKeyValueStoreAssociationsItemsValue.IsSetKeyValueStoreARN())
                                    xmlWriter.WriteElementString("KeyValueStoreARN", StringUtils.FromString(publicRequestConnectionFunctionConfigKeyValueStoreAssociationsItemsValue.KeyValueStoreARN));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.ConnectionFunctionConfig.KeyValueStoreAssociations.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.ConnectionFunctionConfig.KeyValueStoreAssociations.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.ConnectionFunctionConfig.IsSetRuntime())
                        xmlWriter.WriteElementString("Runtime", StringUtils.FromString(publicRequest.ConnectionFunctionConfig.Runtime));
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
        private static UpdateConnectionFunctionRequestMarshaller _instance = new UpdateConnectionFunctionRequestMarshaller();        

        internal static UpdateConnectionFunctionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateConnectionFunctionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateConnectionFunctionRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, UpdateConnectionFunctionRequest publicRequest);
    }    
}