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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutMetrics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LookoutMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricSource Marshaller
    /// </summary>
    public class MetricSourceMarshaller : IRequestMarshaller<MetricSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppFlowConfig())
            {
                context.Writer.WritePropertyName("AppFlowConfig");
                context.Writer.WriteStartObject();

                var marshaller = AppFlowConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AppFlowConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAthenaSourceConfig())
            {
                context.Writer.WritePropertyName("AthenaSourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = AthenaSourceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AthenaSourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCloudWatchConfig())
            {
                context.Writer.WritePropertyName("CloudWatchConfig");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRDSSourceConfig())
            {
                context.Writer.WritePropertyName("RDSSourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = RDSSourceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.RDSSourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRedshiftSourceConfig())
            {
                context.Writer.WritePropertyName("RedshiftSourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftSourceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftSourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3SourceConfig())
            {
                context.Writer.WritePropertyName("S3SourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = S3SourceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.S3SourceConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetricSourceMarshaller Instance = new MetricSourceMarshaller();

    }
}