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
    /// ZeppelinApplicationConfigurationUpdate Marshaller
    /// </summary>
    public class ZeppelinApplicationConfigurationUpdateMarshaller : IRequestMarshaller<ZeppelinApplicationConfigurationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ZeppelinApplicationConfigurationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCatalogConfigurationUpdate())
            {
                context.Writer.WritePropertyName("CatalogConfigurationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = CatalogConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogConfigurationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomArtifactsConfigurationUpdate())
            {
                context.Writer.WritePropertyName("CustomArtifactsConfigurationUpdate");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomArtifactsConfigurationUpdateListValue in requestObject.CustomArtifactsConfigurationUpdate)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomArtifactConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomArtifactsConfigurationUpdateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDeployAsApplicationConfigurationUpdate())
            {
                context.Writer.WritePropertyName("DeployAsApplicationConfigurationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = DeployAsApplicationConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.DeployAsApplicationConfigurationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMonitoringConfigurationUpdate())
            {
                context.Writer.WritePropertyName("MonitoringConfigurationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = ZeppelinMonitoringConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.MonitoringConfigurationUpdate, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ZeppelinApplicationConfigurationUpdateMarshaller Instance = new ZeppelinApplicationConfigurationUpdateMarshaller();

    }
}