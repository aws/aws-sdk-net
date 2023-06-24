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

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PromptAttemptSpecification Marshaller
    /// </summary>
    public class PromptAttemptSpecificationMarshaller : IRequestMarshaller<PromptAttemptSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PromptAttemptSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllowedInputTypes())
            {
                context.Writer.WritePropertyName("allowedInputTypes");
                context.Writer.WriteObjectStart();

                var marshaller = AllowedInputTypesMarshaller.Instance;
                marshaller.Marshall(requestObject.AllowedInputTypes, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAllowInterrupt())
            {
                context.Writer.WritePropertyName("allowInterrupt");
                context.Writer.Write(requestObject.AllowInterrupt);
            }

            if(requestObject.IsSetAudioAndDTMFInputSpecification())
            {
                context.Writer.WritePropertyName("audioAndDTMFInputSpecification");
                context.Writer.WriteObjectStart();

                var marshaller = AudioAndDTMFInputSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.AudioAndDTMFInputSpecification, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTextInputSpecification())
            {
                context.Writer.WritePropertyName("textInputSpecification");
                context.Writer.WriteObjectStart();

                var marshaller = TextInputSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.TextInputSpecification, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PromptAttemptSpecificationMarshaller Instance = new PromptAttemptSpecificationMarshaller();

    }
}