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

using Amazon.DirectoryService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Trust Object
    /// </summary>
    public partial class TrustUnmarshaller : ICborUnmarshaller<Trust, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Trust Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Trust();
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
                    case "CreatedDateTime":
                        context.AddPathSegment("CreatedDateTime");
                        unmarshalledObject.CreatedDateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DirectoryId":
                        context.AddPathSegment("DirectoryId");
                        unmarshalledObject.DirectoryId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastUpdatedDateTime":
                        context.AddPathSegment("LastUpdatedDateTime");
                        unmarshalledObject.LastUpdatedDateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RemoteDomainName":
                        context.AddPathSegment("RemoteDomainName");
                        unmarshalledObject.RemoteDomainName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SelectiveAuth":
                        context.AddPathSegment("SelectiveAuth");
                        unmarshalledObject.SelectiveAuth = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateLastUpdatedDateTime":
                        context.AddPathSegment("StateLastUpdatedDateTime");
                        unmarshalledObject.StateLastUpdatedDateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TrustDirection":
                        context.AddPathSegment("TrustDirection");
                        unmarshalledObject.TrustDirection = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TrustId":
                        context.AddPathSegment("TrustId");
                        unmarshalledObject.TrustId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TrustState":
                        context.AddPathSegment("TrustState");
                        unmarshalledObject.TrustState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TrustStateReason":
                        context.AddPathSegment("TrustStateReason");
                        unmarshalledObject.TrustStateReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TrustType":
                        context.AddPathSegment("TrustType");
                        unmarshalledObject.TrustType = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static TrustUnmarshaller _instance = new TrustUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TrustUnmarshaller Instance => _instance;
    }
}
