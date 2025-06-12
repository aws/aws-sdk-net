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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// The settings for Automatic Input Failover.
    /// </summary>
    public partial class AutomaticInputFailoverSettings
    {
        private int? _errorClearTimeMsec;
        private List<FailoverCondition> _failoverConditions = AWSConfigs.InitializeCollections ? new List<FailoverCondition>() : null;
        private InputPreference _inputPreference;
        private string _secondaryInputId;

        /// <summary>
        /// Gets and sets the property ErrorClearTimeMsec. This clear time defines the requirement
        /// a recovered input must meet to be considered healthy. The input must have no failover
        /// conditions for this length of time. Enter a time in milliseconds. This value is particularly
        /// important if the input_preference for the failover pair is set to PRIMARY_INPUT_PREFERRED,
        /// because after this time, MediaLive will switch back to the primary input.
        /// </summary>
        [AWSProperty(Min=1)]
        public int? ErrorClearTimeMsec
        {
            get { return this._errorClearTimeMsec; }
            set { this._errorClearTimeMsec = value; }
        }

        // Check to see if ErrorClearTimeMsec property is set
        internal bool IsSetErrorClearTimeMsec()
        {
            return this._errorClearTimeMsec.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailoverConditions. A list of failover conditions. If any
        /// of these conditions occur, MediaLive will perform a failover to the other input.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailoverCondition> FailoverConditions
        {
            get { return this._failoverConditions; }
            set { this._failoverConditions = value; }
        }

        // Check to see if FailoverConditions property is set
        internal bool IsSetFailoverConditions()
        {
            return this._failoverConditions != null && (this._failoverConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputPreference. Input preference when deciding which input
        /// to make active when a previously failed input has recovered.
        /// </summary>
        public InputPreference InputPreference
        {
            get { return this._inputPreference; }
            set { this._inputPreference = value; }
        }

        // Check to see if InputPreference property is set
        internal bool IsSetInputPreference()
        {
            return this._inputPreference != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryInputId. The input ID of the secondary input in
        /// the automatic input failover pair.
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecondaryInputId
        {
            get { return this._secondaryInputId; }
            set { this._secondaryInputId = value; }
        }

        // Check to see if SecondaryInputId property is set
        internal bool IsSetSecondaryInputId()
        {
            return this._secondaryInputId != null;
        }

    }
}