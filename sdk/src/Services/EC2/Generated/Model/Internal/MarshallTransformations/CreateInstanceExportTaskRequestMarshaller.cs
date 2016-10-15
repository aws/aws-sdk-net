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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
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
    /// CreateInstanceExportTask Request Marshaller
    /// </summary>       
    public class CreateInstanceExportTaskRequestMarshaller : IMarshaller<IRequest, CreateInstanceExportTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInstanceExportTaskRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInstanceExportTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateInstanceExportTask");
            request.Parameters.Add("Version", "2016-09-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetExportToS3Task())
                {
                    if(publicRequest.ExportToS3Task.IsSetContainerFormat())
                    {
                        request.Parameters.Add("ExportToS3" + "." + "ContainerFormat", StringUtils.FromString(publicRequest.ExportToS3Task.ContainerFormat));
                    }
                    if(publicRequest.ExportToS3Task.IsSetDiskImageFormat())
                    {
                        request.Parameters.Add("ExportToS3" + "." + "DiskImageFormat", StringUtils.FromString(publicRequest.ExportToS3Task.DiskImageFormat));
                    }
                    if(publicRequest.ExportToS3Task.IsSetS3Bucket())
                    {
                        request.Parameters.Add("ExportToS3" + "." + "S3Bucket", StringUtils.FromString(publicRequest.ExportToS3Task.S3Bucket));
                    }
                    if(publicRequest.ExportToS3Task.IsSetS3Prefix())
                    {
                        request.Parameters.Add("ExportToS3" + "." + "S3Prefix", StringUtils.FromString(publicRequest.ExportToS3Task.S3Prefix));
                    }
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
                if(publicRequest.IsSetTargetEnvironment())
                {
                    request.Parameters.Add("TargetEnvironment", StringUtils.FromString(publicRequest.TargetEnvironment));
                }
            }
            return request;
        }
    }
}