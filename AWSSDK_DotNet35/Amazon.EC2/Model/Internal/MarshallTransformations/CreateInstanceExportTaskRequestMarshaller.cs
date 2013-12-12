/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Instance Export Task Request Marshaller
    /// </summary>       
    public class CreateInstanceExportTaskRequestMarshaller : IMarshaller<IRequest, CreateInstanceExportTaskRequest>
    {
        public IRequest Marshall(CreateInstanceExportTaskRequest createInstanceExportTaskRequest)
        {
            IRequest request = new DefaultRequest(createInstanceExportTaskRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CreateInstanceExportTask");
            request.Parameters.Add("Version", "2013-10-15");
            if (createInstanceExportTaskRequest != null && createInstanceExportTaskRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(createInstanceExportTaskRequest.Description));
            }
            if (createInstanceExportTaskRequest != null && createInstanceExportTaskRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(createInstanceExportTaskRequest.InstanceId));
            }
            if (createInstanceExportTaskRequest != null && createInstanceExportTaskRequest.IsSetTargetEnvironment())
            {
                request.Parameters.Add("TargetEnvironment", StringUtils.FromString(createInstanceExportTaskRequest.TargetEnvironment));
            }
            if (createInstanceExportTaskRequest != null)
            {
                ExportToS3TaskSpecification exportToS3Task = createInstanceExportTaskRequest.ExportToS3Task;
                if (exportToS3Task != null && exportToS3Task.IsSetDiskImageFormat())
                {
                    request.Parameters.Add("ExportToS3.DiskImageFormat", StringUtils.FromString(exportToS3Task.DiskImageFormat));
                }
                if (exportToS3Task != null && exportToS3Task.IsSetContainerFormat())
                {
                    request.Parameters.Add("ExportToS3.ContainerFormat", StringUtils.FromString(exportToS3Task.ContainerFormat));
                }
                if (exportToS3Task != null && exportToS3Task.IsSetS3Bucket())
                {
                    request.Parameters.Add("ExportToS3.S3Bucket", StringUtils.FromString(exportToS3Task.S3Bucket));
                }
                if (exportToS3Task != null && exportToS3Task.IsSetS3Prefix())
                {
                    request.Parameters.Add("ExportToS3.S3Prefix", StringUtils.FromString(exportToS3Task.S3Prefix));
                }
            }

            return request;
        }
    }
}
