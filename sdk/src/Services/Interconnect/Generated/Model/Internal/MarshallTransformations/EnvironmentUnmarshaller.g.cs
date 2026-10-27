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

using Amazon.Interconnect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Interconnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Environment Object
    /// </summary>
    public partial class EnvironmentUnmarshaller : ICborUnmarshaller<Environment, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Environment Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Environment();
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
                    case "activationPageUrl":
                        context.AddPathSegment("ActivationPageUrl");
                        unmarshalledObject.ActivationPageUrl = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "bandwidths":
                        context.AddPathSegment("Bandwidths");
                        unmarshalledObject.Bandwidths = BandwidthsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "environmentId":
                        context.AddPathSegment("EnvironmentId");
                        unmarshalledObject.EnvironmentId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "location":
                        context.AddPathSegment("Location");
                        unmarshalledObject.Location = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "provider":
                        context.AddPathSegment("Provider");
                        unmarshalledObject.Provider = ProviderUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "remoteIdentifierType":
                        context.AddPathSegment("RemoteIdentifierType");
                        unmarshalledObject.RemoteIdentifierType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "state":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "type":
                        context.AddPathSegment("Type");
                        unmarshalledObject.Type = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static EnvironmentUnmarshaller _instance = new EnvironmentUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static EnvironmentUnmarshaller Instance => _instance;
    }
}
