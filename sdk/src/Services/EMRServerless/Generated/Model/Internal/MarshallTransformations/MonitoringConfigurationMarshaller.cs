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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EMRServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MonitoringConfiguration Marshaller
    /// </summary>
    public class MonitoringConfigurationMarshaller : IRequestMarshaller<MonitoringConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MonitoringConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchLoggingConfiguration())
            {
                context.Writer.WritePropertyName("cloudWatchLoggingConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = CloudWatchLoggingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLoggingConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetManagedPersistenceMonitoringConfiguration())
            {
                context.Writer.WritePropertyName("managedPersistenceMonitoringConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ManagedPersistenceMonitoringConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ManagedPersistenceMonitoringConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrometheusMonitoringConfiguration())
            {
                context.Writer.WritePropertyName("prometheusMonitoringConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = PrometheusMonitoringConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PrometheusMonitoringConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3MonitoringConfiguration())
            {
                context.Writer.WritePropertyName("s3MonitoringConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = S3MonitoringConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3MonitoringConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MonitoringConfigurationMarshaller Instance = new MonitoringConfigurationMarshaller();

    }
}