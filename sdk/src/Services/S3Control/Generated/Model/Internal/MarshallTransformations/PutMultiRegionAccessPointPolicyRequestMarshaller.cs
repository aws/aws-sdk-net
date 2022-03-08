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
    /// PutMultiRegionAccessPointPolicy Request Marshaller
    /// </summary>       
    public class PutMultiRegionAccessPointPolicyRequestMarshaller : IMarshaller<IRequest, PutMultiRegionAccessPointPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMultiRegionAccessPointPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMultiRegionAccessPointPolicyRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "POST";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            request.ResourcePath = "/v20180820/async-requests/mrap/put-policy";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("PutMultiRegionAccessPointPolicyRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");    
                if(publicRequest.IsSetClientToken())
                    xmlWriter.WriteElementString("ClientToken", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.ClientToken));                    
                else                
                    xmlWriter.WriteElementString("ClientToken", "http://awss3control.amazonaws.com/doc/2018-08-20/", Guid.NewGuid().ToString());                

                
                if (publicRequest.Details != null) 
                {
                    xmlWriter.WriteStartElement("Details", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                    if(publicRequest.Details.IsSetName())
                        xmlWriter.WriteElementString("Name", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Details.Name));                 
    
                    if(publicRequest.Details.IsSetPolicy())
                        xmlWriter.WriteElementString("Policy", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Details.Policy));                 
    
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                ChecksumUtils.SetRequestChecksumMD5(request);
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
        private static PutMultiRegionAccessPointPolicyRequestMarshaller _instance = new PutMultiRegionAccessPointPolicyRequestMarshaller();        

        internal static PutMultiRegionAccessPointPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMultiRegionAccessPointPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}