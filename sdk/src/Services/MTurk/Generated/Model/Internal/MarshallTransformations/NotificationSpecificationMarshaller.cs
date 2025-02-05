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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MTurk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MTurk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NotificationSpecification Marshaller
    /// </summary>
    public class NotificationSpecificationMarshaller : IRequestMarshaller<NotificationSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NotificationSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("Destination");
                context.Writer.WriteStringValue(requestObject.Destination);
            }

            if(requestObject.IsSetEventTypes())
            {
                context.Writer.WritePropertyName("EventTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEventTypesListValue in requestObject.EventTypes)
                {
                        context.Writer.WriteStringValue(requestObjectEventTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTransport())
            {
                context.Writer.WritePropertyName("Transport");
                context.Writer.WriteStringValue(requestObject.Transport);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.WriteStringValue(requestObject.Version);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NotificationSpecificationMarshaller Instance = new NotificationSpecificationMarshaller();

    }
}