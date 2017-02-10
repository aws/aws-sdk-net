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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorksCM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorksCM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CMServer Object
    /// </summary>  
    public class CMServerUnmarshaller : IUnmarshaller<CMServer, XmlUnmarshallerContext>, IUnmarshaller<CMServer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CMServer IUnmarshaller<CMServer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CMServer Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CMServer unmarshalledObject = new CMServer();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BackupRetentionCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BackupRetentionCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisableAutomatedBackup", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DisableAutomatedBackup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Endpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Engine", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EngineAttribute, EngineAttributeUnmarshaller>(EngineAttributeUnmarshaller.Instance);
                    unmarshalledObject.EngineAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceProfileArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceProfileArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyPair", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyPair = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaintenanceStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaintenanceStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredBackupWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredBackupWindow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredMaintenanceWindow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityGroupIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroupIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SubnetIds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CMServerUnmarshaller _instance = new CMServerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CMServerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}