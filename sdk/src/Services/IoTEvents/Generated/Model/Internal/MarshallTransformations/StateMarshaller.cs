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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// State Marshaller
    /// </summary>
    public class StateMarshaller : IRequestMarshaller<State, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(State requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetOnEnter())
            {
                context.Writer.WritePropertyName("onEnter");
                context.Writer.WriteStartObject();

                var marshaller = OnEnterLifecycleMarshaller.Instance;
                marshaller.Marshall(requestObject.OnEnter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOnExit())
            {
                context.Writer.WritePropertyName("onExit");
                context.Writer.WriteStartObject();

                var marshaller = OnExitLifecycleMarshaller.Instance;
                marshaller.Marshall(requestObject.OnExit, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOnInput())
            {
                context.Writer.WritePropertyName("onInput");
                context.Writer.WriteStartObject();

                var marshaller = OnInputLifecycleMarshaller.Instance;
                marshaller.Marshall(requestObject.OnInput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStateName())
            {
                context.Writer.WritePropertyName("stateName");
                context.Writer.WriteStringValue(requestObject.StateName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StateMarshaller Instance = new StateMarshaller();

    }
}