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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMQuickSetup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SSMQuickSetup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConfigurationDefinitionInput Marshaller
    /// </summary>
    public class ConfigurationDefinitionInputMarshaller : IRequestMarshaller<ConfigurationDefinitionInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConfigurationDefinitionInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLocalDeploymentAdministrationRoleArn())
            {
                context.Writer.WritePropertyName("LocalDeploymentAdministrationRoleArn");
                context.Writer.WriteStringValue(requestObject.LocalDeploymentAdministrationRoleArn);
            }

            if(requestObject.IsSetLocalDeploymentExecutionRoleName())
            {
                context.Writer.WritePropertyName("LocalDeploymentExecutionRoleName");
                context.Writer.WriteStringValue(requestObject.LocalDeploymentExecutionRoleName);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetTypeVersion())
            {
                context.Writer.WritePropertyName("TypeVersion");
                context.Writer.WriteStringValue(requestObject.TypeVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConfigurationDefinitionInputMarshaller Instance = new ConfigurationDefinitionInputMarshaller();

    }
}