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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyVerifiedAccessInstanceLoggingConfiguration Request Marshaller
    /// </summary>       
    public class ModifyVerifiedAccessInstanceLoggingConfigurationRequestMarshaller : IMarshaller<IRequest, ModifyVerifiedAccessInstanceLoggingConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVerifiedAccessInstanceLoggingConfigurationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyVerifiedAccessInstanceLoggingConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyVerifiedAccessInstanceLoggingConfiguration");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAccessLogs())
                {
                    if(publicRequest.AccessLogs.IsSetCloudWatchLogs())
                    {
                        if(publicRequest.AccessLogs.CloudWatchLogs.IsSetEnabled())
                        {
                            request.Parameters.Add("AccessLogs" + "." + "CloudWatchLogs" + "." + "Enabled", StringUtils.FromBool(publicRequest.AccessLogs.CloudWatchLogs.Enabled));
                        }
                        if(publicRequest.AccessLogs.CloudWatchLogs.IsSetLogGroup())
                        {
                            request.Parameters.Add("AccessLogs" + "." + "CloudWatchLogs" + "." + "LogGroup", StringUtils.FromString(publicRequest.AccessLogs.CloudWatchLogs.LogGroup));
                        }
                    }
                    if(publicRequest.AccessLogs.IsSetKinesisDataFirehose())
                    {
                        if(publicRequest.AccessLogs.KinesisDataFirehose.IsSetDeliveryStream())
                        {
                            request.Parameters.Add("AccessLogs" + "." + "KinesisDataFirehose" + "." + "DeliveryStream", StringUtils.FromString(publicRequest.AccessLogs.KinesisDataFirehose.DeliveryStream));
                        }
                        if(publicRequest.AccessLogs.KinesisDataFirehose.IsSetEnabled())
                        {
                            request.Parameters.Add("AccessLogs" + "." + "KinesisDataFirehose" + "." + "Enabled", StringUtils.FromBool(publicRequest.AccessLogs.KinesisDataFirehose.Enabled));
                        }
                    }
                    if(publicRequest.AccessLogs.IsSetS3())
                    {
                        if(publicRequest.AccessLogs.S3.IsSetBucketName())
                        {
                            request.Parameters.Add("AccessLogs" + "." + "S3" + "." + "BucketName", StringUtils.FromString(publicRequest.AccessLogs.S3.BucketName));
                        }
                        if(publicRequest.AccessLogs.S3.IsSetBucketOwner())
                        {
                            request.Parameters.Add("AccessLogs" + "." + "S3" + "." + "BucketOwner", StringUtils.FromString(publicRequest.AccessLogs.S3.BucketOwner));
                        }
                        if(publicRequest.AccessLogs.S3.IsSetEnabled())
                        {
                            request.Parameters.Add("AccessLogs" + "." + "S3" + "." + "Enabled", StringUtils.FromBool(publicRequest.AccessLogs.S3.Enabled));
                        }
                        if(publicRequest.AccessLogs.S3.IsSetPrefix())
                        {
                            request.Parameters.Add("AccessLogs" + "." + "S3" + "." + "Prefix", StringUtils.FromString(publicRequest.AccessLogs.S3.Prefix));
                        }
                    }
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetVerifiedAccessInstanceId())
                {
                    request.Parameters.Add("VerifiedAccessInstanceId", StringUtils.FromString(publicRequest.VerifiedAccessInstanceId));
                }
            }
            return request;
        }
                    private static ModifyVerifiedAccessInstanceLoggingConfigurationRequestMarshaller _instance = new ModifyVerifiedAccessInstanceLoggingConfigurationRequestMarshaller();        

        internal static ModifyVerifiedAccessInstanceLoggingConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyVerifiedAccessInstanceLoggingConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}