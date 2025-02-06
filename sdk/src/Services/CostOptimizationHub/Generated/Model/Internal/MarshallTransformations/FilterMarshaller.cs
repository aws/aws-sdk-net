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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostOptimizationHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CostOptimizationHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Filter Marshaller
    /// </summary>
    public class FilterMarshaller : IRequestMarshaller<Filter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Filter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountIds())
            {
                context.Writer.WritePropertyName("accountIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccountIdsListValue in requestObject.AccountIds)
                {
                        context.Writer.WriteStringValue(requestObjectAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetActionTypes())
            {
                context.Writer.WritePropertyName("actionTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectActionTypesListValue in requestObject.ActionTypes)
                {
                        context.Writer.WriteStringValue(requestObjectActionTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetImplementationEfforts())
            {
                context.Writer.WritePropertyName("implementationEfforts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectImplementationEffortsListValue in requestObject.ImplementationEfforts)
                {
                        context.Writer.WriteStringValue(requestObjectImplementationEffortsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRecommendationIds())
            {
                context.Writer.WritePropertyName("recommendationIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRecommendationIdsListValue in requestObject.RecommendationIds)
                {
                        context.Writer.WriteStringValue(requestObjectRecommendationIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("regions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.WriteStringValue(requestObjectRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceArns())
            {
                context.Writer.WritePropertyName("resourceArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceArnsListValue in requestObject.ResourceArns)
                {
                        context.Writer.WriteStringValue(requestObjectResourceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceIds())
            {
                context.Writer.WritePropertyName("resourceIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceIdsListValue in requestObject.ResourceIds)
                {
                        context.Writer.WriteStringValue(requestObjectResourceIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("resourceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRestartNeeded())
            {
                context.Writer.WritePropertyName("restartNeeded");
                context.Writer.WriteBooleanValue(requestObject.RestartNeeded.Value);
            }

            if(requestObject.IsSetRollbackPossible())
            {
                context.Writer.WritePropertyName("rollbackPossible");
                context.Writer.WriteBooleanValue(requestObject.RollbackPossible.Value);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterMarshaller Instance = new FilterMarshaller();

    }
}