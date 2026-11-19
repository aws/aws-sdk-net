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

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProvisioningPreferences Marshaller
    /// </summary>
    public partial class ProvisioningPreferencesMarshaller : IRequestMarshaller<ProvisioningPreferences, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ProvisioningPreferences requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetStackSetAccounts())
            {
                context.Writer.WriteTextString("StackSetAccounts");
                context.Writer.WriteStartArray(requestObject.StackSetAccounts.Count);
                foreach (var requestObjectStackSetAccountsListValue in requestObject.StackSetAccounts)
                {
                    context.Writer.WriteTextString(requestObjectStackSetAccountsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStackSetFailureToleranceCount())
            {
                context.Writer.WriteTextString("StackSetFailureToleranceCount");
                context.Writer.WriteInt32(requestObject.StackSetFailureToleranceCount.Value);
            }

            if (requestObject.IsSetStackSetFailureTolerancePercentage())
            {
                context.Writer.WriteTextString("StackSetFailureTolerancePercentage");
                context.Writer.WriteInt32(requestObject.StackSetFailureTolerancePercentage.Value);
            }

            if (requestObject.IsSetStackSetMaxConcurrencyCount())
            {
                context.Writer.WriteTextString("StackSetMaxConcurrencyCount");
                context.Writer.WriteInt32(requestObject.StackSetMaxConcurrencyCount.Value);
            }

            if (requestObject.IsSetStackSetMaxConcurrencyPercentage())
            {
                context.Writer.WriteTextString("StackSetMaxConcurrencyPercentage");
                context.Writer.WriteInt32(requestObject.StackSetMaxConcurrencyPercentage.Value);
            }

            if (requestObject.IsSetStackSetRegions())
            {
                context.Writer.WriteTextString("StackSetRegions");
                context.Writer.WriteStartArray(requestObject.StackSetRegions.Count);
                foreach (var requestObjectStackSetRegionsListValue in requestObject.StackSetRegions)
                {
                    context.Writer.WriteTextString(requestObjectStackSetRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ProvisioningPreferencesMarshaller Instance = new ProvisioningPreferencesMarshaller();
    }
}
