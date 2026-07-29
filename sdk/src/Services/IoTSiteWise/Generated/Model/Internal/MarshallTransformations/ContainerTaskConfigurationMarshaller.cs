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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContainerTaskConfiguration Marshaller
    /// </summary>
    public class ContainerTaskConfigurationMarshaller : IRequestMarshaller<ContainerTaskConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContainerTaskConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.WriteStringValue(requestObjectCommandListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrUri())
            {
                context.Writer.WritePropertyName("ecrUri");
                context.Writer.WriteStringValue(requestObject.EcrUri);
            }

            if(requestObject.IsSetEnvironmentVariables())
            {
                context.Writer.WritePropertyName("environmentVariables");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEnvironmentVariablesKvp in requestObject.EnvironmentVariables)
                {
                    context.Writer.WritePropertyName(requestObjectEnvironmentVariablesKvp.Key);
                    var requestObjectEnvironmentVariablesValue = requestObjectEnvironmentVariablesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectEnvironmentVariablesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProcessingType())
            {
                context.Writer.WritePropertyName("processingType");
                context.Writer.WriteStringValue(requestObject.ProcessingType);
            }

            if(requestObject.IsSetProcessingUnit())
            {
                context.Writer.WritePropertyName("processingUnit");
                context.Writer.WriteStringValue(requestObject.ProcessingUnit);
            }

            if(requestObject.IsSetTaskExecutionRole())
            {
                context.Writer.WritePropertyName("taskExecutionRole");
                context.Writer.WriteStringValue(requestObject.TaskExecutionRole);
            }

            if(requestObject.IsSetTimeoutSeconds())
            {
                context.Writer.WritePropertyName("timeoutSeconds");
                context.Writer.WriteNumberValue(requestObject.TimeoutSeconds.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContainerTaskConfigurationMarshaller Instance = new ContainerTaskConfigurationMarshaller();

    }
}