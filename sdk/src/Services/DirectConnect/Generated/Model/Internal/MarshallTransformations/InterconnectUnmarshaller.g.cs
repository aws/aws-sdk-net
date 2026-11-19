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

using Amazon.DirectConnect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Interconnect Object
    /// </summary>
    public partial class InterconnectUnmarshaller : ICborUnmarshaller<Interconnect, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Interconnect Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Interconnect();
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
                    case "awsDevice":
                        context.AddPathSegment("AwsDevice");
                        unmarshalledObject.AwsDevice = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "awsDeviceV2":
                        context.AddPathSegment("AwsDeviceV2");
                        unmarshalledObject.AwsDeviceV2 = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "awsLogicalDeviceId":
                        context.AddPathSegment("AwsLogicalDeviceId");
                        unmarshalledObject.AwsLogicalDeviceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "bandwidth":
                        context.AddPathSegment("Bandwidth");
                        unmarshalledObject.Bandwidth = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "encryptionMode":
                        context.AddPathSegment("EncryptionMode");
                        unmarshalledObject.EncryptionMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "hasLogicalRedundancy":
                        context.AddPathSegment("HasLogicalRedundancy");
                        unmarshalledObject.HasLogicalRedundancy = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "interconnectId":
                        context.AddPathSegment("InterconnectId");
                        unmarshalledObject.InterconnectId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "interconnectName":
                        context.AddPathSegment("InterconnectName");
                        unmarshalledObject.InterconnectName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "interconnectState":
                        context.AddPathSegment("InterconnectState");
                        unmarshalledObject.InterconnectState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "jumboFrameCapable":
                        context.AddPathSegment("JumboFrameCapable");
                        unmarshalledObject.JumboFrameCapable = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lagId":
                        context.AddPathSegment("LagId");
                        unmarshalledObject.LagId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "loaIssueTime":
                        context.AddPathSegment("LoaIssueTime");
                        unmarshalledObject.LoaIssueTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "location":
                        context.AddPathSegment("Location");
                        unmarshalledObject.Location = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "macSecCapable":
                        context.AddPathSegment("MacSecCapable");
                        unmarshalledObject.MacSecCapable = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "macSecKeys":
                        context.AddPathSegment("MacSecKeys");
                        unmarshalledObject.MacSecKeys = new CborListUnmarshaller<MacSecKey, MacSecKeyUnmarshaller>(MacSecKeyUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "portEncryptionStatus":
                        context.AddPathSegment("PortEncryptionStatus");
                        unmarshalledObject.PortEncryptionStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "providerName":
                        context.AddPathSegment("ProviderName");
                        unmarshalledObject.ProviderName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "region":
                        context.AddPathSegment("Region");
                        unmarshalledObject.Region = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
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

        private static InterconnectUnmarshaller _instance = new InterconnectUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InterconnectUnmarshaller Instance => _instance;
    }
}
