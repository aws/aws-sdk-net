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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HumanLoopConfig Marshaller
    /// </summary>       
    public class HumanLoopConfigMarshaller : IRequestMarshaller<HumanLoopConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HumanLoopConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetHumanTaskUiArn())
            {
                context.Writer.WritePropertyName("HumanTaskUiArn");
                context.Writer.Write(requestObject.HumanTaskUiArn);
            }

            if(requestObject.IsSetPublicWorkforceTaskPrice())
            {
                context.Writer.WritePropertyName("PublicWorkforceTaskPrice");
                context.Writer.WriteObjectStart();

                var marshaller = PublicWorkforceTaskPriceMarshaller.Instance;
                marshaller.Marshall(requestObject.PublicWorkforceTaskPrice, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTaskAvailabilityLifetimeInSeconds())
            {
                context.Writer.WritePropertyName("TaskAvailabilityLifetimeInSeconds");
                context.Writer.Write(requestObject.TaskAvailabilityLifetimeInSeconds);
            }

            if(requestObject.IsSetTaskCount())
            {
                context.Writer.WritePropertyName("TaskCount");
                context.Writer.Write(requestObject.TaskCount);
            }

            if(requestObject.IsSetTaskDescription())
            {
                context.Writer.WritePropertyName("TaskDescription");
                context.Writer.Write(requestObject.TaskDescription);
            }

            if(requestObject.IsSetTaskKeywords())
            {
                context.Writer.WritePropertyName("TaskKeywords");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTaskKeywordsListValue in requestObject.TaskKeywords)
                {
                        context.Writer.Write(requestObjectTaskKeywordsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTaskTimeLimitInSeconds())
            {
                context.Writer.WritePropertyName("TaskTimeLimitInSeconds");
                context.Writer.Write(requestObject.TaskTimeLimitInSeconds);
            }

            if(requestObject.IsSetTaskTitle())
            {
                context.Writer.WritePropertyName("TaskTitle");
                context.Writer.Write(requestObject.TaskTitle);
            }

            if(requestObject.IsSetWorkteamArn())
            {
                context.Writer.WritePropertyName("WorkteamArn");
                context.Writer.Write(requestObject.WorkteamArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static HumanLoopConfigMarshaller Instance = new HumanLoopConfigMarshaller();

    }
}