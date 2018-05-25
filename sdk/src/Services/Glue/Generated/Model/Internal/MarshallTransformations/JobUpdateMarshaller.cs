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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobUpdate Marshaller
    /// </summary>       
    public class JobUpdateMarshaller : IRequestMarshaller<JobUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllocatedCapacity())
            {
                context.Writer.WritePropertyName("AllocatedCapacity");
                context.Writer.Write(requestObject.AllocatedCapacity);
            }

            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("Command");
                context.Writer.WriteObjectStart();

                var marshaller = JobCommandMarshaller.Instance;
                marshaller.Marshall(requestObject.Command, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConnections())
            {
                context.Writer.WritePropertyName("Connections");
                context.Writer.WriteObjectStart();

                var marshaller = ConnectionsListMarshaller.Instance;
                marshaller.Marshall(requestObject.Connections, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultArguments())
            {
                context.Writer.WritePropertyName("DefaultArguments");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDefaultArgumentsKvp in requestObject.DefaultArguments)
                {
                    context.Writer.WritePropertyName(requestObjectDefaultArgumentsKvp.Key);
                    var requestObjectDefaultArgumentsValue = requestObjectDefaultArgumentsKvp.Value;

                        context.Writer.Write(requestObjectDefaultArgumentsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetExecutionProperty())
            {
                context.Writer.WritePropertyName("ExecutionProperty");
                context.Writer.WriteObjectStart();

                var marshaller = ExecutionPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.ExecutionProperty, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLogUri())
            {
                context.Writer.WritePropertyName("LogUri");
                context.Writer.Write(requestObject.LogUri);
            }

            if(requestObject.IsSetMaxRetries())
            {
                context.Writer.WritePropertyName("MaxRetries");
                context.Writer.Write(requestObject.MaxRetries);
            }

            if(requestObject.IsSetNotificationProperty())
            {
                context.Writer.WritePropertyName("NotificationProperty");
                context.Writer.WriteObjectStart();

                var marshaller = NotificationPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.NotificationProperty, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.Write(requestObject.Role);
            }

            if(requestObject.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.Write(requestObject.Timeout);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static JobUpdateMarshaller Instance = new JobUpdateMarshaller();

    }
}