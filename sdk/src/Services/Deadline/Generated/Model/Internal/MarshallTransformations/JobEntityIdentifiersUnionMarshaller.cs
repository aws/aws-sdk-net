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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobEntityIdentifiersUnion Marshaller
    /// </summary>
    public class JobEntityIdentifiersUnionMarshaller : IRequestMarshaller<JobEntityIdentifiersUnion, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobEntityIdentifiersUnion requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnvironmentDetails())
            {
                context.Writer.WritePropertyName("environmentDetails");
                context.Writer.WriteStartObject();

                var marshaller = EnvironmentDetailsIdentifiersMarshaller.Instance;
                marshaller.Marshall(requestObject.EnvironmentDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJobAttachmentDetails())
            {
                context.Writer.WritePropertyName("jobAttachmentDetails");
                context.Writer.WriteStartObject();

                var marshaller = JobAttachmentDetailsIdentifiersMarshaller.Instance;
                marshaller.Marshall(requestObject.JobAttachmentDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJobDetails())
            {
                context.Writer.WritePropertyName("jobDetails");
                context.Writer.WriteStartObject();

                var marshaller = JobDetailsIdentifiersMarshaller.Instance;
                marshaller.Marshall(requestObject.JobDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStepDetails())
            {
                context.Writer.WritePropertyName("stepDetails");
                context.Writer.WriteStartObject();

                var marshaller = StepDetailsIdentifiersMarshaller.Instance;
                marshaller.Marshall(requestObject.StepDetails, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobEntityIdentifiersUnionMarshaller Instance = new JobEntityIdentifiersUnionMarshaller();

    }
}