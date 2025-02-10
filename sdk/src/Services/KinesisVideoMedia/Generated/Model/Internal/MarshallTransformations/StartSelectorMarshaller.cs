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
 * Do not modify this file. This file is generated from the kinesis-video-media-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisVideoMedia.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisVideoMedia.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartSelector Marshaller
    /// </summary>
    public class StartSelectorMarshaller : IRequestMarshaller<StartSelector, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StartSelector requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAfterFragmentNumber())
            {
                context.Writer.WritePropertyName("AfterFragmentNumber");
                context.Writer.WriteStringValue(requestObject.AfterFragmentNumber);
            }

            if(requestObject.IsSetContinuationToken())
            {
                context.Writer.WritePropertyName("ContinuationToken");
                context.Writer.WriteStringValue(requestObject.ContinuationToken);
            }

            if(requestObject.IsSetStartSelectorType())
            {
                context.Writer.WritePropertyName("StartSelectorType");
                context.Writer.WriteStringValue(requestObject.StartSelectorType);
            }

            if(requestObject.IsSetStartTimestamp())
            {
                context.Writer.WritePropertyName("StartTimestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.StartTimestamp.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StartSelectorMarshaller Instance = new StartSelectorMarshaller();

    }
}