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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;
using Amazon.Util;
using Amazon.S3.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutObjectLockConfiguration Request Marshaller
    /// </summary>       
    public class PutObjectLockConfigurationRequestMarshaller : IMarshaller<IRequest, PutObjectLockConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutObjectLockConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutObjectLockConfigurationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "AmazonS3");
            request.HttpMethod = "PUT";
            string uriResourcePath = "/";
            request.AddSubResource("object-lock");

            if (publicRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(publicRequest.ChecksumAlgorithm));
            if (publicRequest.IsSetContentMD5())
                request.Headers.Add(HeaderKeys.ContentMD5Header, S3Transforms.ToStringValue(publicRequest.ContentMD5));
            if (publicRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(publicRequest.RequestPayer.ToString()));
            if (publicRequest.IsSetToken())
                request.Headers.Add("x-amz-bucket-object-lock-token", publicRequest.Token);
            if (publicRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(publicRequest.ExpectedBucketOwner));
            if (!publicRequest.IsSetBucketName())
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "publicRequest.BucketName");
            
			request.ResourcePath = uriResourcePath;

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetObjectLockConfiguration())
                {
                    xmlWriter.WriteStartElement("ObjectLockConfiguration", S3Constants.S3RequestXmlNamespace);
                    if(publicRequest.ObjectLockConfiguration.IsSetObjectLockEnabled())
                        xmlWriter.WriteElementString("ObjectLockEnabled", StringUtils.FromString(publicRequest.ObjectLockConfiguration.ObjectLockEnabled));


                    if (publicRequest.ObjectLockConfiguration.Rule != null) 
                    {
                        
                        xmlWriter.WriteStartElement("Rule");            
                        
                        
                        if (publicRequest.ObjectLockConfiguration.Rule.DefaultRetention != null) 
                        {
                            
                            xmlWriter.WriteStartElement("DefaultRetention");            
                            
                            if(publicRequest.ObjectLockConfiguration.Rule.DefaultRetention.IsSetDays())
                                xmlWriter.WriteElementString("Days", StringUtils.FromInt(publicRequest.ObjectLockConfiguration.Rule.DefaultRetention.Days));                 
            
                            if(publicRequest.ObjectLockConfiguration.Rule.DefaultRetention.IsSetMode())
                                xmlWriter.WriteElementString("Mode", StringUtils.FromString(publicRequest.ObjectLockConfiguration.Rule.DefaultRetention.Mode));                 
            
                            if(publicRequest.ObjectLockConfiguration.Rule.DefaultRetention.IsSetYears())
                                xmlWriter.WriteElementString("Years", StringUtils.FromInt(publicRequest.ObjectLockConfiguration.Rule.DefaultRetention.Years));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
    
                    xmlWriter.WriteEndElement();
                }
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetRequestChecksum(request, publicRequest.ChecksumAlgorithm);
            }
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        
        private static PutObjectLockConfigurationRequestMarshaller _instance;
        
        public static PutObjectLockConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutObjectLockConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }

    }    
}