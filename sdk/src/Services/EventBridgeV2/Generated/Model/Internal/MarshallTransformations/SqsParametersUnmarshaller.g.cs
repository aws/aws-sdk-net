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

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SqsParameters Object
    /// </summary>
    public partial class SqsParametersUnmarshaller : ICborUnmarshaller<SqsParameters, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public SqsParameters Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new SqsParameters();
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
                    case "DelaySeconds":
                        context.AddPathSegment("DelaySeconds");
                        unmarshalledObject.DelaySeconds = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MessageAttributes":
                        context.AddPathSegment("MessageAttributes");
                        unmarshalledObject.MessageAttributes = new CborDictionaryUnmarshaller<string, SqsMessageAttributeValue, CborStringUnmarshaller, SqsMessageAttributeValueUnmarshaller>(CborStringUnmarshaller.Instance, SqsMessageAttributeValueUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MessageDeduplicationId":
                        context.AddPathSegment("MessageDeduplicationId");
                        unmarshalledObject.MessageDeduplicationId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MessageGroupId":
                        context.AddPathSegment("MessageGroupId");
                        unmarshalledObject.MessageGroupId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MessageSystemAttributes":
                        context.AddPathSegment("MessageSystemAttributes");
                        unmarshalledObject.MessageSystemAttributes = new CborDictionaryUnmarshaller<string, SqsMessageAttributeValue, CborStringUnmarshaller, SqsMessageAttributeValueUnmarshaller>(CborStringUnmarshaller.Instance, SqsMessageAttributeValueUnmarshaller.Instance).Unmarshall(context);
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

        private static SqsParametersUnmarshaller _instance = new SqsParametersUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SqsParametersUnmarshaller Instance => _instance;
    }
}
