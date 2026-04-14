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
 * Do not modify this file. This file is generated from the interconnect-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Interconnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
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
    public class EnvironmentUnmarshaller : ICborUnmarshaller<Environment, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Environment Unmarshall(CborUnmarshallerContext context)
        {
            Environment unmarshalledObject = new Environment();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "activationPageUrl":
                        {
                            context.AddPathSegment("ActivationPageUrl");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ActivationPageUrl = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "bandwidths":
                        {
                            context.AddPathSegment("Bandwidths");
                            var unmarshaller = BandwidthsUnmarshaller.Instance;
                            unmarshalledObject.Bandwidths = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "environmentId":
                        {
                            context.AddPathSegment("EnvironmentId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EnvironmentId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "location":
                        {
                            context.AddPathSegment("Location");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Location = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "provider":
                        {
                            context.AddPathSegment("Provider");
                            var unmarshaller = ProviderUnmarshaller.Instance;
                            unmarshalledObject.Provider = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "remoteIdentifierType":
                        {
                            context.AddPathSegment("RemoteIdentifierType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RemoteIdentifierType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "state":
                        {
                            context.AddPathSegment("State");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.State = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "type":
                        {
                            context.AddPathSegment("Type");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
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
        public static EnvironmentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}