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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkMail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BookingOptions Marshaller
    /// </summary>
    public class BookingOptionsMarshaller : IRequestMarshaller<BookingOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BookingOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutoAcceptRequests())
            {
                context.Writer.WritePropertyName("AutoAcceptRequests");
                context.Writer.WriteBooleanValue(requestObject.AutoAcceptRequests.Value);
            }

            if(requestObject.IsSetAutoDeclineConflictingRequests())
            {
                context.Writer.WritePropertyName("AutoDeclineConflictingRequests");
                context.Writer.WriteBooleanValue(requestObject.AutoDeclineConflictingRequests.Value);
            }

            if(requestObject.IsSetAutoDeclineRecurringRequests())
            {
                context.Writer.WritePropertyName("AutoDeclineRecurringRequests");
                context.Writer.WriteBooleanValue(requestObject.AutoDeclineRecurringRequests.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BookingOptionsMarshaller Instance = new BookingOptionsMarshaller();

    }
}