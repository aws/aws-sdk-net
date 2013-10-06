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
    /// 
    /// </summary>
    public class CreateJobOutput
    {
        
        private string key;
        private string thumbnailPattern;
        private string rotate;
        private string presetId;
        private string segmentDuration;
        private List<JobWatermark> watermarks = new List<JobWatermark>();

        /// <summary>
        /// The name to assign to the transcoded file. Elastic Transcoder saves the file in the Amazon S3 bucket specified by the <c>OutputBucket</c>
        /// object in the pipeline that is specified by the pipeline ID. If a file with the specified name already exists in the output bucket, the job
        /// fails.
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
        public CreateJobOutput WithKey(string key)
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
        public CreateJobOutput WithThumbnailPattern(string thumbnailPattern)
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
        /// values: <c>auto</c>, <c>0</c>, <c>90</c>, <c>180</c>, <c>270</c>. The value <c>auto</c> generally works only if the file that you're
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
        public CreateJobOutput WithRotate(string rotate)
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
        /// The <c>Id</c> of the preset to use for this job. The preset determines the audio, video, and thumbnail settings that Elastic Transcoder uses
        /// for transcoding.
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
        public CreateJobOutput WithPresetId(string presetId)
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
        /// If you specify a preset in <c>PresetId</c> for which the value of <c>Container</c> is ts (MPEG-TS), SegmentDuration is the duration of each
        /// .ts file in seconds. The range of valid values is 1 to 60 seconds.
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
        public CreateJobOutput WithSegmentDuration(string segmentDuration)
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
        /// 
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
        public CreateJobOutput WithWatermarks(params JobWatermark[] watermarks)
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
        public CreateJobOutput WithWatermarks(IEnumerable<JobWatermark> watermarks)
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
