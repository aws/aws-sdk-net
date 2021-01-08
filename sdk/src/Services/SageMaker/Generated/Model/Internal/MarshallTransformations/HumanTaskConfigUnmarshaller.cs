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
    /// Response Unmarshaller for HumanTaskConfig Object
    /// </summary>  
    public class HumanTaskConfigUnmarshaller : IUnmarshaller<HumanTaskConfig, XmlUnmarshallerContext>, IUnmarshaller<HumanTaskConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HumanTaskConfig IUnmarshaller<HumanTaskConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HumanTaskConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HumanTaskConfig unmarshalledObject = new HumanTaskConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AnnotationConsolidationConfig", targetDepth))
                {
                    var unmarshaller = AnnotationConsolidationConfigUnmarshaller.Instance;
                    unmarshalledObject.AnnotationConsolidationConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxConcurrentTaskCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxConcurrentTaskCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfHumanWorkersPerDataObject", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfHumanWorkersPerDataObject = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreHumanTaskLambdaArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreHumanTaskLambdaArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PublicWorkforceTaskPrice", targetDepth))
                {
                    var unmarshaller = PublicWorkforceTaskPriceUnmarshaller.Instance;
                    unmarshalledObject.PublicWorkforceTaskPrice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskAvailabilityLifetimeInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TaskAvailabilityLifetimeInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskKeywords", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TaskKeywords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskTimeLimitInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TaskTimeLimitInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskTitle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskTitle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UiConfig", targetDepth))
                {
                    var unmarshaller = UiConfigUnmarshaller.Instance;
                    unmarshalledObject.UiConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WorkteamArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkteamArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static HumanTaskConfigUnmarshaller _instance = new HumanTaskConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HumanTaskConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}