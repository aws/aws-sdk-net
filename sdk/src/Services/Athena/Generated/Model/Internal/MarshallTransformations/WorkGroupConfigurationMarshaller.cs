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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalConfiguration())
            {
                context.Writer.WritePropertyName("AdditionalConfiguration");
                context.Writer.WriteStringValue(requestObject.AdditionalConfiguration);
            }

            if(requestObject.IsSetBytesScannedCutoffPerQuery())
            {
                context.Writer.WritePropertyName("BytesScannedCutoffPerQuery");
                context.Writer.WriteNumberValue(requestObject.BytesScannedCutoffPerQuery.Value);
            }

            if(requestObject.IsSetCustomerContentEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("CustomerContentEncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CustomerContentEncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomerContentEncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnableMinimumEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("EnableMinimumEncryptionConfiguration");
                context.Writer.WriteBooleanValue(requestObject.EnableMinimumEncryptionConfiguration.Value);
            }

            if(requestObject.IsSetEnforceWorkGroupConfiguration())
            {
                context.Writer.WritePropertyName("EnforceWorkGroupConfiguration");
                context.Writer.WriteBooleanValue(requestObject.EnforceWorkGroupConfiguration.Value);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteStartObject();

                var marshaller = EngineVersionMarshaller.Instance;
                marshaller.Marshall(requestObject.EngineVersion, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExecutionRole())
            {
                context.Writer.WritePropertyName("ExecutionRole");
                context.Writer.WriteStringValue(requestObject.ExecutionRole);
            }

            if(requestObject.IsSetIdentityCenterConfiguration())
            {
                context.Writer.WritePropertyName("IdentityCenterConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = IdentityCenterConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.IdentityCenterConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetManagedQueryResultsConfiguration())
            {
                context.Writer.WritePropertyName("ManagedQueryResultsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ManagedQueryResultsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ManagedQueryResultsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPublishCloudWatchMetricsEnabled())
            {
                context.Writer.WritePropertyName("PublishCloudWatchMetricsEnabled");
                context.Writer.WriteBooleanValue(requestObject.PublishCloudWatchMetricsEnabled.Value);
            }

            if(requestObject.IsSetQueryResultsS3AccessGrantsConfiguration())
            {
                context.Writer.WritePropertyName("QueryResultsS3AccessGrantsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = QueryResultsS3AccessGrantsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.QueryResultsS3AccessGrantsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRequesterPaysEnabled())
            {
                context.Writer.WritePropertyName("RequesterPaysEnabled");
                context.Writer.WriteBooleanValue(requestObject.RequesterPaysEnabled.Value);
            }

            if(requestObject.IsSetResultConfiguration())
            {
                context.Writer.WritePropertyName("ResultConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ResultConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ResultConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WorkGroupConfigurationMarshaller Instance = new WorkGroupConfigurationMarshaller();

    }
}