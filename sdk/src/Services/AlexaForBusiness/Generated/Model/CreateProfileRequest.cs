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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProfile operation.
    /// Creates a new room profile with the specified details.
    /// </summary>
    public partial class CreateProfileRequest : AmazonAlexaForBusinessRequest
    {
        private string _address;
        private string _clientRequestToken;
        private DistanceUnit _distanceUnit;
        private int? _maxVolumeLimit;
        private string _profileName;
        private bool? _pstnEnabled;
        private bool? _setupModeDisabled;
        private TemperatureUnit _temperatureUnit;
        private string _timezone;
        private WakeWord _wakeWord;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The valid address for the room.
        /// </para>
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The user-specified token that is used during the creation of a profile.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// The distance unit to be used by devices in the profile.
        /// </para>
        /// </summary>
        public DistanceUnit DistanceUnit
        {
            get { return this._distanceUnit; }
            set { this._distanceUnit = value; }
        }

        // Check to see if DistanceUnit property is set
        internal bool IsSetDistanceUnit()
        {
            return this._distanceUnit != null;
        }

        /// <summary>
        /// Gets and sets the property MaxVolumeLimit. 
        /// <para>
        /// The maximum volume limit for a room profile.
        /// </para>
        /// </summary>
        public int MaxVolumeLimit
        {
            get { return this._maxVolumeLimit.GetValueOrDefault(); }
            set { this._maxVolumeLimit = value; }
        }

        // Check to see if MaxVolumeLimit property is set
        internal bool IsSetMaxVolumeLimit()
        {
            return this._maxVolumeLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of a room profile.
        /// </para>
        /// </summary>
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property PSTNEnabled. 
        /// <para>
        /// Whether PSTN calling is enabled.
        /// </para>
        /// </summary>
        public bool PSTNEnabled
        {
            get { return this._pstnEnabled.GetValueOrDefault(); }
            set { this._pstnEnabled = value; }
        }

        // Check to see if PSTNEnabled property is set
        internal bool IsSetPSTNEnabled()
        {
            return this._pstnEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SetupModeDisabled. 
        /// <para>
        /// Whether room profile setup is enabled.
        /// </para>
        /// </summary>
        public bool SetupModeDisabled
        {
            get { return this._setupModeDisabled.GetValueOrDefault(); }
            set { this._setupModeDisabled = value; }
        }

        // Check to see if SetupModeDisabled property is set
        internal bool IsSetSetupModeDisabled()
        {
            return this._setupModeDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TemperatureUnit. 
        /// <para>
        /// The temperature unit to be used by devices in the profile.
        /// </para>
        /// </summary>
        public TemperatureUnit TemperatureUnit
        {
            get { return this._temperatureUnit; }
            set { this._temperatureUnit = value; }
        }

        // Check to see if TemperatureUnit property is set
        internal bool IsSetTemperatureUnit()
        {
            return this._temperatureUnit != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone used by a room profile.
        /// </para>
        /// </summary>
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

        /// <summary>
        /// Gets and sets the property WakeWord. 
        /// <para>
        /// A wake word for Alexa, Echo, Amazon, or a computer.
        /// </para>
        /// </summary>
        public WakeWord WakeWord
        {
            get { return this._wakeWord; }
            set { this._wakeWord = value; }
        }

        // Check to see if WakeWord property is set
        internal bool IsSetWakeWord()
        {
            return this._wakeWord != null;
        }

    }
}