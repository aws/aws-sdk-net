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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GreengrassV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LambdaExecutionParameters Marshaller
    /// </summary>
    public class LambdaExecutionParametersMarshaller : IRequestMarshaller<LambdaExecutionParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LambdaExecutionParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
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

            if(requestObject.IsSetEventSources())
            {
                context.Writer.WritePropertyName("eventSources");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEventSourcesListValue in requestObject.EventSources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LambdaEventSourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectEventSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExecArgs())
            {
                context.Writer.WritePropertyName("execArgs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExecArgsListValue in requestObject.ExecArgs)
                {
                        context.Writer.WriteStringValue(requestObjectExecArgsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInputPayloadEncodingType())
            {
                context.Writer.WritePropertyName("inputPayloadEncodingType");
                context.Writer.WriteStringValue(requestObject.InputPayloadEncodingType);
            }

            if(requestObject.IsSetLinuxProcessParams())
            {
                context.Writer.WritePropertyName("linuxProcessParams");
                context.Writer.WriteStartObject();

                var marshaller = LambdaLinuxProcessParamsMarshaller.Instance;
                marshaller.Marshall(requestObject.LinuxProcessParams, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaxIdleTimeInSeconds())
            {
                context.Writer.WritePropertyName("maxIdleTimeInSeconds");
                context.Writer.WriteNumberValue(requestObject.MaxIdleTimeInSeconds.Value);
            }

            if(requestObject.IsSetMaxInstancesCount())
            {
                context.Writer.WritePropertyName("maxInstancesCount");
                context.Writer.WriteNumberValue(requestObject.MaxInstancesCount.Value);
            }

            if(requestObject.IsSetMaxQueueSize())
            {
                context.Writer.WritePropertyName("maxQueueSize");
                context.Writer.WriteNumberValue(requestObject.MaxQueueSize.Value);
            }

            if(requestObject.IsSetPinned())
            {
                context.Writer.WritePropertyName("pinned");
                context.Writer.WriteBooleanValue(requestObject.Pinned.Value);
            }

            if(requestObject.IsSetStatusTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("statusTimeoutInSeconds");
                context.Writer.WriteNumberValue(requestObject.StatusTimeoutInSeconds.Value);
            }

            if(requestObject.IsSetTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("timeoutInSeconds");
                context.Writer.WriteNumberValue(requestObject.TimeoutInSeconds.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LambdaExecutionParametersMarshaller Instance = new LambdaExecutionParametersMarshaller();

    }
}