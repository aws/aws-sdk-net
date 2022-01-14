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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetCapacityProviders())
            {
                context.Writer.WritePropertyName("CapacityProviders");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCapacityProvidersListValue in requestObject.CapacityProviders)
                {
                        context.Writer.Write(requestObjectCapacityProvidersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetClusterSettings())
            {
                context.Writer.WritePropertyName("ClusterSettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectClusterSettingsListValue in requestObject.ClusterSettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsClusterClusterSettingsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusterSettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("Configuration");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsClusterConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Configuration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultCapacityProviderStrategy())
            {
                context.Writer.WritePropertyName("DefaultCapacityProviderStrategy");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDefaultCapacityProviderStrategyListValue in requestObject.DefaultCapacityProviderStrategy)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsClusterDefaultCapacityProviderStrategyDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDefaultCapacityProviderStrategyListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcsClusterDetailsMarshaller Instance = new AwsEcsClusterDetailsMarshaller();

    }
}