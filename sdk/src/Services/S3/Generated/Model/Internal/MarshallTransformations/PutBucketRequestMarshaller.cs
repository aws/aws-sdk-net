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

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutBucket Request Marshaller
    /// </summary>       
    public partial class PutBucketRequestMarshaller : IMarshaller<IRequest, PutBucketRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBucketRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetCannedACL()) 
            {
                request.Headers["x-amz-acl"] = publicRequest.CannedACL;
            }
        
            if (publicRequest.IsSetObjectLockEnabledForBucket()) 
            {
                request.Headers["x-amz-bucket-object-lock-enabled"] = StringUtils.FromBool(publicRequest.ObjectLockEnabledForBucket);
            }
        
            if (publicRequest.IsSetObjectOwnership()) 
            {
                request.Headers["x-amz-object-ownership"] = publicRequest.ObjectOwnership;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketRequest.BucketName");
            request.ResourcePath = "/";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetPutBucketConfiguration())
                {
                    xmlWriter.WriteStartElement("CreateBucketConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.PutBucketConfiguration.BucketInfo != null)
                    {
                        xmlWriter.WriteStartElement("Bucket");
                        if(publicRequest.PutBucketConfiguration.BucketInfo.IsSetDataRedundancy())
                            xmlWriter.WriteElementString("DataRedundancy", StringUtils.FromString(publicRequest.PutBucketConfiguration.BucketInfo.DataRedundancy));
                        if(publicRequest.PutBucketConfiguration.BucketInfo.IsSetType())
                            xmlWriter.WriteElementString("Type", StringUtils.FromString(publicRequest.PutBucketConfiguration.BucketInfo.Type));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.PutBucketConfiguration.Location != null)
                    {
                        xmlWriter.WriteStartElement("Location");
                        if(publicRequest.PutBucketConfiguration.Location.IsSetName())
                            xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.PutBucketConfiguration.Location.Name));
                        if(publicRequest.PutBucketConfiguration.Location.IsSetType())
                            xmlWriter.WriteElementString("Type", StringUtils.FromString(publicRequest.PutBucketConfiguration.Location.Type));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.PutBucketConfiguration.IsSetLocationConstraint())
                        xmlWriter.WriteElementString("LocationConstraint", StringUtils.FromString(publicRequest.PutBucketConfiguration.LocationConstraint));

                    var publicRequestPutBucketConfigurationTags = publicRequest.PutBucketConfiguration.Tags;
                    if (publicRequestPutBucketConfigurationTags != null && (publicRequestPutBucketConfigurationTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("Tags");
                        foreach (var publicRequestPutBucketConfigurationTagsValue in publicRequestPutBucketConfigurationTags) 
                        {
                        if (publicRequestPutBucketConfigurationTagsValue != null)
                        {
                            xmlWriter.WriteStartElement("Tag");
                            if(publicRequestPutBucketConfigurationTagsValue.IsSetKey())
                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestPutBucketConfigurationTagsValue.Key));
                            if(publicRequestPutBucketConfigurationTagsValue.IsSetValue())
                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestPutBucketConfigurationTagsValue.Value));
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }

                    xmlWriter.WriteEndElement();
                }
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2006-03-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static PutBucketRequestMarshaller _instance = new PutBucketRequestMarshaller();        

        internal static PutBucketRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBucketRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketRequest publicRequest);
    }    
}