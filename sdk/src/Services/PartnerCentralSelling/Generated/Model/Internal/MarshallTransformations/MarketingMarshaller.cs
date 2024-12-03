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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Marketing Marshaller
    /// </summary>
    public class MarketingMarshaller : IRequestMarshaller<Marketing, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Marketing requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAwsFundingUsed())
            {
                context.Writer.WritePropertyName("AwsFundingUsed");
                context.Writer.Write(requestObject.AwsFundingUsed);
            }

            if(requestObject.IsSetCampaignName())
            {
                context.Writer.WritePropertyName("CampaignName");
                context.Writer.Write(requestObject.CampaignName);
            }

            if(requestObject.IsSetChannels())
            {
                context.Writer.WritePropertyName("Channels");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectChannelsListValue in requestObject.Channels)
                {
                        context.Writer.Write(requestObjectChannelsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.Write(requestObject.Source);
            }

            if(requestObject.IsSetUseCases())
            {
                context.Writer.WritePropertyName("UseCases");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUseCasesListValue in requestObject.UseCases)
                {
                        context.Writer.Write(requestObjectUseCasesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MarketingMarshaller Instance = new MarketingMarshaller();

    }
}