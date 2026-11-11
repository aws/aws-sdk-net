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

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceChange Object
    /// </summary>
    public partial class ResourceChangeUnmarshaller : ICborUnmarshaller<ResourceChange, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ResourceChange Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ResourceChange();
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
                    case "Action":
                        context.AddPathSegment("Action");
                        unmarshalledObject.Action = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Details":
                        context.AddPathSegment("Details");
                        unmarshalledObject.Details = new CborListUnmarshaller<ResourceChangeDetail, ResourceChangeDetailUnmarshaller>(ResourceChangeDetailUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LogicalResourceId":
                        context.AddPathSegment("LogicalResourceId");
                        unmarshalledObject.LogicalResourceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PhysicalResourceId":
                        context.AddPathSegment("PhysicalResourceId");
                        unmarshalledObject.PhysicalResourceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Replacement":
                        context.AddPathSegment("Replacement");
                        unmarshalledObject.Replacement = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResourceType":
                        context.AddPathSegment("ResourceType");
                        unmarshalledObject.ResourceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Scope":
                        context.AddPathSegment("Scope");
                        unmarshalledObject.Scope = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
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

        private static ResourceChangeUnmarshaller _instance = new ResourceChangeUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ResourceChangeUnmarshaller Instance => _instance;
    }
}
