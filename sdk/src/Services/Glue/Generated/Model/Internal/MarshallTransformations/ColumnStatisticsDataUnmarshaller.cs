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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ColumnStatisticsData Object
    /// </summary>  
    public class ColumnStatisticsDataUnmarshaller : IUnmarshaller<ColumnStatisticsData, XmlUnmarshallerContext>, IUnmarshaller<ColumnStatisticsData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ColumnStatisticsData IUnmarshaller<ColumnStatisticsData, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ColumnStatisticsData Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ColumnStatisticsData unmarshalledObject = new ColumnStatisticsData();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BinaryColumnStatisticsData", targetDepth))
                {
                    var unmarshaller = BinaryColumnStatisticsDataUnmarshaller.Instance;
                    unmarshalledObject.BinaryColumnStatisticsData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BooleanColumnStatisticsData", targetDepth))
                {
                    var unmarshaller = BooleanColumnStatisticsDataUnmarshaller.Instance;
                    unmarshalledObject.BooleanColumnStatisticsData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DateColumnStatisticsData", targetDepth))
                {
                    var unmarshaller = DateColumnStatisticsDataUnmarshaller.Instance;
                    unmarshalledObject.DateColumnStatisticsData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DecimalColumnStatisticsData", targetDepth))
                {
                    var unmarshaller = DecimalColumnStatisticsDataUnmarshaller.Instance;
                    unmarshalledObject.DecimalColumnStatisticsData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DoubleColumnStatisticsData", targetDepth))
                {
                    var unmarshaller = DoubleColumnStatisticsDataUnmarshaller.Instance;
                    unmarshalledObject.DoubleColumnStatisticsData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LongColumnStatisticsData", targetDepth))
                {
                    var unmarshaller = LongColumnStatisticsDataUnmarshaller.Instance;
                    unmarshalledObject.LongColumnStatisticsData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StringColumnStatisticsData", targetDepth))
                {
                    var unmarshaller = StringColumnStatisticsDataUnmarshaller.Instance;
                    unmarshalledObject.StringColumnStatisticsData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ColumnStatisticsDataUnmarshaller _instance = new ColumnStatisticsDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ColumnStatisticsDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}