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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutEquipment.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutEquipment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InferenceExecutionSummary Object
    /// </summary>  
    public class InferenceExecutionSummaryUnmarshaller : IUnmarshaller<InferenceExecutionSummary, XmlUnmarshallerContext>, IUnmarshaller<InferenceExecutionSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InferenceExecutionSummary IUnmarshaller<InferenceExecutionSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InferenceExecutionSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InferenceExecutionSummary unmarshalledObject = new InferenceExecutionSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CustomerResultObject", targetDepth))
                {
                    var unmarshaller = S3ObjectUnmarshaller.Instance;
                    unmarshalledObject.CustomerResultObject = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.DataEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataInputConfiguration", targetDepth))
                {
                    var unmarshaller = InferenceInputConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DataInputConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataOutputConfiguration", targetDepth))
                {
                    var unmarshaller = InferenceOutputConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DataOutputConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.DataStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailedReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailedReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InferenceSchedulerArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InferenceSchedulerArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InferenceSchedulerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InferenceSchedulerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduledStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ScheduledStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InferenceExecutionSummaryUnmarshaller _instance = new InferenceExecutionSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InferenceExecutionSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}