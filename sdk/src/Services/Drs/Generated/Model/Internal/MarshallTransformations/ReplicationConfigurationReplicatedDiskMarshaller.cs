/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplicationConfigurationReplicatedDisk Marshaller
    /// </summary>
    public class ReplicationConfigurationReplicatedDiskMarshaller : IRequestMarshaller<ReplicationConfigurationReplicatedDisk, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReplicationConfigurationReplicatedDisk requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeviceName())
            {
                context.Writer.WritePropertyName("deviceName");
                context.Writer.Write(requestObject.DeviceName);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("iops");
                context.Writer.Write(requestObject.Iops);
            }

            if(requestObject.IsSetIsBootDisk())
            {
                context.Writer.WritePropertyName("isBootDisk");
                context.Writer.Write(requestObject.IsBootDisk);
            }

            if(requestObject.IsSetStagingDiskType())
            {
                context.Writer.WritePropertyName("stagingDiskType");
                context.Writer.Write(requestObject.StagingDiskType);
            }

            if(requestObject.IsSetThroughput())
            {
                context.Writer.WritePropertyName("throughput");
                context.Writer.Write(requestObject.Throughput);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReplicationConfigurationReplicatedDiskMarshaller Instance = new ReplicationConfigurationReplicatedDiskMarshaller();

    }
}