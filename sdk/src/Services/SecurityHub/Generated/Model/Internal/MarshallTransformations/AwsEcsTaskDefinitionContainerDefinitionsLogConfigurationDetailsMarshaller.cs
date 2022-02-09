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
    /// AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetails Marshaller
    /// </summary>
    public class AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetailsMarshaller : IRequestMarshaller<AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetLogDriver())
            {
                context.Writer.WritePropertyName("LogDriver");
                context.Writer.Write(requestObject.LogDriver);
            }

            if(requestObject.IsSetOptions())
            {
                context.Writer.WritePropertyName("Options");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectOptionsKvp in requestObject.Options)
                {
                    context.Writer.WritePropertyName(requestObjectOptionsKvp.Key);
                    var requestObjectOptionsValue = requestObjectOptionsKvp.Value;

                        context.Writer.Write(requestObjectOptionsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSecretOptions())
            {
                context.Writer.WritePropertyName("SecretOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecretOptionsListValue in requestObject.SecretOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationSecretOptionsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecretOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetailsMarshaller Instance = new AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetailsMarshaller();

    }
}