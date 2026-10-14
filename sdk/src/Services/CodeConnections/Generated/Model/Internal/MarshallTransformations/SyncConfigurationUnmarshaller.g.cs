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

using Amazon.CodeConnections.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeConnections.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SyncConfiguration Object
    /// </summary>
    public partial class SyncConfigurationUnmarshaller : ICborUnmarshaller<SyncConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public SyncConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new SyncConfiguration();
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
                    case "Branch":
                        context.AddPathSegment("Branch");
                        unmarshalledObject.Branch = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ConfigFile":
                        context.AddPathSegment("ConfigFile");
                        unmarshalledObject.ConfigFile = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OwnerId":
                        context.AddPathSegment("OwnerId");
                        unmarshalledObject.OwnerId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProviderType":
                        context.AddPathSegment("ProviderType");
                        unmarshalledObject.ProviderType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PublishDeploymentStatus":
                        context.AddPathSegment("PublishDeploymentStatus");
                        unmarshalledObject.PublishDeploymentStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PullRequestComment":
                        context.AddPathSegment("PullRequestComment");
                        unmarshalledObject.PullRequestComment = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RepositoryLinkId":
                        context.AddPathSegment("RepositoryLinkId");
                        unmarshalledObject.RepositoryLinkId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RepositoryName":
                        context.AddPathSegment("RepositoryName");
                        unmarshalledObject.RepositoryName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResourceName":
                        context.AddPathSegment("ResourceName");
                        unmarshalledObject.ResourceName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RoleArn":
                        context.AddPathSegment("RoleArn");
                        unmarshalledObject.RoleArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SyncType":
                        context.AddPathSegment("SyncType");
                        unmarshalledObject.SyncType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TriggerResourceUpdateOn":
                        context.AddPathSegment("TriggerResourceUpdateOn");
                        unmarshalledObject.TriggerResourceUpdateOn = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static SyncConfigurationUnmarshaller _instance = new SyncConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SyncConfigurationUnmarshaller Instance => _instance;
    }
}
