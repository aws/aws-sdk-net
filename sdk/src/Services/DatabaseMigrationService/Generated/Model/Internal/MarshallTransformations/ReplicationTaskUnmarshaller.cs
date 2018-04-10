/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReplicationTask Object
    /// </summary>  
    public class ReplicationTaskUnmarshaller : IUnmarshaller<ReplicationTask, XmlUnmarshallerContext>, IUnmarshaller<ReplicationTask, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReplicationTask IUnmarshaller<ReplicationTask, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReplicationTask Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReplicationTask unmarshalledObject = new ReplicationTask();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CdcStartPosition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CdcStartPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CdcStopPosition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CdcStopPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastFailureMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastFailureMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MigrationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MigrationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecoveryCheckpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecoveryCheckpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationInstanceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInstanceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskCreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskCreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskSettings", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskStartDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskStartDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskStats", targetDepth))
                {
                    var unmarshaller = ReplicationTaskStatsUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskStats = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceEndpointArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceEndpointArn = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("TableMappings", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableMappings = unmarshaller.Unmarshall(context);
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


        private static ReplicationTaskUnmarshaller _instance = new ReplicationTaskUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicationTaskUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}