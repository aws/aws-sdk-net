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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobEntity Object
    /// </summary>  
    public class JobEntityUnmarshaller : IUnmarshaller<JobEntity, XmlUnmarshallerContext>, IUnmarshaller<JobEntity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JobEntity IUnmarshaller<JobEntity, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public JobEntity Unmarshall(JsonUnmarshallerContext context)
        {
            JobEntity unmarshalledObject = new JobEntity();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("environmentDetails", targetDepth))
                {
                    var unmarshaller = EnvironmentDetailsEntityUnmarshaller.Instance;
                    unmarshalledObject.EnvironmentDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobAttachmentDetails", targetDepth))
                {
                    var unmarshaller = JobAttachmentDetailsEntityUnmarshaller.Instance;
                    unmarshalledObject.JobAttachmentDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobDetails", targetDepth))
                {
                    var unmarshaller = JobDetailsEntityUnmarshaller.Instance;
                    unmarshalledObject.JobDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stepDetails", targetDepth))
                {
                    var unmarshaller = StepDetailsEntityUnmarshaller.Instance;
                    unmarshalledObject.StepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static JobEntityUnmarshaller _instance = new JobEntityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobEntityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}