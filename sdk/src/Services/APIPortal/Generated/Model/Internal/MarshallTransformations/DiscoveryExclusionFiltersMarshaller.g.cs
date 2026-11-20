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

using Amazon.APIPortal.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.APIPortal.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DiscoveryExclusionFilters Marshaller
    /// </summary>
    public partial class DiscoveryExclusionFiltersMarshaller : IRequestMarshaller<DiscoveryExclusionFilters, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DiscoveryExclusionFilters requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAccountIds())
            {
                context.Writer.WritePropertyName("accountIds");
                context.Writer.WriteStartArray();
                foreach (var requestObjectAccountIdsListValue in requestObject.AccountIds)
                {
                    context.Writer.WriteStringValue(requestObjectAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetOrganizationalUnitIds())
            {
                context.Writer.WritePropertyName("organizationalUnitIds");
                context.Writer.WriteStartArray();
                foreach (var requestObjectOrganizationalUnitIdsListValue in requestObject.OrganizationalUnitIds)
                {
                    context.Writer.WriteStringValue(requestObjectOrganizationalUnitIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetResourceArns())
            {
                context.Writer.WritePropertyName("resourceArns");
                context.Writer.WriteStartArray();
                foreach (var requestObjectResourceArnsListValue in requestObject.ResourceArns)
                {
                    context.Writer.WriteStringValue(requestObjectResourceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DiscoveryExclusionFiltersMarshaller Instance = new DiscoveryExclusionFiltersMarshaller();
    }
}
