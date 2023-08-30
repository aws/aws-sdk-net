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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptunedata.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Neptunedata.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RDFGraphSummaryValueMap Object
    /// </summary>  
    public class RDFGraphSummaryValueMapUnmarshaller : IUnmarshaller<RDFGraphSummaryValueMap, XmlUnmarshallerContext>, IUnmarshaller<RDFGraphSummaryValueMap, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RDFGraphSummaryValueMap IUnmarshaller<RDFGraphSummaryValueMap, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RDFGraphSummaryValueMap Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RDFGraphSummaryValueMap unmarshalledObject = new RDFGraphSummaryValueMap();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("graphSummary", targetDepth))
                {
                    var unmarshaller = RDFGraphSummaryUnmarshaller.Instance;
                    unmarshalledObject.GraphSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastStatisticsComputationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastStatisticsComputationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("version", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RDFGraphSummaryValueMapUnmarshaller _instance = new RDFGraphSummaryValueMapUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RDFGraphSummaryValueMapUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}