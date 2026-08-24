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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Scope Marshaller
    /// </summary>
    public class ScopeMarshaller : IRequestMarshaller<Scope, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Scope requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGoalIds())
            {
                context.Writer.WritePropertyName("goalIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGoalIdsListValue in requestObject.GoalIds)
                {
                        context.Writer.WriteStringValue(requestObjectGoalIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetItems())
            {
                context.Writer.WritePropertyName("items");
                context.Writer.WriteStartArray();
                foreach(var requestObjectItemsListValue in requestObject.Items)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PillarItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectItemsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPillars())
            {
                context.Writer.WritePropertyName("pillars");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPillarsListValue in requestObject.Pillars)
                {
                        context.Writer.WriteStringValue(requestObjectPillarsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScopeMarshaller Instance = new ScopeMarshaller();

    }
}