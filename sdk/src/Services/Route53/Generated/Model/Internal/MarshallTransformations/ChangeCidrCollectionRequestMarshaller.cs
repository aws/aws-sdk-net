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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChangeCidrCollection Request Marshaller
    /// </summary>       
    public partial class ChangeCidrCollectionRequestMarshaller : IMarshaller<IRequest, ChangeCidrCollectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ChangeCidrCollectionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ChangeCidrCollectionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "POST";
            if (!publicRequest.IsSetId())
                throw new AmazonRoute53Exception("Request object does not have required field Id set");
            request.AddPathResource("{CidrCollectionId}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/2013-04-01/cidrcollection/{CidrCollectionId}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("ChangeCidrCollectionRequest", "https://route53.amazonaws.com/doc/2013-04-01/");
                if(publicRequest.IsSetCollectionVersion())
                    xmlWriter.WriteElementString("CollectionVersion", StringUtils.FromLong(publicRequest.CollectionVersion.Value));

                var publicRequestChanges = publicRequest.Changes;
                if (publicRequestChanges != null && (publicRequestChanges.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("Changes");
                    foreach (var publicRequestChangesValue in publicRequestChanges) 
                    {
                    if (publicRequestChangesValue != null)
                    {
                        xmlWriter.WriteStartElement("member");
                        if(publicRequestChangesValue.IsSetLocationName())
                            xmlWriter.WriteElementString("LocationName", StringUtils.FromString(publicRequestChangesValue.LocationName));
                        if(publicRequestChangesValue.IsSetAction())
                            xmlWriter.WriteElementString("Action", StringUtils.FromString(publicRequestChangesValue.Action));
                        var publicRequestChangesValueCidrList = publicRequestChangesValue.CidrList;
                        if (publicRequestChangesValueCidrList != null && (publicRequestChangesValueCidrList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("CidrList");
                            foreach (var publicRequestChangesValueCidrListValue in publicRequestChangesValueCidrList) 
                            {
                                xmlWriter.WriteStartElement("Cidr");
                                xmlWriter.WriteValue(publicRequestChangesValueCidrListValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-04-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static ChangeCidrCollectionRequestMarshaller _instance = new ChangeCidrCollectionRequestMarshaller();        

        internal static ChangeCidrCollectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChangeCidrCollectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, ChangeCidrCollectionRequest publicRequest);
    }    
}