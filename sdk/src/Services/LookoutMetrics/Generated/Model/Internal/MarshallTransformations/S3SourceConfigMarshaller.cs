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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutMetrics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LookoutMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3SourceConfig Marshaller
    /// </summary>
    public class S3SourceConfigMarshaller : IRequestMarshaller<S3SourceConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3SourceConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFileFormatDescriptor())
            {
                context.Writer.WritePropertyName("FileFormatDescriptor");
                context.Writer.WriteStartObject();

                var marshaller = FileFormatDescriptorMarshaller.Instance;
                marshaller.Marshall(requestObject.FileFormatDescriptor, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHistoricalDataPathList())
            {
                context.Writer.WritePropertyName("HistoricalDataPathList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHistoricalDataPathListListValue in requestObject.HistoricalDataPathList)
                {
                        context.Writer.WriteStringValue(requestObjectHistoricalDataPathListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetTemplatedPathList())
            {
                context.Writer.WritePropertyName("TemplatedPathList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTemplatedPathListListValue in requestObject.TemplatedPathList)
                {
                        context.Writer.WriteStringValue(requestObjectTemplatedPathListListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3SourceConfigMarshaller Instance = new S3SourceConfigMarshaller();

    }
}