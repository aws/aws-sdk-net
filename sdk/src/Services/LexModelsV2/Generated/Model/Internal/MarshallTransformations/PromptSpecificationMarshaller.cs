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
    /// PromptSpecification Marshaller
    /// </summary>
    public class PromptSpecificationMarshaller : IRequestMarshaller<PromptSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PromptSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllowInterrupt())
            {
                context.Writer.WritePropertyName("allowInterrupt");
                context.Writer.Write(requestObject.AllowInterrupt);
            }

            if(requestObject.IsSetMaxRetries())
            {
                context.Writer.WritePropertyName("maxRetries");
                context.Writer.Write(requestObject.MaxRetries);
            }

            if(requestObject.IsSetMessageGroups())
            {
                context.Writer.WritePropertyName("messageGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMessageGroupsListValue in requestObject.MessageGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MessageGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectMessageGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMessageSelectionStrategy())
            {
                context.Writer.WritePropertyName("messageSelectionStrategy");
                context.Writer.Write(requestObject.MessageSelectionStrategy);
            }

            if(requestObject.IsSetPromptAttemptsSpecification())
            {
                context.Writer.WritePropertyName("promptAttemptsSpecification");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPromptAttemptsSpecificationKvp in requestObject.PromptAttemptsSpecification)
                {
                    context.Writer.WritePropertyName(requestObjectPromptAttemptsSpecificationKvp.Key);
                    var requestObjectPromptAttemptsSpecificationValue = requestObjectPromptAttemptsSpecificationKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = PromptAttemptSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectPromptAttemptsSpecificationValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PromptSpecificationMarshaller Instance = new PromptSpecificationMarshaller();

    }
}