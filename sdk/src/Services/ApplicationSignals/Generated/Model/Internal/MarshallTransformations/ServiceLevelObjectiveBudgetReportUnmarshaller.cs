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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceLevelObjectiveBudgetReport Object
    /// </summary>  
    public class ServiceLevelObjectiveBudgetReportUnmarshaller : IUnmarshaller<ServiceLevelObjectiveBudgetReport, XmlUnmarshallerContext>, IUnmarshaller<ServiceLevelObjectiveBudgetReport, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServiceLevelObjectiveBudgetReport IUnmarshaller<ServiceLevelObjectiveBudgetReport, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ServiceLevelObjectiveBudgetReport Unmarshall(JsonUnmarshallerContext context)
        {
            ServiceLevelObjectiveBudgetReport unmarshalledObject = new ServiceLevelObjectiveBudgetReport();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Attainment", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Attainment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BudgetRequestsRemaining", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BudgetRequestsRemaining = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BudgetSecondsRemaining", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BudgetSecondsRemaining = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BudgetStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BudgetStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Goal", targetDepth))
                {
                    var unmarshaller = GoalUnmarshaller.Instance;
                    unmarshalledObject.Goal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestBasedSli", targetDepth))
                {
                    var unmarshaller = RequestBasedServiceLevelIndicatorUnmarshaller.Instance;
                    unmarshalledObject.RequestBasedSli = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Sli", targetDepth))
                {
                    var unmarshaller = ServiceLevelIndicatorUnmarshaller.Instance;
                    unmarshalledObject.Sli = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalBudgetRequests", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalBudgetRequests = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalBudgetSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalBudgetSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServiceLevelObjectiveBudgetReportUnmarshaller _instance = new ServiceLevelObjectiveBudgetReportUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceLevelObjectiveBudgetReportUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}