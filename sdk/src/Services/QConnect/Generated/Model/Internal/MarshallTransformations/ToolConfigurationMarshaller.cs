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
    /// ToolConfiguration Marshaller
    /// </summary>
    public class ToolConfigurationMarshaller : IRequestMarshaller<ToolConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ToolConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnnotations())
            {
                context.Writer.WritePropertyName("annotations");
                context.Writer.WriteObjectStart();

                var marshaller = AnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.Annotations, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetInputSchema())
            {
                context.Writer.WritePropertyName("inputSchema");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.InputSchema);
            }

            if(requestObject.IsSetInstruction())
            {
                context.Writer.WritePropertyName("instruction");
                context.Writer.WriteObjectStart();

                var marshaller = ToolInstructionMarshaller.Instance;
                marshaller.Marshall(requestObject.Instruction, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOutputFilters())
            {
                context.Writer.WritePropertyName("outputFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOutputFiltersListValue in requestObject.OutputFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ToolOutputFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOutputSchema())
            {
                context.Writer.WritePropertyName("outputSchema");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.OutputSchema);
            }

            if(requestObject.IsSetOverrideInputValues())
            {
                context.Writer.WritePropertyName("overrideInputValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOverrideInputValuesListValue in requestObject.OverrideInputValues)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ToolOverrideInputValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectOverrideInputValuesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.Write(requestObject.Title);
            }

            if(requestObject.IsSetToolId())
            {
                context.Writer.WritePropertyName("toolId");
                context.Writer.Write(requestObject.ToolId);
            }

            if(requestObject.IsSetToolName())
            {
                context.Writer.WritePropertyName("toolName");
                context.Writer.Write(requestObject.ToolName);
            }

            if(requestObject.IsSetToolType())
            {
                context.Writer.WritePropertyName("toolType");
                context.Writer.Write(requestObject.ToolType);
            }

            if(requestObject.IsSetUserInteractionConfiguration())
            {
                context.Writer.WritePropertyName("userInteractionConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = UserInteractionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.UserInteractionConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ToolConfigurationMarshaller Instance = new ToolConfigurationMarshaller();

    }
}