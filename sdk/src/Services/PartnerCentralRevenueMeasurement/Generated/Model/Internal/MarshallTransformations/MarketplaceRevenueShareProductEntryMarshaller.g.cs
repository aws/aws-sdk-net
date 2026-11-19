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
    /// MarketplaceRevenueShareProductEntry Marshaller
    /// </summary>
    public partial class MarketplaceRevenueShareProductEntryMarshaller : IRequestMarshaller<MarketplaceRevenueShareProductEntry, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(MarketplaceRevenueShareProductEntry requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAccounts())
            {
                context.Writer.WriteTextString("Accounts");
                context.Writer.WriteStartArray(requestObject.Accounts.Count);
                foreach (var requestObjectAccountsListValue in requestObject.Accounts)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = RevenueShareProductAccountEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectAccountsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetProductId())
            {
                context.Writer.WriteTextString("ProductId");
                context.Writer.WriteTextString(requestObject.ProductId);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static MarketplaceRevenueShareProductEntryMarshaller Instance = new MarketplaceRevenueShareProductEntryMarshaller();
    }
}
