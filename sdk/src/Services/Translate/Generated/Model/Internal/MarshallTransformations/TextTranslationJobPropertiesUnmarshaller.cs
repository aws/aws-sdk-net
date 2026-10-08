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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Translate.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
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
    public class TextTranslationJobPropertiesUnmarshaller : ICborUnmarshaller<TextTranslationJobProperties, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TextTranslationJobProperties Unmarshall(CborUnmarshallerContext context)
        {
            TextTranslationJobProperties unmarshalledObject = new TextTranslationJobProperties();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "DataAccessRoleArn":
                        {
                            context.AddPathSegment("DataAccessRoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DataAccessRoleArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EndTime":
                        {
                            context.AddPathSegment("EndTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InputDataConfig":
                        {
                            context.AddPathSegment("InputDataConfig");
                            var unmarshaller = InputDataConfigUnmarshaller.Instance;
                            unmarshalledObject.InputDataConfig = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "JobDetails":
                        {
                            context.AddPathSegment("JobDetails");
                            var unmarshaller = JobDetailsUnmarshaller.Instance;
                            unmarshalledObject.JobDetails = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "JobId":
                        {
                            context.AddPathSegment("JobId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.JobId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "JobName":
                        {
                            context.AddPathSegment("JobName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.JobName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "JobStatus":
                        {
                            context.AddPathSegment("JobStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.JobStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Message":
                        {
                            context.AddPathSegment("Message");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Message = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "OutputDataConfig":
                        {
                            context.AddPathSegment("OutputDataConfig");
                            var unmarshaller = OutputDataConfigUnmarshaller.Instance;
                            unmarshalledObject.OutputDataConfig = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ParallelDataNames":
                        {
                            context.AddPathSegment("ParallelDataNames");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.ParallelDataNames = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Settings":
                        {
                            context.AddPathSegment("Settings");
                            var unmarshaller = TranslationSettingsUnmarshaller.Instance;
                            unmarshalledObject.Settings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SourceLanguageCode":
                        {
                            context.AddPathSegment("SourceLanguageCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SourceLanguageCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SubmittedTime":
                        {
                            context.AddPathSegment("SubmittedTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.SubmittedTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TargetLanguageCodes":
                        {
                            context.AddPathSegment("TargetLanguageCodes");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.TargetLanguageCodes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TerminologyNames":
                        {
                            context.AddPathSegment("TerminologyNames");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.TerminologyNames = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
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
        public static TextTranslationJobPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}