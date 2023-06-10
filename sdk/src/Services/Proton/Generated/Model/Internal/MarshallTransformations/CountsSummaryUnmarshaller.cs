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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Proton.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Proton.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CountsSummary Object
    /// </summary>  
    public class CountsSummaryUnmarshaller : IUnmarshaller<CountsSummary, XmlUnmarshallerContext>, IUnmarshaller<CountsSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CountsSummary IUnmarshaller<CountsSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CountsSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CountsSummary unmarshalledObject = new CountsSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("components", targetDepth))
                {
                    var unmarshaller = ResourceCountsSummaryUnmarshaller.Instance;
                    unmarshalledObject.Components = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("environments", targetDepth))
                {
                    var unmarshaller = ResourceCountsSummaryUnmarshaller.Instance;
                    unmarshalledObject.Environments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("environmentTemplates", targetDepth))
                {
                    var unmarshaller = ResourceCountsSummaryUnmarshaller.Instance;
                    unmarshalledObject.EnvironmentTemplates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelines", targetDepth))
                {
                    var unmarshaller = ResourceCountsSummaryUnmarshaller.Instance;
                    unmarshalledObject.Pipelines = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceInstances", targetDepth))
                {
                    var unmarshaller = ResourceCountsSummaryUnmarshaller.Instance;
                    unmarshalledObject.ServiceInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("services", targetDepth))
                {
                    var unmarshaller = ResourceCountsSummaryUnmarshaller.Instance;
                    unmarshalledObject.Services = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceTemplates", targetDepth))
                {
                    var unmarshaller = ResourceCountsSummaryUnmarshaller.Instance;
                    unmarshalledObject.ServiceTemplates = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CountsSummaryUnmarshaller _instance = new CountsSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CountsSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}