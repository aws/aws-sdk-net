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
    /// WorkGroupConfigurationUpdates Marshaller
    /// </summary>
    public class WorkGroupConfigurationUpdatesMarshaller : IRequestMarshaller<WorkGroupConfigurationUpdates, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WorkGroupConfigurationUpdates requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAdditionalConfiguration())
            {
                context.Writer.WritePropertyName("AdditionalConfiguration");
                context.Writer.Write(requestObject.AdditionalConfiguration);
            }

            if(requestObject.IsSetBytesScannedCutoffPerQuery())
            {
                context.Writer.WritePropertyName("BytesScannedCutoffPerQuery");
                context.Writer.Write(requestObject.BytesScannedCutoffPerQuery);
            }

            if(requestObject.IsSetCustomerContentEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("CustomerContentEncryptionConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = CustomerContentEncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomerContentEncryptionConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEnableMinimumEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("EnableMinimumEncryptionConfiguration");
                context.Writer.Write(requestObject.EnableMinimumEncryptionConfiguration);
            }

            if(requestObject.IsSetEnforceWorkGroupConfiguration())
            {
                context.Writer.WritePropertyName("EnforceWorkGroupConfiguration");
                context.Writer.Write(requestObject.EnforceWorkGroupConfiguration);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteObjectStart();

                var marshaller = EngineVersionMarshaller.Instance;
                marshaller.Marshall(requestObject.EngineVersion, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExecutionRole())
            {
                context.Writer.WritePropertyName("ExecutionRole");
                context.Writer.Write(requestObject.ExecutionRole);
            }

            if(requestObject.IsSetPublishCloudWatchMetricsEnabled())
            {
                context.Writer.WritePropertyName("PublishCloudWatchMetricsEnabled");
                context.Writer.Write(requestObject.PublishCloudWatchMetricsEnabled);
            }

            if(requestObject.IsSetRemoveBytesScannedCutoffPerQuery())
            {
                context.Writer.WritePropertyName("RemoveBytesScannedCutoffPerQuery");
                context.Writer.Write(requestObject.RemoveBytesScannedCutoffPerQuery);
            }

            if(requestObject.IsSetRemoveCustomerContentEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("RemoveCustomerContentEncryptionConfiguration");
                context.Writer.Write(requestObject.RemoveCustomerContentEncryptionConfiguration);
            }

            if(requestObject.IsSetRequesterPaysEnabled())
            {
                context.Writer.WritePropertyName("RequesterPaysEnabled");
                context.Writer.Write(requestObject.RequesterPaysEnabled);
            }

            if(requestObject.IsSetResultConfigurationUpdates())
            {
                context.Writer.WritePropertyName("ResultConfigurationUpdates");
                context.Writer.WriteObjectStart();

                var marshaller = ResultConfigurationUpdatesMarshaller.Instance;
                marshaller.Marshall(requestObject.ResultConfigurationUpdates, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WorkGroupConfigurationUpdatesMarshaller Instance = new WorkGroupConfigurationUpdatesMarshaller();

    }
}