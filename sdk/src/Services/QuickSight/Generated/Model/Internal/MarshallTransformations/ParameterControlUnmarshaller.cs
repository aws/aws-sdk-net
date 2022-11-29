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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ParameterControl Object
    /// </summary>  
    public class ParameterControlUnmarshaller : IUnmarshaller<ParameterControl, XmlUnmarshallerContext>, IUnmarshaller<ParameterControl, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ParameterControl IUnmarshaller<ParameterControl, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ParameterControl Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ParameterControl unmarshalledObject = new ParameterControl();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DateTimePicker", targetDepth))
                {
                    var unmarshaller = ParameterDateTimePickerControlUnmarshaller.Instance;
                    unmarshalledObject.DateTimePicker = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dropdown", targetDepth))
                {
                    var unmarshaller = ParameterDropDownControlUnmarshaller.Instance;
                    unmarshalledObject.Dropdown = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("List", targetDepth))
                {
                    var unmarshaller = ParameterListControlUnmarshaller.Instance;
                    unmarshalledObject.List = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Slider", targetDepth))
                {
                    var unmarshaller = ParameterSliderControlUnmarshaller.Instance;
                    unmarshalledObject.Slider = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextArea", targetDepth))
                {
                    var unmarshaller = ParameterTextAreaControlUnmarshaller.Instance;
                    unmarshalledObject.TextArea = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextField", targetDepth))
                {
                    var unmarshaller = ParameterTextFieldControlUnmarshaller.Instance;
                    unmarshalledObject.TextField = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ParameterControlUnmarshaller _instance = new ParameterControlUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ParameterControlUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}