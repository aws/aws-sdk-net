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

using Amazon.SecurityHub.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsRdsEventSubscriptionDetails Marshaller
    /// </summary>
    public partial class AwsRdsEventSubscriptionDetailsMarshaller : IRequestMarshaller<AwsRdsEventSubscriptionDetails, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(AwsRdsEventSubscriptionDetails requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCustSubscriptionId())
            {
                context.Writer.WritePropertyName("CustSubscriptionId");
                context.Writer.WriteStringValue(requestObject.CustSubscriptionId);
            }

            if (requestObject.IsSetCustomerAwsId())
            {
                context.Writer.WritePropertyName("CustomerAwsId");
                context.Writer.WriteStringValue(requestObject.CustomerAwsId);
            }

            if (requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if (requestObject.IsSetEventCategoriesList())
            {
                context.Writer.WritePropertyName("EventCategoriesList");
                context.Writer.WriteStartArray();
                foreach (var requestObjectEventCategoriesListListValue in requestObject.EventCategoriesList)
                {
                    context.Writer.WriteStringValue(requestObjectEventCategoriesListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetEventSubscriptionArn())
            {
                context.Writer.WritePropertyName("EventSubscriptionArn");
                context.Writer.WriteStringValue(requestObject.EventSubscriptionArn);
            }

            if (requestObject.IsSetSnsTopicArn())
            {
                context.Writer.WritePropertyName("SnsTopicArn");
                context.Writer.WriteStringValue(requestObject.SnsTopicArn);
            }

            if (requestObject.IsSetSourceIdsList())
            {
                context.Writer.WritePropertyName("SourceIdsList");
                context.Writer.WriteStartArray();
                foreach (var requestObjectSourceIdsListListValue in requestObject.SourceIdsList)
                {
                    context.Writer.WriteStringValue(requestObjectSourceIdsListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("SourceType");
                context.Writer.WriteStringValue(requestObject.SourceType);
            }

            if (requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if (requestObject.IsSetSubscriptionCreationTime())
            {
                context.Writer.WritePropertyName("SubscriptionCreationTime");
                context.Writer.WriteStringValue(requestObject.SubscriptionCreationTime);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static AwsRdsEventSubscriptionDetailsMarshaller Instance = new AwsRdsEventSubscriptionDetailsMarshaller();
    }
}
