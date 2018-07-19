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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// JobTemplateSettings contains all the transcode settings saved in the template that
    /// will be applied to jobs created from it.
    /// </summary>
    public partial class JobTemplateSettings
    {
        private int? _adAvailOffset;
        private AvailBlanking _availBlanking;
        private List<InputTemplate> _inputs = new List<InputTemplate>();
        private NielsenConfiguration _nielsenConfiguration;
        private List<OutputGroup> _outputGroups = new List<OutputGroup>();
        private TimecodeConfig _timecodeConfig;
        private TimedMetadataInsertion _timedMetadataInsertion;

        /// <summary>
        /// Gets and sets the property AdAvailOffset. When specified, this offset (in milliseconds)
        /// is added to the input Ad Avail PTS time.
        /// </summary>
        public int AdAvailOffset
        {
            get { return this._adAvailOffset.GetValueOrDefault(); }
            set { this._adAvailOffset = value; }
        }

        // Check to see if AdAvailOffset property is set
        internal bool IsSetAdAvailOffset()
        {
            return this._adAvailOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailBlanking. Settings for ad avail blanking.  Video can
        /// be blanked or overlaid with an image, and audio muted during SCTE-35 triggered ad
        /// avails.
        /// </summary>
        public AvailBlanking AvailBlanking
        {
            get { return this._availBlanking; }
            set { this._availBlanking = value; }
        }

        // Check to see if AvailBlanking property is set
        internal bool IsSetAvailBlanking()
        {
            return this._availBlanking != null;
        }

        /// <summary>
        /// Gets and sets the property Inputs. Use Inputs (inputs) to define the source file used
        /// in the transcode job. There can only be one input in a job template.  Using the API,
        /// you can include multiple inputs when referencing a job template.
        /// </summary>
        public List<InputTemplate> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && this._inputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NielsenConfiguration.
        /// </summary>
        public NielsenConfiguration NielsenConfiguration
        {
            get { return this._nielsenConfiguration; }
            set { this._nielsenConfiguration = value; }
        }

        // Check to see if NielsenConfiguration property is set
        internal bool IsSetNielsenConfiguration()
        {
            return this._nielsenConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OutputGroups. (OutputGroups) contains one group of settings
        /// for each set of outputs that share a common package type. All unpackaged files (MPEG-4,
        /// MPEG-2 TS, Quicktime, MXF, and no container) are grouped in a single output group
        /// as well. Required in (OutputGroups) is a group of settings that apply to the whole
        /// group. This required object depends on the value you set for (Type) under (OutputGroups)>(OutputGroupSettings).
        /// Type, settings object pairs are as follows. * FILE_GROUP_SETTINGS, FileGroupSettings
        /// * HLS_GROUP_SETTINGS, HlsGroupSettings * DASH_ISO_GROUP_SETTINGS, DashIsoGroupSettings
        /// * MS_SMOOTH_GROUP_SETTINGS, MsSmoothGroupSettings * CMAF_GROUP_SETTINGS, CmafGroupSettings
        /// </summary>
        public List<OutputGroup> OutputGroups
        {
            get { return this._outputGroups; }
            set { this._outputGroups = value; }
        }

        // Check to see if OutputGroups property is set
        internal bool IsSetOutputGroups()
        {
            return this._outputGroups != null && this._outputGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimecodeConfig. Contains settings used to acquire and adjust
        /// timecode information from inputs.
        /// </summary>
        public TimecodeConfig TimecodeConfig
        {
            get { return this._timecodeConfig; }
            set { this._timecodeConfig = value; }
        }

        // Check to see if TimecodeConfig property is set
        internal bool IsSetTimecodeConfig()
        {
            return this._timecodeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataInsertion.
        /// </summary>
        public TimedMetadataInsertion TimedMetadataInsertion
        {
            get { return this._timedMetadataInsertion; }
            set { this._timedMetadataInsertion = value; }
        }

        // Check to see if TimedMetadataInsertion property is set
        internal bool IsSetTimedMetadataInsertion()
        {
            return this._timedMetadataInsertion != null;
        }

    }
}