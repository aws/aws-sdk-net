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
    /// SlotCaptureSetting Marshaller
    /// </summary>
    public class SlotCaptureSettingMarshaller : IRequestMarshaller<SlotCaptureSetting, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SlotCaptureSetting requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCaptureConditional())
            {
                context.Writer.WritePropertyName("captureConditional");
                context.Writer.WriteStartObject();

                var marshaller = ConditionalSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CaptureConditional, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCaptureNextStep())
            {
                context.Writer.WritePropertyName("captureNextStep");
                context.Writer.WriteStartObject();

                var marshaller = DialogStateMarshaller.Instance;
                marshaller.Marshall(requestObject.CaptureNextStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCaptureResponse())
            {
                context.Writer.WritePropertyName("captureResponse");
                context.Writer.WriteStartObject();

                var marshaller = ResponseSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CaptureResponse, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCodeHook())
            {
                context.Writer.WritePropertyName("codeHook");
                context.Writer.WriteStartObject();

                var marshaller = DialogCodeHookInvocationSettingMarshaller.Instance;
                marshaller.Marshall(requestObject.CodeHook, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetElicitationCodeHook())
            {
                context.Writer.WritePropertyName("elicitationCodeHook");
                context.Writer.WriteStartObject();

                var marshaller = ElicitationCodeHookInvocationSettingMarshaller.Instance;
                marshaller.Marshall(requestObject.ElicitationCodeHook, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFailureConditional())
            {
                context.Writer.WritePropertyName("failureConditional");
                context.Writer.WriteStartObject();

                var marshaller = ConditionalSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.FailureConditional, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFailureNextStep())
            {
                context.Writer.WritePropertyName("failureNextStep");
                context.Writer.WriteStartObject();

                var marshaller = DialogStateMarshaller.Instance;
                marshaller.Marshall(requestObject.FailureNextStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFailureResponse())
            {
                context.Writer.WritePropertyName("failureResponse");
                context.Writer.WriteStartObject();

                var marshaller = ResponseSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.FailureResponse, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SlotCaptureSettingMarshaller Instance = new SlotCaptureSettingMarshaller();

    }
}