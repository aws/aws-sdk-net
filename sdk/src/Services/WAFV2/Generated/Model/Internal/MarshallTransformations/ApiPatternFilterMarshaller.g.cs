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

using Amazon.WAFV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApiPatternFilter Marshaller
    /// </summary>
    public partial class ApiPatternFilterMarshaller : IRequestMarshaller<ApiPatternFilter, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ApiPatternFilter requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDomains())
            {
                context.Writer.WritePropertyName("Domains");
                context.Writer.WriteStartArray();
                foreach (var requestObjectDomainsListValue in requestObject.Domains)
                {
                    context.Writer.WriteStringValue(requestObjectDomainsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetMethod())
            {
                context.Writer.WritePropertyName("Method");
                context.Writer.WriteStringValue(requestObject.Method);
            }

            if (requestObject.IsSetPathPattern())
            {
                context.Writer.WritePropertyName("PathPattern");
                context.Writer.WriteStringValue(requestObject.PathPattern);
            }

            if (requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ApiPatternFilterMarshaller Instance = new ApiPatternFilterMarshaller();
    }
}
