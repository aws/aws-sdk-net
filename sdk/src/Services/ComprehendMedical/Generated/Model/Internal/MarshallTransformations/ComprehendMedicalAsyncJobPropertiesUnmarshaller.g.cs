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

using Amazon.ComprehendMedical.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ComprehendMedical.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ComprehendMedicalAsyncJobProperties Object
    /// </summary>
    public partial class ComprehendMedicalAsyncJobPropertiesUnmarshaller : ICborUnmarshaller<ComprehendMedicalAsyncJobProperties, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ComprehendMedicalAsyncJobProperties Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ComprehendMedicalAsyncJobProperties();
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
                    case "DataAccessRoleArn":
                        context.AddPathSegment("DataAccessRoleArn");
                        unmarshalledObject.DataAccessRoleArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EndTime":
                        context.AddPathSegment("EndTime");
                        unmarshalledObject.EndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ExpirationTime":
                        context.AddPathSegment("ExpirationTime");
                        unmarshalledObject.ExpirationTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InputDataConfig":
                        context.AddPathSegment("InputDataConfig");
                        unmarshalledObject.InputDataConfig = InputDataConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "JobId":
                        context.AddPathSegment("JobId");
                        unmarshalledObject.JobId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "JobName":
                        context.AddPathSegment("JobName");
                        unmarshalledObject.JobName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "JobStatus":
                        context.AddPathSegment("JobStatus");
                        unmarshalledObject.JobStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "KMSKey":
                        context.AddPathSegment("KMSKey");
                        unmarshalledObject.KMSKey = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LanguageCode":
                        context.AddPathSegment("LanguageCode");
                        unmarshalledObject.LanguageCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ManifestFilePath":
                        context.AddPathSegment("ManifestFilePath");
                        unmarshalledObject.ManifestFilePath = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Message":
                        context.AddPathSegment("Message");
                        unmarshalledObject.Message = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ModelVersion":
                        context.AddPathSegment("ModelVersion");
                        unmarshalledObject.ModelVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OutputDataConfig":
                        context.AddPathSegment("OutputDataConfig");
                        unmarshalledObject.OutputDataConfig = OutputDataConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubmitTime":
                        context.AddPathSegment("SubmitTime");
                        unmarshalledObject.SubmitTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
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

        private static ComprehendMedicalAsyncJobPropertiesUnmarshaller _instance = new ComprehendMedicalAsyncJobPropertiesUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ComprehendMedicalAsyncJobPropertiesUnmarshaller Instance => _instance;
    }
}
