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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RelativeTimeRange Marshaller
    /// </summary>
    public class RelativeTimeRangeMarshaller : IRequestMarshaller<RelativeTimeRange, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RelativeTimeRange requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEndPercentage())
            {
                context.Writer.WritePropertyName("EndPercentage");
                context.Writer.WriteNumberValue(requestObject.EndPercentage.Value);
            }

            if(requestObject.IsSetFirst())
            {
                context.Writer.WritePropertyName("First");
                context.Writer.WriteNumberValue(requestObject.First.Value);
            }

            if(requestObject.IsSetLast())
            {
                context.Writer.WritePropertyName("Last");
                context.Writer.WriteNumberValue(requestObject.Last.Value);
            }

            if(requestObject.IsSetStartPercentage())
            {
                context.Writer.WritePropertyName("StartPercentage");
                context.Writer.WriteNumberValue(requestObject.StartPercentage.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RelativeTimeRangeMarshaller Instance = new RelativeTimeRangeMarshaller();

    }
}