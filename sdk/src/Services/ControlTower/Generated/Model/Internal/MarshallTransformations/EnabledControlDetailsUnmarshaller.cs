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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ControlTower.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ControlTower.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EnabledControlDetails Object
    /// </summary>  
    public class EnabledControlDetailsUnmarshaller : IUnmarshaller<EnabledControlDetails, XmlUnmarshallerContext>, IUnmarshaller<EnabledControlDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EnabledControlDetails IUnmarshaller<EnabledControlDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EnabledControlDetails Unmarshall(JsonUnmarshallerContext context)
        {
            EnabledControlDetails unmarshalledObject = new EnabledControlDetails();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("controlIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ControlIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("driftStatusSummary", targetDepth))
                {
                    var unmarshaller = DriftStatusSummaryUnmarshaller.Instance;
                    unmarshalledObject.DriftStatusSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parameters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EnabledControlParameterSummary, EnabledControlParameterSummaryUnmarshaller>(EnabledControlParameterSummaryUnmarshaller.Instance);
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusSummary", targetDepth))
                {
                    var unmarshaller = EnablementStatusSummaryUnmarshaller.Instance;
                    unmarshalledObject.StatusSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetRegions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Region, RegionUnmarshaller>(RegionUnmarshaller.Instance);
                    unmarshalledObject.TargetRegions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EnabledControlDetailsUnmarshaller _instance = new EnabledControlDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EnabledControlDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618