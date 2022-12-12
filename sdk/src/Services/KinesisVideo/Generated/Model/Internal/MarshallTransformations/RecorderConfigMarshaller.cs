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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisVideo.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisVideo.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RecorderConfig Marshaller
    /// </summary>
    public class RecorderConfigMarshaller : IRequestMarshaller<RecorderConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RecorderConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMediaSourceConfig())
            {
                context.Writer.WritePropertyName("MediaSourceConfig");
                context.Writer.WriteObjectStart();

                var marshaller = MediaSourceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.MediaSourceConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScheduleConfig())
            {
                context.Writer.WritePropertyName("ScheduleConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ScheduleConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ScheduleConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecorderConfigMarshaller Instance = new RecorderConfigMarshaller();

    }
}