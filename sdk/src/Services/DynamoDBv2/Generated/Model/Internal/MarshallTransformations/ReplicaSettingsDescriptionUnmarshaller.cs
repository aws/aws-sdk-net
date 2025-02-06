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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReplicaSettingsDescription Object
    /// </summary>  
    public class ReplicaSettingsDescriptionUnmarshaller : IJsonUnmarshaller<ReplicaSettingsDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ReplicaSettingsDescription Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ReplicaSettingsDescription unmarshalledObject = new ReplicaSettingsDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("RegionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegionName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicaBillingModeSummary", targetDepth))
                {
                    var unmarshaller = BillingModeSummaryUnmarshaller.Instance;
                    unmarshalledObject.ReplicaBillingModeSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicaGlobalSecondaryIndexSettings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ReplicaGlobalSecondaryIndexSettingsDescription, ReplicaGlobalSecondaryIndexSettingsDescriptionUnmarshaller>(ReplicaGlobalSecondaryIndexSettingsDescriptionUnmarshaller.Instance);
                    unmarshalledObject.ReplicaGlobalSecondaryIndexSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicaProvisionedReadCapacityAutoScalingSettings", targetDepth))
                {
                    var unmarshaller = AutoScalingSettingsDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ReplicaProvisionedReadCapacityAutoScalingSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicaProvisionedReadCapacityUnits", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ReplicaProvisionedReadCapacityUnits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicaProvisionedWriteCapacityAutoScalingSettings", targetDepth))
                {
                    var unmarshaller = AutoScalingSettingsDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ReplicaProvisionedWriteCapacityAutoScalingSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicaProvisionedWriteCapacityUnits", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ReplicaProvisionedWriteCapacityUnits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicaStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicaStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplicaTableClassSummary", targetDepth))
                {
                    var unmarshaller = TableClassSummaryUnmarshaller.Instance;
                    unmarshalledObject.ReplicaTableClassSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ReplicaSettingsDescriptionUnmarshaller _instance = new ReplicaSettingsDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicaSettingsDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}