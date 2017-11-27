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
    /// Response Unmarshaller for InsertableImage Object
    /// </summary>  
    public class InsertableImageUnmarshaller : IUnmarshaller<InsertableImage, XmlUnmarshallerContext>, IUnmarshaller<InsertableImage, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InsertableImage IUnmarshaller<InsertableImage, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InsertableImage Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InsertableImage unmarshalledObject = new InsertableImage();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("duration", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Duration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fadeIn", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FadeIn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fadeOut", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FadeOut = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("height", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Height = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageInserterInput", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageInserterInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageX", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ImageX = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageY", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ImageY = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("layer", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Layer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("opacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Opacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("width", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Width = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InsertableImageUnmarshaller _instance = new InsertableImageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InsertableImageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}