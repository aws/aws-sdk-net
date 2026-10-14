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
    /// Response Unmarshaller for Connection Object
    /// </summary>
    public partial class ConnectionUnmarshaller : ICborUnmarshaller<Connection, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Connection Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Connection();
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
                    case "activationKey":
                        context.AddPathSegment("ActivationKey");
                        unmarshalledObject.ActivationKey = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "arn":
                        context.AddPathSegment("Arn");
                        unmarshalledObject.Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "attachPoint":
                        context.AddPathSegment("AttachPoint");
                        unmarshalledObject.AttachPoint = AttachPointUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "bandwidth":
                        context.AddPathSegment("Bandwidth");
                        unmarshalledObject.Bandwidth = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "billingTier":
                        context.AddPathSegment("BillingTier");
                        unmarshalledObject.BillingTier = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "environmentId":
                        context.AddPathSegment("EnvironmentId");
                        unmarshalledObject.EnvironmentId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "id":
                        context.AddPathSegment("Id");
                        unmarshalledObject.Id = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "location":
                        context.AddPathSegment("Location");
                        unmarshalledObject.Location = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ownerAccount":
                        context.AddPathSegment("OwnerAccount");
                        unmarshalledObject.OwnerAccount = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "provider":
                        context.AddPathSegment("Provider");
                        unmarshalledObject.Provider = ProviderUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "sharedId":
                        context.AddPathSegment("SharedId");
                        unmarshalledObject.SharedId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "state":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance).Unmarshall(context);
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

        private static ConnectionUnmarshaller _instance = new ConnectionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ConnectionUnmarshaller Instance => _instance;
    }
}
