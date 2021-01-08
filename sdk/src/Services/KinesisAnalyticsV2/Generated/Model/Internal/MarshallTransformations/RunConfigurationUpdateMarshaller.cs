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
    /// RunConfigurationUpdate Marshaller
    /// </summary>       
    public class RunConfigurationUpdateMarshaller : IRequestMarshaller<RunConfigurationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RunConfigurationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetApplicationRestoreConfiguration())
            {
                context.Writer.WritePropertyName("ApplicationRestoreConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ApplicationRestoreConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplicationRestoreConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFlinkRunConfiguration())
            {
                context.Writer.WritePropertyName("FlinkRunConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FlinkRunConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FlinkRunConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RunConfigurationUpdateMarshaller Instance = new RunConfigurationUpdateMarshaller();

    }
}