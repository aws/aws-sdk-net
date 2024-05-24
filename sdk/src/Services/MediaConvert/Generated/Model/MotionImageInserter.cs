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
    /// Overlay motion graphics on top of your video. The motion graphics that you specify
    /// here appear on all outputs in all output groups. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/motion-graphic-overlay.html.
    /// </summary>
    public partial class MotionImageInserter
    {
        private MotionImageInsertionFramerate _framerate;
        private string _input;
        private MotionImageInsertionMode _insertionMode;
        private MotionImageInsertionOffset _offset;
        private MotionImagePlayback _playback;
        private string _startTime;

        /// <summary>
        /// Gets and sets the property Framerate. If your motion graphic asset is a .mov file,
        /// keep this setting unspecified. If your motion graphic asset is a series of .png files,
        /// specify the frame rate of the overlay in frames per second, as a fraction. For example,
        /// specify 24 fps as 24/1. Make sure that the number of images in your series matches
        /// the frame rate and your intended overlay duration. For example, if you want a 30-second
        /// overlay at 30 fps, you should have 900 .png images. This overlay frame rate doesn't
        /// need to match the frame rate of the underlying video.
        /// </summary>
        public MotionImageInsertionFramerate Framerate
        {
            get { return this._framerate; }
            set { this._framerate = value; }
        }

        // Check to see if Framerate property is set
        internal bool IsSetFramerate()
        {
            return this._framerate != null;
        }

        /// <summary>
        /// Gets and sets the property Input. Specify the .mov file or series of .png files that
        /// you want to overlay on your video. For .png files, provide the file name of the first
        /// file in the series. Make sure that the names of the .png files end with sequential
        /// numbers that specify the order that they are played in. For example, overlay_000.png,
        /// overlay_001.png, overlay_002.png, and so on. The sequence must start at zero, and
        /// each image file name must have the same number of digits. Pad your initial file names
        /// with enough zeros to complete the sequence. For example, if the first image is overlay_0.png,
        /// there can be only 10 images in the sequence, with the last image being overlay_9.png.
        /// But if the first image is overlay_00.png, there can be 100 images in the sequence.
        /// </summary>
        [AWSProperty(Min=14)]
        public string Input
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
        /// Gets and sets the property InsertionMode. Choose the type of motion graphic asset
        /// that you are providing for your overlay. You can choose either a .mov file or a series
        /// of .png files.
        /// </summary>
        public MotionImageInsertionMode InsertionMode
        {
            get { return this._insertionMode; }
            set { this._insertionMode = value; }
        }

        // Check to see if InsertionMode property is set
        internal bool IsSetInsertionMode()
        {
            return this._insertionMode != null;
        }

        /// <summary>
        /// Gets and sets the property Offset. Use Offset to specify the placement of your motion
        /// graphic overlay on the video frame. Specify in pixels, from the upper-left corner
        /// of the frame. If you don't specify an offset, the service scales your overlay to the
        /// full size of the frame. Otherwise, the service inserts the overlay at its native resolution
        /// and scales the size up or down with any video scaling.
        /// </summary>
        public MotionImageInsertionOffset Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset != null;
        }

        /// <summary>
        /// Gets and sets the property Playback. Specify whether your motion graphic overlay repeats
        /// on a loop or plays only once.
        /// </summary>
        public MotionImagePlayback Playback
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
        /// Gets and sets the property StartTime. Specify when the motion overlay begins. Use
        /// timecode format (HH:MM:SS:FF or HH:MM:SS;FF). Make sure that the timecode you provide
        /// here takes into account how you have set up your timecode configuration under both
        /// job settings and input settings. The simplest way to do that is to set both to start
        /// at 0. If you need to set up your job to follow timecodes embedded in your source that
        /// don't start at zero, make sure that you specify a start time that is after the first
        /// embedded timecode. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/setting-up-timecode.html
        /// </summary>
        [AWSProperty(Min=11, Max=11)]
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

    }
}