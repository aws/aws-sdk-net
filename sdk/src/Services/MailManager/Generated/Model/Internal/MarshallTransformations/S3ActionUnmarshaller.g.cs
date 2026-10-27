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

using Amazon.MailManager.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3Action Object
    /// </summary>
    public partial class S3ActionUnmarshaller : ICborUnmarshaller<S3Action, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public S3Action Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new S3Action();
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
                    case "ActionFailurePolicy":
                        context.AddPathSegment("ActionFailurePolicy");
                        unmarshalledObject.ActionFailurePolicy = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RoleArn":
                        context.AddPathSegment("RoleArn");
                        unmarshalledObject.RoleArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "S3Bucket":
                        context.AddPathSegment("S3Bucket");
                        unmarshalledObject.S3Bucket = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "S3Prefix":
                        context.AddPathSegment("S3Prefix");
                        unmarshalledObject.S3Prefix = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "S3SseKmsKeyId":
                        context.AddPathSegment("S3SseKmsKeyId");
                        unmarshalledObject.S3SseKmsKeyId = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static S3ActionUnmarshaller _instance = new S3ActionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static S3ActionUnmarshaller Instance => _instance;
    }
}
