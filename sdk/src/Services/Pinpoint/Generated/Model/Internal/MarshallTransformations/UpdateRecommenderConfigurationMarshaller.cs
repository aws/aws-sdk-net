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
    /// UpdateRecommenderConfiguration Marshaller
    /// </summary>       
    public class UpdateRecommenderConfigurationMarshaller : IRequestMarshaller<UpdateRecommenderConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateRecommenderConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                        context.Writer.Write(requestObjectAttributesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetRecommendationProviderIdType())
            {
                context.Writer.WritePropertyName("RecommendationProviderIdType");
                context.Writer.Write(requestObject.RecommendationProviderIdType);
            }

            if(requestObject.IsSetRecommendationProviderRoleArn())
            {
                context.Writer.WritePropertyName("RecommendationProviderRoleArn");
                context.Writer.Write(requestObject.RecommendationProviderRoleArn);
            }

            if(requestObject.IsSetRecommendationProviderUri())
            {
                context.Writer.WritePropertyName("RecommendationProviderUri");
                context.Writer.Write(requestObject.RecommendationProviderUri);
            }

            if(requestObject.IsSetRecommendationsDisplayName())
            {
                context.Writer.WritePropertyName("RecommendationsDisplayName");
                context.Writer.Write(requestObject.RecommendationsDisplayName);
            }

            if(requestObject.IsSetRecommendationsPerMessage())
            {
                context.Writer.WritePropertyName("RecommendationsPerMessage");
                context.Writer.Write(requestObject.RecommendationsPerMessage);
            }

            if(requestObject.IsSetRecommendationTransformerUri())
            {
                context.Writer.WritePropertyName("RecommendationTransformerUri");
                context.Writer.Write(requestObject.RecommendationTransformerUri);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static UpdateRecommenderConfigurationMarshaller Instance = new UpdateRecommenderConfigurationMarshaller();

    }
}