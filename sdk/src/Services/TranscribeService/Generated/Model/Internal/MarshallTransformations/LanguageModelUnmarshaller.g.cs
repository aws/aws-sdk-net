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
    /// Response Unmarshaller for LanguageModel Object
    /// </summary>
    public partial class LanguageModelUnmarshaller : ICborUnmarshaller<LanguageModel, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public LanguageModel Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new LanguageModel();
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
                    case "BaseModelName":
                        context.AddPathSegment("BaseModelName");
                        unmarshalledObject.BaseModelName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreateTime":
                        context.AddPathSegment("CreateTime");
                        unmarshalledObject.CreateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EncryptionConfiguration":
                        context.AddPathSegment("EncryptionConfiguration");
                        unmarshalledObject.EncryptionConfiguration = EncryptionConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FailureReason":
                        context.AddPathSegment("FailureReason");
                        unmarshalledObject.FailureReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InputDataConfig":
                        context.AddPathSegment("InputDataConfig");
                        unmarshalledObject.InputDataConfig = InputDataConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LanguageCode":
                        context.AddPathSegment("LanguageCode");
                        unmarshalledObject.LanguageCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastModifiedTime":
                        context.AddPathSegment("LastModifiedTime");
                        unmarshalledObject.LastModifiedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ModelName":
                        context.AddPathSegment("ModelName");
                        unmarshalledObject.ModelName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ModelStatus":
                        context.AddPathSegment("ModelStatus");
                        unmarshalledObject.ModelStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UpgradeAvailability":
                        context.AddPathSegment("UpgradeAvailability");
                        unmarshalledObject.UpgradeAvailability = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
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

        private static LanguageModelUnmarshaller _instance = new LanguageModelUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static LanguageModelUnmarshaller Instance => _instance;
    }
}
