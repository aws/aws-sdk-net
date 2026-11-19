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

using Amazon.PartnerCentralMarketing.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralMarketing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ImageFieldType Object
    /// </summary>
    public partial class ImageFieldTypeUnmarshaller : ICborUnmarshaller<ImageFieldType, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ImageFieldType Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ImageFieldType();
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
                    case "AllowedFormats":
                        context.AddPathSegment("AllowedFormats");
                        unmarshalledObject.AllowedFormats = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DefaultValue":
                        context.AddPathSegment("DefaultValue");
                        unmarshalledObject.DefaultValue = LayoutPreviewUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MaxSizeBytes":
                        context.AddPathSegment("MaxSizeBytes");
                        unmarshalledObject.MaxSizeBytes = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RecommendedHeightPixels":
                        context.AddPathSegment("RecommendedHeightPixels");
                        unmarshalledObject.RecommendedHeightPixels = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RecommendedWidthPixels":
                        context.AddPathSegment("RecommendedWidthPixels");
                        unmarshalledObject.RecommendedWidthPixels = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
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

        private static ImageFieldTypeUnmarshaller _instance = new ImageFieldTypeUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImageFieldTypeUnmarshaller Instance => _instance;
    }
}
