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

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TableOptimizerRun Object
    /// </summary>  
    public class TableOptimizerRunUnmarshaller : IUnmarshaller<TableOptimizerRun, XmlUnmarshallerContext>, IUnmarshaller<TableOptimizerRun, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TableOptimizerRun IUnmarshaller<TableOptimizerRun, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TableOptimizerRun Unmarshall(JsonUnmarshallerContext context)
        {
            TableOptimizerRun unmarshalledObject = new TableOptimizerRun();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("compactionMetrics", targetDepth))
                {
                    var unmarshaller = CompactionMetricsUnmarshaller.Instance;
                    unmarshalledObject.CompactionMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("error", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Error = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metrics", targetDepth))
                {
                    var unmarshaller = RunMetricsUnmarshaller.Instance;
                    unmarshalledObject.Metrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("orphanFileDeletionMetrics", targetDepth))
                {
                    var unmarshaller = OrphanFileDeletionMetricsUnmarshaller.Instance;
                    unmarshalledObject.OrphanFileDeletionMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("retentionMetrics", targetDepth))
                {
                    var unmarshaller = RetentionMetricsUnmarshaller.Instance;
                    unmarshalledObject.RetentionMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TableOptimizerRunUnmarshaller _instance = new TableOptimizerRunUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TableOptimizerRunUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}