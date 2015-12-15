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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplicationVersion Request Marshaller
    /// </summary>       
    public class CreateApplicationVersionRequestMarshaller : IMarshaller<IRequest, CreateApplicationVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationVersionRequest)input);
        }
    
        public IRequest Marshall(CreateApplicationVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "CreateApplicationVersion");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplicationName())
                {
                    request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
                }
                if(publicRequest.IsSetAutoCreateApplication())
                {
                    request.Parameters.Add("AutoCreateApplication", StringUtils.FromBool(publicRequest.AutoCreateApplication));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetProcess())
                {
                    request.Parameters.Add("Process", StringUtils.FromBool(publicRequest.Process));
                }
                if(publicRequest.IsSetSourceBundle())
                {
                    if(publicRequest.SourceBundle.IsSetS3Bucket())
                    {
                        request.Parameters.Add("SourceBundle" + "." + "S3Bucket", StringUtils.FromString(publicRequest.SourceBundle.S3Bucket));
                    }
                    if(publicRequest.SourceBundle.IsSetS3Key())
                    {
                        request.Parameters.Add("SourceBundle" + "." + "S3Key", StringUtils.FromString(publicRequest.SourceBundle.S3Key));
                    }
                }
                if(publicRequest.IsSetVersionLabel())
                {
                    request.Parameters.Add("VersionLabel", StringUtils.FromString(publicRequest.VersionLabel));
                }
            }
            return request;
        }
    }
}