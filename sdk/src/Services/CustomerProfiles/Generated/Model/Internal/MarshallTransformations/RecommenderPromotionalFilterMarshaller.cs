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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RecommenderPromotionalFilter Marshaller
    /// </summary>
    public class RecommenderPromotionalFilterMarshaller : IRequestMarshaller<RecommenderPromotionalFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RecommenderPromotionalFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPercentPromotedItems())
            {
                context.Writer.WritePropertyName("PercentPromotedItems");
                context.Writer.WriteNumberValue(requestObject.PercentPromotedItems.Value);
            }

            if(requestObject.IsSetPromotionName())
            {
                context.Writer.WritePropertyName("PromotionName");
                context.Writer.WriteStringValue(requestObject.PromotionName);
            }

            if(requestObject.IsSetValues())
            {
                context.Writer.WritePropertyName("Values");
                context.Writer.WriteStartObject();
                foreach (var requestObjectValuesKvp in requestObject.Values)
                {
                    context.Writer.WritePropertyName(requestObjectValuesKvp.Key);
                    var requestObjectValuesValue = requestObjectValuesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectValuesValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecommenderPromotionalFilterMarshaller Instance = new RecommenderPromotionalFilterMarshaller();

    }
}