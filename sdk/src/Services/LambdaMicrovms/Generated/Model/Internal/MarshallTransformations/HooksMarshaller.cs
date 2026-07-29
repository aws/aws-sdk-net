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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LambdaMicrovms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LambdaMicrovms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Hooks Marshaller
    /// </summary>
    public class HooksMarshaller : IRequestMarshaller<Hooks, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Hooks requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMicrovmHooks())
            {
                context.Writer.WritePropertyName("microvmHooks");
                context.Writer.WriteStartObject();

                var marshaller = MicrovmHooksMarshaller.Instance;
                marshaller.Marshall(requestObject.MicrovmHooks, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMicrovmImageHooks())
            {
                context.Writer.WritePropertyName("microvmImageHooks");
                context.Writer.WriteStartObject();

                var marshaller = MicrovmImageHooksMarshaller.Instance;
                marshaller.Marshall(requestObject.MicrovmImageHooks, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HooksMarshaller Instance = new HooksMarshaller();

    }
}