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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamWrite.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TimestreamWrite.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataModel Object
    /// </summary>  
    public class DataModelUnmarshaller : IUnmarshaller<DataModel, XmlUnmarshallerContext>, IUnmarshaller<DataModel, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataModel IUnmarshaller<DataModel, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataModel Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataModel unmarshalledObject = new DataModel();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DimensionMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DimensionMapping, DimensionMappingUnmarshaller>(DimensionMappingUnmarshaller.Instance);
                    unmarshalledObject.DimensionMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MeasureNameColumn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MeasureNameColumn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MixedMeasureMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MixedMeasureMapping, MixedMeasureMappingUnmarshaller>(MixedMeasureMappingUnmarshaller.Instance);
                    unmarshalledObject.MixedMeasureMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultiMeasureMappings", targetDepth))
                {
                    var unmarshaller = MultiMeasureMappingsUnmarshaller.Instance;
                    unmarshalledObject.MultiMeasureMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeColumn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeColumn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeUnit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeUnit = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DataModelUnmarshaller _instance = new DataModelUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataModelUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}