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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Workspace Object
    /// </summary>  
    public class WorkspaceUnmarshaller : IUnmarshaller<Workspace, XmlUnmarshallerContext>, IUnmarshaller<Workspace, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Workspace IUnmarshaller<Workspace, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Workspace Unmarshall(JsonUnmarshallerContext context)
        {
            Workspace unmarshalledObject = new Workspace();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BundleId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BundleId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComputerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComputerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataReplicationSettings", targetDepth))
                {
                    var unmarshaller = DataReplicationSettingsUnmarshaller.Instance;
                    unmarshalledObject.DataReplicationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DirectoryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DirectoryId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ipv6Address", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ipv6Address = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModificationStates", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ModificationState, ModificationStateUnmarshaller>(ModificationStateUnmarshaller.Instance);
                    unmarshalledObject.ModificationStates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelatedWorkspaces", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RelatedWorkspaceProperties, RelatedWorkspacePropertiesUnmarshaller>(RelatedWorkspacePropertiesUnmarshaller.Instance);
                    unmarshalledObject.RelatedWorkspaces = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RootVolumeEncryptionEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RootVolumeEncryptionEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StandbyWorkspacesProperties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StandbyWorkspacesProperties, StandbyWorkspacesPropertiesUnmarshaller>(StandbyWorkspacesPropertiesUnmarshaller.Instance);
                    unmarshalledObject.StandbyWorkspacesProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserVolumeEncryptionEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UserVolumeEncryptionEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeEncryptionKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeEncryptionKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WorkspaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkspaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WorkspaceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkspaceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WorkspaceProperties", targetDepth))
                {
                    var unmarshaller = WorkspacePropertiesUnmarshaller.Instance;
                    unmarshalledObject.WorkspaceProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WorkspaceUnmarshaller _instance = new WorkspaceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkspaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}