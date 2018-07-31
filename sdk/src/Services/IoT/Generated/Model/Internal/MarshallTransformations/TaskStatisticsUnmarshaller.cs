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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TaskStatistics Object
    /// </summary>  
    public class TaskStatisticsUnmarshaller : IUnmarshaller<TaskStatistics, XmlUnmarshallerContext>, IUnmarshaller<TaskStatistics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TaskStatistics IUnmarshaller<TaskStatistics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TaskStatistics Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TaskStatistics unmarshalledObject = new TaskStatistics();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("canceledChecks", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CanceledChecks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compliantChecks", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CompliantChecks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failedChecks", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FailedChecks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inProgressChecks", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.InProgressChecks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nonCompliantChecks", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NonCompliantChecks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalChecks", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalChecks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("waitingForDataCollectionChecks", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.WaitingForDataCollectionChecks = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TaskStatisticsUnmarshaller _instance = new TaskStatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TaskStatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}