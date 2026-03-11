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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataPrepConfiguration Object
    /// </summary>  
    public class DataPrepConfigurationUnmarshaller : IJsonUnmarshaller<DataPrepConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DataPrepConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DataPrepConfiguration unmarshalledObject = new DataPrepConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DestinationTableMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, DestinationTable, StringUnmarshaller, DestinationTableUnmarshaller>(StringUnmarshaller.Instance, DestinationTableUnmarshaller.Instance);
                    unmarshalledObject.DestinationTableMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceTableMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, SourceTable, StringUnmarshaller, SourceTableUnmarshaller>(StringUnmarshaller.Instance, SourceTableUnmarshaller.Instance);
                    unmarshalledObject.SourceTableMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TransformStepMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, TransformStep, StringUnmarshaller, TransformStepUnmarshaller>(StringUnmarshaller.Instance, TransformStepUnmarshaller.Instance);
                    unmarshalledObject.TransformStepMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataPrepConfigurationUnmarshaller _instance = new DataPrepConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataPrepConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}