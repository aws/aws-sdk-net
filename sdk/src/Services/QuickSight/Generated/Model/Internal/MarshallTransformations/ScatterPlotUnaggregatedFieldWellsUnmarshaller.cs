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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScatterPlotUnaggregatedFieldWells Object
    /// </summary>  
    public class ScatterPlotUnaggregatedFieldWellsUnmarshaller : IUnmarshaller<ScatterPlotUnaggregatedFieldWells, XmlUnmarshallerContext>, IUnmarshaller<ScatterPlotUnaggregatedFieldWells, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ScatterPlotUnaggregatedFieldWells IUnmarshaller<ScatterPlotUnaggregatedFieldWells, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ScatterPlotUnaggregatedFieldWells Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ScatterPlotUnaggregatedFieldWells unmarshalledObject = new ScatterPlotUnaggregatedFieldWells();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Size", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MeasureField, MeasureFieldUnmarshaller>(MeasureFieldUnmarshaller.Instance);
                    unmarshalledObject.Size = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XAxis", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DimensionField, DimensionFieldUnmarshaller>(DimensionFieldUnmarshaller.Instance);
                    unmarshalledObject.XAxis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("YAxis", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DimensionField, DimensionFieldUnmarshaller>(DimensionFieldUnmarshaller.Instance);
                    unmarshalledObject.YAxis = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ScatterPlotUnaggregatedFieldWellsUnmarshaller _instance = new ScatterPlotUnaggregatedFieldWellsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScatterPlotUnaggregatedFieldWellsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}