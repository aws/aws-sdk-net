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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LogDestinationConfig Marshaller
    /// </summary>
    public class LogDestinationConfigMarshaller : IRequestMarshaller<LogDestinationConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LogDestinationConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLogDestination())
            {
                context.Writer.WritePropertyName("LogDestination");
                context.Writer.WriteStartObject();
                foreach (var requestObjectLogDestinationKvp in requestObject.LogDestination)
                {
                    context.Writer.WritePropertyName(requestObjectLogDestinationKvp.Key);
                    var requestObjectLogDestinationValue = requestObjectLogDestinationKvp.Value;

                        context.Writer.WriteStringValue(requestObjectLogDestinationValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogDestinationType())
            {
                context.Writer.WritePropertyName("LogDestinationType");
                context.Writer.WriteStringValue(requestObject.LogDestinationType);
            }

            if(requestObject.IsSetLogType())
            {
                context.Writer.WritePropertyName("LogType");
                context.Writer.WriteStringValue(requestObject.LogType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LogDestinationConfigMarshaller Instance = new LogDestinationConfigMarshaller();

    }
}