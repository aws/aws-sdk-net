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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplicaSettingsUpdate Marshaller
    /// </summary>
    public class ReplicaSettingsUpdateMarshaller : IRequestMarshaller<ReplicaSettingsUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReplicaSettingsUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRegionName())
            {
                context.Writer.WritePropertyName("RegionName");
                context.Writer.WriteStringValue(requestObject.RegionName);
            }

            if(requestObject.IsSetReplicaGlobalSecondaryIndexSettingsUpdate())
            {
                context.Writer.WritePropertyName("ReplicaGlobalSecondaryIndexSettingsUpdate");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReplicaGlobalSecondaryIndexSettingsUpdateListValue in requestObject.ReplicaGlobalSecondaryIndexSettingsUpdate)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ReplicaGlobalSecondaryIndexSettingsUpdateMarshaller.Instance;
                    marshaller.Marshall(requestObjectReplicaGlobalSecondaryIndexSettingsUpdateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetReplicaProvisionedReadCapacityAutoScalingSettingsUpdate())
            {
                context.Writer.WritePropertyName("ReplicaProvisionedReadCapacityAutoScalingSettingsUpdate");
                context.Writer.WriteStartObject();

                var marshaller = AutoScalingSettingsUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ReplicaProvisionedReadCapacityAutoScalingSettingsUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReplicaProvisionedReadCapacityUnits())
            {
                context.Writer.WritePropertyName("ReplicaProvisionedReadCapacityUnits");
                context.Writer.WriteNumberValue(requestObject.ReplicaProvisionedReadCapacityUnits.Value);
            }

            if(requestObject.IsSetReplicaTableClass())
            {
                context.Writer.WritePropertyName("ReplicaTableClass");
                context.Writer.WriteStringValue(requestObject.ReplicaTableClass);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReplicaSettingsUpdateMarshaller Instance = new ReplicaSettingsUpdateMarshaller();

    }
}