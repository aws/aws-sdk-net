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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEventsData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEventsData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DetectorStateDefinition Marshaller
    /// </summary>       
    public class DetectorStateDefinitionMarshaller : IRequestMarshaller<DetectorStateDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DetectorStateDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetStateName())
            {
                context.Writer.WritePropertyName("stateName");
                context.Writer.Write(requestObject.StateName);
            }

            if(requestObject.IsSetTimers())
            {
                context.Writer.WritePropertyName("timers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTimersListValue in requestObject.Timers)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TimerDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectTimersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVariables())
            {
                context.Writer.WritePropertyName("variables");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVariablesListValue in requestObject.Variables)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VariableDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectVariablesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DetectorStateDefinitionMarshaller Instance = new DetectorStateDefinitionMarshaller();

    }
}