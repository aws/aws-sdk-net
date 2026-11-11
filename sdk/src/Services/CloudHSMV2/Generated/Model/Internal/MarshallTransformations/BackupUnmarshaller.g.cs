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

using Amazon.CloudHSMV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudHSMV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Backup Object
    /// </summary>
    public partial class BackupUnmarshaller : ICborUnmarshaller<Backup, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Backup Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Backup();
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
                    case "BackupArn":
                        context.AddPathSegment("BackupArn");
                        unmarshalledObject.BackupArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BackupId":
                        context.AddPathSegment("BackupId");
                        unmarshalledObject.BackupId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BackupState":
                        context.AddPathSegment("BackupState");
                        unmarshalledObject.BackupState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ClusterId":
                        context.AddPathSegment("ClusterId");
                        unmarshalledObject.ClusterId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CopyTimestamp":
                        context.AddPathSegment("CopyTimestamp");
                        unmarshalledObject.CopyTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreateTimestamp":
                        context.AddPathSegment("CreateTimestamp");
                        unmarshalledObject.CreateTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeleteTimestamp":
                        context.AddPathSegment("DeleteTimestamp");
                        unmarshalledObject.DeleteTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HsmType":
                        context.AddPathSegment("HsmType");
                        unmarshalledObject.HsmType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Mode":
                        context.AddPathSegment("Mode");
                        unmarshalledObject.Mode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NeverExpires":
                        context.AddPathSegment("NeverExpires");
                        unmarshalledObject.NeverExpires = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceBackup":
                        context.AddPathSegment("SourceBackup");
                        unmarshalledObject.SourceBackup = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceCluster":
                        context.AddPathSegment("SourceCluster");
                        unmarshalledObject.SourceCluster = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceRegion":
                        context.AddPathSegment("SourceRegion");
                        unmarshalledObject.SourceRegion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TagList":
                        context.AddPathSegment("TagList");
                        unmarshalledObject.TagList = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
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

        private static BackupUnmarshaller _instance = new BackupUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BackupUnmarshaller Instance => _instance;
    }
}
