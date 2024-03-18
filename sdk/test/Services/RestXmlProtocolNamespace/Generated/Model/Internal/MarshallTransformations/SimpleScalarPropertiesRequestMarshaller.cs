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
 * Do not modify this file. This file is generated from the rest-xml-protocol-namespace-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocolNamespace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.RestXmlProtocolNamespace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SimpleScalarProperties Request Marshaller
    /// </summary>       
    public class SimpleScalarPropertiesRequestMarshaller : IMarshaller<IRequest, SimpleScalarPropertiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SimpleScalarPropertiesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SimpleScalarPropertiesRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocolNamespace");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetFoo()) 
            {
                request.Headers["X-Foo"] = publicRequest.Foo;
            }
            request.ResourcePath = "/SimpleScalarProperties";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("SimpleScalarPropertiesRequest", "https://example.com");    
                if(publicRequest.IsSetByteValue())
                    xmlWriter.WriteElementString("byteValue", "https://example.com", StringUtils.FromInt(publicRequest.ByteValue));                    

                if(publicRequest.IsSetDoubleValue())
                    xmlWriter.WriteElementString("DoubleDribble", "https://example.com", StringUtils.FromDouble(publicRequest.DoubleValue));                    

                if(publicRequest.IsSetFalseBooleanValue())
                    xmlWriter.WriteElementString("falseBooleanValue", "https://example.com", StringUtils.FromBool(publicRequest.FalseBooleanValue));                    

                if(publicRequest.IsSetFloatValue())
                    xmlWriter.WriteElementString("floatValue", "https://example.com", StringUtils.FromFloat(publicRequest.FloatValue));                    

                if(publicRequest.IsSetIntegerValue())
                    xmlWriter.WriteElementString("integerValue", "https://example.com", StringUtils.FromInt(publicRequest.IntegerValue));                    

                if(publicRequest.IsSetLongValue())
                    xmlWriter.WriteElementString("longValue", "https://example.com", StringUtils.FromLong(publicRequest.LongValue));                    

                
                if (publicRequest.Nested != null) 
                {
                    xmlWriter.WriteStartElement("Nested", "https://example.com");            
                    if(publicRequest.Nested.IsSetAttrField())
                        xmlWriter.WriteElementString("xsi:someName", "https://example.com", StringUtils.FromString(publicRequest.Nested.AttrField));                 

                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetShortValue())
                    xmlWriter.WriteElementString("shortValue", "https://example.com", StringUtils.FromInt(publicRequest.ShortValue));                    

                if(publicRequest.IsSetStringValue())
                    xmlWriter.WriteElementString("stringValue", "https://example.com", StringUtils.FromString(publicRequest.StringValue));                    

                if(publicRequest.IsSetTrueBooleanValue())
                    xmlWriter.WriteElementString("trueBooleanValue", "https://example.com", StringUtils.FromBool(publicRequest.TrueBooleanValue));                    


                xmlWriter.WriteEndElement();
            }
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
        private static SimpleScalarPropertiesRequestMarshaller _instance = new SimpleScalarPropertiesRequestMarshaller();        

        internal static SimpleScalarPropertiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimpleScalarPropertiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}