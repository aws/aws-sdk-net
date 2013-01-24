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
    /// Update Job Request Marshaller
    /// </summary>       
    public class UpdateJobRequestMarshaller : IMarshaller<IRequest, UpdateJobRequest>
    {
        public IRequest Marshall(UpdateJobRequest updateJobRequest)
        {
            IRequest request = new DefaultRequest(updateJobRequest, "AmazonImportExport");
            request.Parameters.Add("Action", "UpdateJob");
            request.Parameters.Add("Version", "2010-06-01");
            if (updateJobRequest != null && updateJobRequest.IsSetJobId())
            {
                request.Parameters.Add("JobId", StringUtils.FromString(updateJobRequest.JobId));
            }
            if (updateJobRequest != null && updateJobRequest.IsSetManifest())
            {
                request.Parameters.Add("Manifest", StringUtils.FromString(updateJobRequest.Manifest));
            }
            if (updateJobRequest != null && updateJobRequest.IsSetJobType())
            {
                request.Parameters.Add("JobType", StringUtils.FromString(updateJobRequest.JobType));
            }
            if (updateJobRequest != null && updateJobRequest.IsSetValidateOnly())
            {
                request.Parameters.Add("ValidateOnly", StringUtils.FromBool(updateJobRequest.ValidateOnly));
            }

            return request;
        }
    }
}
