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
    /// UpdateOriginAccessControl Request Marshaller
    /// </summary>       
    public partial class UpdateOriginAccessControlRequestMarshaller : IMarshaller<IRequest, UpdateOriginAccessControlRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOriginAccessControlRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOriginAccessControlRequest publicRequest)
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
            request.ResourcePath = "/2020-05-31/origin-access-control/{Id}/config";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetOriginAccessControlConfig())
                {
                    xmlWriter.WriteStartElement("OriginAccessControlConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if(publicRequest.OriginAccessControlConfig.IsSetDescription())
                        xmlWriter.WriteElementString("Description", StringUtils.FromString(publicRequest.OriginAccessControlConfig.Description));

                    if(publicRequest.OriginAccessControlConfig.IsSetName())
                        xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.OriginAccessControlConfig.Name));

                    if(publicRequest.OriginAccessControlConfig.IsSetOriginAccessControlOriginType())
                        xmlWriter.WriteElementString("OriginAccessControlOriginType", StringUtils.FromString(publicRequest.OriginAccessControlConfig.OriginAccessControlOriginType));

                    if(publicRequest.OriginAccessControlConfig.IsSetSigningBehavior())
                        xmlWriter.WriteElementString("SigningBehavior", StringUtils.FromString(publicRequest.OriginAccessControlConfig.SigningBehavior));

                    if(publicRequest.OriginAccessControlConfig.IsSetSigningProtocol())
                        xmlWriter.WriteElementString("SigningProtocol", StringUtils.FromString(publicRequest.OriginAccessControlConfig.SigningProtocol));


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
        private static UpdateOriginAccessControlRequestMarshaller _instance = new UpdateOriginAccessControlRequestMarshaller();        

        internal static UpdateOriginAccessControlRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOriginAccessControlRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateOriginAccessControlRequest publicRequest);
    }    
}