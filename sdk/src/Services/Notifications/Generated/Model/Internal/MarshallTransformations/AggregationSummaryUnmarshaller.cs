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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Notifications.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Notifications.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AggregationSummary Object
    /// </summary>  
    public class AggregationSummaryUnmarshaller : IUnmarshaller<AggregationSummary, XmlUnmarshallerContext>, IUnmarshaller<AggregationSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AggregationSummary IUnmarshaller<AggregationSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AggregationSummary Unmarshall(JsonUnmarshallerContext context)
        {
            AggregationSummary unmarshalledObject = new AggregationSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("additionalSummarizationDimensions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SummarizationDimensionOverview, SummarizationDimensionOverviewUnmarshaller>(SummarizationDimensionOverviewUnmarshaller.Instance);
                    unmarshalledObject.AdditionalSummarizationDimensions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aggregatedAccounts", targetDepth))
                {
                    var unmarshaller = SummarizationDimensionOverviewUnmarshaller.Instance;
                    unmarshalledObject.AggregatedAccounts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aggregatedBy", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AggregationKey, AggregationKeyUnmarshaller>(AggregationKeyUnmarshaller.Instance);
                    unmarshalledObject.AggregatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aggregatedOrganizationalUnits", targetDepth))
                {
                    var unmarshaller = SummarizationDimensionOverviewUnmarshaller.Instance;
                    unmarshalledObject.AggregatedOrganizationalUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aggregatedRegions", targetDepth))
                {
                    var unmarshaller = SummarizationDimensionOverviewUnmarshaller.Instance;
                    unmarshalledObject.AggregatedRegions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EventCount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AggregationSummaryUnmarshaller _instance = new AggregationSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AggregationSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}