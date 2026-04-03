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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AccountEnforcedGuardrailInferenceInputConfiguration Marshaller
    /// </summary>
    public class AccountEnforcedGuardrailInferenceInputConfigurationMarshaller : IRequestMarshaller<AccountEnforcedGuardrailInferenceInputConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AccountEnforcedGuardrailInferenceInputConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGuardrailIdentifier())
            {
                context.Writer.WritePropertyName("guardrailIdentifier");
                context.Writer.WriteStringValue(requestObject.GuardrailIdentifier);
            }

            if(requestObject.IsSetGuardrailVersion())
            {
                context.Writer.WritePropertyName("guardrailVersion");
                context.Writer.WriteStringValue(requestObject.GuardrailVersion);
            }

            if(requestObject.IsSetModelEnforcement())
            {
                context.Writer.WritePropertyName("modelEnforcement");
                context.Writer.WriteStartObject();

                var marshaller = ModelEnforcementMarshaller.Instance;
                marshaller.Marshall(requestObject.ModelEnforcement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSelectiveContentGuarding())
            {
                context.Writer.WritePropertyName("selectiveContentGuarding");
                context.Writer.WriteStartObject();

                var marshaller = SelectiveContentGuardingMarshaller.Instance;
                marshaller.Marshall(requestObject.SelectiveContentGuarding, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AccountEnforcedGuardrailInferenceInputConfigurationMarshaller Instance = new AccountEnforcedGuardrailInferenceInputConfigurationMarshaller();

    }
}