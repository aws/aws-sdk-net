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

using Amazon.AppStream.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AppBlock Object
    /// </summary>
    public partial class AppBlockUnmarshaller : ICborUnmarshaller<AppBlock, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AppBlock Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new AppBlock();
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
                    case "AppBlockErrors":
                        context.AddPathSegment("AppBlockErrors");
                        unmarshalledObject.AppBlockErrors = new CborListUnmarshaller<ErrorDetails, ErrorDetailsUnmarshaller>(ErrorDetailsUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Arn":
                        context.AddPathSegment("Arn");
                        unmarshalledObject.Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreatedTime":
                        context.AddPathSegment("CreatedTime");
                        unmarshalledObject.CreatedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DisplayName":
                        context.AddPathSegment("DisplayName");
                        unmarshalledObject.DisplayName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PackagingType":
                        context.AddPathSegment("PackagingType");
                        unmarshalledObject.PackagingType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PostSetupScriptDetails":
                        context.AddPathSegment("PostSetupScriptDetails");
                        unmarshalledObject.PostSetupScriptDetails = ScriptDetailsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SetupScriptDetails":
                        context.AddPathSegment("SetupScriptDetails");
                        unmarshalledObject.SetupScriptDetails = ScriptDetailsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceS3Location":
                        context.AddPathSegment("SourceS3Location");
                        unmarshalledObject.SourceS3Location = S3LocationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static AppBlockUnmarshaller _instance = new AppBlockUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AppBlockUnmarshaller Instance => _instance;
    }
}
