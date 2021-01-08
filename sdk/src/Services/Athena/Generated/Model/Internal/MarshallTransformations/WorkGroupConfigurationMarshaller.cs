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
using ThirdParty.Json.LitJson;

namespace Amazon.Athena.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WorkGroupConfiguration Marshaller
    /// </summary>       
    public class WorkGroupConfigurationMarshaller : IRequestMarshaller<WorkGroupConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WorkGroupConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBytesScannedCutoffPerQuery())
            {
                context.Writer.WritePropertyName("BytesScannedCutoffPerQuery");
                context.Writer.Write(requestObject.BytesScannedCutoffPerQuery);
            }

            if(requestObject.IsSetEnforceWorkGroupConfiguration())
            {
                context.Writer.WritePropertyName("EnforceWorkGroupConfiguration");
                context.Writer.Write(requestObject.EnforceWorkGroupConfiguration);
            }

            if(requestObject.IsSetPublishCloudWatchMetricsEnabled())
            {
                context.Writer.WritePropertyName("PublishCloudWatchMetricsEnabled");
                context.Writer.Write(requestObject.PublishCloudWatchMetricsEnabled);
            }

            if(requestObject.IsSetRequesterPaysEnabled())
            {
                context.Writer.WritePropertyName("RequesterPaysEnabled");
                context.Writer.Write(requestObject.RequesterPaysEnabled);
            }

            if(requestObject.IsSetResultConfiguration())
            {
                context.Writer.WritePropertyName("ResultConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ResultConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ResultConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static WorkGroupConfigurationMarshaller Instance = new WorkGroupConfigurationMarshaller();

    }
}