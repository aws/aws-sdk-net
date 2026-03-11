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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OperationUpdate Marshaller
    /// </summary>
    public class OperationUpdateMarshaller : IRequestMarshaller<OperationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OperationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStringValue(requestObject.Action);
            }

            if(requestObject.IsSetCallbackOptions())
            {
                context.Writer.WritePropertyName("CallbackOptions");
                context.Writer.WriteStartObject();

                var marshaller = CallbackOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CallbackOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetChainedInvokeOptions())
            {
                context.Writer.WritePropertyName("ChainedInvokeOptions");
                context.Writer.WriteStartObject();

                var marshaller = ChainedInvokeOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ChainedInvokeOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContextOptions())
            {
                context.Writer.WritePropertyName("ContextOptions");
                context.Writer.WriteStartObject();

                var marshaller = ContextOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ContextOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetError())
            {
                context.Writer.WritePropertyName("Error");
                context.Writer.WriteStartObject();

                var marshaller = ErrorObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.Error, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetParentId())
            {
                context.Writer.WritePropertyName("ParentId");
                context.Writer.WriteStringValue(requestObject.ParentId);
            }

            if(requestObject.IsSetPayload())
            {
                context.Writer.WritePropertyName("Payload");
                context.Writer.WriteStringValue(requestObject.Payload);
            }

            if(requestObject.IsSetStepOptions())
            {
                context.Writer.WritePropertyName("StepOptions");
                context.Writer.WriteStartObject();

                var marshaller = StepOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.StepOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSubType())
            {
                context.Writer.WritePropertyName("SubType");
                context.Writer.WriteStringValue(requestObject.SubType);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetWaitOptions())
            {
                context.Writer.WritePropertyName("WaitOptions");
                context.Writer.WriteStartObject();

                var marshaller = WaitOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.WaitOptions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OperationUpdateMarshaller Instance = new OperationUpdateMarshaller();

    }
}