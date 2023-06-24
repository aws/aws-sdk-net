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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutMetrics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DetectedJsonFormatDescriptor Object
    /// </summary>  
    public class DetectedJsonFormatDescriptorUnmarshaller : IUnmarshaller<DetectedJsonFormatDescriptor, XmlUnmarshallerContext>, IUnmarshaller<DetectedJsonFormatDescriptor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DetectedJsonFormatDescriptor IUnmarshaller<DetectedJsonFormatDescriptor, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DetectedJsonFormatDescriptor Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DetectedJsonFormatDescriptor unmarshalledObject = new DetectedJsonFormatDescriptor();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Charset", targetDepth))
                {
                    var unmarshaller = DetectedFieldUnmarshaller.Instance;
                    unmarshalledObject.Charset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FileCompression", targetDepth))
                {
                    var unmarshaller = DetectedFieldUnmarshaller.Instance;
                    unmarshalledObject.FileCompression = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DetectedJsonFormatDescriptorUnmarshaller _instance = new DetectedJsonFormatDescriptorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DetectedJsonFormatDescriptorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}