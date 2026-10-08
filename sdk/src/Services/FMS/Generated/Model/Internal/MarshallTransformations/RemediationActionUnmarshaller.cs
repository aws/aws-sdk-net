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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
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
    public class RemediationActionUnmarshaller : ICborUnmarshaller<RemediationAction, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RemediationAction Unmarshall(CborUnmarshallerContext context)
        {
            RemediationAction unmarshalledObject = new RemediationAction();
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
                    case "CreateNetworkAclAction":
                        {
                            context.AddPathSegment("CreateNetworkAclAction");
                            var unmarshaller = CreateNetworkAclActionUnmarshaller.Instance;
                            unmarshalledObject.CreateNetworkAclAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreateNetworkAclEntriesAction":
                        {
                            context.AddPathSegment("CreateNetworkAclEntriesAction");
                            var unmarshaller = CreateNetworkAclEntriesActionUnmarshaller.Instance;
                            unmarshalledObject.CreateNetworkAclEntriesAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DeleteNetworkAclEntriesAction":
                        {
                            context.AddPathSegment("DeleteNetworkAclEntriesAction");
                            var unmarshaller = DeleteNetworkAclEntriesActionUnmarshaller.Instance;
                            unmarshalledObject.DeleteNetworkAclEntriesAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EC2AssociateRouteTableAction":
                        {
                            context.AddPathSegment("EC2AssociateRouteTableAction");
                            var unmarshaller = EC2AssociateRouteTableActionUnmarshaller.Instance;
                            unmarshalledObject.EC2AssociateRouteTableAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EC2CopyRouteTableAction":
                        {
                            context.AddPathSegment("EC2CopyRouteTableAction");
                            var unmarshaller = EC2CopyRouteTableActionUnmarshaller.Instance;
                            unmarshalledObject.EC2CopyRouteTableAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EC2CreateRouteAction":
                        {
                            context.AddPathSegment("EC2CreateRouteAction");
                            var unmarshaller = EC2CreateRouteActionUnmarshaller.Instance;
                            unmarshalledObject.EC2CreateRouteAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EC2CreateRouteTableAction":
                        {
                            context.AddPathSegment("EC2CreateRouteTableAction");
                            var unmarshaller = EC2CreateRouteTableActionUnmarshaller.Instance;
                            unmarshalledObject.EC2CreateRouteTableAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EC2DeleteRouteAction":
                        {
                            context.AddPathSegment("EC2DeleteRouteAction");
                            var unmarshaller = EC2DeleteRouteActionUnmarshaller.Instance;
                            unmarshalledObject.EC2DeleteRouteAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EC2ReplaceRouteAction":
                        {
                            context.AddPathSegment("EC2ReplaceRouteAction");
                            var unmarshaller = EC2ReplaceRouteActionUnmarshaller.Instance;
                            unmarshalledObject.EC2ReplaceRouteAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EC2ReplaceRouteTableAssociationAction":
                        {
                            context.AddPathSegment("EC2ReplaceRouteTableAssociationAction");
                            var unmarshaller = EC2ReplaceRouteTableAssociationActionUnmarshaller.Instance;
                            unmarshalledObject.EC2ReplaceRouteTableAssociationAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FMSPolicyUpdateFirewallCreationConfigAction":
                        {
                            context.AddPathSegment("FMSPolicyUpdateFirewallCreationConfigAction");
                            var unmarshaller = FMSPolicyUpdateFirewallCreationConfigActionUnmarshaller.Instance;
                            unmarshalledObject.FMSPolicyUpdateFirewallCreationConfigAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ReplaceNetworkAclAssociationAction":
                        {
                            context.AddPathSegment("ReplaceNetworkAclAssociationAction");
                            var unmarshaller = ReplaceNetworkAclAssociationActionUnmarshaller.Instance;
                            unmarshalledObject.ReplaceNetworkAclAssociationAction = unmarshaller.Unmarshall(context);
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


        private static RemediationActionUnmarshaller _instance = new RemediationActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemediationActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}