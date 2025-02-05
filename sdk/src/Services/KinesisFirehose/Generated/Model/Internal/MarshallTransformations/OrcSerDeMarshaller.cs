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
    /// OrcSerDe Marshaller
    /// </summary>
    public class OrcSerDeMarshaller : IRequestMarshaller<OrcSerDe, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OrcSerDe requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlockSizeBytes())
            {
                context.Writer.WritePropertyName("BlockSizeBytes");
                context.Writer.WriteNumberValue(requestObject.BlockSizeBytes.Value);
            }

            if(requestObject.IsSetBloomFilterColumns())
            {
                context.Writer.WritePropertyName("BloomFilterColumns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBloomFilterColumnsListValue in requestObject.BloomFilterColumns)
                {
                        context.Writer.WriteStringValue(requestObjectBloomFilterColumnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBloomFilterFalsePositiveProbability())
            {
                context.Writer.WritePropertyName("BloomFilterFalsePositiveProbability");
                if(StringUtils.IsSpecialDoubleValue(requestObject.BloomFilterFalsePositiveProbability.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.BloomFilterFalsePositiveProbability.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.BloomFilterFalsePositiveProbability.Value);
                }
            }

            if(requestObject.IsSetCompression())
            {
                context.Writer.WritePropertyName("Compression");
                context.Writer.WriteStringValue(requestObject.Compression);
            }

            if(requestObject.IsSetDictionaryKeyThreshold())
            {
                context.Writer.WritePropertyName("DictionaryKeyThreshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.DictionaryKeyThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.DictionaryKeyThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.DictionaryKeyThreshold.Value);
                }
            }

            if(requestObject.IsSetEnablePadding())
            {
                context.Writer.WritePropertyName("EnablePadding");
                context.Writer.WriteBooleanValue(requestObject.EnablePadding.Value);
            }

            if(requestObject.IsSetFormatVersion())
            {
                context.Writer.WritePropertyName("FormatVersion");
                context.Writer.WriteStringValue(requestObject.FormatVersion);
            }

            if(requestObject.IsSetPaddingTolerance())
            {
                context.Writer.WritePropertyName("PaddingTolerance");
                if(StringUtils.IsSpecialDoubleValue(requestObject.PaddingTolerance.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.PaddingTolerance.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.PaddingTolerance.Value);
                }
            }

            if(requestObject.IsSetRowIndexStride())
            {
                context.Writer.WritePropertyName("RowIndexStride");
                context.Writer.WriteNumberValue(requestObject.RowIndexStride.Value);
            }

            if(requestObject.IsSetStripeSizeBytes())
            {
                context.Writer.WritePropertyName("StripeSizeBytes");
                context.Writer.WriteNumberValue(requestObject.StripeSizeBytes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OrcSerDeMarshaller Instance = new OrcSerDeMarshaller();

    }
}