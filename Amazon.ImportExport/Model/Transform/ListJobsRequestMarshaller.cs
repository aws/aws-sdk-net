/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ImportExport.Model.Transform
{
    /// <summary>
    /// List Jobs Request Marshaller
    /// </summary>       
    public class ListJobsRequestMarshaller : IMarshaller<IRequest<ListJobsRequest>, ListJobsRequest> 
    {

        public IRequest<ListJobsRequest> Marshall(ListJobsRequest listJobsRequest) 
        {
            IRequest<ListJobsRequest> request = new DefaultRequest<ListJobsRequest>(listJobsRequest, "AmazonImportExport");
            request.Parameters.Add("Action", "ListJobs");
            request.Parameters.Add("Version", "2010-06-01");
            if (listJobsRequest != null && listJobsRequest.IsSetMaxJobs()) 
            {
                request.Parameters.Add("MaxJobs", StringUtils.FromInt(listJobsRequest.MaxJobs));
            }
            if (listJobsRequest != null && listJobsRequest.IsSetMarker()) 
            {
                request.Parameters.Add("Marker", StringUtils.FromString(listJobsRequest.Marker));
            }


            return request;
        }
    }
}
