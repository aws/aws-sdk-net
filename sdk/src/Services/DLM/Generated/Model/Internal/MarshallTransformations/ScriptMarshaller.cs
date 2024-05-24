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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DLM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Script Marshaller
    /// </summary>
    public class ScriptMarshaller : IRequestMarshaller<Script, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Script requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExecuteOperationOnScriptFailure())
            {
                context.Writer.WritePropertyName("ExecuteOperationOnScriptFailure");
                context.Writer.Write(requestObject.ExecuteOperationOnScriptFailure);
            }

            if(requestObject.IsSetExecutionHandler())
            {
                context.Writer.WritePropertyName("ExecutionHandler");
                context.Writer.Write(requestObject.ExecutionHandler);
            }

            if(requestObject.IsSetExecutionHandlerService())
            {
                context.Writer.WritePropertyName("ExecutionHandlerService");
                context.Writer.Write(requestObject.ExecutionHandlerService);
            }

            if(requestObject.IsSetExecutionTimeout())
            {
                context.Writer.WritePropertyName("ExecutionTimeout");
                context.Writer.Write(requestObject.ExecutionTimeout);
            }

            if(requestObject.IsSetMaximumRetryCount())
            {
                context.Writer.WritePropertyName("MaximumRetryCount");
                context.Writer.Write(requestObject.MaximumRetryCount);
            }

            if(requestObject.IsSetStages())
            {
                context.Writer.WritePropertyName("Stages");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStagesListValue in requestObject.Stages)
                {
                        context.Writer.Write(requestObjectStagesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScriptMarshaller Instance = new ScriptMarshaller();

    }
}