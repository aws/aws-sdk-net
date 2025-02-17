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

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PluginVisualFieldWell Object
    /// </summary>  
    public class PluginVisualFieldWellUnmarshaller : IUnmarshaller<PluginVisualFieldWell, XmlUnmarshallerContext>, IUnmarshaller<PluginVisualFieldWell, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PluginVisualFieldWell IUnmarshaller<PluginVisualFieldWell, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PluginVisualFieldWell Unmarshall(JsonUnmarshallerContext context)
        {
            PluginVisualFieldWell unmarshalledObject = new PluginVisualFieldWell();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AxisName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AxisName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dimensions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DimensionField, DimensionFieldUnmarshaller>(DimensionFieldUnmarshaller.Instance);
                    unmarshalledObject.Dimensions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Measures", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MeasureField, MeasureFieldUnmarshaller>(MeasureFieldUnmarshaller.Instance);
                    unmarshalledObject.Measures = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Unaggregated", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<UnaggregatedField, UnaggregatedFieldUnmarshaller>(UnaggregatedFieldUnmarshaller.Instance);
                    unmarshalledObject.Unaggregated = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PluginVisualFieldWellUnmarshaller _instance = new PluginVisualFieldWellUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PluginVisualFieldWellUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}