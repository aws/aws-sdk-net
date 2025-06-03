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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PCS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PCS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ClusterSlurmConfigurationRequest Marshaller
    /// </summary>
    public class ClusterSlurmConfigurationRequestMarshaller : IRequestMarshaller<ClusterSlurmConfigurationRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ClusterSlurmConfigurationRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccounting())
            {
                context.Writer.WritePropertyName("accounting");
                context.Writer.WriteStartObject();

                var marshaller = AccountingRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.Accounting, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScaleDownIdleTimeInSeconds())
            {
                context.Writer.WritePropertyName("scaleDownIdleTimeInSeconds");
                context.Writer.WriteNumberValue(requestObject.ScaleDownIdleTimeInSeconds.Value);
            }

            if(requestObject.IsSetSlurmCustomSettings())
            {
                context.Writer.WritePropertyName("slurmCustomSettings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSlurmCustomSettingsListValue in requestObject.SlurmCustomSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SlurmCustomSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectSlurmCustomSettingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ClusterSlurmConfigurationRequestMarshaller Instance = new ClusterSlurmConfigurationRequestMarshaller();

    }
}