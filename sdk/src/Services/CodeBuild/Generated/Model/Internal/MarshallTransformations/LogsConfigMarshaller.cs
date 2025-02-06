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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LogsConfig Marshaller
    /// </summary>
    public class LogsConfigMarshaller : IRequestMarshaller<LogsConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LogsConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchLogs())
            {
                context.Writer.WritePropertyName("cloudWatchLogs");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchLogsConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLogs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Logs())
            {
                context.Writer.WritePropertyName("s3Logs");
                context.Writer.WriteStartObject();

                var marshaller = S3LogsConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Logs, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LogsConfigMarshaller Instance = new LogsConfigMarshaller();

    }
}