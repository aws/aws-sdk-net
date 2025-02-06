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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Transition Marshaller
    /// </summary>
    public class TransitionMarshaller : IRequestMarshaller<Transition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Transition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDurationMillis())
            {
                context.Writer.WritePropertyName("DurationMillis");
                context.Writer.WriteNumberValue(requestObject.DurationMillis.Value);
            }

            if(requestObject.IsSetRelativePosition())
            {
                context.Writer.WritePropertyName("RelativePosition");
                context.Writer.WriteStringValue(requestObject.RelativePosition);
            }

            if(requestObject.IsSetRelativeProgram())
            {
                context.Writer.WritePropertyName("RelativeProgram");
                context.Writer.WriteStringValue(requestObject.RelativeProgram);
            }

            if(requestObject.IsSetScheduledStartTimeMillis())
            {
                context.Writer.WritePropertyName("ScheduledStartTimeMillis");
                context.Writer.WriteNumberValue(requestObject.ScheduledStartTimeMillis.Value);
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
        public readonly static TransitionMarshaller Instance = new TransitionMarshaller();

    }
}