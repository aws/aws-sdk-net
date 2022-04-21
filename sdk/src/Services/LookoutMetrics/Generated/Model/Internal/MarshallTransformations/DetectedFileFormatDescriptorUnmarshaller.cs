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
    /// Response Unmarshaller for DetectedFileFormatDescriptor Object
    /// </summary>  
    public class DetectedFileFormatDescriptorUnmarshaller : IUnmarshaller<DetectedFileFormatDescriptor, XmlUnmarshallerContext>, IUnmarshaller<DetectedFileFormatDescriptor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DetectedFileFormatDescriptor IUnmarshaller<DetectedFileFormatDescriptor, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DetectedFileFormatDescriptor Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DetectedFileFormatDescriptor unmarshalledObject = new DetectedFileFormatDescriptor();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CsvFormatDescriptor", targetDepth))
                {
                    var unmarshaller = DetectedCsvFormatDescriptorUnmarshaller.Instance;
                    unmarshalledObject.CsvFormatDescriptor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JsonFormatDescriptor", targetDepth))
                {
                    var unmarshaller = DetectedJsonFormatDescriptorUnmarshaller.Instance;
                    unmarshalledObject.JsonFormatDescriptor = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DetectedFileFormatDescriptorUnmarshaller _instance = new DetectedFileFormatDescriptorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DetectedFileFormatDescriptorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}