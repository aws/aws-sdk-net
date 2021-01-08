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
    /// Statement Marshaller
    /// </summary>       
    public class StatementMarshaller : IRequestMarshaller<Statement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Statement requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMessages())
            {
                context.Writer.WritePropertyName("messages");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMessagesListValue in requestObject.Messages)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MessageMarshaller.Instance;
                    marshaller.Marshall(requestObjectMessagesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResponseCard())
            {
                context.Writer.WritePropertyName("responseCard");
                context.Writer.Write(requestObject.ResponseCard);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static StatementMarshaller Instance = new StatementMarshaller();

    }
}