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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemediationConfiguration Marshaller
    /// </summary>
    public class RemediationConfigurationMarshaller : IRequestMarshaller<RemediationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RemediationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetAutomatic())
            {
                context.Writer.WritePropertyName("Automatic");
                context.Writer.WriteBooleanValue(requestObject.Automatic.Value);
            }

            if(requestObject.IsSetConfigRuleName())
            {
                context.Writer.WritePropertyName("ConfigRuleName");
                context.Writer.WriteStringValue(requestObject.ConfigRuleName);
            }

            if(requestObject.IsSetCreatedByService())
            {
                context.Writer.WritePropertyName("CreatedByService");
                context.Writer.WriteStringValue(requestObject.CreatedByService);
            }

            if(requestObject.IsSetExecutionControls())
            {
                context.Writer.WritePropertyName("ExecutionControls");
                context.Writer.WriteStartObject();

                var marshaller = ExecutionControlsMarshaller.Instance;
                marshaller.Marshall(requestObject.ExecutionControls, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaximumAutomaticAttempts())
            {
                context.Writer.WritePropertyName("MaximumAutomaticAttempts");
                context.Writer.WriteNumberValue(requestObject.MaximumAutomaticAttempts.Value);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = RemediationParameterValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectParametersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.WriteStringValue(requestObject.ResourceType);
            }

            if(requestObject.IsSetRetryAttemptSeconds())
            {
                context.Writer.WritePropertyName("RetryAttemptSeconds");
                context.Writer.WriteNumberValue(requestObject.RetryAttemptSeconds.Value);
            }

            if(requestObject.IsSetTargetId())
            {
                context.Writer.WritePropertyName("TargetId");
                context.Writer.WriteStringValue(requestObject.TargetId);
            }

            if(requestObject.IsSetTargetType())
            {
                context.Writer.WritePropertyName("TargetType");
                context.Writer.WriteStringValue(requestObject.TargetType);
            }

            if(requestObject.IsSetTargetVersion())
            {
                context.Writer.WritePropertyName("TargetVersion");
                context.Writer.WriteStringValue(requestObject.TargetVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RemediationConfigurationMarshaller Instance = new RemediationConfigurationMarshaller();

    }
}