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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAccountIdsListValue in requestObject.AccountIds)
                {
                        context.Writer.Write(requestObjectAccountIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetActionTypes())
            {
                context.Writer.WritePropertyName("actionTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActionTypesListValue in requestObject.ActionTypes)
                {
                        context.Writer.Write(requestObjectActionTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetImplementationEfforts())
            {
                context.Writer.WritePropertyName("implementationEfforts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectImplementationEffortsListValue in requestObject.ImplementationEfforts)
                {
                        context.Writer.Write(requestObjectImplementationEffortsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRecommendationIds())
            {
                context.Writer.WritePropertyName("recommendationIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRecommendationIdsListValue in requestObject.RecommendationIds)
                {
                        context.Writer.Write(requestObjectRecommendationIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("regions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.Write(requestObjectRegionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceArns())
            {
                context.Writer.WritePropertyName("resourceArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceArnsListValue in requestObject.ResourceArns)
                {
                        context.Writer.Write(requestObjectResourceArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceIds())
            {
                context.Writer.WritePropertyName("resourceIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceIdsListValue in requestObject.ResourceIds)
                {
                        context.Writer.Write(requestObjectResourceIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("resourceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                        context.Writer.Write(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRestartNeeded())
            {
                context.Writer.WritePropertyName("restartNeeded");
                context.Writer.Write(requestObject.RestartNeeded);
            }

            if(requestObject.IsSetRollbackPossible())
            {
                context.Writer.WritePropertyName("rollbackPossible");
                context.Writer.Write(requestObject.RollbackPossible);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterMarshaller Instance = new FilterMarshaller();

    }
}