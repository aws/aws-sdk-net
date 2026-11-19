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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.PartnerCentralRevenueMeasurement.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralRevenueMeasurement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RevenueShareProductAccountEntry Marshaller
    /// </summary>
    public partial class RevenueShareProductAccountEntryMarshaller : IRequestMarshaller<RevenueShareProductAccountEntry, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(RevenueShareProductAccountEntry requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAccountIds())
            {
                context.Writer.WriteTextString("AccountIds");
                context.Writer.WriteStartArray(requestObject.AccountIds.Count);
                foreach (var requestObjectAccountIdsListValue in requestObject.AccountIds)
                {
                    context.Writer.WriteTextString(requestObjectAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetAccountType())
            {
                context.Writer.WriteTextString("AccountType");
                context.Writer.WriteTextString(requestObject.AccountType);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static RevenueShareProductAccountEntryMarshaller Instance = new RevenueShareProductAccountEntryMarshaller();
    }
}
