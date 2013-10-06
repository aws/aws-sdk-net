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

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Download D B Log File Portion Request Marshaller
    /// </summary>       
    public class DownloadDBLogFilePortionRequestMarshaller : IMarshaller<IRequest, DownloadDBLogFilePortionRequest>
    {
        public IRequest Marshall(DownloadDBLogFilePortionRequest downloadDBLogFilePortionRequest)
        {
            IRequest request = new DefaultRequest(downloadDBLogFilePortionRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DownloadDBLogFilePortion");
            request.Parameters.Add("Version", "2013-05-15");
            if (downloadDBLogFilePortionRequest != null && downloadDBLogFilePortionRequest.IsSetDBInstanceIdentifier())
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(downloadDBLogFilePortionRequest.DBInstanceIdentifier));
            }
            if (downloadDBLogFilePortionRequest != null && downloadDBLogFilePortionRequest.IsSetLogFileName())
            {
                request.Parameters.Add("LogFileName", StringUtils.FromString(downloadDBLogFilePortionRequest.LogFileName));
            }
            if (downloadDBLogFilePortionRequest != null && downloadDBLogFilePortionRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(downloadDBLogFilePortionRequest.Marker));
            }
            if (downloadDBLogFilePortionRequest != null && downloadDBLogFilePortionRequest.IsSetNumberOfLines())
            {
                request.Parameters.Add("NumberOfLines", StringUtils.FromInt(downloadDBLogFilePortionRequest.NumberOfLines));
            }

            return request;
        }
    }
}
