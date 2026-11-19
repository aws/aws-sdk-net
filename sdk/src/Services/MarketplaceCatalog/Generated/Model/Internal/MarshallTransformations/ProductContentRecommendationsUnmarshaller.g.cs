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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.MarketplaceCatalog.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProductContentRecommendations Object
    /// </summary>
    public partial class ProductContentRecommendationsUnmarshaller : IJsonUnmarshaller<ProductContentRecommendations, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ProductContentRecommendations Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new ProductContentRecommendations();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AdditionalResources", targetDepth, ref reader))
                {
                    var unmarshaller = ContentRecommendationUnmarshaller.Instance;
                    unmarshalledObject.AdditionalResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Categories", targetDepth, ref reader))
                {
                    var unmarshaller = ContentRecommendationUnmarshaller.Instance;
                    unmarshalledObject.Categories = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Citations", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RecommendationCitation, RecommendationCitationUnmarshaller>(RecommendationCitationUnmarshaller.Instance);
                    unmarshalledObject.Citations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Highlights", targetDepth, ref reader))
                {
                    var unmarshaller = ContentRecommendationUnmarshaller.Instance;
                    unmarshalledObject.Highlights = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LongDescription", targetDepth, ref reader))
                {
                    var unmarshaller = ContentRecommendationUnmarshaller.Instance;
                    unmarshalledObject.LongDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProductTitle", targetDepth, ref reader))
                {
                    var unmarshaller = ContentRecommendationUnmarshaller.Instance;
                    unmarshalledObject.ProductTitle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SearchKeywords", targetDepth, ref reader))
                {
                    var unmarshaller = ContentRecommendationUnmarshaller.Instance;
                    unmarshalledObject.SearchKeywords = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ShortDescription", targetDepth, ref reader))
                {
                    var unmarshaller = ContentRecommendationUnmarshaller.Instance;
                    unmarshalledObject.ShortDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SupportDescription", targetDepth, ref reader))
                {
                    var unmarshaller = ContentRecommendationUnmarshaller.Instance;
                    unmarshalledObject.SupportDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ProductContentRecommendationsUnmarshaller _instance = new ProductContentRecommendationsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ProductContentRecommendationsUnmarshaller Instance => _instance;
    }
}
