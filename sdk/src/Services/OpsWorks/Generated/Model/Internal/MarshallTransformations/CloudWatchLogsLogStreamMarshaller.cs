/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CloudWatchLogsLogStream Marshaller
    /// </summary>       
    public class CloudWatchLogsLogStreamMarshaller : IRequestMarshaller<CloudWatchLogsLogStream, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CloudWatchLogsLogStream requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBatchCount())
            {
                context.Writer.WritePropertyName("BatchCount");
                context.Writer.Write(requestObject.BatchCount);
            }

            if(requestObject.IsSetBatchSize())
            {
                context.Writer.WritePropertyName("BatchSize");
                context.Writer.Write(requestObject.BatchSize);
            }

            if(requestObject.IsSetBufferDuration())
            {
                context.Writer.WritePropertyName("BufferDuration");
                context.Writer.Write(requestObject.BufferDuration);
            }

            if(requestObject.IsSetDatetimeFormat())
            {
                context.Writer.WritePropertyName("DatetimeFormat");
                context.Writer.Write(requestObject.DatetimeFormat);
            }

            if(requestObject.IsSetEncoding())
            {
                context.Writer.WritePropertyName("Encoding");
                context.Writer.Write(requestObject.Encoding);
            }

            if(requestObject.IsSetFile())
            {
                context.Writer.WritePropertyName("File");
                context.Writer.Write(requestObject.File);
            }

            if(requestObject.IsSetFileFingerprintLines())
            {
                context.Writer.WritePropertyName("FileFingerprintLines");
                context.Writer.Write(requestObject.FileFingerprintLines);
            }

            if(requestObject.IsSetInitialPosition())
            {
                context.Writer.WritePropertyName("InitialPosition");
                context.Writer.Write(requestObject.InitialPosition);
            }

            if(requestObject.IsSetLogGroupName())
            {
                context.Writer.WritePropertyName("LogGroupName");
                context.Writer.Write(requestObject.LogGroupName);
            }

            if(requestObject.IsSetMultiLineStartPattern())
            {
                context.Writer.WritePropertyName("MultiLineStartPattern");
                context.Writer.Write(requestObject.MultiLineStartPattern);
            }

            if(requestObject.IsSetTimeZone())
            {
                context.Writer.WritePropertyName("TimeZone");
                context.Writer.Write(requestObject.TimeZone);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CloudWatchLogsLogStreamMarshaller Instance = new CloudWatchLogsLogStreamMarshaller();

    }
}