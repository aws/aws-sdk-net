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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.JSONRPC10.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.JSONRPC10.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Dialog Marshaller
    /// </summary>
    public class DialogMarshaller : IRequestMarshaller<Dialog, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Dialog requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFarewell())
            {
                context.Writer.WritePropertyName("farewell");
                context.Writer.WriteObjectStart();

                var marshaller = FarewellMarshaller.Instance;
                marshaller.Marshall(requestObject.Farewell, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGreeting())
            {
                context.Writer.WritePropertyName("greeting");
                context.Writer.Write(requestObject.Greeting);
            }

            if(requestObject.IsSetLanguage())
            {
                context.Writer.WritePropertyName("language");
                context.Writer.Write(requestObject.Language);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DialogMarshaller Instance = new DialogMarshaller();

    }
}