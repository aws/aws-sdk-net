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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Translate.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TextTranslationJobProperties Object
    /// </summary>  
    public class TextTranslationJobPropertiesUnmarshaller : IJsonUnmarshaller<TextTranslationJobProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TextTranslationJobProperties Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TextTranslationJobProperties unmarshalledObject = new TextTranslationJobProperties();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DataAccessRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataAccessRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InputDataConfig", targetDepth))
                {
                    var unmarshaller = InputDataConfigUnmarshaller.Instance;
                    unmarshalledObject.InputDataConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JobDetails", targetDepth))
                {
                    var unmarshaller = JobDetailsUnmarshaller.Instance;
                    unmarshalledObject.JobDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JobId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Message = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OutputDataConfig", targetDepth))
                {
                    var unmarshaller = OutputDataConfigUnmarshaller.Instance;
                    unmarshalledObject.OutputDataConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ParallelDataNames", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ParallelDataNames = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Settings", targetDepth))
                {
                    var unmarshaller = TranslationSettingsUnmarshaller.Instance;
                    unmarshalledObject.Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceLanguageCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceLanguageCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubmittedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.SubmittedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetLanguageCodes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TargetLanguageCodes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TerminologyNames", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TerminologyNames = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
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