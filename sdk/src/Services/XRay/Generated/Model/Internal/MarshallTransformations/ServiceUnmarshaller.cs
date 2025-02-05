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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Service Object
    /// </summary>  
    public class ServiceUnmarshaller : IJsonUnmarshaller<Service, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Service Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Service unmarshalledObject = new Service();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DurationHistogram", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HistogramEntry, HistogramEntryUnmarshaller>(HistogramEntryUnmarshaller.Instance);
                    unmarshalledObject.DurationHistogram = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Edges", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Edge, EdgeUnmarshaller>(EdgeUnmarshaller.Instance);
                    unmarshalledObject.Edges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Names", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Names = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReferenceId", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ReferenceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResponseTimeHistogram", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HistogramEntry, HistogramEntryUnmarshaller>(HistogramEntryUnmarshaller.Instance);
                    unmarshalledObject.ResponseTimeHistogram = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Root", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Root = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SummaryStatistics", targetDepth))
                {
                    var unmarshaller = ServiceStatisticsUnmarshaller.Instance;
                    unmarshalledObject.SummaryStatistics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServiceUnmarshaller _instance = new ServiceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}