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
    /// ReplicaGlobalSecondaryIndexSettingsUpdate Marshaller
    /// </summary>
    public class ReplicaGlobalSecondaryIndexSettingsUpdateMarshaller : IRequestMarshaller<ReplicaGlobalSecondaryIndexSettingsUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReplicaGlobalSecondaryIndexSettingsUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIndexName())
            {
                context.Writer.WritePropertyName("IndexName");
                context.Writer.WriteStringValue(requestObject.IndexName);
            }

            if(requestObject.IsSetProvisionedReadCapacityAutoScalingSettingsUpdate())
            {
                context.Writer.WritePropertyName("ProvisionedReadCapacityAutoScalingSettingsUpdate");
                context.Writer.WriteStartObject();

                var marshaller = AutoScalingSettingsUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ProvisionedReadCapacityAutoScalingSettingsUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProvisionedReadCapacityUnits())
            {
                context.Writer.WritePropertyName("ProvisionedReadCapacityUnits");
                context.Writer.WriteNumberValue(requestObject.ProvisionedReadCapacityUnits.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReplicaGlobalSecondaryIndexSettingsUpdateMarshaller Instance = new ReplicaGlobalSecondaryIndexSettingsUpdateMarshaller();

    }
}