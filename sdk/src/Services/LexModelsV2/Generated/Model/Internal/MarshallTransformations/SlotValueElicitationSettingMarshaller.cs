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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SlotValueElicitationSetting Marshaller
    /// </summary>
    public class SlotValueElicitationSettingMarshaller : IRequestMarshaller<SlotValueElicitationSetting, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SlotValueElicitationSetting requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefaultValueSpecification())
            {
                context.Writer.WritePropertyName("defaultValueSpecification");
                context.Writer.WriteStartObject();

                var marshaller = SlotDefaultValueSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultValueSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPromptSpecification())
            {
                context.Writer.WritePropertyName("promptSpecification");
                context.Writer.WriteStartObject();

                var marshaller = PromptSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.PromptSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSampleUtterances())
            {
                context.Writer.WritePropertyName("sampleUtterances");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSampleUtterancesListValue in requestObject.SampleUtterances)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SampleUtteranceMarshaller.Instance;
                    marshaller.Marshall(requestObjectSampleUtterancesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSlotCaptureSetting())
            {
                context.Writer.WritePropertyName("slotCaptureSetting");
                context.Writer.WriteStartObject();

                var marshaller = SlotCaptureSettingMarshaller.Instance;
                marshaller.Marshall(requestObject.SlotCaptureSetting, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSlotConstraint())
            {
                context.Writer.WritePropertyName("slotConstraint");
                context.Writer.WriteStringValue(requestObject.SlotConstraint);
            }

            if(requestObject.IsSetSlotResolutionSetting())
            {
                context.Writer.WritePropertyName("slotResolutionSetting");
                context.Writer.WriteStartObject();

                var marshaller = SlotResolutionSettingMarshaller.Instance;
                marshaller.Marshall(requestObject.SlotResolutionSetting, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWaitAndContinueSpecification())
            {
                context.Writer.WritePropertyName("waitAndContinueSpecification");
                context.Writer.WriteStartObject();

                var marshaller = WaitAndContinueSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.WaitAndContinueSpecification, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SlotValueElicitationSettingMarshaller Instance = new SlotValueElicitationSettingMarshaller();

    }
}