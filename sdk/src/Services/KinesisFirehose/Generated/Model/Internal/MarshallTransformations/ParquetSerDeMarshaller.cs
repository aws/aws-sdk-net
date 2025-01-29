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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ParquetSerDe Marshaller
    /// </summary>
    public class ParquetSerDeMarshaller : IRequestMarshaller<ParquetSerDe, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ParquetSerDe requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlockSizeBytes())
            {
                context.Writer.WritePropertyName("BlockSizeBytes");
                context.Writer.WriteNumberValue(requestObject.BlockSizeBytes.Value);
            }

            if(requestObject.IsSetCompression())
            {
                context.Writer.WritePropertyName("Compression");
                context.Writer.WriteStringValue(requestObject.Compression);
            }

            if(requestObject.IsSetEnableDictionaryCompression())
            {
                context.Writer.WritePropertyName("EnableDictionaryCompression");
                context.Writer.WriteBooleanValue(requestObject.EnableDictionaryCompression.Value);
            }

            if(requestObject.IsSetMaxPaddingBytes())
            {
                context.Writer.WritePropertyName("MaxPaddingBytes");
                context.Writer.WriteNumberValue(requestObject.MaxPaddingBytes.Value);
            }

            if(requestObject.IsSetPageSizeBytes())
            {
                context.Writer.WritePropertyName("PageSizeBytes");
                context.Writer.WriteNumberValue(requestObject.PageSizeBytes.Value);
            }

            if(requestObject.IsSetWriterVersion())
            {
                context.Writer.WritePropertyName("WriterVersion");
                context.Writer.WriteStringValue(requestObject.WriterVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ParquetSerDeMarshaller Instance = new ParquetSerDeMarshaller();

    }
}