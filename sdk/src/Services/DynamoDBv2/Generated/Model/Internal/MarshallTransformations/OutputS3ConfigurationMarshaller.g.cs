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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OutputS3Configuration Marshaller
    /// </summary>
    public partial class OutputS3ConfigurationMarshaller : IRequestMarshaller<OutputS3Configuration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(OutputS3Configuration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetOutputType())
            {
                context.Writer.WritePropertyName("OutputType");
                context.Writer.WriteStartArray();
                foreach (var requestObjectOutputTypeListValue in requestObject.OutputType)
                {
                    context.Writer.WriteStringValue(requestObjectOutputTypeListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("S3Bucket");
                context.Writer.WriteStringValue(requestObject.S3Bucket);
            }

            if (requestObject.IsSetS3BucketOwner())
            {
                context.Writer.WritePropertyName("S3BucketOwner");
                context.Writer.WriteStringValue(requestObject.S3BucketOwner);
            }

            if (requestObject.IsSetS3KeyPrefix())
            {
                context.Writer.WritePropertyName("S3KeyPrefix");
                context.Writer.WriteStringValue(requestObject.S3KeyPrefix);
            }

            if (requestObject.IsSetS3SseAlgorithm())
            {
                context.Writer.WritePropertyName("S3SseAlgorithm");
                context.Writer.WriteStringValue(requestObject.S3SseAlgorithm);
            }

            if (requestObject.IsSetS3SseKmsKeyId())
            {
                context.Writer.WritePropertyName("S3SseKmsKeyId");
                context.Writer.WriteStringValue(requestObject.S3SseKmsKeyId);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static OutputS3ConfigurationMarshaller Instance = new OutputS3ConfigurationMarshaller();
    }
}
