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

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AccessGrantSummary Object
    /// </summary>
    public partial class AccessGrantSummaryUnmarshaller : ICborUnmarshaller<AccessGrantSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AccessGrantSummary Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new AccessGrantSummary();
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
                    case "domainId":
                        context.AddPathSegment("DomainId");
                        unmarshalledObject.DomainId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "grantArn":
                        context.AddPathSegment("GrantArn");
                        unmarshalledObject.GrantArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "grantId":
                        context.AddPathSegment("GrantId");
                        unmarshalledObject.GrantId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "grantType":
                        context.AddPathSegment("GrantType");
                        unmarshalledObject.GrantType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "permission":
                        context.AddPathSegment("Permission");
                        unmarshalledObject.Permission = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "principal":
                        context.AddPathSegment("Principal");
                        unmarshalledObject.Principal = AccessGrantPrincipalUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "spaceId":
                        context.AddPathSegment("SpaceId");
                        unmarshalledObject.SpaceId = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static AccessGrantSummaryUnmarshaller _instance = new AccessGrantSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AccessGrantSummaryUnmarshaller Instance => _instance;
    }
}
