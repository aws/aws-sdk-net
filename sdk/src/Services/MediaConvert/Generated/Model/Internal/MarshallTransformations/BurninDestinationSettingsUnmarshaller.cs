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

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BurninDestinationSettings Object
    /// </summary>  
    public class BurninDestinationSettingsUnmarshaller : IUnmarshaller<BurninDestinationSettings, XmlUnmarshallerContext>, IUnmarshaller<BurninDestinationSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BurninDestinationSettings IUnmarshaller<BurninDestinationSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public BurninDestinationSettings Unmarshall(JsonUnmarshallerContext context)
        {
            BurninDestinationSettings unmarshalledObject = new BurninDestinationSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("alignment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Alignment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("applyFontColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplyFontColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("backgroundColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackgroundColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("backgroundOpacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BackgroundOpacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fallbackFont", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FallbackFont = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontFileBold", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontFileBold = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontFileBoldItalic", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontFileBoldItalic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontFileItalic", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontFileItalic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontFileRegular", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontFileRegular = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontOpacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FontOpacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontResolution", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FontResolution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontScript", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontScript = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FontSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hexFontColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HexFontColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outlineColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutlineColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outlineSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.OutlineSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("removeRubyReserveAttributes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoveRubyReserveAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shadowColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShadowColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shadowOpacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ShadowOpacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shadowXOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ShadowXOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shadowYOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ShadowYOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stylePassthrough", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StylePassthrough = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("teletextSpacing", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TeletextSpacing = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("xPosition", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.XPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("yPosition", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.YPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BurninDestinationSettingsUnmarshaller _instance = new BurninDestinationSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BurninDestinationSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}