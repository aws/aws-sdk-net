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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRContainers.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ParametricMonitoringConfiguration Marshaller
    /// </summary>
    public class ParametricMonitoringConfigurationMarshaller : IRequestMarshaller<ParametricMonitoringConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ParametricMonitoringConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchMonitoringConfiguration())
            {
                context.Writer.WritePropertyName("cloudWatchMonitoringConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ParametricCloudWatchMonitoringConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchMonitoringConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPersistentAppUI())
            {
                context.Writer.WritePropertyName("persistentAppUI");
                context.Writer.WriteStringValue(requestObject.PersistentAppUI);
            }

            if(requestObject.IsSetS3MonitoringConfiguration())
            {
                context.Writer.WritePropertyName("s3MonitoringConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ParametricS3MonitoringConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3MonitoringConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ParametricMonitoringConfigurationMarshaller Instance = new ParametricMonitoringConfigurationMarshaller();

    }
}