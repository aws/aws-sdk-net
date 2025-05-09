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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ServerMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SSMValidationParameters Marshaller
    /// </summary>
    public class SSMValidationParametersMarshaller : IRequestMarshaller<SSMValidationParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SSMValidationParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteStringValue(requestObject.Command);
            }

            if(requestObject.IsSetExecutionTimeoutSeconds())
            {
                context.Writer.WritePropertyName("executionTimeoutSeconds");
                context.Writer.WriteNumberValue(requestObject.ExecutionTimeoutSeconds.Value);
            }

            if(requestObject.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("instanceId");
                context.Writer.WriteStringValue(requestObject.InstanceId);
            }

            if(requestObject.IsSetOutputS3BucketName())
            {
                context.Writer.WritePropertyName("outputS3BucketName");
                context.Writer.WriteStringValue(requestObject.OutputS3BucketName);
            }

            if(requestObject.IsSetScriptType())
            {
                context.Writer.WritePropertyName("scriptType");
                context.Writer.WriteStringValue(requestObject.ScriptType);
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteStartObject();

                var marshaller = SourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Source, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SSMValidationParametersMarshaller Instance = new SSMValidationParametersMarshaller();

    }
}