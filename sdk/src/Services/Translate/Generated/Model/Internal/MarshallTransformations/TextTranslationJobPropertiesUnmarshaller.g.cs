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

using Amazon.Translate.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Translate.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TextTranslationJobProperties Object
    /// </summary>
    public partial class TextTranslationJobPropertiesUnmarshaller : ICborUnmarshaller<TextTranslationJobProperties, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public TextTranslationJobProperties Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new TextTranslationJobProperties();
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

                    case "InputDataConfig":
                        context.AddPathSegment("InputDataConfig");
                        unmarshalledObject.InputDataConfig = InputDataConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "JobDetails":
                        context.AddPathSegment("JobDetails");
                        unmarshalledObject.JobDetails = JobDetailsUnmarshaller.Instance.Unmarshall(context);
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

                    case "Message":
                        context.AddPathSegment("Message");
                        unmarshalledObject.Message = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OutputDataConfig":
                        context.AddPathSegment("OutputDataConfig");
                        unmarshalledObject.OutputDataConfig = OutputDataConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ParallelDataNames":
                        context.AddPathSegment("ParallelDataNames");
                        unmarshalledObject.ParallelDataNames = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Settings":
                        context.AddPathSegment("Settings");
                        unmarshalledObject.Settings = TranslationSettingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceLanguageCode":
                        context.AddPathSegment("SourceLanguageCode");
                        unmarshalledObject.SourceLanguageCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubmittedTime":
                        context.AddPathSegment("SubmittedTime");
                        unmarshalledObject.SubmittedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TargetLanguageCodes":
                        context.AddPathSegment("TargetLanguageCodes");
                        unmarshalledObject.TargetLanguageCodes = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TerminologyNames":
                        context.AddPathSegment("TerminologyNames");
                        unmarshalledObject.TerminologyNames = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
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

        private static TextTranslationJobPropertiesUnmarshaller _instance = new TextTranslationJobPropertiesUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TextTranslationJobPropertiesUnmarshaller Instance => _instance;
    }
}
