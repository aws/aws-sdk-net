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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InputAttachment Marshaller
    /// </summary>
    public class InputAttachmentMarshaller : IRequestMarshaller<InputAttachment, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InputAttachment requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutomaticInputFailoverSettings())
            {
                context.Writer.WritePropertyName("automaticInputFailoverSettings");
                context.Writer.WriteStartObject();

                var marshaller = AutomaticInputFailoverSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AutomaticInputFailoverSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputAttachmentName())
            {
                context.Writer.WritePropertyName("inputAttachmentName");
                context.Writer.WriteStringValue(requestObject.InputAttachmentName);
            }

            if(requestObject.IsSetInputId())
            {
                context.Writer.WritePropertyName("inputId");
                context.Writer.WriteStringValue(requestObject.InputId);
            }

            if(requestObject.IsSetInputSettings())
            {
                context.Writer.WritePropertyName("inputSettings");
                context.Writer.WriteStartObject();

                var marshaller = InputSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.InputSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogicalInterfaceNames())
            {
                context.Writer.WritePropertyName("logicalInterfaceNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLogicalInterfaceNamesListValue in requestObject.LogicalInterfaceNames)
                {
                        context.Writer.WriteStringValue(requestObjectLogicalInterfaceNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InputAttachmentMarshaller Instance = new InputAttachmentMarshaller();

    }
}