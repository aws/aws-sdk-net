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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BillingConductor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BillingConductor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAccountAssociationsFilter Marshaller
    /// </summary>
    public class ListAccountAssociationsFilterMarshaller : IRequestMarshaller<ListAccountAssociationsFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListAccountAssociationsFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountId())
            {
                context.Writer.WritePropertyName("AccountId");
                context.Writer.WriteStringValue(requestObject.AccountId);
            }

            if(requestObject.IsSetAccountIds())
            {
                context.Writer.WritePropertyName("AccountIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccountIdsListValue in requestObject.AccountIds)
                {
                        context.Writer.WriteStringValue(requestObjectAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAssociation())
            {
                context.Writer.WritePropertyName("Association");
                context.Writer.WriteStringValue(requestObject.Association);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ListAccountAssociationsFilterMarshaller Instance = new ListAccountAssociationsFilterMarshaller();

    }
}