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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkflowStep Object
    /// </summary>  
    public class WorkflowStepUnmarshaller : IUnmarshaller<WorkflowStep, XmlUnmarshallerContext>, IUnmarshaller<WorkflowStep, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        WorkflowStep IUnmarshaller<WorkflowStep, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public WorkflowStep Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            WorkflowStep unmarshalledObject = new WorkflowStep();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CopyStepDetails", targetDepth))
                {
                    var unmarshaller = CopyStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.CopyStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomStepDetails", targetDepth))
                {
                    var unmarshaller = CustomStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.CustomStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DecryptStepDetails", targetDepth))
                {
                    var unmarshaller = DecryptStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.DecryptStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeleteStepDetails", targetDepth))
                {
                    var unmarshaller = DeleteStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.DeleteStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TagStepDetails", targetDepth))
                {
                    var unmarshaller = TagStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.TagStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static WorkflowStepUnmarshaller _instance = new WorkflowStepUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkflowStepUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}