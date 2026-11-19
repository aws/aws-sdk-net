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

using Amazon.Comprehend.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AugmentedManifestsListItem Object
    /// </summary>
    public partial class AugmentedManifestsListItemUnmarshaller : ICborUnmarshaller<AugmentedManifestsListItem, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AugmentedManifestsListItem Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new AugmentedManifestsListItem();
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
                    case "AnnotationDataS3Uri":
                        context.AddPathSegment("AnnotationDataS3Uri");
                        unmarshalledObject.AnnotationDataS3Uri = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AttributeNames":
                        context.AddPathSegment("AttributeNames");
                        unmarshalledObject.AttributeNames = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DocumentType":
                        context.AddPathSegment("DocumentType");
                        unmarshalledObject.DocumentType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "S3Uri":
                        context.AddPathSegment("S3Uri");
                        unmarshalledObject.S3Uri = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceDocumentsS3Uri":
                        context.AddPathSegment("SourceDocumentsS3Uri");
                        unmarshalledObject.SourceDocumentsS3Uri = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Split":
                        context.AddPathSegment("Split");
                        unmarshalledObject.Split = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static AugmentedManifestsListItemUnmarshaller _instance = new AugmentedManifestsListItemUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AugmentedManifestsListItemUnmarshaller Instance => _instance;
    }
}
