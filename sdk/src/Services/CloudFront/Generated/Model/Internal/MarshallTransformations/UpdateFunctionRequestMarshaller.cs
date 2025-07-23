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
    /// UpdateFunction Request Marshaller
    /// </summary>       
    public partial class UpdateFunctionRequestMarshaller : IMarshaller<IRequest, UpdateFunctionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFunctionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFunctionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
            if (!publicRequest.IsSetName())
                throw new AmazonCloudFrontException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/2020-05-31/function/{Name}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("UpdateFunctionRequest", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                if(publicRequest.IsSetFunctionCode())
                    xmlWriter.WriteElementString("FunctionCode", StringUtils.FromMemoryStream(publicRequest.FunctionCode));

                if (publicRequest.FunctionConfig != null)
                {
                    xmlWriter.WriteStartElement("FunctionConfig");
                    if(publicRequest.FunctionConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.FunctionConfig.Comment));
                    if (publicRequest.FunctionConfig.KeyValueStoreAssociations != null)
                    {
                        xmlWriter.WriteStartElement("KeyValueStoreAssociations");
                        var publicRequestFunctionConfigKeyValueStoreAssociationsItems = publicRequest.FunctionConfig.KeyValueStoreAssociations.Items;
                        if (publicRequestFunctionConfigKeyValueStoreAssociationsItems != null && (publicRequestFunctionConfigKeyValueStoreAssociationsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestFunctionConfigKeyValueStoreAssociationsItemsValue in publicRequestFunctionConfigKeyValueStoreAssociationsItems) 
                            {
                            if (publicRequestFunctionConfigKeyValueStoreAssociationsItemsValue != null)
                            {
                                xmlWriter.WriteStartElement("KeyValueStoreAssociation");
                                if(publicRequestFunctionConfigKeyValueStoreAssociationsItemsValue.IsSetKeyValueStoreARN())
                                    xmlWriter.WriteElementString("KeyValueStoreARN", StringUtils.FromString(publicRequestFunctionConfigKeyValueStoreAssociationsItemsValue.KeyValueStoreARN));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.FunctionConfig.KeyValueStoreAssociations.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.FunctionConfig.KeyValueStoreAssociations.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.FunctionConfig.IsSetRuntime())
                        xmlWriter.WriteElementString("Runtime", StringUtils.FromString(publicRequest.FunctionConfig.Runtime));
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
        private static UpdateFunctionRequestMarshaller _instance = new UpdateFunctionRequestMarshaller();        

        internal static UpdateFunctionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFunctionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateFunctionRequest publicRequest);
    }    
}