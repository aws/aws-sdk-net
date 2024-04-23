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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PickupDetails Marshaller
    /// </summary>
    public class PickupDetailsMarshaller : IRequestMarshaller<PickupDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PickupDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDevicePickupId())
            {
                context.Writer.WritePropertyName("DevicePickupId");
                context.Writer.Write(requestObject.DevicePickupId);
            }

            if(requestObject.IsSetEmail())
            {
                context.Writer.WritePropertyName("Email");
                context.Writer.Write(requestObject.Email);
            }

            if(requestObject.IsSetIdentificationExpirationDate())
            {
                context.Writer.WritePropertyName("IdentificationExpirationDate");
                context.Writer.Write(requestObject.IdentificationExpirationDate);
            }

            if(requestObject.IsSetIdentificationIssuingOrg())
            {
                context.Writer.WritePropertyName("IdentificationIssuingOrg");
                context.Writer.Write(requestObject.IdentificationIssuingOrg);
            }

            if(requestObject.IsSetIdentificationNumber())
            {
                context.Writer.WritePropertyName("IdentificationNumber");
                context.Writer.Write(requestObject.IdentificationNumber);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPhoneNumber())
            {
                context.Writer.WritePropertyName("PhoneNumber");
                context.Writer.Write(requestObject.PhoneNumber);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PickupDetailsMarshaller Instance = new PickupDetailsMarshaller();

    }
}
#pragma warning restore CS0612,CS0618