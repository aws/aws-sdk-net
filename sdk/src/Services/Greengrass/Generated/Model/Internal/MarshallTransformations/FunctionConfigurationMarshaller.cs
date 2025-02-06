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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FunctionConfiguration Marshaller
    /// </summary>
    public class FunctionConfigurationMarshaller : IRequestMarshaller<FunctionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FunctionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEncodingType())
            {
                context.Writer.WritePropertyName("EncodingType");
                context.Writer.WriteStringValue(requestObject.EncodingType);
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartObject();

                var marshaller = FunctionConfigurationEnvironmentMarshaller.Instance;
                marshaller.Marshall(requestObject.Environment, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExecArgs())
            {
                context.Writer.WritePropertyName("ExecArgs");
                context.Writer.WriteStringValue(requestObject.ExecArgs);
            }

            if(requestObject.IsSetExecutable())
            {
                context.Writer.WritePropertyName("Executable");
                context.Writer.WriteStringValue(requestObject.Executable);
            }

            if(requestObject.IsSetFunctionRuntimeOverride())
            {
                context.Writer.WritePropertyName("FunctionRuntimeOverride");
                context.Writer.WriteStringValue(requestObject.FunctionRuntimeOverride);
            }

            if(requestObject.IsSetMemorySize())
            {
                context.Writer.WritePropertyName("MemorySize");
                context.Writer.WriteNumberValue(requestObject.MemorySize.Value);
            }

            if(requestObject.IsSetPinned())
            {
                context.Writer.WritePropertyName("Pinned");
                context.Writer.WriteBooleanValue(requestObject.Pinned.Value);
            }

            if(requestObject.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.WriteNumberValue(requestObject.Timeout.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FunctionConfigurationMarshaller Instance = new FunctionConfigurationMarshaller();

    }
}