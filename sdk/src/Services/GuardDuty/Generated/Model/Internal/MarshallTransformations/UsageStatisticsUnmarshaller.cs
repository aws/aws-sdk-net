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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UsageStatistics Object
    /// </summary>  
    public class UsageStatisticsUnmarshaller : IJsonUnmarshaller<UsageStatistics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public UsageStatistics Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            UsageStatistics unmarshalledObject = new UsageStatistics();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("sumByAccount", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<UsageAccountResult, UsageAccountResultUnmarshaller>(UsageAccountResultUnmarshaller.Instance);
                    unmarshalledObject.SumByAccount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sumByDataSource", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<UsageDataSourceResult, UsageDataSourceResultUnmarshaller>(UsageDataSourceResultUnmarshaller.Instance);
                    unmarshalledObject.SumByDataSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sumByFeature", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<UsageFeatureResult, UsageFeatureResultUnmarshaller>(UsageFeatureResultUnmarshaller.Instance);
                    unmarshalledObject.SumByFeature = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sumByResource", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<UsageResourceResult, UsageResourceResultUnmarshaller>(UsageResourceResultUnmarshaller.Instance);
                    unmarshalledObject.SumByResource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("topAccountsByFeature", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<UsageTopAccountsResult, UsageTopAccountsResultUnmarshaller>(UsageTopAccountsResultUnmarshaller.Instance);
                    unmarshalledObject.TopAccountsByFeature = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("topResources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<UsageResourceResult, UsageResourceResultUnmarshaller>(UsageResourceResultUnmarshaller.Instance);
                    unmarshalledObject.TopResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static UsageStatisticsUnmarshaller _instance = new UsageStatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UsageStatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}