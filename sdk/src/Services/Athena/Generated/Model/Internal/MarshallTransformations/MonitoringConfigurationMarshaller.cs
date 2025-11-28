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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Athena.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Athena.Model.Internal.MarshallTransformations
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
                context.Writer.WritePropertyName("CloudWatchLoggingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchLoggingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLoggingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetManagedLoggingConfiguration())
            {
                context.Writer.WritePropertyName("ManagedLoggingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ManagedLoggingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ManagedLoggingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3LoggingConfiguration())
            {
                context.Writer.WritePropertyName("S3LoggingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = S3LoggingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3LoggingConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MonitoringConfigurationMarshaller Instance = new MonitoringConfigurationMarshaller();

    }
}