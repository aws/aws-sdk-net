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
    /// CreateHostedZone Request Marshaller
    /// </summary>       
    public partial class CreateHostedZoneRequestMarshaller : IMarshaller<IRequest, CreateHostedZoneRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateHostedZoneRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateHostedZoneRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2013-04-01/hostedzone";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("CreateHostedZoneRequest", "https://route53.amazonaws.com/doc/2013-04-01/");
                if(publicRequest.IsSetName())
                    xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.Name));

                if (publicRequest.VPC != null)
                {
                    xmlWriter.WriteStartElement("VPC");
                    if(publicRequest.VPC.IsSetVPCRegion())
                        xmlWriter.WriteElementString("VPCRegion", StringUtils.FromString(publicRequest.VPC.VPCRegion));
                    if(publicRequest.VPC.IsSetVPCId())
                        xmlWriter.WriteElementString("VPCId", StringUtils.FromString(publicRequest.VPC.VPCId));
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetCallerReference())
                    xmlWriter.WriteElementString("CallerReference", StringUtils.FromString(publicRequest.CallerReference));

                if (publicRequest.HostedZoneConfig != null)
                {
                    xmlWriter.WriteStartElement("HostedZoneConfig");
                    if(publicRequest.HostedZoneConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.HostedZoneConfig.Comment));
                    if(publicRequest.HostedZoneConfig.IsSetPrivateZone())
                        xmlWriter.WriteElementString("PrivateZone", StringUtils.FromBool(publicRequest.HostedZoneConfig.PrivateZone.Value));
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetDelegationSetId())
                    xmlWriter.WriteElementString("DelegationSetId", StringUtils.FromString(publicRequest.DelegationSetId));


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
        private static CreateHostedZoneRequestMarshaller _instance = new CreateHostedZoneRequestMarshaller();        

        internal static CreateHostedZoneRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateHostedZoneRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateHostedZoneRequest publicRequest);
    }    
}