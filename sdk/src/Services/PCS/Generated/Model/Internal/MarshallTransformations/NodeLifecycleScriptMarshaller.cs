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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PCS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PCS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NodeLifecycleScript Marshaller
    /// </summary>
    public class NodeLifecycleScriptMarshaller : IRequestMarshaller<NodeLifecycleScript, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NodeLifecycleScript requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArguments())
            {
                context.Writer.WritePropertyName("arguments");
                context.Writer.WriteStartArray();
                foreach(var requestObjectArgumentsListValue in requestObject.Arguments)
                {
                        context.Writer.WriteStringValue(requestObjectArgumentsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExecutionPolicy())
            {
                context.Writer.WritePropertyName("executionPolicy");
                context.Writer.WriteStringValue(requestObject.ExecutionPolicy);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOnError())
            {
                context.Writer.WritePropertyName("onError");
                context.Writer.WriteStringValue(requestObject.OnError);
            }

            if(requestObject.IsSetScriptSource())
            {
                context.Writer.WritePropertyName("scriptSource");
                context.Writer.WriteStartObject();

                var marshaller = ScriptSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.ScriptSource, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NodeLifecycleScriptMarshaller Instance = new NodeLifecycleScriptMarshaller();

    }
}