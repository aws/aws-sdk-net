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

using Amazon.TranscribeService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InterruptionFilter Object
    /// </summary>
    public partial class InterruptionFilterUnmarshaller : ICborUnmarshaller<InterruptionFilter, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public InterruptionFilter Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new InterruptionFilter();
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
                    case "AbsoluteTimeRange":
                        context.AddPathSegment("AbsoluteTimeRange");
                        unmarshalledObject.AbsoluteTimeRange = AbsoluteTimeRangeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Negate":
                        context.AddPathSegment("Negate");
                        unmarshalledObject.Negate = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ParticipantRole":
                        context.AddPathSegment("ParticipantRole");
                        unmarshalledObject.ParticipantRole = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RelativeTimeRange":
                        context.AddPathSegment("RelativeTimeRange");
                        unmarshalledObject.RelativeTimeRange = RelativeTimeRangeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Threshold":
                        context.AddPathSegment("Threshold");
                        unmarshalledObject.Threshold = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
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

        private static InterruptionFilterUnmarshaller _instance = new InterruptionFilterUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InterruptionFilterUnmarshaller Instance => _instance;
    }
}
