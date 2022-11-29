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
    /// Response Unmarshaller for DataLabelOptions Object
    /// </summary>  
    public class DataLabelOptionsUnmarshaller : IUnmarshaller<DataLabelOptions, XmlUnmarshallerContext>, IUnmarshaller<DataLabelOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataLabelOptions IUnmarshaller<DataLabelOptions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataLabelOptions Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataLabelOptions unmarshalledObject = new DataLabelOptions();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CategoryLabelVisibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CategoryLabelVisibility = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataLabelTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataLabelType, DataLabelTypeUnmarshaller>(DataLabelTypeUnmarshaller.Instance);
                    unmarshalledObject.DataLabelTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LabelColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelContent", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LabelContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelFontConfiguration", targetDepth))
                {
                    var unmarshaller = FontConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LabelFontConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MeasureLabelVisibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MeasureLabelVisibility = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Overlap", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Overlap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Position", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Position = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Visibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Visibility = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DataLabelOptionsUnmarshaller _instance = new DataLabelOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataLabelOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}