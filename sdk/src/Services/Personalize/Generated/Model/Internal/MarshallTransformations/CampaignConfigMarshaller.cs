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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Personalize.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CampaignConfig Marshaller
    /// </summary>
    public class CampaignConfigMarshaller : IRequestMarshaller<CampaignConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CampaignConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnableMetadataWithRecommendations())
            {
                context.Writer.WritePropertyName("enableMetadataWithRecommendations");
                context.Writer.WriteBooleanValue(requestObject.EnableMetadataWithRecommendations.Value);
            }

            if(requestObject.IsSetItemExplorationConfig())
            {
                context.Writer.WritePropertyName("itemExplorationConfig");
                context.Writer.WriteStartObject();
                foreach (var requestObjectItemExplorationConfigKvp in requestObject.ItemExplorationConfig)
                {
                    context.Writer.WritePropertyName(requestObjectItemExplorationConfigKvp.Key);
                    var requestObjectItemExplorationConfigValue = requestObjectItemExplorationConfigKvp.Value;

                        context.Writer.WriteStringValue(requestObjectItemExplorationConfigValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSyncWithLatestSolutionVersion())
            {
                context.Writer.WritePropertyName("syncWithLatestSolutionVersion");
                context.Writer.WriteBooleanValue(requestObject.SyncWithLatestSolutionVersion.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CampaignConfigMarshaller Instance = new CampaignConfigMarshaller();

    }
}