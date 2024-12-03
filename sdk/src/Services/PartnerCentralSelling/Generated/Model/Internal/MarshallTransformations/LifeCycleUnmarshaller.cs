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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LifeCycle Object
    /// </summary>  
    public class LifeCycleUnmarshaller : IUnmarshaller<LifeCycle, XmlUnmarshallerContext>, IUnmarshaller<LifeCycle, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LifeCycle IUnmarshaller<LifeCycle, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LifeCycle Unmarshall(JsonUnmarshallerContext context)
        {
            LifeCycle unmarshalledObject = new LifeCycle();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ClosedLostReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClosedLostReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextSteps", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NextSteps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextStepsHistory", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NextStepsHistory, NextStepsHistoryUnmarshaller>(NextStepsHistoryUnmarshaller.Instance);
                    unmarshalledObject.NextStepsHistory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReviewComments", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReviewComments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReviewStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReviewStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReviewStatusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReviewStatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Stage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Stage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetCloseDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetCloseDate = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LifeCycleUnmarshaller _instance = new LifeCycleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LifeCycleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}