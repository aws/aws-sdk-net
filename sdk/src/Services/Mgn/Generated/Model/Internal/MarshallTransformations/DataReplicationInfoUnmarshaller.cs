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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataReplicationInfo Object
    /// </summary>  
    public class DataReplicationInfoUnmarshaller : IJsonUnmarshaller<DataReplicationInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DataReplicationInfo Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DataReplicationInfo unmarshalledObject = new DataReplicationInfo();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("dataReplicationError", targetDepth))
                {
                    var unmarshaller = DataReplicationErrorUnmarshaller.Instance;
                    unmarshalledObject.DataReplicationError = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataReplicationInitiation", targetDepth))
                {
                    var unmarshaller = DataReplicationInitiationUnmarshaller.Instance;
                    unmarshalledObject.DataReplicationInitiation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataReplicationState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataReplicationState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("etaDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EtaDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lagDuration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LagDuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastSnapshotDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastSnapshotDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("replicatedDisks", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataReplicationInfoReplicatedDisk, DataReplicationInfoReplicatedDiskUnmarshaller>(DataReplicationInfoReplicatedDiskUnmarshaller.Instance);
                    unmarshalledObject.ReplicatedDisks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataReplicationInfoUnmarshaller _instance = new DataReplicationInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataReplicationInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}