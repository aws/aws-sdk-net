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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamInfluxDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TimestreamInfluxDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InfluxDBv2Parameters Marshaller
    /// </summary>
    public class InfluxDBv2ParametersMarshaller : IRequestMarshaller<InfluxDBv2Parameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InfluxDBv2Parameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFluxLogEnabled())
            {
                context.Writer.WritePropertyName("fluxLogEnabled");
                context.Writer.Write(requestObject.FluxLogEnabled);
            }

            if(requestObject.IsSetLogLevel())
            {
                context.Writer.WritePropertyName("logLevel");
                context.Writer.Write(requestObject.LogLevel);
            }

            if(requestObject.IsSetMetricsDisabled())
            {
                context.Writer.WritePropertyName("metricsDisabled");
                context.Writer.Write(requestObject.MetricsDisabled);
            }

            if(requestObject.IsSetNoTasks())
            {
                context.Writer.WritePropertyName("noTasks");
                context.Writer.Write(requestObject.NoTasks);
            }

            if(requestObject.IsSetQueryConcurrency())
            {
                context.Writer.WritePropertyName("queryConcurrency");
                context.Writer.Write(requestObject.QueryConcurrency);
            }

            if(requestObject.IsSetQueryQueueSize())
            {
                context.Writer.WritePropertyName("queryQueueSize");
                context.Writer.Write(requestObject.QueryQueueSize);
            }

            if(requestObject.IsSetTracingType())
            {
                context.Writer.WritePropertyName("tracingType");
                context.Writer.Write(requestObject.TracingType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InfluxDBv2ParametersMarshaller Instance = new InfluxDBv2ParametersMarshaller();

    }
}