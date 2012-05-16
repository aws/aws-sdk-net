/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Snapshot Schedule Request Marshaller
    /// </summary>       
    internal class DescribeSnapshotScheduleRequestMarshaller : IMarshaller<IRequest, DescribeSnapshotScheduleRequest> 
    {
        public IRequest Marshall(DescribeSnapshotScheduleRequest describeSnapshotScheduleRequest) 
        {

            IRequest request = new DefaultRequest(describeSnapshotScheduleRequest, "AmazonStorageGateway");
            string target = "StorageGateway_20120430.DescribeSnapshotSchedule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";

            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (describeSnapshotScheduleRequest != null && describeSnapshotScheduleRequest.IsSetVolumeARN()) 
                {
                    writer.WritePropertyName("VolumeARN");
                    writer.Write(describeSnapshotScheduleRequest.VolumeARN);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
                return request;
            }
        }
    }
}
