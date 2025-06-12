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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Overlay one or more videos on top of your input video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/video-overlays.html
    /// </summary>
    public partial class VideoOverlay
    {
        private VideoOverlayCrop _crop;
        private string _endTimecode;
        private VideoOverlayPosition _initialPosition;
        private VideoOverlayInput _input;
        private VideoOverlayPlayBackMode _playback;
        private string _startTimecode;
        private List<VideoOverlayTransition> _transitions = AWSConfigs.InitializeCollections ? new List<VideoOverlayTransition>() : null;

        /// <summary>
        /// Gets and sets the property Crop. Specify a rectangle of content to crop and use from
        /// your video overlay's input video. When you do, MediaConvert uses the cropped dimensions
        /// that you specify under X offset, Y offset, Width, and Height.
        /// </summary>
        public VideoOverlayCrop Crop
        {
            get { return this._crop; }
            set { this._crop = value; }
        }

        // Check to see if Crop property is set
        internal bool IsSetCrop()
        {
            return this._crop != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimecode. Enter the end timecode in the base input video
        /// for this overlay. Your overlay will be active through this frame. To display your
        /// video overlay for the duration of the base input video: Leave blank. Use the format
        /// HH:MM:SS:FF or HH:MM:SS;FF, where HH is the hour, MM is the minute, SS isthe second,
        /// and FF is the frame number. When entering this value, take into account your choice
        /// for the base input video's timecode source. For example, if you have embedded timecodes
        /// that start at 01:00:00:00 and you want your overlay to end ten minutes into the video,
        /// enter 01:10:00:00.
        /// </summary>
        public string EndTimecode
        {
            get { return this._endTimecode; }
            set { this._endTimecode = value; }
        }

        // Check to see if EndTimecode property is set
        internal bool IsSetEndTimecode()
        {
            return this._endTimecode != null;
        }

        /// <summary>
        /// Gets and sets the property InitialPosition. Specify the Initial position of your video
        /// overlay. To specify the Initial position of your video overlay, including distance
        /// from the left or top edge of the base input video's frame, or size: Enter a value
        /// for X position, Y position, Width, or Height. To use the full frame of the base input
        /// video: Leave blank.
        /// </summary>
        public VideoOverlayPosition InitialPosition
        {
            get { return this._initialPosition; }
            set { this._initialPosition = value; }
        }

        // Check to see if InitialPosition property is set
        internal bool IsSetInitialPosition()
        {
            return this._initialPosition != null;
        }

        /// <summary>
        /// Gets and sets the property Input. Input settings for Video overlay. You can include
        /// one or more video overlays in sequence at different times that you specify.
        /// </summary>
        public VideoOverlayInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property Playback. Specify whether your video overlay repeats or
        /// plays only once. To repeat your video overlay on a loop: Keep the default value, Repeat.
        /// Your overlay will repeat for the duration of the base input video. To playback your
        /// video overlay only once: Choose Once. With either option, you can end playback at
        /// a time that you specify by entering a value for End timecode.
        /// </summary>
        public VideoOverlayPlayBackMode Playback
        {
            get { return this._playback; }
            set { this._playback = value; }
        }

        // Check to see if Playback property is set
        internal bool IsSetPlayback()
        {
            return this._playback != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimecode. Enter the start timecode in the base input
        /// video for this overlay. Your overlay will be active starting with this frame. To display
        /// your video overlay starting at the beginning of the base input video: Leave blank.
        /// Use the format HH:MM:SS:FF or HH:MM:SS;FF, where HH is the hour, MM is the minute,
        /// SS is the second, and FF is the frame number. When entering this value, take into
        /// account your choice for the base input video's timecode source. For example, if you
        /// have embedded timecodes that start at 01:00:00:00 and you want your overlay to begin
        /// five minutes into the video, enter 01:05:00:00.
        /// </summary>
        public string StartTimecode
        {
            get { return this._startTimecode; }
            set { this._startTimecode = value; }
        }

        // Check to see if StartTimecode property is set
        internal bool IsSetStartTimecode()
        {
            return this._startTimecode != null;
        }

        /// <summary>
        /// Gets and sets the property Transitions. Specify one or more transitions for your video
        /// overlay. Use Transitions to reposition or resize your overlay over time. To use the
        /// same position and size for the duration of your video overlay: Leave blank. To specify
        /// a Transition: Enter a value for Start timecode, End Timecode, X Position, Y Position,
        /// Width, or Height.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VideoOverlayTransition> Transitions
        {
            get { return this._transitions; }
            set { this._transitions = value; }
        }

        // Check to see if Transitions property is set
        internal bool IsSetTransitions()
        {
            return this._transitions != null && (this._transitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}