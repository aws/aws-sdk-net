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

using Amazon.GuardDuty.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UsageCriteria Marshaller
    /// </summary>
    public partial class UsageCriteriaMarshaller : IRequestMarshaller<UsageCriteria, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(UsageCriteria requestObject, JsonMarshallerContext context)
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

            if (requestObject.IsSetDataSources())
            {
                context.Writer.WritePropertyName("dataSources");
                context.Writer.WriteStartArray();
                foreach (var requestObjectDataSourcesListValue in requestObject.DataSources)
                {
                    context.Writer.WriteStringValue(requestObjectDataSourcesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetFeatures())
            {
                context.Writer.WritePropertyName("features");
                context.Writer.WriteStartArray();
                foreach (var requestObjectFeaturesListValue in requestObject.Features)
                {
                    context.Writer.WriteStringValue(requestObjectFeaturesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetResources())
            {
                context.Writer.WritePropertyName("resources");
                context.Writer.WriteStartArray();
                foreach (var requestObjectResourcesListValue in requestObject.Resources)
                {
                    context.Writer.WriteStringValue(requestObjectResourcesListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static UsageCriteriaMarshaller Instance = new UsageCriteriaMarshaller();
    }
}
