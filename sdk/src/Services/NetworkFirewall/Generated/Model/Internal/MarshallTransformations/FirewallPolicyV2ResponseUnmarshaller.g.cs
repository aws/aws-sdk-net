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

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FirewallPolicyV2Response Object
    /// </summary>
    public partial class FirewallPolicyV2ResponseUnmarshaller : ICborUnmarshaller<FirewallPolicyV2Response, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public FirewallPolicyV2Response Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new FirewallPolicyV2Response();
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
                    case "ConsumedFirewallRuleCapacity":
                        context.AddPathSegment("ConsumedFirewallRuleCapacity");
                        unmarshalledObject.ConsumedFirewallRuleCapacity = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ConsumedIpsDomainCapacity":
                        context.AddPathSegment("ConsumedIpsDomainCapacity");
                        unmarshalledObject.ConsumedIpsDomainCapacity = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ConsumedIpsRuleCapacity":
                        context.AddPathSegment("ConsumedIpsRuleCapacity");
                        unmarshalledObject.ConsumedIpsRuleCapacity = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EncryptionConfiguration":
                        context.AddPathSegment("EncryptionConfiguration");
                        unmarshalledObject.EncryptionConfiguration = EncryptionConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Errors":
                        context.AddPathSegment("Errors");
                        unmarshalledObject.Errors = new CborListUnmarshaller<FirewallPolicyError, FirewallPolicyErrorUnmarshaller>(FirewallPolicyErrorUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallPolicyV2Arn":
                        context.AddPathSegment("FirewallPolicyV2Arn");
                        unmarshalledObject.FirewallPolicyV2Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallPolicyV2Id":
                        context.AddPathSegment("FirewallPolicyV2Id");
                        unmarshalledObject.FirewallPolicyV2Id = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallPolicyV2Name":
                        context.AddPathSegment("FirewallPolicyV2Name");
                        unmarshalledObject.FirewallPolicyV2Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallPolicyV2Status":
                        context.AddPathSegment("FirewallPolicyV2Status");
                        unmarshalledObject.FirewallPolicyV2Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastModifiedTime":
                        context.AddPathSegment("LastModifiedTime");
                        unmarshalledObject.LastModifiedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NumberOfAssociations":
                        context.AddPathSegment("NumberOfAssociations");
                        unmarshalledObject.NumberOfAssociations = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StatusMessage":
                        context.AddPathSegment("StatusMessage");
                        unmarshalledObject.StatusMessage = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Tags":
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

        private static FirewallPolicyV2ResponseUnmarshaller _instance = new FirewallPolicyV2ResponseUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static FirewallPolicyV2ResponseUnmarshaller Instance => _instance;
    }
}
