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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ToolDescriptionSource Marshaller
    /// </summary>
    public class ToolDescriptionSourceMarshaller : IRequestMarshaller<ToolDescriptionSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ToolDescriptionSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfigurationBundle())
            {
                context.Writer.WritePropertyName("configurationBundle");
                context.Writer.WriteStartObject();

                var marshaller = ToolDescriptionConfigurationBundleMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfigurationBundle, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetToolDescriptionText())
            {
                context.Writer.WritePropertyName("toolDescriptionText");
                context.Writer.WriteStartObject();

                var marshaller = ToolDescriptionTextInputMarshaller.Instance;
                marshaller.Marshall(requestObject.ToolDescriptionText, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ToolDescriptionSourceMarshaller Instance = new ToolDescriptionSourceMarshaller();

    }
}