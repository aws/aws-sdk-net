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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RelationalDatabase Object
    /// </summary>  
    public class RelationalDatabaseUnmarshaller : IUnmarshaller<RelationalDatabase, XmlUnmarshallerContext>, IUnmarshaller<RelationalDatabase, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RelationalDatabase IUnmarshaller<RelationalDatabase, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RelationalDatabase Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RelationalDatabase unmarshalledObject = new RelationalDatabase();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("backupRetentionEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.BackupRetentionEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("engine", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("engineVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hardware", targetDepth))
                {
                    var unmarshaller = RelationalDatabaseHardwareUnmarshaller.Instance;
                    unmarshalledObject.Hardware = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("latestRestorableTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LatestRestorableTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("location", targetDepth))
                {
                    var unmarshaller = ResourceLocationUnmarshaller.Instance;
                    unmarshalledObject.Location = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("masterDatabaseName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MasterDatabaseName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("masterEndpoint", targetDepth))
                {
                    var unmarshaller = RelationalDatabaseEndpointUnmarshaller.Instance;
                    unmarshalledObject.MasterEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("masterUsername", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MasterUsername = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parameterApplyStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParameterApplyStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pendingMaintenanceActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PendingMaintenanceAction, PendingMaintenanceActionUnmarshaller>(PendingMaintenanceActionUnmarshaller.Instance);
                    unmarshalledObject.PendingMaintenanceActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pendingModifiedValues", targetDepth))
                {
                    var unmarshaller = PendingModifiedRelationalDatabaseValuesUnmarshaller.Instance;
                    unmarshalledObject.PendingModifiedValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("preferredBackupWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredBackupWindow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("preferredMaintenanceWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredMaintenanceWindow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publiclyAccessible", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PubliclyAccessible = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("relationalDatabaseBlueprintId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelationalDatabaseBlueprintId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("relationalDatabaseBundleId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelationalDatabaseBundleId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("secondaryAvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecondaryAvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SupportCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RelationalDatabaseUnmarshaller _instance = new RelationalDatabaseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RelationalDatabaseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}