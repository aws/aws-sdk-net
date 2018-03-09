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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HealthCheck Marshaller
    /// </summary>       
    public class HealthCheckMarshaller : IRequestMarshaller<HealthCheck, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HealthCheck requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.Write(requestObjectCommandListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInterval())
            {
                context.Writer.WritePropertyName("interval");
                context.Writer.Write(requestObject.Interval);
            }

            if(requestObject.IsSetRetries())
            {
                context.Writer.WritePropertyName("retries");
                context.Writer.Write(requestObject.Retries);
            }

            if(requestObject.IsSetStartPeriod())
            {
                context.Writer.WritePropertyName("startPeriod");
                context.Writer.Write(requestObject.StartPeriod);
            }

            if(requestObject.IsSetTimeout())
            {
                context.Writer.WritePropertyName("timeout");
                context.Writer.Write(requestObject.Timeout);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static HealthCheckMarshaller Instance = new HealthCheckMarshaller();

    }
}