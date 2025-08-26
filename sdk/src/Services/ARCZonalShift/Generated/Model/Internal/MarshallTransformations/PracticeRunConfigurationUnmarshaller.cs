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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCZonalShift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCZonalShift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PracticeRunConfiguration Object
    /// </summary>  
    public class PracticeRunConfigurationUnmarshaller : IUnmarshaller<PracticeRunConfiguration, XmlUnmarshallerContext>, IUnmarshaller<PracticeRunConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PracticeRunConfiguration IUnmarshaller<PracticeRunConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PracticeRunConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            PracticeRunConfiguration unmarshalledObject = new PracticeRunConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("allowedWindows", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedWindows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blockedDates", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.BlockedDates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blockedWindows", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.BlockedWindows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blockingAlarms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ControlCondition, ControlConditionUnmarshaller>(ControlConditionUnmarshaller.Instance);
                    unmarshalledObject.BlockingAlarms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outcomeAlarms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ControlCondition, ControlConditionUnmarshaller>(ControlConditionUnmarshaller.Instance);
                    unmarshalledObject.OutcomeAlarms = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PracticeRunConfigurationUnmarshaller _instance = new PracticeRunConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PracticeRunConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}