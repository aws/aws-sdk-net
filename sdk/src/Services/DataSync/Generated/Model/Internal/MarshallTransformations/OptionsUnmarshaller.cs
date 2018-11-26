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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Options Object
    /// </summary>  
    public class OptionsUnmarshaller : IUnmarshaller<Options, XmlUnmarshallerContext>, IUnmarshaller<Options, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Options IUnmarshaller<Options, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Options Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Options unmarshalledObject = new Options();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Atime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Atime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BytesPerSecond", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.BytesPerSecond = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Gid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Gid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Mtime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Mtime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PosixPermissions", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PosixPermissions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreserveDeletedFiles", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreserveDeletedFiles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreserveDevices", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreserveDevices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Uid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Uid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VerifyMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VerifyMode = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OptionsUnmarshaller _instance = new OptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}