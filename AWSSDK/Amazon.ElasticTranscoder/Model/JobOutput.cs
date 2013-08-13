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
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para> <para><b>IMPORTANT:</b>Outputs recommended instead.</para> If you specified one output for a job, information about that output. If
    /// you specified multiple outputs for a job, the <c>Output</c> object lists information about the first output. This duplicates the information
    /// that is listed for the first output in the <c>Outputs</c> object.</para>
    /// </summary>
    public class JobOutput
    {
        
        private string id;
        private string key;
        private string thumbnailPattern;
        private string rotate;
        private string presetId;
        private string segmentDuration;
        private string status;
        private string statusDetail;
        private long? duration;
        private int? width;
        private int? height;
        private List<JobWatermark> watermarks = new List<JobWatermark>();

        /// <summary>
        /// A sequential counter, starting with 1, that identifies an output among the outputs from the current job. In the Output syntax, this value is
        /// always 1.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The name to assign to the transcoded file. Elastic Transcoder saves the file in the Amazon S3 bucket specified by the <c>OutputBucket</c>
        /// object in the pipeline that is specified by the pipeline ID.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the Key property
        /// </summary>
        /// <param name="key">The value to set for the Key property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithKey(string key)
        {
            this.key = key;
            return this;
        }
            

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// Whether you want Elastic Transcoder to create thumbnails for your videos and, if so, how you want Elastic Transcoder to name the files. If
        /// you don't want Elastic Transcoder to create thumbnails, specify "". If you do want Elastic Transcoder to create thumbnails, specify the
        /// information that you want to include in the file name for each thumbnail. You can specify the following values in any sequence: <ul> <li>
        /// <b><c>{count}</c> (Required)</b>: If you want to create thumbnails, you must include <c>{count}</c> in the <c>ThumbnailPattern</c> object.
        /// Wherever you specify <c>{count}</c>, Elastic Transcoder adds a five-digit sequence number (beginning with <b>00001</b>) to thumbnail file
        /// names. The number indicates where a given thumbnail appears in the sequence of thumbnails for a transcoded file. <important>If you specify a
        /// literal value and/or <c>{resolution}</c> but you omit <c>{count}</c>, Elastic Transcoder returns a validation error and does not create the
        /// job.</important> </li> <li> <b>Literal values (Optional)</b>: You can specify literal values anywhere in the <c>ThumbnailPattern</c> object.
        /// For example, you can include them as a file name prefix or as a delimiter between <c>{resolution}</c> and <c>{count}</c>. </li> <li>
        /// <b><c>{resolution}</c> (Optional)</b>: If you want Elastic Transcoder to include the resolution in the file name, include
        /// <c>{resolution}</c> in the <c>ThumbnailPattern</c> object. </li> </ul> When creating thumbnails, Elastic Transcoder automatically saves the
        /// files in the format (.jpg or .png) that appears in the preset that you specified in the <c>PresetID</c> value of <c>CreateJobOutput</c>.
        /// Elastic Transcoder also appends the applicable file name extension.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^$)|(^.*\{count\}.*$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ThumbnailPattern
        {
            get { return this.thumbnailPattern; }
            set { this.thumbnailPattern = value; }
        }

        /// <summary>
        /// Sets the ThumbnailPattern property
        /// </summary>
        /// <param name="thumbnailPattern">The value to set for the ThumbnailPattern property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithThumbnailPattern(string thumbnailPattern)
        {
            this.thumbnailPattern = thumbnailPattern;
            return this;
        }
            

        // Check to see if ThumbnailPattern property is set
        internal bool IsSetThumbnailPattern()
        {
            return this.thumbnailPattern != null;
        }

        /// <summary>
        /// The number of degrees clockwise by which you want Elastic Transcoder to rotate the output relative to the input. Enter one of the following
        /// values: <c>auto</c>, <c>0</c>, <c>90</c>, <c>180</c>, <c>270</c> The value <c>auto</c> generally works only if the file that you're
        /// transcoding contains rotation metadata.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^0$)|(^90$)|(^180$)|(^270$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Rotate
        {
            get { return this.rotate; }
            set { this.rotate = value; }
        }

        /// <summary>
        /// Sets the Rotate property
        /// </summary>
        /// <param name="rotate">The value to set for the Rotate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithRotate(string rotate)
        {
            this.rotate = rotate;
            return this;
        }
            

        // Check to see if Rotate property is set
        internal bool IsSetRotate()
        {
            return this.rotate != null;
        }

        /// <summary>
        /// The value of the <c>Id</c> object for the preset that you want to use for this job. The preset determines the audio, video, and thumbnail
        /// settings that Elastic Transcoder uses for transcoding. To use a preset that you created, specify the preset ID that Elastic Transcoder
        /// returned in the response when you created the preset. You can also use the Elastic Transcoder system presets, which you can get with
        /// <c>ListPresets</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PresetId
        {
            get { return this.presetId; }
            set { this.presetId = value; }
        }

        /// <summary>
        /// Sets the PresetId property
        /// </summary>
        /// <param name="presetId">The value to set for the PresetId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithPresetId(string presetId)
        {
            this.presetId = presetId;
            return this;
        }
            

        // Check to see if PresetId property is set
        internal bool IsSetPresetId()
        {
            return this.presetId != null;
        }

        /// <summary>
        /// <important>(Outputs in MPEG-TS format only.</important>If you specify a preset in <c>PresetId</c> for which the value of <c>Container</c>is
        /// <c>ts</c> (MPEG-TS), <c>SegmentDuration</c> is the maximum duration of each .ts file in seconds. The range of valid values is 1 to 60
        /// seconds. If the duration of the video is not evenly divisible by <c>SegmentDuration</c>, the duration of the last segment is the remainder
        /// of total length/SegmentDuration. Elastic Transcoder creates an output-specific playlist for each output that you specify in OutputKeys. To
        /// add an output to the master playlist for this job, include it in <c>OutputKeys</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{1,5}([.]\d{0,5})?$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SegmentDuration
        {
            get { return this.segmentDuration; }
            set { this.segmentDuration = value; }
        }

        /// <summary>
        /// Sets the SegmentDuration property
        /// </summary>
        /// <param name="segmentDuration">The value to set for the SegmentDuration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithSegmentDuration(string segmentDuration)
        {
            this.segmentDuration = segmentDuration;
            return this;
        }
            

        // Check to see if SegmentDuration property is set
        internal bool IsSetSegmentDuration()
        {
            return this.segmentDuration != null;
        }

        /// <summary>
        /// The status of one output in a job. If you specified only one output for the job, <c>Outputs:Status</c> is always the same as
        /// <c>Job:Status</c>. If you specified more than one output: <ul> <li><c>Job:Status</c> and <c>Outputs:Status</c> for all of the outputs is
        /// Submitted until Elastic Transcoder starts to process the first output.</li> <li>When Elastic Transcoder starts to process the first output,
        /// <c>Outputs:Status</c> for that output and <c>Job:Status</c> both change to Progressing. For each output, the value of <c>Outputs:Status</c>
        /// remains Submitted until Elastic Transcoder starts to process the output.</li> <li>Job:Status remains Progressing until all of the outputs
        /// reach a terminal status, either Complete or Error.</li> <li>When all of the outputs reach a terminal status, <c>Job:Status</c> changes to
        /// Complete only if <c>Outputs:Status</c> for all of the outputs is <c>Complete</c>. If <c>Outputs:Status</c> for one or more outputs is
        /// <c>Error</c>, the terminal status for <c>Job:Status</c> is also <c>Error</c>.</li> </ul> The value of <c>Status</c> is one of the following:
        /// <c>Submitted</c>, <c>Progressing</c>, <c>Complete</c>, <c>Canceled</c>, or <c>Error</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Submitted$)|(^Progressing$)|(^Complete$)|(^Canceled$)|(^Error$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Information that further explains <c>Status</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StatusDetail
        {
            get { return this.statusDetail; }
            set { this.statusDetail = value; }
        }

        /// <summary>
        /// Sets the StatusDetail property
        /// </summary>
        /// <param name="statusDetail">The value to set for the StatusDetail property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithStatusDetail(string statusDetail)
        {
            this.statusDetail = statusDetail;
            return this;
        }
            

        // Check to see if StatusDetail property is set
        internal bool IsSetStatusDetail()
        {
            return this.statusDetail != null;
        }

        /// <summary>
        /// Duration of the output file, in seconds.
        ///  
        /// </summary>
        public long Duration
        {
            get { return this.duration ?? default(long); }
            set { this.duration = value; }
        }

        /// <summary>
        /// Sets the Duration property
        /// </summary>
        /// <param name="duration">The value to set for the Duration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithDuration(long duration)
        {
            this.duration = duration;
            return this;
        }
            

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this.duration.HasValue;
        }

        /// <summary>
        /// Specifies the width of the output file in pixels.
        ///  
        /// </summary>
        public int Width
        {
            get { return this.width ?? default(int); }
            set { this.width = value; }
        }

        /// <summary>
        /// Sets the Width property
        /// </summary>
        /// <param name="width">The value to set for the Width property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithWidth(int width)
        {
            this.width = width;
            return this;
        }
            

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this.width.HasValue;
        }

        /// <summary>
        /// Height of the output file, in pixels.
        ///  
        /// </summary>
        public int Height
        {
            get { return this.height ?? default(int); }
            set { this.height = value; }
        }

        /// <summary>
        /// Sets the Height property
        /// </summary>
        /// <param name="height">The value to set for the Height property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithHeight(int height)
        {
            this.height = height;
            return this;
        }
            

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this.height.HasValue;
        }

        /// <summary>
        /// Information about the watermarks that you want Elastic Transcoder to add to the video during transcoding. You can specify up to four
        /// watermarks for each output. Settings for each watermark must be defined in the preset that you specify in <c>Preset</c> for the current
        /// output. Watermarks are added to the output video in the sequence in which you list them in the job outputâ€�?the first watermark in the list
        /// is added to the output video first, the second watermark in the list is added next, and so on. As a result, if the settings in a preset
        /// cause Elastic Transcoder to place all watermarks in the same location, the second watermark that you add will cover the first one, the third
        /// one will cover the second, and the fourth one will cover the third.
        ///  
        /// </summary>
        public List<JobWatermark> Watermarks
        {
            get { return this.watermarks; }
            set { this.watermarks = value; }
        }
        /// <summary>
        /// Adds elements to the Watermarks collection
        /// </summary>
        /// <param name="watermarks">The values to add to the Watermarks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithWatermarks(params JobWatermark[] watermarks)
        {
            foreach (JobWatermark element in watermarks)
            {
                this.watermarks.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Watermarks collection
        /// </summary>
        /// <param name="watermarks">The values to add to the Watermarks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobOutput WithWatermarks(IEnumerable<JobWatermark> watermarks)
        {
            foreach (JobWatermark element in watermarks)
            {
                this.watermarks.Add(element);
            }

            return this;
        }

        // Check to see if Watermarks property is set
        internal bool IsSetWatermarks()
        {
            return this.watermarks.Count > 0;
        }
    }
}
