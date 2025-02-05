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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SubSlotValueElicitationSetting Object
    /// </summary>  
    public class SubSlotValueElicitationSettingUnmarshaller : IJsonUnmarshaller<SubSlotValueElicitationSetting, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SubSlotValueElicitationSetting Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SubSlotValueElicitationSetting unmarshalledObject = new SubSlotValueElicitationSetting();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("defaultValueSpecification", targetDepth))
                {
                    var unmarshaller = SlotDefaultValueSpecificationUnmarshaller.Instance;
                    unmarshalledObject.DefaultValueSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("promptSpecification", targetDepth))
                {
                    var unmarshaller = PromptSpecificationUnmarshaller.Instance;
                    unmarshalledObject.PromptSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sampleUtterances", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SampleUtterance, SampleUtteranceUnmarshaller>(SampleUtteranceUnmarshaller.Instance);
                    unmarshalledObject.SampleUtterances = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("waitAndContinueSpecification", targetDepth))
                {
                    var unmarshaller = WaitAndContinueSpecificationUnmarshaller.Instance;
                    unmarshalledObject.WaitAndContinueSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SubSlotValueElicitationSettingUnmarshaller _instance = new SubSlotValueElicitationSettingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubSlotValueElicitationSettingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}