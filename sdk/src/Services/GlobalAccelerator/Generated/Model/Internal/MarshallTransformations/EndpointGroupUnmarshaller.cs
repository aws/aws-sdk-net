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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlobalAccelerator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GlobalAccelerator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EndpointGroup Object
    /// </summary>  
    public class EndpointGroupUnmarshaller : IUnmarshaller<EndpointGroup, XmlUnmarshallerContext>, IUnmarshaller<EndpointGroup, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EndpointGroup IUnmarshaller<EndpointGroup, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EndpointGroup Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EndpointGroup unmarshalledObject = new EndpointGroup();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EndpointDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EndpointDescription, EndpointDescriptionUnmarshaller>(EndpointDescriptionUnmarshaller.Instance);
                    unmarshalledObject.EndpointDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndpointGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndpointGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndpointGroupRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndpointGroupRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthCheckIntervalSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HealthCheckIntervalSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthCheckPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HealthCheckPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthCheckPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HealthCheckPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthCheckProtocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HealthCheckProtocol = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThresholdCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ThresholdCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrafficDialPercentage", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.TrafficDialPercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EndpointGroupUnmarshaller _instance = new EndpointGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EndpointGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}