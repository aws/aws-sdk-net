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

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTrafficPolicyInstance Request Marshaller
    /// </summary>       
    public class CreateTrafficPolicyInstanceRequestMarshaller : IMarshaller<IRequest, CreateTrafficPolicyInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTrafficPolicyInstanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTrafficPolicyInstanceRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2013-04-01/trafficpolicyinstance";
            request.MarshallerVersion = 2;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("CreateTrafficPolicyInstanceRequest", "https://route53.amazonaws.com/doc/2013-04-01/");    
                if(publicRequest.IsSetHostedZoneId())
                    xmlWriter.WriteElementString("HostedZoneId", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.HostedZoneId));                    

                if(publicRequest.IsSetName())
                    xmlWriter.WriteElementString("Name", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.Name));                    

                if(publicRequest.IsSetTTL())
                    xmlWriter.WriteElementString("TTL", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromLong(publicRequest.TTL));                    

                if(publicRequest.IsSetTrafficPolicyId())
                    xmlWriter.WriteElementString("TrafficPolicyId", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromString(publicRequest.TrafficPolicyId));                    

                if(publicRequest.IsSetTrafficPolicyVersion())
                    xmlWriter.WriteElementString("TrafficPolicyVersion", "https://route53.amazonaws.com/doc/2013-04-01/", StringUtils.FromInt(publicRequest.TrafficPolicyVersion));                    


                xmlWriter.WriteEndElement();
            }
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
        private static CreateTrafficPolicyInstanceRequestMarshaller _instance = new CreateTrafficPolicyInstanceRequestMarshaller();        

        internal static CreateTrafficPolicyInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTrafficPolicyInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}