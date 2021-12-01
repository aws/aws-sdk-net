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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PropertyLatestValue Object
    /// </summary>  
    public class PropertyLatestValueUnmarshaller : IUnmarshaller<PropertyLatestValue, XmlUnmarshallerContext>, IUnmarshaller<PropertyLatestValue, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PropertyLatestValue IUnmarshaller<PropertyLatestValue, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PropertyLatestValue Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PropertyLatestValue unmarshalledObject = new PropertyLatestValue();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("propertyReference", targetDepth))
                {
                    var unmarshaller = EntityPropertyReferenceUnmarshaller.Instance;
                    unmarshalledObject.PropertyReference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("propertyValue", targetDepth))
                {
                    var unmarshaller = DataValueUnmarshaller.Instance;
                    unmarshalledObject.PropertyValue = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PropertyLatestValueUnmarshaller _instance = new PropertyLatestValueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PropertyLatestValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}