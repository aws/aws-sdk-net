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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Personalize.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CampaignConfig Object
    /// </summary>  
    public class CampaignConfigUnmarshaller : IUnmarshaller<CampaignConfig, XmlUnmarshallerContext>, IUnmarshaller<CampaignConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CampaignConfig IUnmarshaller<CampaignConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CampaignConfig Unmarshall(JsonUnmarshallerContext context)
        {
            CampaignConfig unmarshalledObject = new CampaignConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("enableMetadataWithRecommendations", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableMetadataWithRecommendations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("itemExplorationConfig", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.ItemExplorationConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rankingInfluence", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, double, StringUnmarshaller, DoubleUnmarshaller>(StringUnmarshaller.Instance, DoubleUnmarshaller.Instance);
                    unmarshalledObject.RankingInfluence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("syncWithLatestSolutionVersion", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SyncWithLatestSolutionVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CampaignConfigUnmarshaller _instance = new CampaignConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CampaignConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}