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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LambdaWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LambdaWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoggingConfig Marshaller
    /// </summary>
    public class LoggingConfigMarshaller : IRequestMarshaller<LoggingConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoggingConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationLogLevel())
            {
                context.Writer.WritePropertyName("applicationLogLevel");
                context.Writer.WriteStringValue(requestObject.ApplicationLogLevel);
            }

            if(requestObject.IsSetLogGroup())
            {
                context.Writer.WritePropertyName("logGroup");
                context.Writer.WriteStringValue(requestObject.LogGroup);
            }

            if(requestObject.IsSetSystemLogLevel())
            {
                context.Writer.WritePropertyName("systemLogLevel");
                context.Writer.WriteStringValue(requestObject.SystemLogLevel);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LoggingConfigMarshaller Instance = new LoggingConfigMarshaller();

    }
}