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
using ThirdParty.Json.LitJson;

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
                context.Writer.Write(requestObject.BlockSizeBytes.Value);
            }

            if(requestObject.IsSetBloomFilterColumns())
            {
                context.Writer.WritePropertyName("BloomFilterColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBloomFilterColumnsListValue in requestObject.BloomFilterColumns)
                {
                        context.Writer.Write(requestObjectBloomFilterColumnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBloomFilterFalsePositiveProbability())
            {
                context.Writer.WritePropertyName("BloomFilterFalsePositiveProbability");
<<<<<<< HEAD
                context.Writer.Write(requestObject.BloomFilterFalsePositiveProbability.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.BloomFilterFalsePositiveProbability))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.BloomFilterFalsePositiveProbability));
                }
                else
                {
                    context.Writer.Write(requestObject.BloomFilterFalsePositiveProbability);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetCompression())
            {
                context.Writer.WritePropertyName("Compression");
                context.Writer.Write(requestObject.Compression);
            }

            if(requestObject.IsSetDictionaryKeyThreshold())
            {
                context.Writer.WritePropertyName("DictionaryKeyThreshold");
<<<<<<< HEAD
                context.Writer.Write(requestObject.DictionaryKeyThreshold.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.DictionaryKeyThreshold))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.DictionaryKeyThreshold));
                }
                else
                {
                    context.Writer.Write(requestObject.DictionaryKeyThreshold);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetEnablePadding())
            {
                context.Writer.WritePropertyName("EnablePadding");
                context.Writer.Write(requestObject.EnablePadding.Value);
            }

            if(requestObject.IsSetFormatVersion())
            {
                context.Writer.WritePropertyName("FormatVersion");
                context.Writer.Write(requestObject.FormatVersion);
            }

            if(requestObject.IsSetPaddingTolerance())
            {
                context.Writer.WritePropertyName("PaddingTolerance");
<<<<<<< HEAD
                context.Writer.Write(requestObject.PaddingTolerance.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.PaddingTolerance))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.PaddingTolerance));
                }
                else
                {
                    context.Writer.Write(requestObject.PaddingTolerance);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetRowIndexStride())
            {
                context.Writer.WritePropertyName("RowIndexStride");
                context.Writer.Write(requestObject.RowIndexStride.Value);
            }

            if(requestObject.IsSetStripeSizeBytes())
            {
                context.Writer.WritePropertyName("StripeSizeBytes");
                context.Writer.Write(requestObject.StripeSizeBytes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OrcSerDeMarshaller Instance = new OrcSerDeMarshaller();

    }
}