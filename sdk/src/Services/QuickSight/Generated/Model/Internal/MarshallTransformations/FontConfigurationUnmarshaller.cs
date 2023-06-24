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
    /// Response Unmarshaller for FontConfiguration Object
    /// </summary>  
    public class FontConfigurationUnmarshaller : IUnmarshaller<FontConfiguration, XmlUnmarshallerContext>, IUnmarshaller<FontConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FontConfiguration IUnmarshaller<FontConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FontConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FontConfiguration unmarshalledObject = new FontConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FontColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FontDecoration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontDecoration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FontSize", targetDepth))
                {
                    var unmarshaller = FontSizeUnmarshaller.Instance;
                    unmarshalledObject.FontSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FontStyle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FontWeight", targetDepth))
                {
                    var unmarshaller = FontWeightUnmarshaller.Instance;
                    unmarshalledObject.FontWeight = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FontConfigurationUnmarshaller _instance = new FontConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FontConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}