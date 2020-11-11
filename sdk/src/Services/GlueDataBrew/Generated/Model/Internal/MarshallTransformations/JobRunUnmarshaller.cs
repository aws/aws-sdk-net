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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobRun Object
    /// </summary>  
    public class JobRunUnmarshaller : IUnmarshaller<JobRun, XmlUnmarshallerContext>, IUnmarshaller<JobRun, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JobRun IUnmarshaller<JobRun, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public JobRun Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            JobRun unmarshalledObject = new JobRun();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Attempt", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Attempt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CompletedOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CompletedOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatasetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatasetName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionTime", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ExecutionTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogSubscription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogSubscription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Outputs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Output, OutputUnmarshaller>(OutputUnmarshaller.Instance);
                    unmarshalledObject.Outputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecipeReference", targetDepth))
                {
                    var unmarshaller = RecipeReferenceUnmarshaller.Instance;
                    unmarshalledObject.RecipeReference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RunId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RunId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartedOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartedOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static JobRunUnmarshaller _instance = new JobRunUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobRunUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}