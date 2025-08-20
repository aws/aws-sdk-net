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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApplicationConfiguration Marshaller
    /// </summary>
    public class ApplicationConfigurationMarshaller : IRequestMarshaller<ApplicationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ApplicationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationCodeConfiguration())
            {
                context.Writer.WritePropertyName("ApplicationCodeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ApplicationCodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplicationCodeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetApplicationEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("ApplicationEncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ApplicationEncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplicationEncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetApplicationSnapshotConfiguration())
            {
                context.Writer.WritePropertyName("ApplicationSnapshotConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ApplicationSnapshotConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplicationSnapshotConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetApplicationSystemRollbackConfiguration())
            {
                context.Writer.WritePropertyName("ApplicationSystemRollbackConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ApplicationSystemRollbackConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplicationSystemRollbackConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnvironmentProperties())
            {
                context.Writer.WritePropertyName("EnvironmentProperties");
                context.Writer.WriteStartObject();

                var marshaller = EnvironmentPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.EnvironmentProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFlinkApplicationConfiguration())
            {
                context.Writer.WritePropertyName("FlinkApplicationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FlinkApplicationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FlinkApplicationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqlApplicationConfiguration())
            {
                context.Writer.WritePropertyName("SqlApplicationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SqlApplicationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SqlApplicationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVpcConfigurations())
            {
                context.Writer.WritePropertyName("VpcConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVpcConfigurationsListValue in requestObject.VpcConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VpcConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetZeppelinApplicationConfiguration())
            {
                context.Writer.WritePropertyName("ZeppelinApplicationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ZeppelinApplicationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ZeppelinApplicationConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ApplicationConfigurationMarshaller Instance = new ApplicationConfigurationMarshaller();

    }
}