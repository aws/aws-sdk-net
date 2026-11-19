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
    /// Response Unmarshaller for DescribeProxyResource Object
    /// </summary>
    public partial class DescribeProxyResourceUnmarshaller : ICborUnmarshaller<DescribeProxyResource, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DescribeProxyResource Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeProxyResource();
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
                    case "CreateTime":
                        context.AddPathSegment("CreateTime");
                        unmarshalledObject.CreateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeleteTime":
                        context.AddPathSegment("DeleteTime");
                        unmarshalledObject.DeleteTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FailureCode":
                        context.AddPathSegment("FailureCode");
                        unmarshalledObject.FailureCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FailureMessage":
                        context.AddPathSegment("FailureMessage");
                        unmarshalledObject.FailureMessage = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ListenerProperties":
                        context.AddPathSegment("ListenerProperties");
                        unmarshalledObject.ListenerProperties = new CborListUnmarshaller<ListenerProperty, ListenerPropertyUnmarshaller>(ListenerPropertyUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NatGatewayId":
                        context.AddPathSegment("NatGatewayId");
                        unmarshalledObject.NatGatewayId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PrivateDNSName":
                        context.AddPathSegment("PrivateDNSName");
                        unmarshalledObject.PrivateDNSName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProxyArn":
                        context.AddPathSegment("ProxyArn");
                        unmarshalledObject.ProxyArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProxyConfigurationArn":
                        context.AddPathSegment("ProxyConfigurationArn");
                        unmarshalledObject.ProxyConfigurationArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProxyConfigurationName":
                        context.AddPathSegment("ProxyConfigurationName");
                        unmarshalledObject.ProxyConfigurationName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProxyModifyState":
                        context.AddPathSegment("ProxyModifyState");
                        unmarshalledObject.ProxyModifyState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProxyName":
                        context.AddPathSegment("ProxyName");
                        unmarshalledObject.ProxyName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProxyState":
                        context.AddPathSegment("ProxyState");
                        unmarshalledObject.ProxyState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TlsInterceptProperties":
                        context.AddPathSegment("TlsInterceptProperties");
                        unmarshalledObject.TlsInterceptProperties = TlsInterceptPropertiesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UpdateTime":
                        context.AddPathSegment("UpdateTime");
                        unmarshalledObject.UpdateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VpcEndpointServiceName":
                        context.AddPathSegment("VpcEndpointServiceName");
                        unmarshalledObject.VpcEndpointServiceName = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static DescribeProxyResourceUnmarshaller _instance = new DescribeProxyResourceUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeProxyResourceUnmarshaller Instance => _instance;
    }
}
