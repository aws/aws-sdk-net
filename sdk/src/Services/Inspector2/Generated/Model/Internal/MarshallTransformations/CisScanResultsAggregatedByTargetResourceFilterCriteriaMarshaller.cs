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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAccountIdFiltersListValue in requestObject.AccountIdFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAccountIdFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCheckIdFilters())
            {
                context.Writer.WritePropertyName("checkIdFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCheckIdFiltersListValue in requestObject.CheckIdFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCheckIdFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFailedChecksFilters())
            {
                context.Writer.WritePropertyName("failedChecksFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFailedChecksFiltersListValue in requestObject.FailedChecksFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisNumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFailedChecksFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPlatformFilters())
            {
                context.Writer.WritePropertyName("platformFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPlatformFiltersListValue in requestObject.PlatformFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlatformFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatusFilters())
            {
                context.Writer.WritePropertyName("statusFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatusFiltersListValue in requestObject.StatusFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisResultStatusFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatusFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetResourceIdFilters())
            {
                context.Writer.WritePropertyName("targetResourceIdFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetResourceIdFiltersListValue in requestObject.TargetResourceIdFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetResourceIdFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetResourceTagFilters())
            {
                context.Writer.WritePropertyName("targetResourceTagFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetResourceTagFiltersListValue in requestObject.TargetResourceTagFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TagFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetResourceTagFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetStatusFilters())
            {
                context.Writer.WritePropertyName("targetStatusFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetStatusFiltersListValue in requestObject.TargetStatusFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisTargetStatusFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetStatusFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetStatusReasonFilters())
            {
                context.Writer.WritePropertyName("targetStatusReasonFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetStatusReasonFiltersListValue in requestObject.TargetStatusReasonFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CisTargetStatusReasonFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetStatusReasonFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CisScanResultsAggregatedByTargetResourceFilterCriteriaMarshaller Instance = new CisScanResultsAggregatedByTargetResourceFilterCriteriaMarshaller();

    }
}