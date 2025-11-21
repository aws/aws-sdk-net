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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRoomsML.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LogsConfigurationPolicy Marshaller
    /// </summary>
    public class LogsConfigurationPolicyMarshaller : IRequestMarshaller<LogsConfigurationPolicy, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LogsConfigurationPolicy requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedAccountIds())
            {
                context.Writer.WritePropertyName("allowedAccountIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowedAccountIdsListValue in requestObject.AllowedAccountIds)
                {
                        context.Writer.WriteStringValue(requestObjectAllowedAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFilterPattern())
            {
                context.Writer.WritePropertyName("filterPattern");
                context.Writer.WriteStringValue(requestObject.FilterPattern);
            }

            if(requestObject.IsSetLogRedactionConfiguration())
            {
                context.Writer.WritePropertyName("logRedactionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LogRedactionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LogRedactionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogType())
            {
                context.Writer.WritePropertyName("logType");
                context.Writer.WriteStringValue(requestObject.LogType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LogsConfigurationPolicyMarshaller Instance = new LogsConfigurationPolicyMarshaller();

    }
}