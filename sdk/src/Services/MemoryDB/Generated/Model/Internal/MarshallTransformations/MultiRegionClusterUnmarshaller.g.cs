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
    /// Response Unmarshaller for MultiRegionCluster Object
    /// </summary>
    public partial class MultiRegionClusterUnmarshaller : ICborUnmarshaller<MultiRegionCluster, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public MultiRegionCluster Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new MultiRegionCluster();
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
                    case "ARN":
                        context.AddPathSegment("ARN");
                        unmarshalledObject.ARN = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Clusters":
                        context.AddPathSegment("Clusters");
                        unmarshalledObject.Clusters = new CborListUnmarshaller<RegionalCluster, RegionalClusterUnmarshaller>(RegionalClusterUnmarshaller.Instance).Unmarshall(context);
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

                    case "EngineVersion":
                        context.AddPathSegment("EngineVersion");
                        unmarshalledObject.EngineVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
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

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static MultiRegionClusterUnmarshaller _instance = new MultiRegionClusterUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static MultiRegionClusterUnmarshaller Instance => _instance;
    }
}
