/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Input Object
    /// </summary>  
    public class InputUnmarshaller : IUnmarshaller<Input, XmlUnmarshallerContext>, IUnmarshaller<Input, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Input IUnmarshaller<Input, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Input Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Input unmarshalledObject = new Input();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioSelectorGroups", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, AudioSelectorGroup, StringUnmarshaller, AudioSelectorGroupUnmarshaller>(StringUnmarshaller.Instance, AudioSelectorGroupUnmarshaller.Instance);
                    unmarshalledObject.AudioSelectorGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioSelectors", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, AudioSelector, StringUnmarshaller, AudioSelectorUnmarshaller>(StringUnmarshaller.Instance, AudioSelectorUnmarshaller.Instance);
                    unmarshalledObject.AudioSelectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("captionSelectors", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, CaptionSelector, StringUnmarshaller, CaptionSelectorUnmarshaller>(StringUnmarshaller.Instance, CaptionSelectorUnmarshaller.Instance);
                    unmarshalledObject.CaptionSelectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deblockFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeblockFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("denoiseFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DenoiseFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileInput", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filterEnable", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterEnable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filterStrength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FilterStrength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputClippings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InputClipping, InputClippingUnmarshaller>(InputClippingUnmarshaller.Instance);
                    unmarshalledObject.InputClippings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("programNumber", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProgramNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("psiControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PsiControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timecodeSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimecodeSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("videoSelector", targetDepth))
                {
                    var unmarshaller = VideoSelectorUnmarshaller.Instance;
                    unmarshalledObject.VideoSelector = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InputUnmarshaller _instance = new InputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}