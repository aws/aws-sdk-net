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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CisScanResultsAggregatedByTargetResourceFilterCriteria Marshaller
    /// </summary>
    public class CisScanResultsAggregatedByTargetResourceFilterCriteriaMarshaller : IRequestMarshaller<CisScanResultsAggregatedByTargetResourceFilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CisScanResultsAggregatedByTargetResourceFilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountIdFilters())
            {
                context.Writer.WritePropertyName("accountIdFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccountIdFiltersListValue in requestObject.AccountIdFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAccountIdFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCheckIdFilters())
            {
                context.Writer.WritePropertyName("checkIdFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCheckIdFiltersListValue in requestObject.CheckIdFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCheckIdFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFailedChecksFilters())
            {
                context.Writer.WritePropertyName("failedChecksFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFailedChecksFiltersListValue in requestObject.FailedChecksFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisNumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFailedChecksFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPlatformFilters())
            {
                context.Writer.WritePropertyName("platformFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPlatformFiltersListValue in requestObject.PlatformFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlatformFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatusFilters())
            {
                context.Writer.WritePropertyName("statusFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatusFiltersListValue in requestObject.StatusFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisResultStatusFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatusFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetResourceIdFilters())
            {
                context.Writer.WritePropertyName("targetResourceIdFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetResourceIdFiltersListValue in requestObject.TargetResourceIdFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetResourceIdFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetResourceTagFilters())
            {
                context.Writer.WritePropertyName("targetResourceTagFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetResourceTagFiltersListValue in requestObject.TargetResourceTagFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetResourceTagFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetStatusFilters())
            {
                context.Writer.WritePropertyName("targetStatusFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetStatusFiltersListValue in requestObject.TargetStatusFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisTargetStatusFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetStatusFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetStatusReasonFilters())
            {
                context.Writer.WritePropertyName("targetStatusReasonFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetStatusReasonFiltersListValue in requestObject.TargetStatusReasonFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisTargetStatusReasonFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetStatusReasonFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CisScanResultsAggregatedByTargetResourceFilterCriteriaMarshaller Instance = new CisScanResultsAggregatedByTargetResourceFilterCriteriaMarshaller();

    }
}