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

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBucket Request Marshaller
    /// </summary>       
    public partial class CreateBucketRequestMarshaller : IMarshaller<IRequest, CreateBucketRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBucketRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBucketRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
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
        
            if (publicRequest.IsSetOutpostId()) 
            {
                request.Headers["x-amz-outpost-id"] = publicRequest.OutpostId;
            }
            if (!publicRequest.IsSetBucket())
                throw new AmazonS3ControlException("Request object does not have required field Bucket set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Bucket));
            request.ResourcePath = "/v20180820/bucket/{name}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetCreateBucketConfiguration())
                {
                    xmlWriter.WriteStartElement("CreateBucketConfiguration", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                    if(publicRequest.CreateBucketConfiguration.IsSetLocationConstraint())
                        xmlWriter.WriteElementString("LocationConstraint", StringUtils.FromString(publicRequest.CreateBucketConfiguration.LocationConstraint));


                    xmlWriter.WriteEndElement();
                }
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                ChecksumUtils.SetChecksumData(request);
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static CreateBucketRequestMarshaller _instance = new CreateBucketRequestMarshaller();        

        internal static CreateBucketRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBucketRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateBucketRequest publicRequest);
    }    
}