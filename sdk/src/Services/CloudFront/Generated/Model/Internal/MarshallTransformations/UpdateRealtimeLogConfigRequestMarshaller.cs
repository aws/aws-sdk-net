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

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRealtimeLogConfig Request Marshaller
    /// </summary>       
    public class UpdateRealtimeLogConfigRequestMarshaller : IMarshaller<IRequest, UpdateRealtimeLogConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRealtimeLogConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRealtimeLogConfigRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "PUT";
            request.ResourcePath = "/2020-05-31/realtime-log-config/";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("UpdateRealtimeLogConfigRequest", "http://cloudfront.amazonaws.com/doc/2020-05-31/");    
                if(publicRequest.IsSetARN())
                    xmlWriter.WriteElementString("ARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.ARN));                    

                var publicRequestEndPoints = publicRequest.EndPoints;
                if (publicRequestEndPoints != null && publicRequestEndPoints.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("EndPoints", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    foreach (var publicRequestEndPointsValue in publicRequestEndPoints) 
                    {
                
                    if (publicRequestEndPointsValue != null) 
                    {
                        xmlWriter.WriteStartElement("member", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                
                        if (publicRequestEndPointsValue.KinesisStreamConfig != null) 
                        {
                            xmlWriter.WriteStartElement("KinesisStreamConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            if(publicRequestEndPointsValue.KinesisStreamConfig.IsSetRoleARN())
                                xmlWriter.WriteElementString("RoleARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestEndPointsValue.KinesisStreamConfig.RoleARN));                 

                            if(publicRequestEndPointsValue.KinesisStreamConfig.IsSetStreamARN())
                                xmlWriter.WriteElementString("StreamARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestEndPointsValue.KinesisStreamConfig.StreamARN));                 

                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequestEndPointsValue.IsSetStreamType())
                            xmlWriter.WriteElementString("StreamType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestEndPointsValue.StreamType));                 

                        xmlWriter.WriteEndElement();
                    }
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestFields = publicRequest.Fields;
                if (publicRequestFields != null && publicRequestFields.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("Fields", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    foreach (var publicRequestFieldsValue in publicRequestFields) 
                    {
                        xmlWriter.WriteStartElement("Field", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                        xmlWriter.WriteValue(publicRequestFieldsValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetName())
                    xmlWriter.WriteElementString("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.Name));                    

                if(publicRequest.IsSetSamplingRate())
                    xmlWriter.WriteElementString("SamplingRate", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.SamplingRate));                    


                xmlWriter.WriteEndElement();
            }
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
        private static UpdateRealtimeLogConfigRequestMarshaller _instance = new UpdateRealtimeLogConfigRequestMarshaller();        

        internal static UpdateRealtimeLogConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRealtimeLogConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}