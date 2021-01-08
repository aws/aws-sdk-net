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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CampaignLimits Marshaller
    /// </summary>       
    public class CampaignLimitsMarshaller : IRequestMarshaller<CampaignLimits, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CampaignLimits requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDaily())
            {
                context.Writer.WritePropertyName("Daily");
                context.Writer.Write(requestObject.Daily);
            }

            if(requestObject.IsSetMaximumDuration())
            {
                context.Writer.WritePropertyName("MaximumDuration");
                context.Writer.Write(requestObject.MaximumDuration);
            }

            if(requestObject.IsSetMessagesPerSecond())
            {
                context.Writer.WritePropertyName("MessagesPerSecond");
                context.Writer.Write(requestObject.MessagesPerSecond);
            }

            if(requestObject.IsSetTotal())
            {
                context.Writer.WritePropertyName("Total");
                context.Writer.Write(requestObject.Total);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CampaignLimitsMarshaller Instance = new CampaignLimitsMarshaller();

    }
}