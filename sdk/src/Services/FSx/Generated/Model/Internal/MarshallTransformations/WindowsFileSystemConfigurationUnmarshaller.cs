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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WindowsFileSystemConfiguration Object
    /// </summary>  
    public class WindowsFileSystemConfigurationUnmarshaller : IJsonUnmarshaller<WindowsFileSystemConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public WindowsFileSystemConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            WindowsFileSystemConfiguration unmarshalledObject = new WindowsFileSystemConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ActiveDirectoryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActiveDirectoryId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Aliases", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Alias, AliasUnmarshaller>(AliasUnmarshaller.Instance);
                    unmarshalledObject.Aliases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AuditLogConfiguration", targetDepth))
                {
                    var unmarshaller = WindowsAuditLogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AuditLogConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AutomaticBackupRetentionDays", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.AutomaticBackupRetentionDays = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CopyTagsToBackups", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTagsToBackups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DailyAutomaticBackupStartTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DailyAutomaticBackupStartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeploymentType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DiskIopsConfiguration", targetDepth))
                {
                    var unmarshaller = DiskIopsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DiskIopsConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaintenanceOperationsInProgress", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.MaintenanceOperationsInProgress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PreferredFileServerIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredFileServerIp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PreferredFileServerIpv6", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredFileServerIpv6 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PreferredSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredSubnetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RemoteAdministrationEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteAdministrationEndpoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SelfManagedActiveDirectoryConfiguration", targetDepth))
                {
                    var unmarshaller = SelfManagedActiveDirectoryAttributesUnmarshaller.Instance;
                    unmarshalledObject.SelfManagedActiveDirectoryConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThroughputCapacity", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ThroughputCapacity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WeeklyMaintenanceStartTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WeeklyMaintenanceStartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WindowsFileSystemConfigurationUnmarshaller _instance = new WindowsFileSystemConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WindowsFileSystemConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}