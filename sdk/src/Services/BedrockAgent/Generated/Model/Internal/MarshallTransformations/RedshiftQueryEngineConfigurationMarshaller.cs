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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedshiftQueryEngineConfiguration Marshaller
    /// </summary>
    public class RedshiftQueryEngineConfigurationMarshaller : IRequestMarshaller<RedshiftQueryEngineConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftQueryEngineConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetProvisionedConfiguration())
            {
                context.Writer.WritePropertyName("provisionedConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftProvisionedConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProvisionedConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServerlessConfiguration())
            {
                context.Writer.WritePropertyName("serverlessConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftServerlessConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ServerlessConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RedshiftQueryEngineConfigurationMarshaller Instance = new RedshiftQueryEngineConfigurationMarshaller();

    }
}