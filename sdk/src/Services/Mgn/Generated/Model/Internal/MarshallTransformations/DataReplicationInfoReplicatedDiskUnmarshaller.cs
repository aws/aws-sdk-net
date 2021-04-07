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
using ThirdParty.Json.LitJson;

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataReplicationInfoReplicatedDisk Object
    /// </summary>  
    public class DataReplicationInfoReplicatedDiskUnmarshaller : IUnmarshaller<DataReplicationInfoReplicatedDisk, XmlUnmarshallerContext>, IUnmarshaller<DataReplicationInfoReplicatedDisk, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataReplicationInfoReplicatedDisk IUnmarshaller<DataReplicationInfoReplicatedDisk, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataReplicationInfoReplicatedDisk Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataReplicationInfoReplicatedDisk unmarshalledObject = new DataReplicationInfoReplicatedDisk();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("backloggedStorageBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.BackloggedStorageBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deviceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicatedStorageBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ReplicatedStorageBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rescannedStorageBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.RescannedStorageBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalStorageBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalStorageBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DataReplicationInfoReplicatedDiskUnmarshaller _instance = new DataReplicationInfoReplicatedDiskUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataReplicationInfoReplicatedDiskUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}