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
    /// Response Unmarshaller for SlotCaptureSetting Object
    /// </summary>  
    public class SlotCaptureSettingUnmarshaller : IUnmarshaller<SlotCaptureSetting, XmlUnmarshallerContext>, IUnmarshaller<SlotCaptureSetting, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SlotCaptureSetting IUnmarshaller<SlotCaptureSetting, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SlotCaptureSetting Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SlotCaptureSetting unmarshalledObject = new SlotCaptureSetting();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("captureConditional", targetDepth))
                {
                    var unmarshaller = ConditionalSpecificationUnmarshaller.Instance;
                    unmarshalledObject.CaptureConditional = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("captureNextStep", targetDepth))
                {
                    var unmarshaller = DialogStateUnmarshaller.Instance;
                    unmarshalledObject.CaptureNextStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("captureResponse", targetDepth))
                {
                    var unmarshaller = ResponseSpecificationUnmarshaller.Instance;
                    unmarshalledObject.CaptureResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codeHook", targetDepth))
                {
                    var unmarshaller = DialogCodeHookInvocationSettingUnmarshaller.Instance;
                    unmarshalledObject.CodeHook = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("elicitationCodeHook", targetDepth))
                {
                    var unmarshaller = ElicitationCodeHookInvocationSettingUnmarshaller.Instance;
                    unmarshalledObject.ElicitationCodeHook = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureConditional", targetDepth))
                {
                    var unmarshaller = ConditionalSpecificationUnmarshaller.Instance;
                    unmarshalledObject.FailureConditional = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureNextStep", targetDepth))
                {
                    var unmarshaller = DialogStateUnmarshaller.Instance;
                    unmarshalledObject.FailureNextStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureResponse", targetDepth))
                {
                    var unmarshaller = ResponseSpecificationUnmarshaller.Instance;
                    unmarshalledObject.FailureResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SlotCaptureSettingUnmarshaller _instance = new SlotCaptureSettingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SlotCaptureSettingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}