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
    /// Response Unmarshaller for Firewall Object
    /// </summary>
    public partial class FirewallUnmarshaller : ICborUnmarshaller<Firewall, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Firewall Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Firewall();
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
                    case "AvailabilityZoneChangeProtection":
                        context.AddPathSegment("AvailabilityZoneChangeProtection");
                        unmarshalledObject.AvailabilityZoneChangeProtection = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AvailabilityZoneMappings":
                        context.AddPathSegment("AvailabilityZoneMappings");
                        unmarshalledObject.AvailabilityZoneMappings = new CborListUnmarshaller<AvailabilityZoneMapping, AvailabilityZoneMappingUnmarshaller>(AvailabilityZoneMappingUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeleteProtection":
                        context.AddPathSegment("DeleteProtection");
                        unmarshalledObject.DeleteProtection = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EnabledAnalysisTypes":
                        context.AddPathSegment("EnabledAnalysisTypes");
                        unmarshalledObject.EnabledAnalysisTypes = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EncryptionConfiguration":
                        context.AddPathSegment("EncryptionConfiguration");
                        unmarshalledObject.EncryptionConfiguration = EncryptionConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallArn":
                        context.AddPathSegment("FirewallArn");
                        unmarshalledObject.FirewallArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallId":
                        context.AddPathSegment("FirewallId");
                        unmarshalledObject.FirewallId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallName":
                        context.AddPathSegment("FirewallName");
                        unmarshalledObject.FirewallName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallPolicyArn":
                        context.AddPathSegment("FirewallPolicyArn");
                        unmarshalledObject.FirewallPolicyArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallPolicyChangeProtection":
                        context.AddPathSegment("FirewallPolicyChangeProtection");
                        unmarshalledObject.FirewallPolicyChangeProtection = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NatGatewayCreateMappings":
                        context.AddPathSegment("NatGatewayCreateMappings");
                        unmarshalledObject.NatGatewayCreateMappings = new CborListUnmarshaller<NatGatewayCreateMapping, NatGatewayCreateMappingUnmarshaller>(NatGatewayCreateMappingUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NumberOfAssociations":
                        context.AddPathSegment("NumberOfAssociations");
                        unmarshalledObject.NumberOfAssociations = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProxySettings":
                        context.AddPathSegment("ProxySettings");
                        unmarshalledObject.ProxySettings = ProxySettingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubnetChangeProtection":
                        context.AddPathSegment("SubnetChangeProtection");
                        unmarshalledObject.SubnetChangeProtection = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubnetMappings":
                        context.AddPathSegment("SubnetMappings");
                        unmarshalledObject.SubnetMappings = new CborListUnmarshaller<SubnetMapping, SubnetMappingUnmarshaller>(SubnetMappingUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TransitGatewayId":
                        context.AddPathSegment("TransitGatewayId");
                        unmarshalledObject.TransitGatewayId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TransitGatewayOwnerAccountId":
                        context.AddPathSegment("TransitGatewayOwnerAccountId");
                        unmarshalledObject.TransitGatewayOwnerAccountId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TransparentFilteringNatScope":
                        context.AddPathSegment("TransparentFilteringNatScope");
                        unmarshalledObject.TransparentFilteringNatScope = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VpcEndpoint":
                        context.AddPathSegment("VpcEndpoint");
                        unmarshalledObject.VpcEndpoint = VpcEndpointUnmarshaller.Instance.Unmarshall(context);
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

        private static FirewallUnmarshaller _instance = new FirewallUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static FirewallUnmarshaller Instance => _instance;
    }
}
