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
    /// CreatePreset Request Marshaller
    /// </summary>       
    public class CreatePresetRequestMarshaller : IMarshaller<IRequest, CreatePresetRequest> 
    {
        public IRequest Marshall(CreatePresetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/2012-09-25/presets";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetAudio())
                {
                    writer.WritePropertyName("Audio");
                    writer.WriteObjectStart();
                    if(publicRequest.Audio.IsSetBitRate())
                    {
                        writer.WritePropertyName("BitRate");
                        writer.Write(publicRequest.Audio.BitRate);
                    }

                    if(publicRequest.Audio.IsSetChannels())
                    {
                        writer.WritePropertyName("Channels");
                        writer.Write(publicRequest.Audio.Channels);
                    }

                    if(publicRequest.Audio.IsSetCodec())
                    {
                        writer.WritePropertyName("Codec");
                        writer.Write(publicRequest.Audio.Codec);
                    }

                    if(publicRequest.Audio.IsSetCodecOptions())
                    {
                        writer.WritePropertyName("CodecOptions");
                        writer.WriteObjectStart();
                        if(publicRequest.Audio.CodecOptions.IsSetProfile())
                        {
                            writer.WritePropertyName("Profile");
                            writer.Write(publicRequest.Audio.CodecOptions.Profile);
                        }

                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.Audio.IsSetSampleRate())
                    {
                        writer.WritePropertyName("SampleRate");
                        writer.Write(publicRequest.Audio.SampleRate);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetContainer())
                {
                    writer.WritePropertyName("Container");
                    writer.Write(publicRequest.Container);
                }

                if(publicRequest.IsSetDescription())
                {
                    writer.WritePropertyName("Description");
                    writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetName())
                {
                    writer.WritePropertyName("Name");
                    writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetThumbnails())
                {
                    writer.WritePropertyName("Thumbnails");
                    writer.WriteObjectStart();
                    if(publicRequest.Thumbnails.IsSetAspectRatio())
                    {
                        writer.WritePropertyName("AspectRatio");
                        writer.Write(publicRequest.Thumbnails.AspectRatio);
                    }

                    if(publicRequest.Thumbnails.IsSetFormat())
                    {
                        writer.WritePropertyName("Format");
                        writer.Write(publicRequest.Thumbnails.Format);
                    }

                    if(publicRequest.Thumbnails.IsSetInterval())
                    {
                        writer.WritePropertyName("Interval");
                        writer.Write(publicRequest.Thumbnails.Interval);
                    }

                    if(publicRequest.Thumbnails.IsSetMaxHeight())
                    {
                        writer.WritePropertyName("MaxHeight");
                        writer.Write(publicRequest.Thumbnails.MaxHeight);
                    }

                    if(publicRequest.Thumbnails.IsSetMaxWidth())
                    {
                        writer.WritePropertyName("MaxWidth");
                        writer.Write(publicRequest.Thumbnails.MaxWidth);
                    }

                    if(publicRequest.Thumbnails.IsSetPaddingPolicy())
                    {
                        writer.WritePropertyName("PaddingPolicy");
                        writer.Write(publicRequest.Thumbnails.PaddingPolicy);
                    }

                    if(publicRequest.Thumbnails.IsSetResolution())
                    {
                        writer.WritePropertyName("Resolution");
                        writer.Write(publicRequest.Thumbnails.Resolution);
                    }

                    if(publicRequest.Thumbnails.IsSetSizingPolicy())
                    {
                        writer.WritePropertyName("SizingPolicy");
                        writer.Write(publicRequest.Thumbnails.SizingPolicy);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVideo())
                {
                    writer.WritePropertyName("Video");
                    writer.WriteObjectStart();
                    if(publicRequest.Video.IsSetAspectRatio())
                    {
                        writer.WritePropertyName("AspectRatio");
                        writer.Write(publicRequest.Video.AspectRatio);
                    }

                    if(publicRequest.Video.IsSetBitRate())
                    {
                        writer.WritePropertyName("BitRate");
                        writer.Write(publicRequest.Video.BitRate);
                    }

                    if(publicRequest.Video.IsSetCodec())
                    {
                        writer.WritePropertyName("Codec");
                        writer.Write(publicRequest.Video.Codec);
                    }

                    if(publicRequest.Video.IsSetCodecOptions())
                    {
                        writer.WritePropertyName("CodecOptions");
                        writer.WriteObjectStart();
                        foreach (var publicRequestVideoCodecOptionsKvp in publicRequest.Video.CodecOptions)
                        {
                            writer.WritePropertyName(publicRequestVideoCodecOptionsKvp.Key);
                            var publicRequestVideoCodecOptionsValue = publicRequestVideoCodecOptionsKvp.Value;

                            writer.Write(publicRequestVideoCodecOptionsValue);
                        }
                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.Video.IsSetDisplayAspectRatio())
                    {
                        writer.WritePropertyName("DisplayAspectRatio");
                        writer.Write(publicRequest.Video.DisplayAspectRatio);
                    }

                    if(publicRequest.Video.IsSetFixedGOP())
                    {
                        writer.WritePropertyName("FixedGOP");
                        writer.Write(publicRequest.Video.FixedGOP);
                    }

                    if(publicRequest.Video.IsSetFrameRate())
                    {
                        writer.WritePropertyName("FrameRate");
                        writer.Write(publicRequest.Video.FrameRate);
                    }

                    if(publicRequest.Video.IsSetKeyframesMaxDist())
                    {
                        writer.WritePropertyName("KeyframesMaxDist");
                        writer.Write(publicRequest.Video.KeyframesMaxDist);
                    }

                    if(publicRequest.Video.IsSetMaxFrameRate())
                    {
                        writer.WritePropertyName("MaxFrameRate");
                        writer.Write(publicRequest.Video.MaxFrameRate);
                    }

                    if(publicRequest.Video.IsSetMaxHeight())
                    {
                        writer.WritePropertyName("MaxHeight");
                        writer.Write(publicRequest.Video.MaxHeight);
                    }

                    if(publicRequest.Video.IsSetMaxWidth())
                    {
                        writer.WritePropertyName("MaxWidth");
                        writer.Write(publicRequest.Video.MaxWidth);
                    }

                    if(publicRequest.Video.IsSetPaddingPolicy())
                    {
                        writer.WritePropertyName("PaddingPolicy");
                        writer.Write(publicRequest.Video.PaddingPolicy);
                    }

                    if(publicRequest.Video.IsSetResolution())
                    {
                        writer.WritePropertyName("Resolution");
                        writer.Write(publicRequest.Video.Resolution);
                    }

                    if(publicRequest.Video.IsSetSizingPolicy())
                    {
                        writer.WritePropertyName("SizingPolicy");
                        writer.Write(publicRequest.Video.SizingPolicy);
                    }

                    if(publicRequest.Video.IsSetWatermarks())
                    {
                        writer.WritePropertyName("Watermarks");
                        writer.WriteArrayStart();
                        foreach(var publicRequestVideoWatermarksListValue in publicRequest.Video.Watermarks)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestVideoWatermarksListValue.IsSetHorizontalAlign())
                            {
                                writer.WritePropertyName("HorizontalAlign");
                                writer.Write(publicRequestVideoWatermarksListValue.HorizontalAlign);
                            }

                            if(publicRequestVideoWatermarksListValue.IsSetHorizontalOffset())
                            {
                                writer.WritePropertyName("HorizontalOffset");
                                writer.Write(publicRequestVideoWatermarksListValue.HorizontalOffset);
                            }

                            if(publicRequestVideoWatermarksListValue.IsSetId())
                            {
                                writer.WritePropertyName("Id");
                                writer.Write(publicRequestVideoWatermarksListValue.Id);
                            }

                            if(publicRequestVideoWatermarksListValue.IsSetMaxHeight())
                            {
                                writer.WritePropertyName("MaxHeight");
                                writer.Write(publicRequestVideoWatermarksListValue.MaxHeight);
                            }

                            if(publicRequestVideoWatermarksListValue.IsSetMaxWidth())
                            {
                                writer.WritePropertyName("MaxWidth");
                                writer.Write(publicRequestVideoWatermarksListValue.MaxWidth);
                            }

                            if(publicRequestVideoWatermarksListValue.IsSetOpacity())
                            {
                                writer.WritePropertyName("Opacity");
                                writer.Write(publicRequestVideoWatermarksListValue.Opacity);
                            }

                            if(publicRequestVideoWatermarksListValue.IsSetSizingPolicy())
                            {
                                writer.WritePropertyName("SizingPolicy");
                                writer.Write(publicRequestVideoWatermarksListValue.SizingPolicy);
                            }

                            if(publicRequestVideoWatermarksListValue.IsSetTarget())
                            {
                                writer.WritePropertyName("Target");
                                writer.Write(publicRequestVideoWatermarksListValue.Target);
                            }

                            if(publicRequestVideoWatermarksListValue.IsSetVerticalAlign())
                            {
                                writer.WritePropertyName("VerticalAlign");
                                writer.Write(publicRequestVideoWatermarksListValue.VerticalAlign);
                            }

                            if(publicRequestVideoWatermarksListValue.IsSetVerticalOffset())
                            {
                                writer.WritePropertyName("VerticalOffset");
                                writer.Write(publicRequestVideoWatermarksListValue.VerticalOffset);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}