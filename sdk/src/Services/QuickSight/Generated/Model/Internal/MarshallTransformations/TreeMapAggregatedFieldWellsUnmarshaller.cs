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
    /// Response Unmarshaller for TreeMapAggregatedFieldWells Object
    /// </summary>  
    public class TreeMapAggregatedFieldWellsUnmarshaller : IUnmarshaller<TreeMapAggregatedFieldWells, XmlUnmarshallerContext>, IUnmarshaller<TreeMapAggregatedFieldWells, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TreeMapAggregatedFieldWells IUnmarshaller<TreeMapAggregatedFieldWells, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TreeMapAggregatedFieldWells Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TreeMapAggregatedFieldWells unmarshalledObject = new TreeMapAggregatedFieldWells();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Colors", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MeasureField, MeasureFieldUnmarshaller>(MeasureFieldUnmarshaller.Instance);
                    unmarshalledObject.Colors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Groups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DimensionField, DimensionFieldUnmarshaller>(DimensionFieldUnmarshaller.Instance);
                    unmarshalledObject.Groups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Sizes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MeasureField, MeasureFieldUnmarshaller>(MeasureFieldUnmarshaller.Instance);
                    unmarshalledObject.Sizes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TreeMapAggregatedFieldWellsUnmarshaller _instance = new TreeMapAggregatedFieldWellsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TreeMapAggregatedFieldWellsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}