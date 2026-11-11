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

using Amazon.MemoryDB.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.MemoryDB.Model.Internal.MarshallTransformations
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
                    case "ACLName":
                        context.AddPathSegment("ACLName");
                        unmarshalledObject.ACLName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ARN":
                        context.AddPathSegment("ARN");
                        unmarshalledObject.ARN = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AutoMinorVersionUpgrade":
                        context.AddPathSegment("AutoMinorVersionUpgrade");
                        unmarshalledObject.AutoMinorVersionUpgrade = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AvailabilityMode":
                        context.AddPathSegment("AvailabilityMode");
                        unmarshalledObject.AvailabilityMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ClusterEndpoint":
                        context.AddPathSegment("ClusterEndpoint");
                        unmarshalledObject.ClusterEndpoint = EndpointUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DataTiering":
                        context.AddPathSegment("DataTiering");
                        unmarshalledObject.DataTiering = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Engine":
                        context.AddPathSegment("Engine");
                        unmarshalledObject.Engine = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EnginePatchVersion":
                        context.AddPathSegment("EnginePatchVersion");
                        unmarshalledObject.EnginePatchVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EngineVersion":
                        context.AddPathSegment("EngineVersion");
                        unmarshalledObject.EngineVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IpDiscovery":
                        context.AddPathSegment("IpDiscovery");
                        unmarshalledObject.IpDiscovery = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "KmsKeyId":
                        context.AddPathSegment("KmsKeyId");
                        unmarshalledObject.KmsKeyId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MaintenanceWindow":
                        context.AddPathSegment("MaintenanceWindow");
                        unmarshalledObject.MaintenanceWindow = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MultiRegionClusterName":
                        context.AddPathSegment("MultiRegionClusterName");
                        unmarshalledObject.MultiRegionClusterName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkType":
                        context.AddPathSegment("NetworkType");
                        unmarshalledObject.NetworkType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NodeType":
                        context.AddPathSegment("NodeType");
                        unmarshalledObject.NodeType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NumberOfShards":
                        context.AddPathSegment("NumberOfShards");
                        unmarshalledObject.NumberOfShards = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ParameterGroupName":
                        context.AddPathSegment("ParameterGroupName");
                        unmarshalledObject.ParameterGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ParameterGroupStatus":
                        context.AddPathSegment("ParameterGroupStatus");
                        unmarshalledObject.ParameterGroupStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PendingUpdates":
                        context.AddPathSegment("PendingUpdates");
                        unmarshalledObject.PendingUpdates = ClusterPendingUpdatesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SecurityGroups":
                        context.AddPathSegment("SecurityGroups");
                        unmarshalledObject.SecurityGroups = new CborListUnmarshaller<SecurityGroupMembership, SecurityGroupMembershipUnmarshaller>(SecurityGroupMembershipUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Shards":
                        context.AddPathSegment("Shards");
                        unmarshalledObject.Shards = new CborListUnmarshaller<Shard, ShardUnmarshaller>(ShardUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SnapshotRetentionLimit":
                        context.AddPathSegment("SnapshotRetentionLimit");
                        unmarshalledObject.SnapshotRetentionLimit = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SnapshotWindow":
                        context.AddPathSegment("SnapshotWindow");
                        unmarshalledObject.SnapshotWindow = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SnsTopicArn":
                        context.AddPathSegment("SnsTopicArn");
                        unmarshalledObject.SnsTopicArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SnsTopicStatus":
                        context.AddPathSegment("SnsTopicStatus");
                        unmarshalledObject.SnsTopicStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubnetGroupName":
                        context.AddPathSegment("SubnetGroupName");
                        unmarshalledObject.SubnetGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TLSEnabled":
                        context.AddPathSegment("TLSEnabled");
                        unmarshalledObject.TLSEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
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
