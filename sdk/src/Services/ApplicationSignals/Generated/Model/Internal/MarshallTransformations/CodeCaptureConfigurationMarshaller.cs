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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CodeCaptureConfiguration Marshaller
    /// </summary>
    public class CodeCaptureConfigurationMarshaller : IRequestMarshaller<CodeCaptureConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CodeCaptureConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCaptureArguments())
            {
                context.Writer.WritePropertyName("CaptureArguments");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCaptureArgumentsListValue in requestObject.CaptureArguments)
                {
                        context.Writer.WriteStringValue(requestObjectCaptureArgumentsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCaptureLimits())
            {
                context.Writer.WritePropertyName("CaptureLimits");
                context.Writer.WriteStartObject();

                var marshaller = CaptureLimitsConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CaptureLimits, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCaptureLocals())
            {
                context.Writer.WritePropertyName("CaptureLocals");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCaptureLocalsListValue in requestObject.CaptureLocals)
                {
                        context.Writer.WriteStringValue(requestObjectCaptureLocalsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCaptureReturn())
            {
                context.Writer.WritePropertyName("CaptureReturn");
                context.Writer.WriteBooleanValue(requestObject.CaptureReturn.Value);
            }

            if(requestObject.IsSetCaptureStackTrace())
            {
                context.Writer.WritePropertyName("CaptureStackTrace");
                context.Writer.WriteBooleanValue(requestObject.CaptureStackTrace.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CodeCaptureConfigurationMarshaller Instance = new CodeCaptureConfigurationMarshaller();

    }
}