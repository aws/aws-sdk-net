/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Get Status Request Marshaller
    /// </summary>       
    public class GetStatusRequestMarshaller : IMarshaller<IRequest<GetStatusRequest>, GetStatusRequest> 
    {

        public IRequest<GetStatusRequest> Marshall(GetStatusRequest getStatusRequest) 
        {
            IRequest<GetStatusRequest> request = new DefaultRequest<GetStatusRequest>(getStatusRequest, "AmazonImportExport");
            request.Parameters.Add("Action", "GetStatus");
            request.Parameters.Add("Version", "2010-06-01");
            if (getStatusRequest != null && getStatusRequest.IsSetJobId()) 
            {
                request.Parameters.Add("JobId", StringUtils.FromString(getStatusRequest.JobId));
            }


            return request;
        }
    }
}
