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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamQuery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TimestreamConfiguration Object
    /// </summary>  
    public class TimestreamConfigurationUnmarshaller : IUnmarshaller<TimestreamConfiguration, XmlUnmarshallerContext>, IUnmarshaller<TimestreamConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TimestreamConfiguration IUnmarshaller<TimestreamConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TimestreamConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            TimestreamConfiguration unmarshalledObject = new TimestreamConfiguration();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DatabaseName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseName = unmarshaller.Unmarshall(context);
                    continue;
                }
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
                if (context.TestExpression("TableName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeColumn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeColumn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TimestreamConfigurationUnmarshaller _instance = new TimestreamConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TimestreamConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}