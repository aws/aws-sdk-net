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
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FlinkApplicationConfigurationUpdate Marshaller
    /// </summary>       
    public class FlinkApplicationConfigurationUpdateMarshaller : IRequestMarshaller<FlinkApplicationConfigurationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FlinkApplicationConfigurationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCheckpointConfigurationUpdate())
            {
                context.Writer.WritePropertyName("CheckpointConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = CheckpointConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.CheckpointConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMonitoringConfigurationUpdate())
            {
                context.Writer.WritePropertyName("MonitoringConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = MonitoringConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.MonitoringConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParallelismConfigurationUpdate())
            {
                context.Writer.WritePropertyName("ParallelismConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = ParallelismConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ParallelismConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FlinkApplicationConfigurationUpdateMarshaller Instance = new FlinkApplicationConfigurationUpdateMarshaller();

    }
}