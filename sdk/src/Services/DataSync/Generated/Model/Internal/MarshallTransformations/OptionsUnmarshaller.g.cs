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

using Amazon.DataSync.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Options Object
    /// </summary>
    public partial class OptionsUnmarshaller : ICborUnmarshaller<Options, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Options Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Options();
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
                    case "Atime":
                        context.AddPathSegment("Atime");
                        unmarshalledObject.Atime = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BytesPerSecond":
                        context.AddPathSegment("BytesPerSecond");
                        unmarshalledObject.BytesPerSecond = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Gid":
                        context.AddPathSegment("Gid");
                        unmarshalledObject.Gid = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LogLevel":
                        context.AddPathSegment("LogLevel");
                        unmarshalledObject.LogLevel = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Mtime":
                        context.AddPathSegment("Mtime");
                        unmarshalledObject.Mtime = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ObjectMetadata":
                        context.AddPathSegment("ObjectMetadata");
                        unmarshalledObject.ObjectMetadata = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ObjectTags":
                        context.AddPathSegment("ObjectTags");
                        unmarshalledObject.ObjectTags = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OverwriteMode":
                        context.AddPathSegment("OverwriteMode");
                        unmarshalledObject.OverwriteMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PosixPermissions":
                        context.AddPathSegment("PosixPermissions");
                        unmarshalledObject.PosixPermissions = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PreserveDeletedFiles":
                        context.AddPathSegment("PreserveDeletedFiles");
                        unmarshalledObject.PreserveDeletedFiles = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PreserveDevices":
                        context.AddPathSegment("PreserveDevices");
                        unmarshalledObject.PreserveDevices = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SecurityDescriptorCopyFlags":
                        context.AddPathSegment("SecurityDescriptorCopyFlags");
                        unmarshalledObject.SecurityDescriptorCopyFlags = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TaskQueueing":
                        context.AddPathSegment("TaskQueueing");
                        unmarshalledObject.TaskQueueing = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TransferMode":
                        context.AddPathSegment("TransferMode");
                        unmarshalledObject.TransferMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Uid":
                        context.AddPathSegment("Uid");
                        unmarshalledObject.Uid = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VerifyMode":
                        context.AddPathSegment("VerifyMode");
                        unmarshalledObject.VerifyMode = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static OptionsUnmarshaller _instance = new OptionsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static OptionsUnmarshaller Instance => _instance;
    }
}
