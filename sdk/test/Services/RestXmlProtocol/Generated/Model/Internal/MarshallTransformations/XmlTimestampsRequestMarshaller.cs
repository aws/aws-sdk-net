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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// XmlTimestamps Request Marshaller
    /// </summary>       
    public partial class XmlTimestampsRequestMarshaller : IMarshaller<IRequest, XmlTimestampsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((XmlTimestampsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(XmlTimestampsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "POST";
            request.ResourcePath = "/XmlTimestamps";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("XmlTimestampsRequest", "");
                if(publicRequest.IsSetDateTime())
                    xmlWriter.WriteElementString("dateTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.DateTime.Value));

                if(publicRequest.IsSetDateTimeOnTarget())
                    xmlWriter.WriteElementString("dateTimeOnTarget", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.DateTimeOnTarget.Value));

                if(publicRequest.IsSetEpochSeconds())
                    xmlWriter.WriteElementString("epochSeconds", StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EpochSeconds.Value));

                if(publicRequest.IsSetEpochSecondsOnTarget())
                    xmlWriter.WriteElementString("epochSecondsOnTarget", StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EpochSecondsOnTarget.Value));

                if(publicRequest.IsSetHttpDate())
                    xmlWriter.WriteElementString("httpDate", StringUtils.FromDateTimeToRFC822(publicRequest.HttpDate.Value));

                if(publicRequest.IsSetHttpDateOnTarget())
                    xmlWriter.WriteElementString("httpDateOnTarget", StringUtils.FromDateTimeToRFC822(publicRequest.HttpDateOnTarget.Value));

                if(publicRequest.IsSetNormal())
                    xmlWriter.WriteElementString("normal", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Normal.Value));


                xmlWriter.WriteEndElement();
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static XmlTimestampsRequestMarshaller _instance = new XmlTimestampsRequestMarshaller();        

        internal static XmlTimestampsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XmlTimestampsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, XmlTimestampsRequest publicRequest);
    }    
}