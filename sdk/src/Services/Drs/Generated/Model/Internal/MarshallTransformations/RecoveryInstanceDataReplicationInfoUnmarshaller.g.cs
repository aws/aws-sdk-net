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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Drs.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecoveryInstanceDataReplicationInfo Object
    /// </summary>
    public partial class RecoveryInstanceDataReplicationInfoUnmarshaller : IJsonUnmarshaller<RecoveryInstanceDataReplicationInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RecoveryInstanceDataReplicationInfo Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new RecoveryInstanceDataReplicationInfo();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("dataReplicationError", targetDepth, ref reader))
                {
                    var unmarshaller = RecoveryInstanceDataReplicationErrorUnmarshaller.Instance;
                    unmarshalledObject.DataReplicationError = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("dataReplicationInitiation", targetDepth, ref reader))
                {
                    var unmarshaller = RecoveryInstanceDataReplicationInitiationUnmarshaller.Instance;
                    unmarshalledObject.DataReplicationInitiation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("dataReplicationState", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataReplicationState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("etaDateTime", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EtaDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("lagDuration", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LagDuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("replicatedDisks", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RecoveryInstanceDataReplicationInfoReplicatedDisk, RecoveryInstanceDataReplicationInfoReplicatedDiskUnmarshaller>(RecoveryInstanceDataReplicationInfoReplicatedDiskUnmarshaller.Instance);
                    unmarshalledObject.ReplicatedDisks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("stagingAvailabilityZone", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StagingAvailabilityZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("stagingOutpostArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StagingOutpostArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static RecoveryInstanceDataReplicationInfoUnmarshaller _instance = new RecoveryInstanceDataReplicationInfoUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RecoveryInstanceDataReplicationInfoUnmarshaller Instance => _instance;
    }
}
