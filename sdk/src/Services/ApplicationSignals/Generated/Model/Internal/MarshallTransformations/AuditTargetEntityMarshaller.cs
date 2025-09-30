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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuditTargetEntity Marshaller
    /// </summary>
    public class AuditTargetEntityMarshaller : IRequestMarshaller<AuditTargetEntity, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AuditTargetEntity requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetService())
            {
                context.Writer.WritePropertyName("Service");
                context.Writer.WriteStartObject();

                var marshaller = ServiceEntityMarshaller.Instance;
                marshaller.Marshall(requestObject.Service, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServiceOperation())
            {
                context.Writer.WritePropertyName("ServiceOperation");
                context.Writer.WriteStartObject();

                var marshaller = ServiceOperationEntityMarshaller.Instance;
                marshaller.Marshall(requestObject.ServiceOperation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSlo())
            {
                context.Writer.WritePropertyName("Slo");
                context.Writer.WriteStartObject();

                var marshaller = ServiceLevelObjectiveEntityMarshaller.Instance;
                marshaller.Marshall(requestObject.Slo, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AuditTargetEntityMarshaller Instance = new AuditTargetEntityMarshaller();

    }
}