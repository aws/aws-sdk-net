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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchJobIdentifier Marshaller
    /// </summary>
    public class BatchJobIdentifierMarshaller : IRequestMarshaller<BatchJobIdentifier, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchJobIdentifier requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFileBatchJobIdentifier())
            {
                context.Writer.WritePropertyName("fileBatchJobIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = FileBatchJobIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.FileBatchJobIdentifier, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRestartBatchJobIdentifier())
            {
                context.Writer.WritePropertyName("restartBatchJobIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = RestartBatchJobIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.RestartBatchJobIdentifier, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3BatchJobIdentifier())
            {
                context.Writer.WritePropertyName("s3BatchJobIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = S3BatchJobIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.S3BatchJobIdentifier, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScriptBatchJobIdentifier())
            {
                context.Writer.WritePropertyName("scriptBatchJobIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = ScriptBatchJobIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.ScriptBatchJobIdentifier, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchJobIdentifierMarshaller Instance = new BatchJobIdentifierMarshaller();

    }
}