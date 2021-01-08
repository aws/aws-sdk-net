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
    /// Response Unmarshaller for UIColorPalette Object
    /// </summary>  
    public class UIColorPaletteUnmarshaller : IUnmarshaller<UIColorPalette, XmlUnmarshallerContext>, IUnmarshaller<UIColorPalette, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UIColorPalette IUnmarshaller<UIColorPalette, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UIColorPalette Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            UIColorPalette unmarshalledObject = new UIColorPalette();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Accent", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Accent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AccentForeground", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccentForeground = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Danger", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Danger = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DangerForeground", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DangerForeground = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dimension", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Dimension = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DimensionForeground", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DimensionForeground = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Measure", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Measure = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MeasureForeground", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MeasureForeground = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryBackground", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrimaryBackground = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryForeground", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrimaryForeground = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecondaryBackground", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecondaryBackground = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecondaryForeground", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecondaryForeground = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Success", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Success = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SuccessForeground", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SuccessForeground = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Warning", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Warning = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WarningForeground", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WarningForeground = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UIColorPaletteUnmarshaller _instance = new UIColorPaletteUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UIColorPaletteUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}