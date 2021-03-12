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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SourceLocation Object
    /// </summary>  
    public class SourceLocationUnmarshaller : IUnmarshaller<SourceLocation, XmlUnmarshallerContext>, IUnmarshaller<SourceLocation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SourceLocation IUnmarshaller<SourceLocation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SourceLocation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SourceLocation unmarshalledObject = new SourceLocation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessConfiguration", targetDepth))
                {
                    var unmarshaller = AccessConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AccessConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultSegmentDeliveryConfiguration", targetDepth))
                {
                    var unmarshaller = DefaultSegmentDeliveryConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DefaultSegmentDeliveryConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HttpConfiguration", targetDepth))
                {
                    var unmarshaller = HttpConfigurationUnmarshaller.Instance;
                    unmarshalledObject.HttpConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceLocationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceLocationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SourceLocationUnmarshaller _instance = new SourceLocationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SourceLocationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}