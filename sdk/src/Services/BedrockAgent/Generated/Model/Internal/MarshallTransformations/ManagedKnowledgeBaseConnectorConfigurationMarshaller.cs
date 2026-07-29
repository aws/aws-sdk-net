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
    /// ManagedKnowledgeBaseConnectorConfiguration Marshaller
    /// </summary>
    public class ManagedKnowledgeBaseConnectorConfigurationMarshaller : IRequestMarshaller<ManagedKnowledgeBaseConnectorConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ManagedKnowledgeBaseConnectorConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectorParameters())
            {
                context.Writer.WritePropertyName("connectorParameters");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.ConnectorParameters);
            }

            if(requestObject.IsSetDeletionProtectionConfiguration())
            {
                context.Writer.WritePropertyName("deletionProtectionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DeletionProtectionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DeletionProtectionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMediaExtractionConfiguration())
            {
                context.Writer.WritePropertyName("mediaExtractionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MediaExtractionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MediaExtractionConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ManagedKnowledgeBaseConnectorConfigurationMarshaller Instance = new ManagedKnowledgeBaseConnectorConfigurationMarshaller();

    }
}