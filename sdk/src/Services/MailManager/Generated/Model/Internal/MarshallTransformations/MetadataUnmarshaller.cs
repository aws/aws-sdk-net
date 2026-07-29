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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Metadata Object
    /// </summary>  
    public class MetadataUnmarshaller : ICborUnmarshaller<Metadata, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Metadata Unmarshall(CborUnmarshallerContext context)
        {
            Metadata unmarshalledObject = new Metadata();
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
                    case "ConfigurationSet":
                        {
                            context.AddPathSegment("ConfigurationSet");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ConfigurationSet = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IngressPointId":
                        {
                            context.AddPathSegment("IngressPointId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IngressPointId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RuleSetId":
                        {
                            context.AddPathSegment("RuleSetId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RuleSetId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SenderHostname":
                        {
                            context.AddPathSegment("SenderHostname");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SenderHostname = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SenderIpAddress":
                        {
                            context.AddPathSegment("SenderIpAddress");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SenderIpAddress = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SendingMethod":
                        {
                            context.AddPathSegment("SendingMethod");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SendingMethod = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SendingPool":
                        {
                            context.AddPathSegment("SendingPool");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SendingPool = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SourceArn":
                        {
                            context.AddPathSegment("SourceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SourceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SourceIdentity":
                        {
                            context.AddPathSegment("SourceIdentity");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SourceIdentity = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Timestamp":
                        {
                            context.AddPathSegment("Timestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TlsCipherSuite":
                        {
                            context.AddPathSegment("TlsCipherSuite");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.TlsCipherSuite = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TlsProtocol":
                        {
                            context.AddPathSegment("TlsProtocol");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.TlsProtocol = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TrafficPolicyId":
                        {
                            context.AddPathSegment("TrafficPolicyId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.TrafficPolicyId = unmarshaller.Unmarshall(context);
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


        private static MetadataUnmarshaller _instance = new MetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}