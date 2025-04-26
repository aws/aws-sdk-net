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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobStepRestartMarker Marshaller
    /// </summary>
    public class JobStepRestartMarkerMarshaller : IRequestMarshaller<JobStepRestartMarker, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobStepRestartMarker requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFromProcStep())
            {
                context.Writer.WritePropertyName("fromProcStep");
                context.Writer.WriteStringValue(requestObject.FromProcStep);
            }

            if(requestObject.IsSetFromStep())
            {
                context.Writer.WritePropertyName("fromStep");
                context.Writer.WriteStringValue(requestObject.FromStep);
            }

            if(requestObject.IsSetSkip())
            {
                context.Writer.WritePropertyName("skip");
                context.Writer.WriteBooleanValue(requestObject.Skip.Value);
            }

            if(requestObject.IsSetStepCheckpoint())
            {
                context.Writer.WritePropertyName("stepCheckpoint");
                context.Writer.WriteNumberValue(requestObject.StepCheckpoint.Value);
            }

            if(requestObject.IsSetToProcStep())
            {
                context.Writer.WritePropertyName("toProcStep");
                context.Writer.WriteStringValue(requestObject.ToProcStep);
            }

            if(requestObject.IsSetToStep())
            {
                context.Writer.WritePropertyName("toStep");
                context.Writer.WriteStringValue(requestObject.ToStep);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobStepRestartMarkerMarshaller Instance = new JobStepRestartMarkerMarshaller();

    }
}