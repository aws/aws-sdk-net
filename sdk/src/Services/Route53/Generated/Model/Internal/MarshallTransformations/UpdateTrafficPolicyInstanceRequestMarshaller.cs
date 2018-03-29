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
    /// UpdateTrafficPolicyInstance Request Marshaller
    /// </summary>       
    public class UpdateTrafficPolicyInstanceRequestMarshaller : IMarshaller<IRequest, UpdateTrafficPolicyInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTrafficPolicyInstanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTrafficPolicyInstanceRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "POST";
            string uriResourcePath = "/2013-04-01/trafficpolicyinstance/{Id}";
            if (!publicRequest.IsSetId())
                throw new AmazonRoute53Exception("Request object does not have required field Id set");
            uriResourcePath = uriResourcePath.Replace("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("UpdateTrafficPolicyInstanceRequest", "https://route53.amazonaws.com/doc/2013-04-01/");    
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
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static UpdateTrafficPolicyInstanceRequestMarshaller _instance = new UpdateTrafficPolicyInstanceRequestMarshaller();        

        internal static UpdateTrafficPolicyInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTrafficPolicyInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}