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
    /// Response Unmarshaller for DocumentClassifierProperties Object
    /// </summary>
    public partial class DocumentClassifierPropertiesUnmarshaller : ICborUnmarshaller<DocumentClassifierProperties, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DocumentClassifierProperties Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DocumentClassifierProperties();
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
                    case "ClassifierMetadata":
                        context.AddPathSegment("ClassifierMetadata");
                        unmarshalledObject.ClassifierMetadata = ClassifierMetadataUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DataAccessRoleArn":
                        context.AddPathSegment("DataAccessRoleArn");
                        unmarshalledObject.DataAccessRoleArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DocumentClassifierArn":
                        context.AddPathSegment("DocumentClassifierArn");
                        unmarshalledObject.DocumentClassifierArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EndTime":
                        context.AddPathSegment("EndTime");
                        unmarshalledObject.EndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FlywheelArn":
                        context.AddPathSegment("FlywheelArn");
                        unmarshalledObject.FlywheelArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InputDataConfig":
                        context.AddPathSegment("InputDataConfig");
                        unmarshalledObject.InputDataConfig = DocumentClassifierInputDataConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LanguageCode":
                        context.AddPathSegment("LanguageCode");
                        unmarshalledObject.LanguageCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Message":
                        context.AddPathSegment("Message");
                        unmarshalledObject.Message = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Mode":
                        context.AddPathSegment("Mode");
                        unmarshalledObject.Mode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ModelKmsKeyId":
                        context.AddPathSegment("ModelKmsKeyId");
                        unmarshalledObject.ModelKmsKeyId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OutputDataConfig":
                        context.AddPathSegment("OutputDataConfig");
                        unmarshalledObject.OutputDataConfig = DocumentClassifierOutputDataConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceModelArn":
                        context.AddPathSegment("SourceModelArn");
                        unmarshalledObject.SourceModelArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubmitTime":
                        context.AddPathSegment("SubmitTime");
                        unmarshalledObject.SubmitTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TrainingEndTime":
                        context.AddPathSegment("TrainingEndTime");
                        unmarshalledObject.TrainingEndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TrainingStartTime":
                        context.AddPathSegment("TrainingStartTime");
                        unmarshalledObject.TrainingStartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VersionName":
                        context.AddPathSegment("VersionName");
                        unmarshalledObject.VersionName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VolumeKmsKeyId":
                        context.AddPathSegment("VolumeKmsKeyId");
                        unmarshalledObject.VolumeKmsKeyId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VpcConfig":
                        context.AddPathSegment("VpcConfig");
                        unmarshalledObject.VpcConfig = VpcConfigUnmarshaller.Instance.Unmarshall(context);
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

        private static DocumentClassifierPropertiesUnmarshaller _instance = new DocumentClassifierPropertiesUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DocumentClassifierPropertiesUnmarshaller Instance => _instance;
    }
}
