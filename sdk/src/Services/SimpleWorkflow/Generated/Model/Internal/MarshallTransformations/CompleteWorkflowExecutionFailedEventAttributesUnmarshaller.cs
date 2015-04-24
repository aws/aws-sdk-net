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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CompleteWorkflowExecutionFailedEventAttributes Object
    /// </summary>  
    public class CompleteWorkflowExecutionFailedEventAttributesUnmarshaller : IUnmarshaller<CompleteWorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<CompleteWorkflowExecutionFailedEventAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CompleteWorkflowExecutionFailedEventAttributes IUnmarshaller<CompleteWorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CompleteWorkflowExecutionFailedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CompleteWorkflowExecutionFailedEventAttributes unmarshalledObject = new CompleteWorkflowExecutionFailedEventAttributes();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cause", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cause = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DecisionTaskCompletedEventId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CompleteWorkflowExecutionFailedEventAttributesUnmarshaller _instance = new CompleteWorkflowExecutionFailedEventAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CompleteWorkflowExecutionFailedEventAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}