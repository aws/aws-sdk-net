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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WorkflowStep Marshaller
    /// </summary>
    public class WorkflowStepMarshaller : IRequestMarshaller<WorkflowStep, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WorkflowStep requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCopyStepDetails())
            {
                context.Writer.WritePropertyName("CopyStepDetails");
                context.Writer.WriteStartObject();

                var marshaller = CopyStepDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CopyStepDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomStepDetails())
            {
                context.Writer.WritePropertyName("CustomStepDetails");
                context.Writer.WriteStartObject();

                var marshaller = CustomStepDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomStepDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDecryptStepDetails())
            {
                context.Writer.WritePropertyName("DecryptStepDetails");
                context.Writer.WriteStartObject();

                var marshaller = DecryptStepDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DecryptStepDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeleteStepDetails())
            {
                context.Writer.WritePropertyName("DeleteStepDetails");
                context.Writer.WriteStartObject();

                var marshaller = DeleteStepDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DeleteStepDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTagStepDetails())
            {
                context.Writer.WritePropertyName("TagStepDetails");
                context.Writer.WriteStartObject();

                var marshaller = TagStepDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.TagStepDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WorkflowStepMarshaller Instance = new WorkflowStepMarshaller();

    }
}