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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Replication Object
    /// </summary>  
    public class ReplicationUnmarshaller : IUnmarshaller<Replication, XmlUnmarshallerContext>, IUnmarshaller<Replication, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Replication IUnmarshaller<Replication, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Replication Unmarshall(JsonUnmarshallerContext context)
        {
            Replication unmarshalledObject = new Replication();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CdcStartPosition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CdcStartPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CdcStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CdcStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CdcStopPosition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CdcStopPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureMessages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FailureMessages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsReadOnly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsReadOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PremigrationAssessmentStatuses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PremigrationAssessmentStatus, PremigrationAssessmentStatusUnmarshaller>(PremigrationAssessmentStatusUnmarshaller.Instance);
                    unmarshalledObject.PremigrationAssessmentStatuses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionData", targetDepth))
                {
                    var unmarshaller = ProvisionDataUnmarshaller.Instance;
                    unmarshalledObject.ProvisionData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecoveryCheckpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecoveryCheckpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationConfigArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationConfigArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationConfigIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationConfigIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationCreateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ReplicationCreateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationDeprovisionTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ReplicationDeprovisionTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationLastStopTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ReplicationLastStopTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationStats", targetDepth))
                {
                    var unmarshaller = ReplicationStatsUnmarshaller.Instance;
                    unmarshalledObject.ReplicationStats = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationUpdateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ReplicationUpdateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceEndpointArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceEndpointArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartReplicationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartReplicationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StopReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StopReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetEndpointArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetEndpointArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ReplicationUnmarshaller _instance = new ReplicationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}