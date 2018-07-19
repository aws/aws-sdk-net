/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Comprehend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KeyPhrasesDetectionJobFilter Marshaller
    /// </summary>       
    public class KeyPhrasesDetectionJobFilterMarshaller : IRequestMarshaller<KeyPhrasesDetectionJobFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KeyPhrasesDetectionJobFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetJobName())
            {
                context.Writer.WritePropertyName("JobName");
                context.Writer.Write(requestObject.JobName);
            }

            if(requestObject.IsSetJobStatus())
            {
                context.Writer.WritePropertyName("JobStatus");
                context.Writer.Write(requestObject.JobStatus);
            }

            if(requestObject.IsSetSubmitTimeAfter())
            {
                context.Writer.WritePropertyName("SubmitTimeAfter");
                context.Writer.Write(requestObject.SubmitTimeAfter);
            }

            if(requestObject.IsSetSubmitTimeBefore())
            {
                context.Writer.WritePropertyName("SubmitTimeBefore");
                context.Writer.Write(requestObject.SubmitTimeBefore);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static KeyPhrasesDetectionJobFilterMarshaller Instance = new KeyPhrasesDetectionJobFilterMarshaller();

    }
}