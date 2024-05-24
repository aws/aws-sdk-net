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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IntentConfirmationSetting Marshaller
    /// </summary>
    public class IntentConfirmationSettingMarshaller : IRequestMarshaller<IntentConfirmationSetting, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IntentConfirmationSetting requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActive())
            {
                context.Writer.WritePropertyName("active");
                context.Writer.Write(requestObject.Active);
            }

            if(requestObject.IsSetCodeHook())
            {
                context.Writer.WritePropertyName("codeHook");
                context.Writer.WriteObjectStart();

                var marshaller = DialogCodeHookInvocationSettingMarshaller.Instance;
                marshaller.Marshall(requestObject.CodeHook, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConfirmationConditional())
            {
                context.Writer.WritePropertyName("confirmationConditional");
                context.Writer.WriteObjectStart();

                var marshaller = ConditionalSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfirmationConditional, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConfirmationNextStep())
            {
                context.Writer.WritePropertyName("confirmationNextStep");
                context.Writer.WriteObjectStart();

                var marshaller = DialogStateMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfirmationNextStep, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConfirmationResponse())
            {
                context.Writer.WritePropertyName("confirmationResponse");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfirmationResponse, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeclinationConditional())
            {
                context.Writer.WritePropertyName("declinationConditional");
                context.Writer.WriteObjectStart();

                var marshaller = ConditionalSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.DeclinationConditional, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeclinationNextStep())
            {
                context.Writer.WritePropertyName("declinationNextStep");
                context.Writer.WriteObjectStart();

                var marshaller = DialogStateMarshaller.Instance;
                marshaller.Marshall(requestObject.DeclinationNextStep, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeclinationResponse())
            {
                context.Writer.WritePropertyName("declinationResponse");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.DeclinationResponse, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetElicitationCodeHook())
            {
                context.Writer.WritePropertyName("elicitationCodeHook");
                context.Writer.WriteObjectStart();

                var marshaller = ElicitationCodeHookInvocationSettingMarshaller.Instance;
                marshaller.Marshall(requestObject.ElicitationCodeHook, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFailureConditional())
            {
                context.Writer.WritePropertyName("failureConditional");
                context.Writer.WriteObjectStart();

                var marshaller = ConditionalSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.FailureConditional, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFailureNextStep())
            {
                context.Writer.WritePropertyName("failureNextStep");
                context.Writer.WriteObjectStart();

                var marshaller = DialogStateMarshaller.Instance;
                marshaller.Marshall(requestObject.FailureNextStep, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFailureResponse())
            {
                context.Writer.WritePropertyName("failureResponse");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.FailureResponse, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPromptSpecification())
            {
                context.Writer.WritePropertyName("promptSpecification");
                context.Writer.WriteObjectStart();

                var marshaller = PromptSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.PromptSpecification, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IntentConfirmationSettingMarshaller Instance = new IntentConfirmationSettingMarshaller();

    }
}