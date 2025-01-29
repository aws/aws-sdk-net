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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// X12FunctionalGroupHeaders Marshaller
    /// </summary>
    public class X12FunctionalGroupHeadersMarshaller : IRequestMarshaller<X12FunctionalGroupHeaders, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(X12FunctionalGroupHeaders requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationReceiverCode())
            {
                context.Writer.WritePropertyName("applicationReceiverCode");
                context.Writer.WriteStringValue(requestObject.ApplicationReceiverCode);
            }

            if(requestObject.IsSetApplicationSenderCode())
            {
                context.Writer.WritePropertyName("applicationSenderCode");
                context.Writer.WriteStringValue(requestObject.ApplicationSenderCode);
            }

            if(requestObject.IsSetResponsibleAgencyCode())
            {
                context.Writer.WritePropertyName("responsibleAgencyCode");
                context.Writer.WriteStringValue(requestObject.ResponsibleAgencyCode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static X12FunctionalGroupHeadersMarshaller Instance = new X12FunctionalGroupHeadersMarshaller();

    }
}