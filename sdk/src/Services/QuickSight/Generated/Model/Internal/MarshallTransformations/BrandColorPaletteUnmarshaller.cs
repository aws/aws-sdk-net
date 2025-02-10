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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BrandColorPalette Object
    /// </summary>  
    public class BrandColorPaletteUnmarshaller : IJsonUnmarshaller<BrandColorPalette, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public BrandColorPalette Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            BrandColorPalette unmarshalledObject = new BrandColorPalette();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Accent", targetDepth))
                {
                    var unmarshaller = PaletteUnmarshaller.Instance;
                    unmarshalledObject.Accent = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Danger", targetDepth))
                {
                    var unmarshaller = PaletteUnmarshaller.Instance;
                    unmarshalledObject.Danger = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Dimension", targetDepth))
                {
                    var unmarshaller = PaletteUnmarshaller.Instance;
                    unmarshalledObject.Dimension = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Info", targetDepth))
                {
                    var unmarshaller = PaletteUnmarshaller.Instance;
                    unmarshalledObject.Info = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Measure", targetDepth))
                {
                    var unmarshaller = PaletteUnmarshaller.Instance;
                    unmarshalledObject.Measure = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Primary", targetDepth))
                {
                    var unmarshaller = PaletteUnmarshaller.Instance;
                    unmarshalledObject.Primary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Secondary", targetDepth))
                {
                    var unmarshaller = PaletteUnmarshaller.Instance;
                    unmarshalledObject.Secondary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Success", targetDepth))
                {
                    var unmarshaller = PaletteUnmarshaller.Instance;
                    unmarshalledObject.Success = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Warning", targetDepth))
                {
                    var unmarshaller = PaletteUnmarshaller.Instance;
                    unmarshalledObject.Warning = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BrandColorPaletteUnmarshaller _instance = new BrandColorPaletteUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BrandColorPaletteUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}