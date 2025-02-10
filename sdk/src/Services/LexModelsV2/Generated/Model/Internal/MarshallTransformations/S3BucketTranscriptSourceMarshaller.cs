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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3BucketTranscriptSource Marshaller
    /// </summary>
    public class S3BucketTranscriptSourceMarshaller : IRequestMarshaller<S3BucketTranscriptSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3BucketTranscriptSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("kmsKeyArn");
                context.Writer.WriteStringValue(requestObject.KmsKeyArn);
            }

            if(requestObject.IsSetPathFormat())
            {
                context.Writer.WritePropertyName("pathFormat");
                context.Writer.WriteStartObject();

                var marshaller = PathFormatMarshaller.Instance;
                marshaller.Marshall(requestObject.PathFormat, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3BucketName())
            {
                context.Writer.WritePropertyName("s3BucketName");
                context.Writer.WriteStringValue(requestObject.S3BucketName);
            }

            if(requestObject.IsSetTranscriptFilter())
            {
                context.Writer.WritePropertyName("transcriptFilter");
                context.Writer.WriteStartObject();

                var marshaller = TranscriptFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.TranscriptFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTranscriptFormat())
            {
                context.Writer.WritePropertyName("transcriptFormat");
                context.Writer.WriteStringValue(requestObject.TranscriptFormat);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3BucketTranscriptSourceMarshaller Instance = new S3BucketTranscriptSourceMarshaller();

    }
}