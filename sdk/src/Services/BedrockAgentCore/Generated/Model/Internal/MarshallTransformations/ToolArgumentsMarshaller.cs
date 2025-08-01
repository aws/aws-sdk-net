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
    /// ToolArguments Marshaller
    /// </summary>
    public class ToolArgumentsMarshaller : IRequestMarshaller<ToolArguments, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ToolArguments requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClearContext())
            {
                context.Writer.WritePropertyName("clearContext");
                context.Writer.WriteBooleanValue(requestObject.ClearContext.Value);
            }

            if(requestObject.IsSetCode())
            {
                context.Writer.WritePropertyName("code");
                context.Writer.WriteStringValue(requestObject.Code);
            }

            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteStringValue(requestObject.Command);
            }

            if(requestObject.IsSetContent())
            {
                context.Writer.WritePropertyName("content");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContentListValue in requestObject.Content)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputContentBlockMarshaller.Instance;
                    marshaller.Marshall(requestObjectContentListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDirectoryPath())
            {
                context.Writer.WritePropertyName("directoryPath");
                context.Writer.WriteStringValue(requestObject.DirectoryPath);
            }

            if(requestObject.IsSetLanguage())
            {
                context.Writer.WritePropertyName("language");
                context.Writer.WriteStringValue(requestObject.Language);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("path");
                context.Writer.WriteStringValue(requestObject.Path);
            }

            if(requestObject.IsSetPaths())
            {
                context.Writer.WritePropertyName("paths");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPathsListValue in requestObject.Paths)
                {
                        context.Writer.WriteStringValue(requestObjectPathsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTaskId())
            {
                context.Writer.WritePropertyName("taskId");
                context.Writer.WriteStringValue(requestObject.TaskId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ToolArgumentsMarshaller Instance = new ToolArgumentsMarshaller();

    }
}