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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MLTransform Object
    /// </summary>  
    public class MLTransformUnmarshaller : IJsonUnmarshaller<MLTransform, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MLTransform Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MLTransform unmarshalledObject = new MLTransform();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CreatedOn", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedOn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EvaluationMetrics", targetDepth))
                {
                    var unmarshaller = EvaluationMetricsUnmarshaller.Instance;
                    unmarshalledObject.EvaluationMetrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GlueVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GlueVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InputRecordTables", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<GlueTable, GlueTableUnmarshaller>(GlueTableUnmarshaller.Instance);
                    unmarshalledObject.InputRecordTables = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LabelCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.LabelCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModifiedOn", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedOn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxCapacity", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.MaxCapacity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxRetries", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MaxRetries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NumberOfWorkers", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfWorkers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = TransformParametersUnmarshaller.Instance;
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Role", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Role = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Schema", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SchemaColumn, SchemaColumnUnmarshaller>(SchemaColumnUnmarshaller.Instance);
                    unmarshalledObject.Schema = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Timeout", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Timeout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TransformEncryption", targetDepth))
                {
                    var unmarshaller = TransformEncryptionUnmarshaller.Instance;
                    unmarshalledObject.TransformEncryption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TransformId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransformId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WorkerType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkerType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MLTransformUnmarshaller _instance = new MLTransformUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MLTransformUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}