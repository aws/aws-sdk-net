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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FollowUpPrompt Marshaller
    /// </summary>       
    public class FollowUpPromptMarshaller : IRequestMarshaller<FollowUpPrompt, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FollowUpPrompt requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetPrompt())
            {
                context.Writer.WritePropertyName("prompt");
                context.Writer.WriteObjectStart();

                var marshaller = PromptMarshaller.Instance;
                marshaller.Marshall(requestObject.Prompt, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRejectionStatement())
            {
                context.Writer.WritePropertyName("rejectionStatement");
                context.Writer.WriteObjectStart();

                var marshaller = StatementMarshaller.Instance;
                marshaller.Marshall(requestObject.RejectionStatement, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FollowUpPromptMarshaller Instance = new FollowUpPromptMarshaller();

    }
}