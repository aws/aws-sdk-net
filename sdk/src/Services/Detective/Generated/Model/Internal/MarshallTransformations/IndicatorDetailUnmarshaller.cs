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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Detective.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Detective.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IndicatorDetail Object
    /// </summary>  
    public class IndicatorDetailUnmarshaller : IJsonUnmarshaller<IndicatorDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public IndicatorDetail Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            IndicatorDetail unmarshalledObject = new IndicatorDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("FlaggedIpAddressDetail", targetDepth))
                {
                    var unmarshaller = FlaggedIpAddressDetailUnmarshaller.Instance;
                    unmarshalledObject.FlaggedIpAddressDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImpossibleTravelDetail", targetDepth))
                {
                    var unmarshaller = ImpossibleTravelDetailUnmarshaller.Instance;
                    unmarshalledObject.ImpossibleTravelDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NewAsoDetail", targetDepth))
                {
                    var unmarshaller = NewAsoDetailUnmarshaller.Instance;
                    unmarshalledObject.NewAsoDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NewGeolocationDetail", targetDepth))
                {
                    var unmarshaller = NewGeolocationDetailUnmarshaller.Instance;
                    unmarshalledObject.NewGeolocationDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NewUserAgentDetail", targetDepth))
                {
                    var unmarshaller = NewUserAgentDetailUnmarshaller.Instance;
                    unmarshalledObject.NewUserAgentDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RelatedFindingDetail", targetDepth))
                {
                    var unmarshaller = RelatedFindingDetailUnmarshaller.Instance;
                    unmarshalledObject.RelatedFindingDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RelatedFindingGroupDetail", targetDepth))
                {
                    var unmarshaller = RelatedFindingGroupDetailUnmarshaller.Instance;
                    unmarshalledObject.RelatedFindingGroupDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TTPsObservedDetail", targetDepth))
                {
                    var unmarshaller = TTPsObservedDetailUnmarshaller.Instance;
                    unmarshalledObject.TTPsObservedDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static IndicatorDetailUnmarshaller _instance = new IndicatorDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IndicatorDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}