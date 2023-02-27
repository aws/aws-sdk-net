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
    /// Response Unmarshaller for MixedMeasureMapping Object
    /// </summary>  
    public class MixedMeasureMappingUnmarshaller : IUnmarshaller<MixedMeasureMapping, XmlUnmarshallerContext>, IUnmarshaller<MixedMeasureMapping, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MixedMeasureMapping IUnmarshaller<MixedMeasureMapping, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MixedMeasureMapping Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MixedMeasureMapping unmarshalledObject = new MixedMeasureMapping();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("MeasureName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MeasureName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MeasureValueType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MeasureValueType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultiMeasureAttributeMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MultiMeasureAttributeMapping, MultiMeasureAttributeMappingUnmarshaller>(MultiMeasureAttributeMappingUnmarshaller.Instance);
                    unmarshalledObject.MultiMeasureAttributeMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceColumn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceColumn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetMeasureName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetMeasureName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MixedMeasureMappingUnmarshaller _instance = new MixedMeasureMappingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MixedMeasureMappingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}