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
    /// Use automated ABR to have MediaConvert set up the renditions in your ABR package for
    /// you automatically, based on characteristics of your input video. This feature optimizes
    /// video quality while minimizing the overall size of your ABR package.
    /// </summary>
    public partial class AutomatedAbrSettings
    {
        private int? _maxAbrBitrate;
        private double? _maxQualityLevel;
        private int? _maxRenditions;
        private int? _minAbrBitrate;
        private List<AutomatedAbrRule> _rules = AWSConfigs.InitializeCollections ? new List<AutomatedAbrRule>() : null;

        /// <summary>
        /// Gets and sets the property MaxAbrBitrate. Specify the maximum average bitrate for
        /// MediaConvert to use in your automated ABR stack. If you don't specify a value, MediaConvert
        /// uses 8,000,000 (8 mb/s) by default. The average bitrate of your highest-quality rendition
        /// will be equal to or below this value, depending on the quality, complexity, and resolution
        /// of your content. Note that the instantaneous maximum bitrate may vary above the value
        /// that you specify.
        /// </summary>
        [AWSProperty(Min=100000, Max=100000000)]
        public int? MaxAbrBitrate
        {
            get { return this._maxAbrBitrate; }
            set { this._maxAbrBitrate = value; }
        }

        // Check to see if MaxAbrBitrate property is set
        internal bool IsSetMaxAbrBitrate()
        {
            return this._maxAbrBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxQualityLevel. Optional. Specify the QVBR quality level
        /// to use for all renditions in your automated ABR stack. To have MediaConvert automatically
        /// determine the quality level: Leave blank. To manually specify a quality level: Enter
        /// a value from 1 to 10. MediaConvert will use a quality level up to the value that you
        /// specify, depending on your source. For more information about QVBR quality levels,
        /// see: https://docs.aws.amazon.com/mediaconvert/latest/ug/qvbr-guidelines.html
        /// </summary>
        public double? MaxQualityLevel
        {
            get { return this._maxQualityLevel; }
            set { this._maxQualityLevel = value; }
        }

        // Check to see if MaxQualityLevel property is set
        internal bool IsSetMaxQualityLevel()
        {
            return this._maxQualityLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRenditions. Optional. The maximum number of renditions
        /// that MediaConvert will create in your automated ABR stack. The number of renditions
        /// is determined automatically, based on analysis of each job, but will never exceed
        /// this limit. When you set this to Auto in the console, which is equivalent to excluding
        /// it from your JSON job specification, MediaConvert defaults to a limit of 15.
        /// </summary>
        [AWSProperty(Min=3, Max=15)]
        public int? MaxRenditions
        {
            get { return this._maxRenditions; }
            set { this._maxRenditions = value; }
        }

        // Check to see if MaxRenditions property is set
        internal bool IsSetMaxRenditions()
        {
            return this._maxRenditions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinAbrBitrate. Specify the minimum average bitrate for
        /// MediaConvert to use in your automated ABR stack. If you don't specify a value, MediaConvert
        /// uses 600,000 (600 kb/s) by default. The average bitrate of your lowest-quality rendition
        /// will be near this value. Note that the instantaneous minimum bitrate may vary below
        /// the value that you specify.
        /// </summary>
        [AWSProperty(Min=100000, Max=100000000)]
        public int? MinAbrBitrate
        {
            get { return this._minAbrBitrate; }
            set { this._minAbrBitrate = value; }
        }

        // Check to see if MinAbrBitrate property is set
        internal bool IsSetMinAbrBitrate()
        {
            return this._minAbrBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rules. Optional. Use Automated ABR rules to specify restrictions
        /// for the rendition sizes MediaConvert will create in your ABR stack. You can use these
        /// rules if your ABR workflow has specific rendition size requirements, but you still
        /// want MediaConvert to optimize for video quality and overall file size.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomatedAbrRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}