/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Create Job Request Marshaller
    /// </summary>       
    internal class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> 
    {
        

        public IRequest Marshall(CreateJobRequest createJobRequest) 
        {

            IRequest request = new DefaultRequest(createJobRequest, "AmazonElasticTranscoder");
            string target = "EtsCustomerService.CreateJob";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.HttpMethod = "POST";
              
            string uriResourcePath = "2012-09-25/jobs"; 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (createJobRequest != null && createJobRequest.IsSetPipelineId()) 
                {
                    writer.WritePropertyName("PipelineId");
                    writer.Write(createJobRequest.PipelineId);
                }

                if (createJobRequest != null) 
                {
                    JobInput input = createJobRequest.Input;
                    if (input != null)
                    {
                        writer.WritePropertyName("Input");
                        writer.WriteObjectStart();
                        if (input != null && input.IsSetKey()) 
                        {
                            writer.WritePropertyName("Key");
                            writer.Write(input.Key);
                        }
                        if (input != null && input.IsSetFrameRate()) 
                        {
                            writer.WritePropertyName("FrameRate");
                            writer.Write(input.FrameRate);
                        }
                        if (input != null && input.IsSetResolution()) 
                        {
                            writer.WritePropertyName("Resolution");
                            writer.Write(input.Resolution);
                        }
                        if (input != null && input.IsSetAspectRatio()) 
                        {
                            writer.WritePropertyName("AspectRatio");
                            writer.Write(input.AspectRatio);
                        }
                        if (input != null && input.IsSetInterlaced()) 
                        {
                            writer.WritePropertyName("Interlaced");
                            writer.Write(input.Interlaced);
                        }
                        if (input != null && input.IsSetContainer()) 
                        {
                            writer.WritePropertyName("Container");
                            writer.Write(input.Container);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (createJobRequest != null) 
                {
                    CreateJobOutput output = createJobRequest.Output;
                    if (output != null)
                    {
                        writer.WritePropertyName("Output");
                        writer.WriteObjectStart();
                        if (output != null && output.IsSetKey()) 
                        {
                            writer.WritePropertyName("Key");
                            writer.Write(output.Key);
                        }
                        if (output != null && output.IsSetThumbnailPattern()) 
                        {
                            writer.WritePropertyName("ThumbnailPattern");
                            writer.Write(output.ThumbnailPattern);
                        }
                        if (output != null && output.IsSetRotate()) 
                        {
                            writer.WritePropertyName("Rotate");
                            writer.Write(output.Rotate);
                        }
                        if (output != null && output.IsSetPresetId()) 
                        {
                            writer.WritePropertyName("PresetId");
                            writer.Write(output.PresetId);
                        }
                        if (output != null && output.IsSetSegmentDuration()) 
                        {
                            writer.WritePropertyName("SegmentDuration");
                            writer.Write(output.SegmentDuration);
                        }

                        if (output != null && output.Watermarks != null && output.Watermarks.Count > 0)
                        {
                            List<JobWatermark> watermarksList = output.Watermarks;
                            writer.WritePropertyName("Watermarks");
                            writer.WriteArrayStart();

                            foreach (JobWatermark watermarksListValue in watermarksList) 
                            {
                                writer.WriteObjectStart();
                                if (watermarksListValue != null && watermarksListValue.IsSetPresetWatermarkId()) 
                                {
                                    writer.WritePropertyName("PresetWatermarkId");
                                    writer.Write(watermarksListValue.PresetWatermarkId);
                                }
                                if (watermarksListValue != null && watermarksListValue.IsSetInputKey()) 
                                {
                                    writer.WritePropertyName("InputKey");
                                    writer.Write(watermarksListValue.InputKey);
                                }
                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }

                        if (output != null) 
                        {
                            JobAlbumArt albumArt = output.AlbumArt;
                            if (albumArt != null)
                            {
                                writer.WritePropertyName("AlbumArt");
                                writer.WriteObjectStart();
                                if (albumArt != null && albumArt.IsSetMergePolicy()) 
                                {
                                    writer.WritePropertyName("MergePolicy");
                                    writer.Write(albumArt.MergePolicy);
                                }

                                if (albumArt != null && albumArt.Artwork != null && albumArt.Artwork.Count > 0)
                                {
                                    List<Artwork> artworkList = albumArt.Artwork;
                                    writer.WritePropertyName("Artwork");
                                    writer.WriteArrayStart();

                                    foreach (Artwork artworkListValue in artworkList) 
                                    {
                                        writer.WriteObjectStart();
                                        if (artworkListValue != null && artworkListValue.IsSetInputKey()) 
                                        {
                                            writer.WritePropertyName("InputKey");
                                            writer.Write(artworkListValue.InputKey);
                                        }
                                        if (artworkListValue != null && artworkListValue.IsSetMaxWidth()) 
                                        {
                                            writer.WritePropertyName("MaxWidth");
                                            writer.Write(artworkListValue.MaxWidth);
                                        }
                                        if (artworkListValue != null && artworkListValue.IsSetMaxHeight()) 
                                        {
                                            writer.WritePropertyName("MaxHeight");
                                            writer.Write(artworkListValue.MaxHeight);
                                        }
                                        if (artworkListValue != null && artworkListValue.IsSetSizingPolicy()) 
                                        {
                                            writer.WritePropertyName("SizingPolicy");
                                            writer.Write(artworkListValue.SizingPolicy);
                                        }
                                        if (artworkListValue != null && artworkListValue.IsSetPaddingPolicy()) 
                                        {
                                            writer.WritePropertyName("PaddingPolicy");
                                            writer.Write(artworkListValue.PaddingPolicy);
                                        }
                                        if (artworkListValue != null && artworkListValue.IsSetAlbumArtFormat()) 
                                        {
                                            writer.WritePropertyName("AlbumArtFormat");
                                            writer.Write(artworkListValue.AlbumArtFormat);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                    writer.WriteArrayEnd();
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (output != null && output.Composition != null && output.Composition.Count > 0)
                        {
                            List<Clip> compositionList = output.Composition;
                            writer.WritePropertyName("Composition");
                            writer.WriteArrayStart();

                            foreach (Clip compositionListValue in compositionList) 
                            {
                                writer.WriteObjectStart();

                                if (compositionListValue != null) 
                                {
                                    TimeSpan timeSpan = compositionListValue.TimeSpan;
                                    if (timeSpan != null)
                                    {
                                        writer.WritePropertyName("TimeSpan");
                                        writer.WriteObjectStart();
                                        if (timeSpan != null && timeSpan.IsSetStartTime()) 
                                        {
                                            writer.WritePropertyName("StartTime");
                                            writer.Write(timeSpan.StartTime);
                                        }
                                        if (timeSpan != null && timeSpan.IsSetDuration()) 
                                        {
                                            writer.WritePropertyName("Duration");
                                            writer.Write(timeSpan.Duration);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                }
                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (createJobRequest != null && createJobRequest.Outputs != null && createJobRequest.Outputs.Count > 0)
                {
                    List<CreateJobOutput> outputsList = createJobRequest.Outputs;
                    writer.WritePropertyName("Outputs");
                    writer.WriteArrayStart();

                    foreach (CreateJobOutput outputsListValue in outputsList) 
                    {
                        writer.WriteObjectStart();
                        if (outputsListValue != null && outputsListValue.IsSetKey()) 
                        {
                            writer.WritePropertyName("Key");
                            writer.Write(outputsListValue.Key);
                        }
                        if (outputsListValue != null && outputsListValue.IsSetThumbnailPattern()) 
                        {
                            writer.WritePropertyName("ThumbnailPattern");
                            writer.Write(outputsListValue.ThumbnailPattern);
                        }
                        if (outputsListValue != null && outputsListValue.IsSetRotate()) 
                        {
                            writer.WritePropertyName("Rotate");
                            writer.Write(outputsListValue.Rotate);
                        }
                        if (outputsListValue != null && outputsListValue.IsSetPresetId()) 
                        {
                            writer.WritePropertyName("PresetId");
                            writer.Write(outputsListValue.PresetId);
                        }
                        if (outputsListValue != null && outputsListValue.IsSetSegmentDuration()) 
                        {
                            writer.WritePropertyName("SegmentDuration");
                            writer.Write(outputsListValue.SegmentDuration);
                        }

                        if (outputsListValue != null && outputsListValue.Watermarks != null && outputsListValue.Watermarks.Count > 0)
                        {
                            List<JobWatermark> watermarksList = outputsListValue.Watermarks;
                            writer.WritePropertyName("Watermarks");
                            writer.WriteArrayStart();

                            foreach (JobWatermark watermarksListValue in watermarksList) 
                            {
                                writer.WriteObjectStart();
                                if (watermarksListValue != null && watermarksListValue.IsSetPresetWatermarkId()) 
                                {
                                    writer.WritePropertyName("PresetWatermarkId");
                                    writer.Write(watermarksListValue.PresetWatermarkId);
                                }
                                if (watermarksListValue != null && watermarksListValue.IsSetInputKey()) 
                                {
                                    writer.WritePropertyName("InputKey");
                                    writer.Write(watermarksListValue.InputKey);
                                }
                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }

                        if (outputsListValue != null) 
                        {
                            JobAlbumArt albumArt = outputsListValue.AlbumArt;
                            if (albumArt != null)
                            {
                                writer.WritePropertyName("AlbumArt");
                                writer.WriteObjectStart();
                                if (albumArt != null && albumArt.IsSetMergePolicy()) 
                                {
                                    writer.WritePropertyName("MergePolicy");
                                    writer.Write(albumArt.MergePolicy);
                                }

                                if (albumArt != null && albumArt.Artwork != null && albumArt.Artwork.Count > 0)
                                {
                                    List<Artwork> artworkList = albumArt.Artwork;
                                    writer.WritePropertyName("Artwork");
                                    writer.WriteArrayStart();

                                    foreach (Artwork artworkListValue in artworkList) 
                                    {
                                        writer.WriteObjectStart();
                                        if (artworkListValue != null && artworkListValue.IsSetInputKey()) 
                                        {
                                            writer.WritePropertyName("InputKey");
                                            writer.Write(artworkListValue.InputKey);
                                        }
                                        if (artworkListValue != null && artworkListValue.IsSetMaxWidth()) 
                                        {
                                            writer.WritePropertyName("MaxWidth");
                                            writer.Write(artworkListValue.MaxWidth);
                                        }
                                        if (artworkListValue != null && artworkListValue.IsSetMaxHeight()) 
                                        {
                                            writer.WritePropertyName("MaxHeight");
                                            writer.Write(artworkListValue.MaxHeight);
                                        }
                                        if (artworkListValue != null && artworkListValue.IsSetSizingPolicy()) 
                                        {
                                            writer.WritePropertyName("SizingPolicy");
                                            writer.Write(artworkListValue.SizingPolicy);
                                        }
                                        if (artworkListValue != null && artworkListValue.IsSetPaddingPolicy()) 
                                        {
                                            writer.WritePropertyName("PaddingPolicy");
                                            writer.Write(artworkListValue.PaddingPolicy);
                                        }
                                        if (artworkListValue != null && artworkListValue.IsSetAlbumArtFormat()) 
                                        {
                                            writer.WritePropertyName("AlbumArtFormat");
                                            writer.Write(artworkListValue.AlbumArtFormat);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                    writer.WriteArrayEnd();
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (outputsListValue != null && outputsListValue.Composition != null && outputsListValue.Composition.Count > 0)
                        {
                            List<Clip> compositionList = outputsListValue.Composition;
                            writer.WritePropertyName("Composition");
                            writer.WriteArrayStart();

                            foreach (Clip compositionListValue in compositionList) 
                            {
                                writer.WriteObjectStart();

                                if (compositionListValue != null) 
                                {
                                    TimeSpan timeSpan = compositionListValue.TimeSpan;
                                    if (timeSpan != null)
                                    {
                                        writer.WritePropertyName("TimeSpan");
                                        writer.WriteObjectStart();
                                        if (timeSpan != null && timeSpan.IsSetStartTime()) 
                                        {
                                            writer.WritePropertyName("StartTime");
                                            writer.Write(timeSpan.StartTime);
                                        }
                                        if (timeSpan != null && timeSpan.IsSetDuration()) 
                                        {
                                            writer.WritePropertyName("Duration");
                                            writer.Write(timeSpan.Duration);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                }
                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }
                if (createJobRequest != null && createJobRequest.IsSetOutputKeyPrefix()) 
                {
                    writer.WritePropertyName("OutputKeyPrefix");
                    writer.Write(createJobRequest.OutputKeyPrefix);
                }

                if (createJobRequest != null && createJobRequest.Playlists != null && createJobRequest.Playlists.Count > 0)
                {
                    List<CreateJobPlaylist> playlistsList = createJobRequest.Playlists;
                    writer.WritePropertyName("Playlists");
                    writer.WriteArrayStart();

                    foreach (CreateJobPlaylist playlistsListValue in playlistsList) 
                    {
                        writer.WriteObjectStart();
                        if (playlistsListValue != null && playlistsListValue.IsSetName()) 
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(playlistsListValue.Name);
                        }
                        if (playlistsListValue != null && playlistsListValue.IsSetFormat()) 
                        {
                            writer.WritePropertyName("Format");
                            writer.Write(playlistsListValue.Format);
                        }

                        if (playlistsListValue != null && playlistsListValue.OutputKeys != null && playlistsListValue.OutputKeys.Count > 0) 
                        {
                            List<string> outputKeysList = playlistsListValue.OutputKeys;
                            writer.WritePropertyName("OutputKeys");
                            writer.WriteArrayStart();

                            foreach (string outputKeysListValue in outputKeysList) 
                            { 
                                writer.Write(StringUtils.FromString(outputKeysListValue));
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
