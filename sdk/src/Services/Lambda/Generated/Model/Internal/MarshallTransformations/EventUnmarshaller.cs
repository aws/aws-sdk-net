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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Event Object
    /// </summary>  
    public class EventUnmarshaller : IUnmarshaller<Event, XmlUnmarshallerContext>, IUnmarshaller<Event, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Event IUnmarshaller<Event, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Event Unmarshall(JsonUnmarshallerContext context)
        {
            Event unmarshalledObject = new Event();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CallbackFailedDetails", targetDepth))
                {
                    var unmarshaller = CallbackFailedDetailsUnmarshaller.Instance;
                    unmarshalledObject.CallbackFailedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CallbackStartedDetails", targetDepth))
                {
                    var unmarshaller = CallbackStartedDetailsUnmarshaller.Instance;
                    unmarshalledObject.CallbackStartedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CallbackSucceededDetails", targetDepth))
                {
                    var unmarshaller = CallbackSucceededDetailsUnmarshaller.Instance;
                    unmarshalledObject.CallbackSucceededDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CallbackTimedOutDetails", targetDepth))
                {
                    var unmarshaller = CallbackTimedOutDetailsUnmarshaller.Instance;
                    unmarshalledObject.CallbackTimedOutDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChainedInvokeFailedDetails", targetDepth))
                {
                    var unmarshaller = ChainedInvokeFailedDetailsUnmarshaller.Instance;
                    unmarshalledObject.ChainedInvokeFailedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChainedInvokeStartedDetails", targetDepth))
                {
                    var unmarshaller = ChainedInvokeStartedDetailsUnmarshaller.Instance;
                    unmarshalledObject.ChainedInvokeStartedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChainedInvokeStoppedDetails", targetDepth))
                {
                    var unmarshaller = ChainedInvokeStoppedDetailsUnmarshaller.Instance;
                    unmarshalledObject.ChainedInvokeStoppedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChainedInvokeSucceededDetails", targetDepth))
                {
                    var unmarshaller = ChainedInvokeSucceededDetailsUnmarshaller.Instance;
                    unmarshalledObject.ChainedInvokeSucceededDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChainedInvokeTimedOutDetails", targetDepth))
                {
                    var unmarshaller = ChainedInvokeTimedOutDetailsUnmarshaller.Instance;
                    unmarshalledObject.ChainedInvokeTimedOutDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContextFailedDetails", targetDepth))
                {
                    var unmarshaller = ContextFailedDetailsUnmarshaller.Instance;
                    unmarshalledObject.ContextFailedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContextStartedDetails", targetDepth))
                {
                    var unmarshaller = ContextStartedDetailsUnmarshaller.Instance;
                    unmarshalledObject.ContextStartedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContextSucceededDetails", targetDepth))
                {
                    var unmarshaller = ContextSucceededDetailsUnmarshaller.Instance;
                    unmarshalledObject.ContextSucceededDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EventId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EventTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionFailedDetails", targetDepth))
                {
                    var unmarshaller = ExecutionFailedDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionFailedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionStartedDetails", targetDepth))
                {
                    var unmarshaller = ExecutionStartedDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStartedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionStoppedDetails", targetDepth))
                {
                    var unmarshaller = ExecutionStoppedDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStoppedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionSucceededDetails", targetDepth))
                {
                    var unmarshaller = ExecutionSucceededDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionSucceededDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionTimedOutDetails", targetDepth))
                {
                    var unmarshaller = ExecutionTimedOutDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionTimedOutDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InvocationCompletedDetails", targetDepth))
                {
                    var unmarshaller = InvocationCompletedDetailsUnmarshaller.Instance;
                    unmarshalledObject.InvocationCompletedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StepFailedDetails", targetDepth))
                {
                    var unmarshaller = StepFailedDetailsUnmarshaller.Instance;
                    unmarshalledObject.StepFailedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StepStartedDetails", targetDepth))
                {
                    var unmarshaller = StepStartedDetailsUnmarshaller.Instance;
                    unmarshalledObject.StepStartedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StepSucceededDetails", targetDepth))
                {
                    var unmarshaller = StepSucceededDetailsUnmarshaller.Instance;
                    unmarshalledObject.StepSucceededDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WaitCancelledDetails", targetDepth))
                {
                    var unmarshaller = WaitCancelledDetailsUnmarshaller.Instance;
                    unmarshalledObject.WaitCancelledDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WaitStartedDetails", targetDepth))
                {
                    var unmarshaller = WaitStartedDetailsUnmarshaller.Instance;
                    unmarshalledObject.WaitStartedDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WaitSucceededDetails", targetDepth))
                {
                    var unmarshaller = WaitSucceededDetailsUnmarshaller.Instance;
                    unmarshalledObject.WaitSucceededDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EventUnmarshaller _instance = new EventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}