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
    /// Response Unmarshaller for Hdr10Metadata Object
    /// </summary>  
    public class Hdr10MetadataUnmarshaller : IUnmarshaller<Hdr10Metadata, XmlUnmarshallerContext>, IUnmarshaller<Hdr10Metadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Hdr10Metadata IUnmarshaller<Hdr10Metadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Hdr10Metadata Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Hdr10Metadata unmarshalledObject = new Hdr10Metadata();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("bluePrimaryX", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BluePrimaryX = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bluePrimaryY", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BluePrimaryY = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("greenPrimaryX", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.GreenPrimaryX = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("greenPrimaryY", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.GreenPrimaryY = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxContentLightLevel", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxContentLightLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxFrameAverageLightLevel", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxFrameAverageLightLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxLuminance", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxLuminance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minLuminance", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinLuminance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("redPrimaryX", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RedPrimaryX = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("redPrimaryY", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RedPrimaryY = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("whitePointX", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.WhitePointX = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("whitePointY", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.WhitePointY = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static Hdr10MetadataUnmarshaller _instance = new Hdr10MetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Hdr10MetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}