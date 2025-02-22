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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BundleInstance Request Marshaller
    /// </summary>       
    public class BundleInstanceRequestMarshaller : IMarshaller<IRequest, BundleInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BundleInstanceRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BundleInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "BundleInstance");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
                if(publicRequest.IsSetStorage())
                {
                    if(publicRequest.Storage.IsSetS3())
                    {
                        if(publicRequest.Storage.S3.IsSetAWSAccessKeyId())
                        {
                            request.Parameters.Add("Storage" + "." + "S3" + "." + "AWSAccessKeyId", StringUtils.FromString(publicRequest.Storage.S3.AWSAccessKeyId));
                        }
                        if(publicRequest.Storage.S3.IsSetBucket())
                        {
                            request.Parameters.Add("Storage" + "." + "S3" + "." + "Bucket", StringUtils.FromString(publicRequest.Storage.S3.Bucket));
                        }
                        if(publicRequest.Storage.S3.IsSetPrefix())
                        {
                            request.Parameters.Add("Storage" + "." + "S3" + "." + "Prefix", StringUtils.FromString(publicRequest.Storage.S3.Prefix));
                        }
                        if(publicRequest.Storage.S3.IsSetUploadPolicy())
                        {
                            request.Parameters.Add("Storage" + "." + "S3" + "." + "UploadPolicy", StringUtils.FromString(publicRequest.Storage.S3.UploadPolicy));
                        }
                        if(publicRequest.Storage.S3.IsSetUploadPolicySignature())
                        {
                            request.Parameters.Add("Storage" + "." + "S3" + "." + "UploadPolicySignature", StringUtils.FromString(publicRequest.Storage.S3.UploadPolicySignature));
                        }
                    }
                }
            }
            return request;
        }
                    private static BundleInstanceRequestMarshaller _instance = new BundleInstanceRequestMarshaller();        

        internal static BundleInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BundleInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}