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
    /// Response Unmarshaller for FilterControl Object
    /// </summary>  
    public class FilterControlUnmarshaller : IUnmarshaller<FilterControl, XmlUnmarshallerContext>, IUnmarshaller<FilterControl, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FilterControl IUnmarshaller<FilterControl, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FilterControl Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FilterControl unmarshalledObject = new FilterControl();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DateTimePicker", targetDepth))
                {
                    var unmarshaller = FilterDateTimePickerControlUnmarshaller.Instance;
                    unmarshalledObject.DateTimePicker = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dropdown", targetDepth))
                {
                    var unmarshaller = FilterDropDownControlUnmarshaller.Instance;
                    unmarshalledObject.Dropdown = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("List", targetDepth))
                {
                    var unmarshaller = FilterListControlUnmarshaller.Instance;
                    unmarshalledObject.List = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelativeDateTime", targetDepth))
                {
                    var unmarshaller = FilterRelativeDateTimeControlUnmarshaller.Instance;
                    unmarshalledObject.RelativeDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Slider", targetDepth))
                {
                    var unmarshaller = FilterSliderControlUnmarshaller.Instance;
                    unmarshalledObject.Slider = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextArea", targetDepth))
                {
                    var unmarshaller = FilterTextAreaControlUnmarshaller.Instance;
                    unmarshalledObject.TextArea = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextField", targetDepth))
                {
                    var unmarshaller = FilterTextFieldControlUnmarshaller.Instance;
                    unmarshalledObject.TextField = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FilterControlUnmarshaller _instance = new FilterControlUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FilterControlUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}