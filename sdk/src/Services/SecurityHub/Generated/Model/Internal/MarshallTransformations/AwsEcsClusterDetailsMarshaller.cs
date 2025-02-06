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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEcsClusterDetails Marshaller
    /// </summary>
    public class AwsEcsClusterDetailsMarshaller : IRequestMarshaller<AwsEcsClusterDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcsClusterDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActiveServicesCount())
            {
                context.Writer.WritePropertyName("ActiveServicesCount");
                context.Writer.WriteNumberValue(requestObject.ActiveServicesCount.Value);
            }

            if(requestObject.IsSetCapacityProviders())
            {
                context.Writer.WritePropertyName("CapacityProviders");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCapacityProvidersListValue in requestObject.CapacityProviders)
                {
                        context.Writer.WriteStringValue(requestObjectCapacityProvidersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetClusterArn())
            {
                context.Writer.WritePropertyName("ClusterArn");
                context.Writer.WriteStringValue(requestObject.ClusterArn);
            }

            if(requestObject.IsSetClusterName())
            {
                context.Writer.WritePropertyName("ClusterName");
                context.Writer.WriteStringValue(requestObject.ClusterName);
            }

            if(requestObject.IsSetClusterSettings())
            {
                context.Writer.WritePropertyName("ClusterSettings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectClusterSettingsListValue in requestObject.ClusterSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsClusterClusterSettingsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusterSettingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("Configuration");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsClusterConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultCapacityProviderStrategy())
            {
                context.Writer.WritePropertyName("DefaultCapacityProviderStrategy");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDefaultCapacityProviderStrategyListValue in requestObject.DefaultCapacityProviderStrategy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsClusterDefaultCapacityProviderStrategyDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDefaultCapacityProviderStrategyListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRegisteredContainerInstancesCount())
            {
                context.Writer.WritePropertyName("RegisteredContainerInstancesCount");
                context.Writer.WriteNumberValue(requestObject.RegisteredContainerInstancesCount.Value);
            }

            if(requestObject.IsSetRunningTasksCount())
            {
                context.Writer.WritePropertyName("RunningTasksCount");
                context.Writer.WriteNumberValue(requestObject.RunningTasksCount.Value);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcsClusterDetailsMarshaller Instance = new AwsEcsClusterDetailsMarshaller();

    }
}