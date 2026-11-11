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
    /// Response Unmarshaller for WorkspaceDirectory Object
    /// </summary>
    public partial class WorkspaceDirectoryUnmarshaller : ICborUnmarshaller<WorkspaceDirectory, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public WorkspaceDirectory Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new WorkspaceDirectory();
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
                    case "ActiveDirectoryConfig":
                        context.AddPathSegment("ActiveDirectoryConfig");
                        unmarshalledObject.ActiveDirectoryConfig = ActiveDirectoryConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Alias":
                        context.AddPathSegment("Alias");
                        unmarshalledObject.Alias = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CertificateBasedAuthProperties":
                        context.AddPathSegment("CertificateBasedAuthProperties");
                        unmarshalledObject.CertificateBasedAuthProperties = CertificateBasedAuthPropertiesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CustomerUserName":
                        context.AddPathSegment("CustomerUserName");
                        unmarshalledObject.CustomerUserName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DirectoryId":
                        context.AddPathSegment("DirectoryId");
                        unmarshalledObject.DirectoryId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DirectoryName":
                        context.AddPathSegment("DirectoryName");
                        unmarshalledObject.DirectoryName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DirectoryType":
                        context.AddPathSegment("DirectoryType");
                        unmarshalledObject.DirectoryType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DnsIpAddresses":
                        context.AddPathSegment("DnsIpAddresses");
                        unmarshalledObject.DnsIpAddresses = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DnsIpv6Addresses":
                        context.AddPathSegment("DnsIpv6Addresses");
                        unmarshalledObject.DnsIpv6Addresses = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EndpointEncryptionMode":
                        context.AddPathSegment("EndpointEncryptionMode");
                        unmarshalledObject.EndpointEncryptionMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ErrorMessage":
                        context.AddPathSegment("ErrorMessage");
                        unmarshalledObject.ErrorMessage = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IDCConfig":
                        context.AddPathSegment("IDCConfig");
                        unmarshalledObject.IDCConfig = IDCConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IamRoleId":
                        context.AddPathSegment("IamRoleId");
                        unmarshalledObject.IamRoleId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ipGroupIds":
                        context.AddPathSegment("IpGroupIds");
                        unmarshalledObject.IpGroupIds = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MicrosoftEntraConfig":
                        context.AddPathSegment("MicrosoftEntraConfig");
                        unmarshalledObject.MicrosoftEntraConfig = MicrosoftEntraConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RegistrationCode":
                        context.AddPathSegment("RegistrationCode");
                        unmarshalledObject.RegistrationCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SamlProperties":
                        context.AddPathSegment("SamlProperties");
                        unmarshalledObject.SamlProperties = SamlPropertiesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SelfservicePermissions":
                        context.AddPathSegment("SelfservicePermissions");
                        unmarshalledObject.SelfservicePermissions = SelfservicePermissionsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StreamingProperties":
                        context.AddPathSegment("StreamingProperties");
                        unmarshalledObject.StreamingProperties = StreamingPropertiesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubnetIds":
                        context.AddPathSegment("SubnetIds");
                        unmarshalledObject.SubnetIds = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Tenancy":
                        context.AddPathSegment("Tenancy");
                        unmarshalledObject.Tenancy = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UserIdentityType":
                        context.AddPathSegment("UserIdentityType");
                        unmarshalledObject.UserIdentityType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WorkspaceAccessProperties":
                        context.AddPathSegment("WorkspaceAccessProperties");
                        unmarshalledObject.WorkspaceAccessProperties = WorkspaceAccessPropertiesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WorkspaceCreationProperties":
                        context.AddPathSegment("WorkspaceCreationProperties");
                        unmarshalledObject.WorkspaceCreationProperties = DefaultWorkspaceCreationPropertiesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WorkspaceDirectoryDescription":
                        context.AddPathSegment("WorkspaceDirectoryDescription");
                        unmarshalledObject.WorkspaceDirectoryDescription = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WorkspaceDirectoryName":
                        context.AddPathSegment("WorkspaceDirectoryName");
                        unmarshalledObject.WorkspaceDirectoryName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WorkspaceSecurityGroupId":
                        context.AddPathSegment("WorkspaceSecurityGroupId");
                        unmarshalledObject.WorkspaceSecurityGroupId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WorkspaceType":
                        context.AddPathSegment("WorkspaceType");
                        unmarshalledObject.WorkspaceType = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static WorkspaceDirectoryUnmarshaller _instance = new WorkspaceDirectoryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static WorkspaceDirectoryUnmarshaller Instance => _instance;
    }
}
