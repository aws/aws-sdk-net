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

using Amazon.CloudHSMV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudHSMV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Cluster Object
    /// </summary>
    public partial class ClusterUnmarshaller : ICborUnmarshaller<Cluster, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Cluster Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Cluster();
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
                    case "BackupPolicy":
                        context.AddPathSegment("BackupPolicy");
                        unmarshalledObject.BackupPolicy = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BackupRetentionPolicy":
                        context.AddPathSegment("BackupRetentionPolicy");
                        unmarshalledObject.BackupRetentionPolicy = BackupRetentionPolicyUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Certificates":
                        context.AddPathSegment("Certificates");
                        unmarshalledObject.Certificates = CertificatesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ClusterId":
                        context.AddPathSegment("ClusterId");
                        unmarshalledObject.ClusterId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreateTimestamp":
                        context.AddPathSegment("CreateTimestamp");
                        unmarshalledObject.CreateTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HsmType":
                        context.AddPathSegment("HsmType");
                        unmarshalledObject.HsmType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HsmTypeRollbackExpiration":
                        context.AddPathSegment("HsmTypeRollbackExpiration");
                        unmarshalledObject.HsmTypeRollbackExpiration = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Hsms":
                        context.AddPathSegment("Hsms");
                        unmarshalledObject.Hsms = new CborListUnmarshaller<Hsm, HsmUnmarshaller>(HsmUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Mode":
                        context.AddPathSegment("Mode");
                        unmarshalledObject.Mode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkType":
                        context.AddPathSegment("NetworkType");
                        unmarshalledObject.NetworkType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PreCoPassword":
                        context.AddPathSegment("PreCoPassword");
                        unmarshalledObject.PreCoPassword = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SecurityGroup":
                        context.AddPathSegment("SecurityGroup");
                        unmarshalledObject.SecurityGroup = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceBackupId":
                        context.AddPathSegment("SourceBackupId");
                        unmarshalledObject.SourceBackupId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateMessage":
                        context.AddPathSegment("StateMessage");
                        unmarshalledObject.StateMessage = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubnetMapping":
                        context.AddPathSegment("SubnetMapping");
                        unmarshalledObject.SubnetMapping = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TagList":
                        context.AddPathSegment("TagList");
                        unmarshalledObject.TagList = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VpcId":
                        context.AddPathSegment("VpcId");
                        unmarshalledObject.VpcId = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static ClusterUnmarshaller _instance = new ClusterUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ClusterUnmarshaller Instance => _instance;
    }
}
