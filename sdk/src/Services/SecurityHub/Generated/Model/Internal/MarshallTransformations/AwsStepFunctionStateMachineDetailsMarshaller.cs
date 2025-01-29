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
    /// AwsStepFunctionStateMachineDetails Marshaller
    /// </summary>
    public class AwsStepFunctionStateMachineDetailsMarshaller : IRequestMarshaller<AwsStepFunctionStateMachineDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsStepFunctionStateMachineDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLabel())
            {
                context.Writer.WritePropertyName("Label");
                context.Writer.WriteStringValue(requestObject.Label);
            }

            if(requestObject.IsSetLoggingConfiguration())
            {
                context.Writer.WritePropertyName("LoggingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsStepFunctionStateMachineLoggingConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LoggingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetStateMachineArn())
            {
                context.Writer.WritePropertyName("StateMachineArn");
                context.Writer.WriteStringValue(requestObject.StateMachineArn);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetTracingConfiguration())
            {
                context.Writer.WritePropertyName("TracingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsStepFunctionStateMachineTracingConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.TracingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsStepFunctionStateMachineDetailsMarshaller Instance = new AwsStepFunctionStateMachineDetailsMarshaller();

    }
}