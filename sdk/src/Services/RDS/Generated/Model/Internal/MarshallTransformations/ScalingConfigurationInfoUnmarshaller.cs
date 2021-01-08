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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScalingConfigurationInfo Object
    /// </summary>  
    public class ScalingConfigurationInfoUnmarshaller : IUnmarshaller<ScalingConfigurationInfo, XmlUnmarshallerContext>, IUnmarshaller<ScalingConfigurationInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ScalingConfigurationInfo Unmarshall(XmlUnmarshallerContext context)
        {
            ScalingConfigurationInfo unmarshalledObject = new ScalingConfigurationInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoPause", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AutoPause = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxCapacity", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MaxCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinCapacity", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MinCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SecondsUntilAutoPause", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.SecondsUntilAutoPause = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TimeoutAction", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TimeoutAction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ScalingConfigurationInfo Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ScalingConfigurationInfoUnmarshaller _instance = new ScalingConfigurationInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScalingConfigurationInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}