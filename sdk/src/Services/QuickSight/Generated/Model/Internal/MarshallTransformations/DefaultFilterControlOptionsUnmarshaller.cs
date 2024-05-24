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

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DefaultFilterControlOptions Object
    /// </summary>  
    public class DefaultFilterControlOptionsUnmarshaller : IUnmarshaller<DefaultFilterControlOptions, XmlUnmarshallerContext>, IUnmarshaller<DefaultFilterControlOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DefaultFilterControlOptions IUnmarshaller<DefaultFilterControlOptions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DefaultFilterControlOptions Unmarshall(JsonUnmarshallerContext context)
        {
            DefaultFilterControlOptions unmarshalledObject = new DefaultFilterControlOptions();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DefaultDateTimePickerOptions", targetDepth))
                {
                    var unmarshaller = DefaultDateTimePickerControlOptionsUnmarshaller.Instance;
                    unmarshalledObject.DefaultDateTimePickerOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultDropdownOptions", targetDepth))
                {
                    var unmarshaller = DefaultFilterDropDownControlOptionsUnmarshaller.Instance;
                    unmarshalledObject.DefaultDropdownOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultListOptions", targetDepth))
                {
                    var unmarshaller = DefaultFilterListControlOptionsUnmarshaller.Instance;
                    unmarshalledObject.DefaultListOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultRelativeDateTimeOptions", targetDepth))
                {
                    var unmarshaller = DefaultRelativeDateTimeControlOptionsUnmarshaller.Instance;
                    unmarshalledObject.DefaultRelativeDateTimeOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultSliderOptions", targetDepth))
                {
                    var unmarshaller = DefaultSliderControlOptionsUnmarshaller.Instance;
                    unmarshalledObject.DefaultSliderOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultTextAreaOptions", targetDepth))
                {
                    var unmarshaller = DefaultTextAreaControlOptionsUnmarshaller.Instance;
                    unmarshalledObject.DefaultTextAreaOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultTextFieldOptions", targetDepth))
                {
                    var unmarshaller = DefaultTextFieldControlOptionsUnmarshaller.Instance;
                    unmarshalledObject.DefaultTextFieldOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DefaultFilterControlOptionsUnmarshaller _instance = new DefaultFilterControlOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DefaultFilterControlOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}