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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StateTemplateUpdateStrategy Object
    /// </summary>  
    public class StateTemplateUpdateStrategyUnmarshaller : IUnmarshaller<StateTemplateUpdateStrategy, XmlUnmarshallerContext>, IUnmarshaller<StateTemplateUpdateStrategy, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StateTemplateUpdateStrategy IUnmarshaller<StateTemplateUpdateStrategy, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public StateTemplateUpdateStrategy Unmarshall(JsonUnmarshallerContext context)
        {
            StateTemplateUpdateStrategy unmarshalledObject = new StateTemplateUpdateStrategy();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("onChange", targetDepth))
                {
                    var unmarshaller = OnChangeStateTemplateUpdateStrategyUnmarshaller.Instance;
                    unmarshalledObject.OnChange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("periodic", targetDepth))
                {
                    var unmarshaller = PeriodicStateTemplateUpdateStrategyUnmarshaller.Instance;
                    unmarshalledObject.Periodic = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StateTemplateUpdateStrategyUnmarshaller _instance = new StateTemplateUpdateStrategyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StateTemplateUpdateStrategyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}