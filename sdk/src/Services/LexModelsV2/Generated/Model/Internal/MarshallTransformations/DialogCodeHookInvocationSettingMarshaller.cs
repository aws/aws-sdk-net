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
    /// DialogCodeHookInvocationSetting Marshaller
    /// </summary>
    public class DialogCodeHookInvocationSettingMarshaller : IRequestMarshaller<DialogCodeHookInvocationSetting, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DialogCodeHookInvocationSetting requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActive())
            {
                context.Writer.WritePropertyName("active");
                context.Writer.WriteBooleanValue(requestObject.Active.Value);
            }

            if(requestObject.IsSetEnableCodeHookInvocation())
            {
                context.Writer.WritePropertyName("enableCodeHookInvocation");
                context.Writer.WriteBooleanValue(requestObject.EnableCodeHookInvocation.Value);
            }

            if(requestObject.IsSetInvocationLabel())
            {
                context.Writer.WritePropertyName("invocationLabel");
                context.Writer.WriteStringValue(requestObject.InvocationLabel);
            }

            if(requestObject.IsSetPostCodeHookSpecification())
            {
                context.Writer.WritePropertyName("postCodeHookSpecification");
                context.Writer.WriteStartObject();

                var marshaller = PostDialogCodeHookInvocationSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.PostCodeHookSpecification, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DialogCodeHookInvocationSettingMarshaller Instance = new DialogCodeHookInvocationSettingMarshaller();

    }
}