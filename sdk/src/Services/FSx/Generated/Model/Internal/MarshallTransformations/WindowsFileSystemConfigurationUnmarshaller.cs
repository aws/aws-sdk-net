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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WindowsFileSystemConfiguration Object
    /// </summary>  
    public class WindowsFileSystemConfigurationUnmarshaller : IUnmarshaller<WindowsFileSystemConfiguration, XmlUnmarshallerContext>, IUnmarshaller<WindowsFileSystemConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        WindowsFileSystemConfiguration IUnmarshaller<WindowsFileSystemConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public WindowsFileSystemConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            WindowsFileSystemConfiguration unmarshalledObject = new WindowsFileSystemConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActiveDirectoryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActiveDirectoryId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Aliases", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Alias, AliasUnmarshaller>(AliasUnmarshaller.Instance);
                    unmarshalledObject.Aliases = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AuditLogConfiguration", targetDepth))
                {
                    var unmarshaller = WindowsAuditLogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AuditLogConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutomaticBackupRetentionDays", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AutomaticBackupRetentionDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CopyTagsToBackups", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTagsToBackups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DailyAutomaticBackupStartTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DailyAutomaticBackupStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeploymentType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DiskIopsConfiguration", targetDepth))
                {
                    var unmarshaller = DiskIopsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DiskIopsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaintenanceOperationsInProgress", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.MaintenanceOperationsInProgress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredFileServerIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredFileServerIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredFileServerIpv6", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredFileServerIpv6 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredSubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RemoteAdministrationEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteAdministrationEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelfManagedActiveDirectoryConfiguration", targetDepth))
                {
                    var unmarshaller = SelfManagedActiveDirectoryAttributesUnmarshaller.Instance;
                    unmarshalledObject.SelfManagedActiveDirectoryConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThroughputCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ThroughputCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WeeklyMaintenanceStartTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WeeklyMaintenanceStartTime = unmarshaller.Unmarshall(context);
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