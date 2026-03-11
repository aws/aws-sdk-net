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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetObjectTypeAttributeStatisticsPercentiles Object
    /// </summary>  
    public class GetObjectTypeAttributeStatisticsPercentilesUnmarshaller : IJsonUnmarshaller<GetObjectTypeAttributeStatisticsPercentiles, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public GetObjectTypeAttributeStatisticsPercentiles Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            GetObjectTypeAttributeStatisticsPercentiles unmarshalledObject = new GetObjectTypeAttributeStatisticsPercentiles();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("P25", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.P25 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("P5", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.P5 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("P50", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.P50 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("P75", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.P75 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("P95", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.P95 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GetObjectTypeAttributeStatisticsPercentilesUnmarshaller _instance = new GetObjectTypeAttributeStatisticsPercentilesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetObjectTypeAttributeStatisticsPercentilesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}