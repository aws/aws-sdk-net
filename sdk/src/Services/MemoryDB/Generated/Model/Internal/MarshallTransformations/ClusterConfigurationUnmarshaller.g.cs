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
    /// Response Unmarshaller for ClusterConfiguration Object
    /// </summary>
    public partial class ClusterConfigurationUnmarshaller : ICborUnmarshaller<ClusterConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ClusterConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ClusterConfiguration();
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

                    case "EngineVersion":
                        context.AddPathSegment("EngineVersion");
                        unmarshalledObject.EngineVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
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

                    case "MultiRegionParameterGroupName":
                        context.AddPathSegment("MultiRegionParameterGroupName");
                        unmarshalledObject.MultiRegionParameterGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NodeType":
                        context.AddPathSegment("NodeType");
                        unmarshalledObject.NodeType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NumShards":
                        context.AddPathSegment("NumShards");
                        unmarshalledObject.NumShards = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ParameterGroupName":
                        context.AddPathSegment("ParameterGroupName");
                        unmarshalledObject.ParameterGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Port":
                        context.AddPathSegment("Port");
                        unmarshalledObject.Port = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Shards":
                        context.AddPathSegment("Shards");
                        unmarshalledObject.Shards = new CborListUnmarshaller<ShardDetail, ShardDetailUnmarshaller>(ShardDetailUnmarshaller.Instance).Unmarshall(context);
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

                    case "SubnetGroupName":
                        context.AddPathSegment("SubnetGroupName");
                        unmarshalledObject.SubnetGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TopicArn":
                        context.AddPathSegment("TopicArn");
                        unmarshalledObject.TopicArn = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static ClusterConfigurationUnmarshaller _instance = new ClusterConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ClusterConfigurationUnmarshaller Instance => _instance;
    }
}
