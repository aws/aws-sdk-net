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
    /// UpdatedSessionActionInfo Marshaller
    /// </summary>
    public class UpdatedSessionActionInfoMarshaller : IRequestMarshaller<UpdatedSessionActionInfo, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdatedSessionActionInfo requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCompletedStatus())
            {
                context.Writer.WritePropertyName("completedStatus");
                context.Writer.WriteStringValue(requestObject.CompletedStatus);
            }

            if(requestObject.IsSetEndedAt())
            {
                context.Writer.WritePropertyName("endedAt");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.EndedAt));
            }

            if(requestObject.IsSetManifests())
            {
                context.Writer.WritePropertyName("manifests");
                context.Writer.WriteStartArray();
                foreach(var requestObjectManifestsListValue in requestObject.Manifests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TaskRunManifestPropertiesRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProcessExitCode())
            {
                context.Writer.WritePropertyName("processExitCode");
                context.Writer.WriteNumberValue(requestObject.ProcessExitCode.Value);
            }

            if(requestObject.IsSetProgressMessage())
            {
                context.Writer.WritePropertyName("progressMessage");
                context.Writer.WriteStringValue(requestObject.ProgressMessage);
            }

            if(requestObject.IsSetProgressPercent())
            {
                context.Writer.WritePropertyName("progressPercent");
                if(StringUtils.IsSpecialFloatValue(requestObject.ProgressPercent.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.ProgressPercent.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ProgressPercent.Value);
                }
            }

            if(requestObject.IsSetStartedAt())
            {
                context.Writer.WritePropertyName("startedAt");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.StartedAt));
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("updatedAt");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.UpdatedAt));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdatedSessionActionInfoMarshaller Instance = new UpdatedSessionActionInfoMarshaller();

    }
}