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

using Amazon.FMS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RemediationAction Object
    /// </summary>
    public partial class RemediationActionUnmarshaller : ICborUnmarshaller<RemediationAction, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RemediationAction Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RemediationAction();
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
                    case "CreateNetworkAclAction":
                        context.AddPathSegment("CreateNetworkAclAction");
                        unmarshalledObject.CreateNetworkAclAction = CreateNetworkAclActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreateNetworkAclEntriesAction":
                        context.AddPathSegment("CreateNetworkAclEntriesAction");
                        unmarshalledObject.CreateNetworkAclEntriesAction = CreateNetworkAclEntriesActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeleteNetworkAclEntriesAction":
                        context.AddPathSegment("DeleteNetworkAclEntriesAction");
                        unmarshalledObject.DeleteNetworkAclEntriesAction = DeleteNetworkAclEntriesActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EC2AssociateRouteTableAction":
                        context.AddPathSegment("EC2AssociateRouteTableAction");
                        unmarshalledObject.EC2AssociateRouteTableAction = EC2AssociateRouteTableActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EC2CopyRouteTableAction":
                        context.AddPathSegment("EC2CopyRouteTableAction");
                        unmarshalledObject.EC2CopyRouteTableAction = EC2CopyRouteTableActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EC2CreateRouteAction":
                        context.AddPathSegment("EC2CreateRouteAction");
                        unmarshalledObject.EC2CreateRouteAction = EC2CreateRouteActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EC2CreateRouteTableAction":
                        context.AddPathSegment("EC2CreateRouteTableAction");
                        unmarshalledObject.EC2CreateRouteTableAction = EC2CreateRouteTableActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EC2DeleteRouteAction":
                        context.AddPathSegment("EC2DeleteRouteAction");
                        unmarshalledObject.EC2DeleteRouteAction = EC2DeleteRouteActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EC2ReplaceRouteAction":
                        context.AddPathSegment("EC2ReplaceRouteAction");
                        unmarshalledObject.EC2ReplaceRouteAction = EC2ReplaceRouteActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EC2ReplaceRouteTableAssociationAction":
                        context.AddPathSegment("EC2ReplaceRouteTableAssociationAction");
                        unmarshalledObject.EC2ReplaceRouteTableAssociationAction = EC2ReplaceRouteTableAssociationActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FMSPolicyUpdateFirewallCreationConfigAction":
                        context.AddPathSegment("FMSPolicyUpdateFirewallCreationConfigAction");
                        unmarshalledObject.FMSPolicyUpdateFirewallCreationConfigAction = FMSPolicyUpdateFirewallCreationConfigActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ReplaceNetworkAclAssociationAction":
                        context.AddPathSegment("ReplaceNetworkAclAssociationAction");
                        unmarshalledObject.ReplaceNetworkAclAssociationAction = ReplaceNetworkAclAssociationActionUnmarshaller.Instance.Unmarshall(context);
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

        private static RemediationActionUnmarshaller _instance = new RemediationActionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RemediationActionUnmarshaller Instance => _instance;
    }
}
