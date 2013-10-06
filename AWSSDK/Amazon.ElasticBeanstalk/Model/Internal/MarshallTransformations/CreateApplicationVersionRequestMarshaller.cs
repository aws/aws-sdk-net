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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Application Version Request Marshaller
    /// </summary>       
    public class CreateApplicationVersionRequestMarshaller : IMarshaller<IRequest, CreateApplicationVersionRequest>
    {
        public IRequest Marshall(CreateApplicationVersionRequest createApplicationVersionRequest)
        {
            IRequest request = new DefaultRequest(createApplicationVersionRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "CreateApplicationVersion");
            request.Parameters.Add("Version", "2010-12-01");
            if (createApplicationVersionRequest != null && createApplicationVersionRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(createApplicationVersionRequest.ApplicationName));
            }
            if (createApplicationVersionRequest != null && createApplicationVersionRequest.IsSetVersionLabel())
            {
                request.Parameters.Add("VersionLabel", StringUtils.FromString(createApplicationVersionRequest.VersionLabel));
            }
            if (createApplicationVersionRequest != null && createApplicationVersionRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(createApplicationVersionRequest.Description));
            }
            if (createApplicationVersionRequest != null)
            {
                S3Location sourceBundle = createApplicationVersionRequest.SourceBundle;
                if (sourceBundle != null && sourceBundle.IsSetS3Bucket())
                {
                    request.Parameters.Add("SourceBundle.S3Bucket", StringUtils.FromString(sourceBundle.S3Bucket));
                }
                if (sourceBundle != null && sourceBundle.IsSetS3Key())
                {
                    request.Parameters.Add("SourceBundle.S3Key", StringUtils.FromString(sourceBundle.S3Key));
                }
            }
            if (createApplicationVersionRequest != null && createApplicationVersionRequest.IsSetAutoCreateApplication())
            {
                request.Parameters.Add("AutoCreateApplication", StringUtils.FromBool(createApplicationVersionRequest.AutoCreateApplication));
            }

            return request;
        }
    }
}
