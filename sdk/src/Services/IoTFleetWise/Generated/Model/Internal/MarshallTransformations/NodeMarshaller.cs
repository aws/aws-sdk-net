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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Node Marshaller
    /// </summary>
    public class NodeMarshaller : IRequestMarshaller<Node, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Node requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActuator())
            {
                context.Writer.WritePropertyName("actuator");
                context.Writer.WriteObjectStart();

                var marshaller = ActuatorMarshaller.Instance;
                marshaller.Marshall(requestObject.Actuator, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAttribute())
            {
                context.Writer.WritePropertyName("attribute");
                context.Writer.WriteObjectStart();

                var marshaller = AttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.Attribute, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBranch())
            {
                context.Writer.WritePropertyName("branch");
                context.Writer.WriteObjectStart();

                var marshaller = BranchMarshaller.Instance;
                marshaller.Marshall(requestObject.Branch, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSensor())
            {
                context.Writer.WritePropertyName("sensor");
                context.Writer.WriteObjectStart();

                var marshaller = SensorMarshaller.Instance;
                marshaller.Marshall(requestObject.Sensor, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NodeMarshaller Instance = new NodeMarshaller();

    }
}