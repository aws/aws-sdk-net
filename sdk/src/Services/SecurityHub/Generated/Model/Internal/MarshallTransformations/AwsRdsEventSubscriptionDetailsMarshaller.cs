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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsRdsEventSubscriptionDetails Marshaller
    /// </summary>       
    public class AwsRdsEventSubscriptionDetailsMarshaller : IRequestMarshaller<AwsRdsEventSubscriptionDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRdsEventSubscriptionDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCustomerAwsId())
            {
                context.Writer.WritePropertyName("CustomerAwsId");
                context.Writer.Write(requestObject.CustomerAwsId);
            }

            if(requestObject.IsSetCustSubscriptionId())
            {
                context.Writer.WritePropertyName("CustSubscriptionId");
                context.Writer.Write(requestObject.CustSubscriptionId);
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.Write(requestObject.Enabled);
            }

            if(requestObject.IsSetEventCategoriesList())
            {
                context.Writer.WritePropertyName("EventCategoriesList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventCategoriesListListValue in requestObject.EventCategoriesList)
                {
                        context.Writer.Write(requestObjectEventCategoriesListListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEventSubscriptionArn())
            {
                context.Writer.WritePropertyName("EventSubscriptionArn");
                context.Writer.Write(requestObject.EventSubscriptionArn);
            }

            if(requestObject.IsSetSnsTopicArn())
            {
                context.Writer.WritePropertyName("SnsTopicArn");
                context.Writer.Write(requestObject.SnsTopicArn);
            }

            if(requestObject.IsSetSourceIdsList())
            {
                context.Writer.WritePropertyName("SourceIdsList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSourceIdsListListValue in requestObject.SourceIdsList)
                {
                        context.Writer.Write(requestObjectSourceIdsListListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("SourceType");
                context.Writer.Write(requestObject.SourceType);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetSubscriptionCreationTime())
            {
                context.Writer.WritePropertyName("SubscriptionCreationTime");
                context.Writer.Write(requestObject.SubscriptionCreationTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsRdsEventSubscriptionDetailsMarshaller Instance = new AwsRdsEventSubscriptionDetailsMarshaller();

    }
}