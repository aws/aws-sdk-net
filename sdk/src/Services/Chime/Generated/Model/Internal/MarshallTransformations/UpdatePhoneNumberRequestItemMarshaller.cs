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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePhoneNumberRequestItem Marshaller
    /// </summary>
    public class UpdatePhoneNumberRequestItemMarshaller : IRequestMarshaller<UpdatePhoneNumberRequestItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdatePhoneNumberRequestItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCallingName())
            {
                context.Writer.WritePropertyName("CallingName");
                context.Writer.WriteStringValue(requestObject.CallingName);
            }

            if(requestObject.IsSetPhoneNumberId())
            {
                context.Writer.WritePropertyName("PhoneNumberId");
                context.Writer.WriteStringValue(requestObject.PhoneNumberId);
            }

            if(requestObject.IsSetProductType())
            {
                context.Writer.WritePropertyName("ProductType");
                context.Writer.WriteStringValue(requestObject.ProductType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdatePhoneNumberRequestItemMarshaller Instance = new UpdatePhoneNumberRequestItemMarshaller();

    }
}