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
    /// ListCisScansFilterCriteria Marshaller
    /// </summary>
    public class ListCisScansFilterCriteriaMarshaller : IRequestMarshaller<ListCisScansFilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListCisScansFilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
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

            if(requestObject.IsSetScanArnFilters())
            {
                context.Writer.WritePropertyName("scanArnFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanArnFiltersListValue in requestObject.ScanArnFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanArnFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScanAtFilters())
            {
                context.Writer.WritePropertyName("scanAtFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanAtFiltersListValue in requestObject.ScanAtFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisDateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanAtFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScanConfigurationArnFilters())
            {
                context.Writer.WritePropertyName("scanConfigurationArnFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanConfigurationArnFiltersListValue in requestObject.ScanConfigurationArnFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanConfigurationArnFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScanNameFilters())
            {
                context.Writer.WritePropertyName("scanNameFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanNameFiltersListValue in requestObject.ScanNameFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanNameFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScanStatusFilters())
            {
                context.Writer.WritePropertyName("scanStatusFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanStatusFiltersListValue in requestObject.ScanStatusFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisScanStatusFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanStatusFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScheduledByFilters())
            {
                context.Writer.WritePropertyName("scheduledByFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScheduledByFiltersListValue in requestObject.ScheduledByFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScheduledByFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetAccountIdFilters())
            {
                context.Writer.WritePropertyName("targetAccountIdFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetAccountIdFiltersListValue in requestObject.TargetAccountIdFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CisStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetAccountIdFiltersListValue, context);

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

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ListCisScansFilterCriteriaMarshaller Instance = new ListCisScansFilterCriteriaMarshaller();

    }
}