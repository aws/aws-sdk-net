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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OTAUpdateFile Object
    /// </summary>  
    public class OTAUpdateFileUnmarshaller : IUnmarshaller<OTAUpdateFile, XmlUnmarshallerContext>, IUnmarshaller<OTAUpdateFile, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OTAUpdateFile IUnmarshaller<OTAUpdateFile, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OTAUpdateFile Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OTAUpdateFile unmarshalledObject = new OTAUpdateFile();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("attributes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codeSigning", targetDepth))
                {
                    var unmarshaller = CodeSigningUnmarshaller.Instance;
                    unmarshalledObject.CodeSigning = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileLocation", targetDepth))
                {
                    var unmarshaller = FileLocationUnmarshaller.Instance;
                    unmarshalledObject.FileLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OTAUpdateFileUnmarshaller _instance = new OTAUpdateFileUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OTAUpdateFileUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}