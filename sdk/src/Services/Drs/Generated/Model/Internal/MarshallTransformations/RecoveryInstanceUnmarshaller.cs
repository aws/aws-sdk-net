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
using System.Net;
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
    /// Response Unmarshaller for RecoveryInstance Object
    /// </summary>  
    public class RecoveryInstanceUnmarshaller : IUnmarshaller<RecoveryInstance, XmlUnmarshallerContext>, IUnmarshaller<RecoveryInstance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecoveryInstance IUnmarshaller<RecoveryInstance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RecoveryInstance Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RecoveryInstance unmarshalledObject = new RecoveryInstance();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataReplicationInfo", targetDepth))
                {
                    var unmarshaller = RecoveryInstanceDataReplicationInfoUnmarshaller.Instance;
                    unmarshalledObject.DataReplicationInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2InstanceID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2InstanceID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2InstanceState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2InstanceState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failback", targetDepth))
                {
                    var unmarshaller = RecoveryInstanceFailbackUnmarshaller.Instance;
                    unmarshalledObject.Failback = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isDrill", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsDrill = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("originAvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OriginAvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("originEnvironment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OriginEnvironment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pointInTimeSnapshotDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PointInTimeSnapshotDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recoveryInstanceID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecoveryInstanceID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recoveryInstanceProperties", targetDepth))
                {
                    var unmarshaller = RecoveryInstancePropertiesUnmarshaller.Instance;
                    unmarshalledObject.RecoveryInstanceProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceServerID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceServerID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RecoveryInstanceUnmarshaller _instance = new RecoveryInstanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecoveryInstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}