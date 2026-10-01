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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Pipes.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchContainerOverrides Marshaller
    /// </summary>
    public partial class BatchContainerOverridesMarshaller : IRequestMarshaller<BatchContainerOverrides, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(BatchContainerOverrides requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("Command");
                context.Writer.WriteStartArray();
                foreach (var requestObjectCommandListValue in requestObject.Command)
                {
                    context.Writer.WriteStringValue(requestObjectCommandListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartArray();
                foreach (var requestObjectEnvironmentListValue in requestObject.Environment)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BatchEnvironmentVariableMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(requestObject.InstanceType);
            }

            if (requestObject.IsSetResourceRequirements())
            {
                context.Writer.WritePropertyName("ResourceRequirements");
                context.Writer.WriteStartArray();
                foreach (var requestObjectResourceRequirementsListValue in requestObject.ResourceRequirements)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BatchResourceRequirementMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceRequirementsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static BatchContainerOverridesMarshaller Instance = new BatchContainerOverridesMarshaller();
    }
}
