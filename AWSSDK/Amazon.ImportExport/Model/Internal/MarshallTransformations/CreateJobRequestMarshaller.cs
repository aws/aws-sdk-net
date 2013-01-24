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

using Amazon.ImportExport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ImportExport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Job Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest>
    {
        public IRequest Marshall(CreateJobRequest createJobRequest)
        {
            IRequest request = new DefaultRequest(createJobRequest, "AmazonImportExport");
            request.Parameters.Add("Action", "CreateJob");
            request.Parameters.Add("Version", "2010-06-01");
            if (createJobRequest != null && createJobRequest.IsSetJobType())
            {
                request.Parameters.Add("JobType", StringUtils.FromString(createJobRequest.JobType));
            }
            if (createJobRequest != null && createJobRequest.IsSetManifest())
            {
                request.Parameters.Add("Manifest", StringUtils.FromString(createJobRequest.Manifest));
            }
            if (createJobRequest != null && createJobRequest.IsSetManifestAddendum())
            {
                request.Parameters.Add("ManifestAddendum", StringUtils.FromString(createJobRequest.ManifestAddendum));
            }
            if (createJobRequest != null && createJobRequest.IsSetValidateOnly())
            {
                request.Parameters.Add("ValidateOnly", StringUtils.FromBool(createJobRequest.ValidateOnly));
            }

            return request;
        }
    }
}
