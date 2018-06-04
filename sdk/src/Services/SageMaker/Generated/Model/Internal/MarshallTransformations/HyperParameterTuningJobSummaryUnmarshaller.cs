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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HyperParameterTuningJobSummary Object
    /// </summary>  
    public class HyperParameterTuningJobSummaryUnmarshaller : IUnmarshaller<HyperParameterTuningJobSummary, XmlUnmarshallerContext>, IUnmarshaller<HyperParameterTuningJobSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HyperParameterTuningJobSummary IUnmarshaller<HyperParameterTuningJobSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HyperParameterTuningJobSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HyperParameterTuningJobSummary unmarshalledObject = new HyperParameterTuningJobSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ObjectiveStatusCounters", targetDepth))
                {
                    var unmarshaller = ObjectiveStatusCountersUnmarshaller.Instance;
                    unmarshalledObject.ObjectiveStatusCounters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceLimits", targetDepth))
                {
                    var unmarshaller = ResourceLimitsUnmarshaller.Instance;
                    unmarshalledObject.ResourceLimits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Strategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Strategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingJobStatusCounters", targetDepth))
                {
                    var unmarshaller = TrainingJobStatusCountersUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobStatusCounters = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static HyperParameterTuningJobSummaryUnmarshaller _instance = new HyperParameterTuningJobSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HyperParameterTuningJobSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}