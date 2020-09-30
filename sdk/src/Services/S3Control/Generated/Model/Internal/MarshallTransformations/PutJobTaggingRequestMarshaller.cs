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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutJobTagging Request Marshaller
    /// </summary>       
    public class PutJobTaggingRequestMarshaller : IMarshaller<IRequest, PutJobTaggingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutJobTaggingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutJobTaggingRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "PUT";
        
            if(publicRequest.IsSetAccountId())
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            if (!publicRequest.IsSetJobId())
                throw new AmazonS3ControlException("Request object does not have required field JobId set");
            request.AddPathResource("{id}", StringUtils.FromString(publicRequest.JobId));
            request.ResourcePath = "/v20180820/jobs/{id}/tagging";
            request.MarshallerVersion = 2;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("PutJobTaggingRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");    
                var publicRequestTags = publicRequest.Tags;
                if (publicRequestTags != null && publicRequestTags.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("Tags", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                    foreach (var publicRequestTagsValue in publicRequestTags) 
                    {
                    
                    if (publicRequestTagsValue != null) 
                    {
                        xmlWriter.WriteStartElement("member", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        if(publicRequestTagsValue.IsSetKey())
                            xmlWriter.WriteElementString("Key", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestTagsValue.Key));                 
        
                        if(publicRequestTagsValue.IsSetValue())
                            xmlWriter.WriteElementString("Value", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestTagsValue.Value));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    }            
                    xmlWriter.WriteEndElement();            
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }


            var hostPrefixLabels = new
            {
                AccountId = StringUtils.FromString(publicRequest.AccountId),
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.AccountId))
                throw new AmazonS3ControlException("AccountId can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");        
            
            request.HostPrefix = $"{hostPrefixLabels.AccountId}.";
            return request;
        }
        private static PutJobTaggingRequestMarshaller _instance = new PutJobTaggingRequestMarshaller();        

        internal static PutJobTaggingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutJobTaggingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}