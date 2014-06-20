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
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> 
    {
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/2012-09-25/jobs";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetInput())
                {
                    writer.WritePropertyName("Input");
                    writer.WriteObjectStart();
                    if(publicRequest.Input.IsSetAspectRatio())
                    {
                        writer.WritePropertyName("AspectRatio");
                        writer.Write(publicRequest.Input.AspectRatio);
                    }

                    if(publicRequest.Input.IsSetContainer())
                    {
                        writer.WritePropertyName("Container");
                        writer.Write(publicRequest.Input.Container);
                    }

                    if(publicRequest.Input.IsSetFrameRate())
                    {
                        writer.WritePropertyName("FrameRate");
                        writer.Write(publicRequest.Input.FrameRate);
                    }

                    if(publicRequest.Input.IsSetInterlaced())
                    {
                        writer.WritePropertyName("Interlaced");
                        writer.Write(publicRequest.Input.Interlaced);
                    }

                    if(publicRequest.Input.IsSetKey())
                    {
                        writer.WritePropertyName("Key");
                        writer.Write(publicRequest.Input.Key);
                    }

                    if(publicRequest.Input.IsSetResolution())
                    {
                        writer.WritePropertyName("Resolution");
                        writer.Write(publicRequest.Input.Resolution);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutput())
                {
                    writer.WritePropertyName("Output");
                    writer.WriteObjectStart();
                    if(publicRequest.Output.IsSetAlbumArt())
                    {
                        writer.WritePropertyName("AlbumArt");
                        writer.WriteObjectStart();
                        if(publicRequest.Output.AlbumArt.IsSetArtwork())
                        {
                            writer.WritePropertyName("Artwork");
                            writer.WriteArrayStart();
                            foreach(var publicRequestOutputAlbumArtArtworkListValue in publicRequest.Output.AlbumArt.Artwork)
                            {
                                writer.WriteObjectStart();
                                if(publicRequestOutputAlbumArtArtworkListValue.IsSetAlbumArtFormat())
                                {
                                    writer.WritePropertyName("AlbumArtFormat");
                                    writer.Write(publicRequestOutputAlbumArtArtworkListValue.AlbumArtFormat);
                                }

                                if(publicRequestOutputAlbumArtArtworkListValue.IsSetInputKey())
                                {
                                    writer.WritePropertyName("InputKey");
                                    writer.Write(publicRequestOutputAlbumArtArtworkListValue.InputKey);
                                }

                                if(publicRequestOutputAlbumArtArtworkListValue.IsSetMaxHeight())
                                {
                                    writer.WritePropertyName("MaxHeight");
                                    writer.Write(publicRequestOutputAlbumArtArtworkListValue.MaxHeight);
                                }

                                if(publicRequestOutputAlbumArtArtworkListValue.IsSetMaxWidth())
                                {
                                    writer.WritePropertyName("MaxWidth");
                                    writer.Write(publicRequestOutputAlbumArtArtworkListValue.MaxWidth);
                                }

                                if(publicRequestOutputAlbumArtArtworkListValue.IsSetPaddingPolicy())
                                {
                                    writer.WritePropertyName("PaddingPolicy");
                                    writer.Write(publicRequestOutputAlbumArtArtworkListValue.PaddingPolicy);
                                }

                                if(publicRequestOutputAlbumArtArtworkListValue.IsSetSizingPolicy())
                                {
                                    writer.WritePropertyName("SizingPolicy");
                                    writer.Write(publicRequestOutputAlbumArtArtworkListValue.SizingPolicy);
                                }

                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }

                        if(publicRequest.Output.AlbumArt.IsSetMergePolicy())
                        {
                            writer.WritePropertyName("MergePolicy");
                            writer.Write(publicRequest.Output.AlbumArt.MergePolicy);
                        }

                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.Output.IsSetCaptions())
                    {
                        writer.WritePropertyName("Captions");
                        writer.WriteObjectStart();
                        if(publicRequest.Output.Captions.IsSetCaptionFormats())
                        {
                            writer.WritePropertyName("CaptionFormats");
                            writer.WriteArrayStart();
                            foreach(var publicRequestOutputCaptionsCaptionFormatsListValue in publicRequest.Output.Captions.CaptionFormats)
                            {
                                writer.WriteObjectStart();
                                if(publicRequestOutputCaptionsCaptionFormatsListValue.IsSetFormat())
                                {
                                    writer.WritePropertyName("Format");
                                    writer.Write(publicRequestOutputCaptionsCaptionFormatsListValue.Format);
                                }

                                if(publicRequestOutputCaptionsCaptionFormatsListValue.IsSetPattern())
                                {
                                    writer.WritePropertyName("Pattern");
                                    writer.Write(publicRequestOutputCaptionsCaptionFormatsListValue.Pattern);
                                }

                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }

                        if(publicRequest.Output.Captions.IsSetCaptionSources())
                        {
                            writer.WritePropertyName("CaptionSources");
                            writer.WriteArrayStart();
                            foreach(var publicRequestOutputCaptionsCaptionSourcesListValue in publicRequest.Output.Captions.CaptionSources)
                            {
                                writer.WriteObjectStart();
                                if(publicRequestOutputCaptionsCaptionSourcesListValue.IsSetKey())
                                {
                                    writer.WritePropertyName("Key");
                                    writer.Write(publicRequestOutputCaptionsCaptionSourcesListValue.Key);
                                }

                                if(publicRequestOutputCaptionsCaptionSourcesListValue.IsSetLabel())
                                {
                                    writer.WritePropertyName("Label");
                                    writer.Write(publicRequestOutputCaptionsCaptionSourcesListValue.Label);
                                }

                                if(publicRequestOutputCaptionsCaptionSourcesListValue.IsSetLanguage())
                                {
                                    writer.WritePropertyName("Language");
                                    writer.Write(publicRequestOutputCaptionsCaptionSourcesListValue.Language);
                                }

                                if(publicRequestOutputCaptionsCaptionSourcesListValue.IsSetTimeOffset())
                                {
                                    writer.WritePropertyName("TimeOffset");
                                    writer.Write(publicRequestOutputCaptionsCaptionSourcesListValue.TimeOffset);
                                }

                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }

                        if(publicRequest.Output.Captions.IsSetMergePolicy())
                        {
                            writer.WritePropertyName("MergePolicy");
                            writer.Write(publicRequest.Output.Captions.MergePolicy);
                        }

                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.Output.IsSetComposition())
                    {
                        writer.WritePropertyName("Composition");
                        writer.WriteArrayStart();
                        foreach(var publicRequestOutputCompositionListValue in publicRequest.Output.Composition)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestOutputCompositionListValue.IsSetTimeSpan())
                            {
                                writer.WritePropertyName("TimeSpan");
                                writer.WriteObjectStart();
                                if(publicRequestOutputCompositionListValue.TimeSpan.IsSetDuration())
                                {
                                    writer.WritePropertyName("Duration");
                                    writer.Write(publicRequestOutputCompositionListValue.TimeSpan.Duration);
                                }

                                if(publicRequestOutputCompositionListValue.TimeSpan.IsSetStartTime())
                                {
                                    writer.WritePropertyName("StartTime");
                                    writer.Write(publicRequestOutputCompositionListValue.TimeSpan.StartTime);
                                }

                                writer.WriteObjectEnd();
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.Output.IsSetKey())
                    {
                        writer.WritePropertyName("Key");
                        writer.Write(publicRequest.Output.Key);
                    }

                    if(publicRequest.Output.IsSetPresetId())
                    {
                        writer.WritePropertyName("PresetId");
                        writer.Write(publicRequest.Output.PresetId);
                    }

                    if(publicRequest.Output.IsSetRotate())
                    {
                        writer.WritePropertyName("Rotate");
                        writer.Write(publicRequest.Output.Rotate);
                    }

                    if(publicRequest.Output.IsSetSegmentDuration())
                    {
                        writer.WritePropertyName("SegmentDuration");
                        writer.Write(publicRequest.Output.SegmentDuration);
                    }

                    if(publicRequest.Output.IsSetThumbnailPattern())
                    {
                        writer.WritePropertyName("ThumbnailPattern");
                        writer.Write(publicRequest.Output.ThumbnailPattern);
                    }

                    if(publicRequest.Output.IsSetWatermarks())
                    {
                        writer.WritePropertyName("Watermarks");
                        writer.WriteArrayStart();
                        foreach(var publicRequestOutputWatermarksListValue in publicRequest.Output.Watermarks)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestOutputWatermarksListValue.IsSetInputKey())
                            {
                                writer.WritePropertyName("InputKey");
                                writer.Write(publicRequestOutputWatermarksListValue.InputKey);
                            }

                            if(publicRequestOutputWatermarksListValue.IsSetPresetWatermarkId())
                            {
                                writer.WritePropertyName("PresetWatermarkId");
                                writer.Write(publicRequestOutputWatermarksListValue.PresetWatermarkId);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputKeyPrefix())
                {
                    writer.WritePropertyName("OutputKeyPrefix");
                    writer.Write(publicRequest.OutputKeyPrefix);
                }

                if(publicRequest.IsSetOutputs())
                {
                    writer.WritePropertyName("Outputs");
                    writer.WriteArrayStart();
                    foreach(var publicRequestOutputsListValue in publicRequest.Outputs)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestOutputsListValue.IsSetAlbumArt())
                        {
                            writer.WritePropertyName("AlbumArt");
                            writer.WriteObjectStart();
                            if(publicRequestOutputsListValue.AlbumArt.IsSetArtwork())
                            {
                                writer.WritePropertyName("Artwork");
                                writer.WriteArrayStart();
                                foreach(var publicRequestOutputsListValueAlbumArtArtworkListValue in publicRequestOutputsListValue.AlbumArt.Artwork)
                                {
                                    writer.WriteObjectStart();
                                    if(publicRequestOutputsListValueAlbumArtArtworkListValue.IsSetAlbumArtFormat())
                                    {
                                        writer.WritePropertyName("AlbumArtFormat");
                                        writer.Write(publicRequestOutputsListValueAlbumArtArtworkListValue.AlbumArtFormat);
                                    }

                                    if(publicRequestOutputsListValueAlbumArtArtworkListValue.IsSetInputKey())
                                    {
                                        writer.WritePropertyName("InputKey");
                                        writer.Write(publicRequestOutputsListValueAlbumArtArtworkListValue.InputKey);
                                    }

                                    if(publicRequestOutputsListValueAlbumArtArtworkListValue.IsSetMaxHeight())
                                    {
                                        writer.WritePropertyName("MaxHeight");
                                        writer.Write(publicRequestOutputsListValueAlbumArtArtworkListValue.MaxHeight);
                                    }

                                    if(publicRequestOutputsListValueAlbumArtArtworkListValue.IsSetMaxWidth())
                                    {
                                        writer.WritePropertyName("MaxWidth");
                                        writer.Write(publicRequestOutputsListValueAlbumArtArtworkListValue.MaxWidth);
                                    }

                                    if(publicRequestOutputsListValueAlbumArtArtworkListValue.IsSetPaddingPolicy())
                                    {
                                        writer.WritePropertyName("PaddingPolicy");
                                        writer.Write(publicRequestOutputsListValueAlbumArtArtworkListValue.PaddingPolicy);
                                    }

                                    if(publicRequestOutputsListValueAlbumArtArtworkListValue.IsSetSizingPolicy())
                                    {
                                        writer.WritePropertyName("SizingPolicy");
                                        writer.Write(publicRequestOutputsListValueAlbumArtArtworkListValue.SizingPolicy);
                                    }

                                    writer.WriteObjectEnd();
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestOutputsListValue.AlbumArt.IsSetMergePolicy())
                            {
                                writer.WritePropertyName("MergePolicy");
                                writer.Write(publicRequestOutputsListValue.AlbumArt.MergePolicy);
                            }

                            writer.WriteObjectEnd();
                        }

                        if(publicRequestOutputsListValue.IsSetCaptions())
                        {
                            writer.WritePropertyName("Captions");
                            writer.WriteObjectStart();
                            if(publicRequestOutputsListValue.Captions.IsSetCaptionFormats())
                            {
                                writer.WritePropertyName("CaptionFormats");
                                writer.WriteArrayStart();
                                foreach(var publicRequestOutputsListValueCaptionsCaptionFormatsListValue in publicRequestOutputsListValue.Captions.CaptionFormats)
                                {
                                    writer.WriteObjectStart();
                                    if(publicRequestOutputsListValueCaptionsCaptionFormatsListValue.IsSetFormat())
                                    {
                                        writer.WritePropertyName("Format");
                                        writer.Write(publicRequestOutputsListValueCaptionsCaptionFormatsListValue.Format);
                                    }

                                    if(publicRequestOutputsListValueCaptionsCaptionFormatsListValue.IsSetPattern())
                                    {
                                        writer.WritePropertyName("Pattern");
                                        writer.Write(publicRequestOutputsListValueCaptionsCaptionFormatsListValue.Pattern);
                                    }

                                    writer.WriteObjectEnd();
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestOutputsListValue.Captions.IsSetCaptionSources())
                            {
                                writer.WritePropertyName("CaptionSources");
                                writer.WriteArrayStart();
                                foreach(var publicRequestOutputsListValueCaptionsCaptionSourcesListValue in publicRequestOutputsListValue.Captions.CaptionSources)
                                {
                                    writer.WriteObjectStart();
                                    if(publicRequestOutputsListValueCaptionsCaptionSourcesListValue.IsSetKey())
                                    {
                                        writer.WritePropertyName("Key");
                                        writer.Write(publicRequestOutputsListValueCaptionsCaptionSourcesListValue.Key);
                                    }

                                    if(publicRequestOutputsListValueCaptionsCaptionSourcesListValue.IsSetLabel())
                                    {
                                        writer.WritePropertyName("Label");
                                        writer.Write(publicRequestOutputsListValueCaptionsCaptionSourcesListValue.Label);
                                    }

                                    if(publicRequestOutputsListValueCaptionsCaptionSourcesListValue.IsSetLanguage())
                                    {
                                        writer.WritePropertyName("Language");
                                        writer.Write(publicRequestOutputsListValueCaptionsCaptionSourcesListValue.Language);
                                    }

                                    if(publicRequestOutputsListValueCaptionsCaptionSourcesListValue.IsSetTimeOffset())
                                    {
                                        writer.WritePropertyName("TimeOffset");
                                        writer.Write(publicRequestOutputsListValueCaptionsCaptionSourcesListValue.TimeOffset);
                                    }

                                    writer.WriteObjectEnd();
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestOutputsListValue.Captions.IsSetMergePolicy())
                            {
                                writer.WritePropertyName("MergePolicy");
                                writer.Write(publicRequestOutputsListValue.Captions.MergePolicy);
                            }

                            writer.WriteObjectEnd();
                        }

                        if(publicRequestOutputsListValue.IsSetComposition())
                        {
                            writer.WritePropertyName("Composition");
                            writer.WriteArrayStart();
                            foreach(var publicRequestOutputsListValueCompositionListValue in publicRequestOutputsListValue.Composition)
                            {
                                writer.WriteObjectStart();
                                if(publicRequestOutputsListValueCompositionListValue.IsSetTimeSpan())
                                {
                                    writer.WritePropertyName("TimeSpan");
                                    writer.WriteObjectStart();
                                    if(publicRequestOutputsListValueCompositionListValue.TimeSpan.IsSetDuration())
                                    {
                                        writer.WritePropertyName("Duration");
                                        writer.Write(publicRequestOutputsListValueCompositionListValue.TimeSpan.Duration);
                                    }

                                    if(publicRequestOutputsListValueCompositionListValue.TimeSpan.IsSetStartTime())
                                    {
                                        writer.WritePropertyName("StartTime");
                                        writer.Write(publicRequestOutputsListValueCompositionListValue.TimeSpan.StartTime);
                                    }

                                    writer.WriteObjectEnd();
                                }

                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }

                        if(publicRequestOutputsListValue.IsSetKey())
                        {
                            writer.WritePropertyName("Key");
                            writer.Write(publicRequestOutputsListValue.Key);
                        }

                        if(publicRequestOutputsListValue.IsSetPresetId())
                        {
                            writer.WritePropertyName("PresetId");
                            writer.Write(publicRequestOutputsListValue.PresetId);
                        }

                        if(publicRequestOutputsListValue.IsSetRotate())
                        {
                            writer.WritePropertyName("Rotate");
                            writer.Write(publicRequestOutputsListValue.Rotate);
                        }

                        if(publicRequestOutputsListValue.IsSetSegmentDuration())
                        {
                            writer.WritePropertyName("SegmentDuration");
                            writer.Write(publicRequestOutputsListValue.SegmentDuration);
                        }

                        if(publicRequestOutputsListValue.IsSetThumbnailPattern())
                        {
                            writer.WritePropertyName("ThumbnailPattern");
                            writer.Write(publicRequestOutputsListValue.ThumbnailPattern);
                        }

                        if(publicRequestOutputsListValue.IsSetWatermarks())
                        {
                            writer.WritePropertyName("Watermarks");
                            writer.WriteArrayStart();
                            foreach(var publicRequestOutputsListValueWatermarksListValue in publicRequestOutputsListValue.Watermarks)
                            {
                                writer.WriteObjectStart();
                                if(publicRequestOutputsListValueWatermarksListValue.IsSetInputKey())
                                {
                                    writer.WritePropertyName("InputKey");
                                    writer.Write(publicRequestOutputsListValueWatermarksListValue.InputKey);
                                }

                                if(publicRequestOutputsListValueWatermarksListValue.IsSetPresetWatermarkId())
                                {
                                    writer.WritePropertyName("PresetWatermarkId");
                                    writer.Write(publicRequestOutputsListValueWatermarksListValue.PresetWatermarkId);
                                }

                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPipelineId())
                {
                    writer.WritePropertyName("PipelineId");
                    writer.Write(publicRequest.PipelineId);
                }

                if(publicRequest.IsSetPlaylists())
                {
                    writer.WritePropertyName("Playlists");
                    writer.WriteArrayStart();
                    foreach(var publicRequestPlaylistsListValue in publicRequest.Playlists)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestPlaylistsListValue.IsSetFormat())
                        {
                            writer.WritePropertyName("Format");
                            writer.Write(publicRequestPlaylistsListValue.Format);
                        }

                        if(publicRequestPlaylistsListValue.IsSetName())
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(publicRequestPlaylistsListValue.Name);
                        }

                        if(publicRequestPlaylistsListValue.IsSetOutputKeys())
                        {
                            writer.WritePropertyName("OutputKeys");
                            writer.WriteArrayStart();
                            foreach(var publicRequestPlaylistsListValueOutputKeysListValue in publicRequestPlaylistsListValue.OutputKeys)
                            {
                                writer.Write(publicRequestPlaylistsListValueOutputKeysListValue);
                            }
                            writer.WriteArrayEnd();
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}