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
    /// Response Unmarshaller for FindingStatistics Object
    /// </summary>  
    public class FindingStatisticsUnmarshaller : IJsonUnmarshaller<FindingStatistics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FindingStatistics Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FindingStatistics unmarshalledObject = new FindingStatistics();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("countBySeverity", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, int, StringUnmarshaller, IntUnmarshaller>(StringUnmarshaller.Instance, IntUnmarshaller.Instance);
                    unmarshalledObject.CountBySeverity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("groupedByAccount", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AccountStatistics, AccountStatisticsUnmarshaller>(AccountStatisticsUnmarshaller.Instance);
                    unmarshalledObject.GroupedByAccount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("groupedByDate", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateStatistics, DateStatisticsUnmarshaller>(DateStatisticsUnmarshaller.Instance);
                    unmarshalledObject.GroupedByDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("groupedByFindingType", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<FindingTypeStatistics, FindingTypeStatisticsUnmarshaller>(FindingTypeStatisticsUnmarshaller.Instance);
                    unmarshalledObject.GroupedByFindingType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("groupedByResource", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceStatistics, ResourceStatisticsUnmarshaller>(ResourceStatisticsUnmarshaller.Instance);
                    unmarshalledObject.GroupedByResource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("groupedBySeverity", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SeverityStatistics, SeverityStatisticsUnmarshaller>(SeverityStatisticsUnmarshaller.Instance);
                    unmarshalledObject.GroupedBySeverity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FindingStatisticsUnmarshaller _instance = new FindingStatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FindingStatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}