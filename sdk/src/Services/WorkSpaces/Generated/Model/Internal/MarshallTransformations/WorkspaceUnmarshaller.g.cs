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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Workspace Object
    /// </summary>
    public partial class WorkspaceUnmarshaller : ICborUnmarshaller<Workspace, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Workspace Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Workspace();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "BundleId":
                        context.AddPathSegment("BundleId");
                        unmarshalledObject.BundleId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ComputerName":
                        context.AddPathSegment("ComputerName");
                        unmarshalledObject.ComputerName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DataReplicationSettings":
                        context.AddPathSegment("DataReplicationSettings");
                        unmarshalledObject.DataReplicationSettings = DataReplicationSettingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DirectoryId":
                        context.AddPathSegment("DirectoryId");
                        unmarshalledObject.DirectoryId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ErrorCode":
                        context.AddPathSegment("ErrorCode");
                        unmarshalledObject.ErrorCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ErrorMessage":
                        context.AddPathSegment("ErrorMessage");
                        unmarshalledObject.ErrorMessage = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IpAddress":
                        context.AddPathSegment("IpAddress");
                        unmarshalledObject.IpAddress = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Ipv6Address":
                        context.AddPathSegment("Ipv6Address");
                        unmarshalledObject.Ipv6Address = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ModificationStates":
                        context.AddPathSegment("ModificationStates");
                        unmarshalledObject.ModificationStates = new CborListUnmarshaller<ModificationState, ModificationStateUnmarshaller>(ModificationStateUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RelatedWorkspaces":
                        context.AddPathSegment("RelatedWorkspaces");
                        unmarshalledObject.RelatedWorkspaces = new CborListUnmarshaller<RelatedWorkspaceProperties, RelatedWorkspacePropertiesUnmarshaller>(RelatedWorkspacePropertiesUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RootVolumeEncryptionEnabled":
                        context.AddPathSegment("RootVolumeEncryptionEnabled");
                        unmarshalledObject.RootVolumeEncryptionEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StandbyWorkspacesProperties":
                        context.AddPathSegment("StandbyWorkspacesProperties");
                        unmarshalledObject.StandbyWorkspacesProperties = new CborListUnmarshaller<StandbyWorkspacesProperties, StandbyWorkspacesPropertiesUnmarshaller>(StandbyWorkspacesPropertiesUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubnetId":
                        context.AddPathSegment("SubnetId");
                        unmarshalledObject.SubnetId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UserName":
                        context.AddPathSegment("UserName");
                        unmarshalledObject.UserName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UserVolumeEncryptionEnabled":
                        context.AddPathSegment("UserVolumeEncryptionEnabled");
                        unmarshalledObject.UserVolumeEncryptionEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VolumeEncryptionKey":
                        context.AddPathSegment("VolumeEncryptionKey");
                        unmarshalledObject.VolumeEncryptionKey = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WorkspaceId":
                        context.AddPathSegment("WorkspaceId");
                        unmarshalledObject.WorkspaceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WorkspaceName":
                        context.AddPathSegment("WorkspaceName");
                        unmarshalledObject.WorkspaceName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WorkspaceProperties":
                        context.AddPathSegment("WorkspaceProperties");
                        unmarshalledObject.WorkspaceProperties = WorkspacePropertiesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static WorkspaceUnmarshaller _instance = new WorkspaceUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static WorkspaceUnmarshaller Instance => _instance;
    }
}
