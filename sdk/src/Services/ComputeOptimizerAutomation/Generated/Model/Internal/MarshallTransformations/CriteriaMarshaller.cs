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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Criteria Marshaller
    /// </summary>
    public class CriteriaMarshaller : IRequestMarshaller<Criteria, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Criteria requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetEbsVolumeSizeInGib())
            {
                context.Writer.WriteTextString("ebsVolumeSizeInGib");
                context.Writer.WriteStartArray(requestObject.EbsVolumeSizeInGib.Count);
                foreach(var requestObjectEbsVolumeSizeInGibListValue in requestObject.EbsVolumeSizeInGib)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = IntegerCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectEbsVolumeSizeInGibListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEbsVolumeType())
            {
                context.Writer.WriteTextString("ebsVolumeType");
                context.Writer.WriteStartArray(requestObject.EbsVolumeType.Count);
                foreach(var requestObjectEbsVolumeTypeListValue in requestObject.EbsVolumeType)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = StringCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectEbsVolumeTypeListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEstimatedMonthlySavings())
            {
                context.Writer.WriteTextString("estimatedMonthlySavings");
                context.Writer.WriteStartArray(requestObject.EstimatedMonthlySavings.Count);
                foreach(var requestObjectEstimatedMonthlySavingsListValue in requestObject.EstimatedMonthlySavings)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = DoubleCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectEstimatedMonthlySavingsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetLookBackPeriodInDays())
            {
                context.Writer.WriteTextString("lookBackPeriodInDays");
                context.Writer.WriteStartArray(requestObject.LookBackPeriodInDays.Count);
                foreach(var requestObjectLookBackPeriodInDaysListValue in requestObject.LookBackPeriodInDays)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = IntegerCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectLookBackPeriodInDaysListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetRegion())
            {
                context.Writer.WriteTextString("region");
                context.Writer.WriteStartArray(requestObject.Region.Count);
                foreach(var requestObjectRegionListValue in requestObject.Region)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = StringCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectRegionListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetResourceArn())
            {
                context.Writer.WriteTextString("resourceArn");
                context.Writer.WriteStartArray(requestObject.ResourceArn.Count);
                foreach(var requestObjectResourceArnListValue in requestObject.ResourceArn)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = StringCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceArnListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetResourceTag())
            {
                context.Writer.WriteTextString("resourceTag");
                context.Writer.WriteStartArray(requestObject.ResourceTag.Count);
                foreach(var requestObjectResourceTagListValue in requestObject.ResourceTag)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ResourceTagsCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTagListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetRestartNeeded())
            {
                context.Writer.WriteTextString("restartNeeded");
                context.Writer.WriteStartArray(requestObject.RestartNeeded.Count);
                foreach(var requestObjectRestartNeededListValue in requestObject.RestartNeeded)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = StringCriteriaConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectRestartNeededListValue, context);

                    context.Writer.WriteEndMap();
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