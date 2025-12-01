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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OrchestrationAIAgentConfiguration Marshaller
    /// </summary>
    public class OrchestrationAIAgentConfigurationMarshaller : IRequestMarshaller<OrchestrationAIAgentConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OrchestrationAIAgentConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectInstanceArn())
            {
                context.Writer.WritePropertyName("connectInstanceArn");
                context.Writer.Write(requestObject.ConnectInstanceArn);
            }

            if(requestObject.IsSetLocale())
            {
                context.Writer.WritePropertyName("locale");
                context.Writer.Write(requestObject.Locale);
            }

            if(requestObject.IsSetOrchestrationAIGuardrailId())
            {
                context.Writer.WritePropertyName("orchestrationAIGuardrailId");
                context.Writer.Write(requestObject.OrchestrationAIGuardrailId);
            }

            if(requestObject.IsSetOrchestrationAIPromptId())
            {
                context.Writer.WritePropertyName("orchestrationAIPromptId");
                context.Writer.Write(requestObject.OrchestrationAIPromptId);
            }

            if(requestObject.IsSetToolConfigurations())
            {
                context.Writer.WritePropertyName("toolConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectToolConfigurationsListValue in requestObject.ToolConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ToolConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectToolConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OrchestrationAIAgentConfigurationMarshaller Instance = new OrchestrationAIAgentConfigurationMarshaller();

    }
}