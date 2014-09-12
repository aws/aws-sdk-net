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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AudioParameters Marshaller
    /// </summary>       
    public class AudioParametersMarshaller : IRequestMarshaller<AudioParameters, JsonMarshallerContext> 
    {
        public void Marshall(AudioParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBitRate())
            {
                context.Writer.WritePropertyName("BitRate");
                context.Writer.Write(requestObject.BitRate);
            }

            if(requestObject.IsSetChannels())
            {
                context.Writer.WritePropertyName("Channels");
                context.Writer.Write(requestObject.Channels);
            }

            if(requestObject.IsSetCodec())
            {
                context.Writer.WritePropertyName("Codec");
                context.Writer.Write(requestObject.Codec);
            }

            if(requestObject.IsSetCodecOptions())
            {
                context.Writer.WritePropertyName("CodecOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AudioCodecOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CodecOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("SampleRate");
                context.Writer.Write(requestObject.SampleRate);
            }

        }

        public readonly static AudioParametersMarshaller Instance = new AudioParametersMarshaller();

    }
}