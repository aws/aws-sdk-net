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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UnusedAccessFindingsStatistics Object
    /// </summary>  
    public class UnusedAccessFindingsStatisticsUnmarshaller : IUnmarshaller<UnusedAccessFindingsStatistics, XmlUnmarshallerContext>, IUnmarshaller<UnusedAccessFindingsStatistics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UnusedAccessFindingsStatistics IUnmarshaller<UnusedAccessFindingsStatistics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public UnusedAccessFindingsStatistics Unmarshall(JsonUnmarshallerContext context)
        {
            UnusedAccessFindingsStatistics unmarshalledObject = new UnusedAccessFindingsStatistics();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("topAccounts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FindingAggregationAccountDetails, FindingAggregationAccountDetailsUnmarshaller>(FindingAggregationAccountDetailsUnmarshaller.Instance);
                    unmarshalledObject.TopAccounts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalActiveFindings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalActiveFindings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalArchivedFindings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalArchivedFindings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalResolvedFindings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalResolvedFindings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unusedAccessTypeStatistics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<UnusedAccessTypeStatistics, UnusedAccessTypeStatisticsUnmarshaller>(UnusedAccessTypeStatisticsUnmarshaller.Instance);
                    unmarshalledObject.UnusedAccessTypeStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static UnusedAccessFindingsStatisticsUnmarshaller _instance = new UnusedAccessFindingsStatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UnusedAccessFindingsStatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}