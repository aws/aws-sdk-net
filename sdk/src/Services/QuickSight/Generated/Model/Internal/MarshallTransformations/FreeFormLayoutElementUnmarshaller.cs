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
    /// Response Unmarshaller for FreeFormLayoutElement Object
    /// </summary>  
    public class FreeFormLayoutElementUnmarshaller : IUnmarshaller<FreeFormLayoutElement, XmlUnmarshallerContext>, IUnmarshaller<FreeFormLayoutElement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FreeFormLayoutElement IUnmarshaller<FreeFormLayoutElement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FreeFormLayoutElement Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FreeFormLayoutElement unmarshalledObject = new FreeFormLayoutElement();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BackgroundStyle", targetDepth))
                {
                    var unmarshaller = FreeFormLayoutElementBackgroundStyleUnmarshaller.Instance;
                    unmarshalledObject.BackgroundStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BorderStyle", targetDepth))
                {
                    var unmarshaller = FreeFormLayoutElementBorderStyleUnmarshaller.Instance;
                    unmarshalledObject.BorderStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElementId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElementId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElementType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElementType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Height", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Height = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LoadingAnimation", targetDepth))
                {
                    var unmarshaller = LoadingAnimationUnmarshaller.Instance;
                    unmarshalledObject.LoadingAnimation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RenderingRules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SheetElementRenderingRule, SheetElementRenderingRuleUnmarshaller>(SheetElementRenderingRuleUnmarshaller.Instance);
                    unmarshalledObject.RenderingRules = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectedBorderStyle", targetDepth))
                {
                    var unmarshaller = FreeFormLayoutElementBorderStyleUnmarshaller.Instance;
                    unmarshalledObject.SelectedBorderStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Visibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Visibility = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Width", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Width = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XAxisLocation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.XAxisLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("YAxisLocation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.YAxisLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FreeFormLayoutElementUnmarshaller _instance = new FreeFormLayoutElementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FreeFormLayoutElementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}