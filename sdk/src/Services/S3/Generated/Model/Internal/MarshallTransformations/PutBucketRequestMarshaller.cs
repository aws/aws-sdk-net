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
    public class PutBucketRequestMarshaller : IMarshaller<IRequest, PutBucketRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
        
            if (publicRequest.IsSetACL()) 
            {
                request.Headers["x-amz-acl"] = publicRequest.ACL;
            }
        
            if (publicRequest.IsSetGrantFullControl()) 
            {
                request.Headers["x-amz-grant-full-control"] = publicRequest.GrantFullControl;
            }
        
            if (publicRequest.IsSetGrantRead()) 
            {
                request.Headers["x-amz-grant-read"] = publicRequest.GrantRead;
            }
        
            if (publicRequest.IsSetGrantReadACP()) 
            {
                request.Headers["x-amz-grant-read-acp"] = publicRequest.GrantReadACP;
            }
        
            if (publicRequest.IsSetGrantWrite()) 
            {
                request.Headers["x-amz-grant-write"] = publicRequest.GrantWrite;
            }
        
            if (publicRequest.IsSetGrantWriteACP()) 
            {
                request.Headers["x-amz-grant-write-acp"] = publicRequest.GrantWriteACP;
            }
        
            if (publicRequest.IsSetObjectLockEnabledForBucket()) 
            {
                request.Headers["x-amz-bucket-object-lock-enabled"] = StringUtils.FromBool(publicRequest.ObjectLockEnabledForBucket);
            }
        
            if (publicRequest.IsSetObjectOwnership()) 
            {
                request.Headers["x-amz-object-ownership"] = publicRequest.ObjectOwnership;
            }
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            request.ResourcePath = "/{Bucket}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetCreateBucketConfiguration())
                {
                    xmlWriter.WriteStartElement("CreateBucketConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (publicRequest.CreateBucketConfiguration.BucketName != null)
                    {
                        xmlWriter.WriteStartElement("Bucket");
                        if(publicRequest.CreateBucketConfiguration.BucketName.IsSetDataRedundancy())
                            xmlWriter.WriteElementString("DataRedundancy", StringUtils.FromString(publicRequest.CreateBucketConfiguration.BucketName.DataRedundancy));
                        if(publicRequest.CreateBucketConfiguration.BucketName.IsSetType())
                            xmlWriter.WriteElementString("Type", StringUtils.FromString(publicRequest.CreateBucketConfiguration.BucketName.Type));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.CreateBucketConfiguration.Location != null)
                    {
                        xmlWriter.WriteStartElement("Location");
                        if(publicRequest.CreateBucketConfiguration.Location.IsSetName())
                            xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequest.CreateBucketConfiguration.Location.Name));
                        if(publicRequest.CreateBucketConfiguration.Location.IsSetType())
                            xmlWriter.WriteElementString("Type", StringUtils.FromString(publicRequest.CreateBucketConfiguration.Location.Type));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.CreateBucketConfiguration.IsSetLocationConstraint())
                        xmlWriter.WriteElementString("LocationConstraint", StringUtils.FromString(publicRequest.CreateBucketConfiguration.LocationConstraint));


                    xmlWriter.WriteEndElement();
                }
            }
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

    }    
}