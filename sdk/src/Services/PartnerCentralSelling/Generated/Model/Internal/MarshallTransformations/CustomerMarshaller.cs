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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Customer Marshaller
    /// </summary>
    public class CustomerMarshaller : IRequestMarshaller<Customer, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Customer requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccount())
            {
                context.Writer.WritePropertyName("Account");
                context.Writer.WriteStartObject();

                var marshaller = AccountMarshaller.Instance;
                marshaller.Marshall(requestObject.Account, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContacts())
            {
                context.Writer.WritePropertyName("Contacts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContactsListValue in requestObject.Contacts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContactMarshaller.Instance;
                    marshaller.Marshall(requestObjectContactsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomerMarshaller Instance = new CustomerMarshaller();

    }
}