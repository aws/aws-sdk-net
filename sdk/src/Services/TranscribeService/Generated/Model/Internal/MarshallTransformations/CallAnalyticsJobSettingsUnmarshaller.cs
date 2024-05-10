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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CallAnalyticsJobSettings Object
    /// </summary>  
    public class CallAnalyticsJobSettingsUnmarshaller : IUnmarshaller<CallAnalyticsJobSettings, XmlUnmarshallerContext>, IUnmarshaller<CallAnalyticsJobSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CallAnalyticsJobSettings IUnmarshaller<CallAnalyticsJobSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CallAnalyticsJobSettings Unmarshall(JsonUnmarshallerContext context)
        {
            CallAnalyticsJobSettings unmarshalledObject = new CallAnalyticsJobSettings();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ContentRedaction", targetDepth))
                {
                    var unmarshaller = ContentRedactionUnmarshaller.Instance;
                    unmarshalledObject.ContentRedaction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LanguageIdSettings", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, LanguageIdSettings, StringUnmarshaller, LanguageIdSettingsUnmarshaller>(StringUnmarshaller.Instance, LanguageIdSettingsUnmarshaller.Instance);
                    unmarshalledObject.LanguageIdSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LanguageModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LanguageModelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LanguageOptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LanguageOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Summarization", targetDepth))
                {
                    var unmarshaller = SummarizationUnmarshaller.Instance;
                    unmarshalledObject.Summarization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VocabularyFilterMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VocabularyFilterMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VocabularyFilterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VocabularyFilterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VocabularyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VocabularyName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CallAnalyticsJobSettingsUnmarshaller _instance = new CallAnalyticsJobSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CallAnalyticsJobSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}