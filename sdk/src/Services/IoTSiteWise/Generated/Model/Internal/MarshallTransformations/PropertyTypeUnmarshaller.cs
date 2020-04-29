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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PropertyType Object
    /// </summary>  
    public class PropertyTypeUnmarshaller : IUnmarshaller<PropertyType, XmlUnmarshallerContext>, IUnmarshaller<PropertyType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PropertyType IUnmarshaller<PropertyType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PropertyType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PropertyType unmarshalledObject = new PropertyType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("attribute", targetDepth))
                {
                    var unmarshaller = AttributeUnmarshaller.Instance;
                    unmarshalledObject.Attribute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("measurement", targetDepth))
                {
                    var unmarshaller = MeasurementUnmarshaller.Instance;
                    unmarshalledObject.Measurement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metric", targetDepth))
                {
                    var unmarshaller = MetricUnmarshaller.Instance;
                    unmarshalledObject.Metric = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transform", targetDepth))
                {
                    var unmarshaller = TransformUnmarshaller.Instance;
                    unmarshalledObject.Transform = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PropertyTypeUnmarshaller _instance = new PropertyTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PropertyTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}