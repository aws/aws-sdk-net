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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAddress Marshaller
    /// </summary>
    public class UpdateAddressMarshaller : IRequestMarshaller<UpdateAddress, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateAddress requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddress1())
            {
                context.Writer.WritePropertyName("Address1");
                context.Writer.WriteStringValue(requestObject.Address1);
            }

            if(requestObject.IsSetAddress2())
            {
                context.Writer.WritePropertyName("Address2");
                context.Writer.WriteStringValue(requestObject.Address2);
            }

            if(requestObject.IsSetAddress3())
            {
                context.Writer.WritePropertyName("Address3");
                context.Writer.WriteStringValue(requestObject.Address3);
            }

            if(requestObject.IsSetAddress4())
            {
                context.Writer.WritePropertyName("Address4");
                context.Writer.WriteStringValue(requestObject.Address4);
            }

            if(requestObject.IsSetCity())
            {
                context.Writer.WritePropertyName("City");
                context.Writer.WriteStringValue(requestObject.City);
            }

            if(requestObject.IsSetCountry())
            {
                context.Writer.WritePropertyName("Country");
                context.Writer.WriteStringValue(requestObject.Country);
            }

            if(requestObject.IsSetCounty())
            {
                context.Writer.WritePropertyName("County");
                context.Writer.WriteStringValue(requestObject.County);
            }

            if(requestObject.IsSetPostalCode())
            {
                context.Writer.WritePropertyName("PostalCode");
                context.Writer.WriteStringValue(requestObject.PostalCode);
            }

            if(requestObject.IsSetProvince())
            {
                context.Writer.WritePropertyName("Province");
                context.Writer.WriteStringValue(requestObject.Province);
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStringValue(requestObject.State);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateAddressMarshaller Instance = new UpdateAddressMarshaller();

    }
}