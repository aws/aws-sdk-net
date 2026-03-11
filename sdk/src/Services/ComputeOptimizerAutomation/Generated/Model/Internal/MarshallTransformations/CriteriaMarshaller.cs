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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizerAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Criteria Marshaller
    /// </summary>
    public class CriteriaMarshaller : IRequestMarshaller<Criteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Criteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEbsVolumeSizeInGib())
            {
                context.Writer.WritePropertyName("ebsVolumeSizeInGib");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEbsVolumeSizeInGibListValue in requestObject.EbsVolumeSizeInGib)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IntegerCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectEbsVolumeSizeInGibListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEbsVolumeType())
            {
                context.Writer.WritePropertyName("ebsVolumeType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEbsVolumeTypeListValue in requestObject.EbsVolumeType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectEbsVolumeTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEstimatedMonthlySavings())
            {
                context.Writer.WritePropertyName("estimatedMonthlySavings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEstimatedMonthlySavingsListValue in requestObject.EstimatedMonthlySavings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DoubleCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectEstimatedMonthlySavingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLookBackPeriodInDays())
            {
                context.Writer.WritePropertyName("lookBackPeriodInDays");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLookBackPeriodInDaysListValue in requestObject.LookBackPeriodInDays)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IntegerCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectLookBackPeriodInDaysListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("region");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRegionListValue in requestObject.Region)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectRegionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceArn())
            {
                context.Writer.WritePropertyName("resourceArn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceArnListValue in requestObject.ResourceArn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceArnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceTag())
            {
                context.Writer.WritePropertyName("resourceTag");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTagListValue in requestObject.ResourceTag)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceTagsCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTagListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRestartNeeded())
            {
                context.Writer.WritePropertyName("restartNeeded");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRestartNeededListValue in requestObject.RestartNeeded)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectRestartNeededListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CriteriaMarshaller Instance = new CriteriaMarshaller();

    }
}