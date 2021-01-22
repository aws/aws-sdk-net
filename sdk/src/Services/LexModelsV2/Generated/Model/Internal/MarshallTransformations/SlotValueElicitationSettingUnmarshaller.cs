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
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SlotValueElicitationSetting Object
    /// </summary>  
    public class SlotValueElicitationSettingUnmarshaller : IUnmarshaller<SlotValueElicitationSetting, XmlUnmarshallerContext>, IUnmarshaller<SlotValueElicitationSetting, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SlotValueElicitationSetting IUnmarshaller<SlotValueElicitationSetting, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SlotValueElicitationSetting Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SlotValueElicitationSetting unmarshalledObject = new SlotValueElicitationSetting();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("defaultValueSpecification", targetDepth))
                {
                    var unmarshaller = SlotDefaultValueSpecificationUnmarshaller.Instance;
                    unmarshalledObject.DefaultValueSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("promptSpecification", targetDepth))
                {
                    var unmarshaller = PromptSpecificationUnmarshaller.Instance;
                    unmarshalledObject.PromptSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleUtterances", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SampleUtterance, SampleUtteranceUnmarshaller>(SampleUtteranceUnmarshaller.Instance);
                    unmarshalledObject.SampleUtterances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("slotConstraint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SlotConstraint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("waitAndContinueSpecification", targetDepth))
                {
                    var unmarshaller = WaitAndContinueSpecificationUnmarshaller.Instance;
                    unmarshalledObject.WaitAndContinueSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SlotValueElicitationSettingUnmarshaller _instance = new SlotValueElicitationSettingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SlotValueElicitationSettingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}