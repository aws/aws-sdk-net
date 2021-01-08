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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// A room profile with attributes.
    /// </summary>
    public partial class Profile
    {
        private string _address;
        private string _addressBookArn;
        private DistanceUnit _distanceUnit;
        private bool? _isDefault;
        private string _locale;
        private int? _maxVolumeLimit;
        private MeetingRoomConfiguration _meetingRoomConfiguration;
        private string _profileArn;
        private string _profileName;
        private bool? _pstnEnabled;
        private bool? _setupModeDisabled;
        private TemperatureUnit _temperatureUnit;
        private string _timezone;
        private WakeWord _wakeWord;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The address of a room profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Gets and sets the property AddressBookArn. 
        /// <para>
        /// The ARN of the address book.
        /// </para>
        /// </summary>
        public string AddressBookArn
        {
            get { return this._addressBookArn; }
            set { this._addressBookArn = value; }
        }

        // Check to see if AddressBookArn property is set
        internal bool IsSetAddressBookArn()
        {
            return this._addressBookArn != null;
        }

        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// The distance unit of a room profile.
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
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Retrieves if the profile is default or not.
        /// </para>
        /// </summary>
        public bool IsDefault
        {
            get { return this._isDefault.GetValueOrDefault(); }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale of a room profile. (This is currently available only to a limited preview
        /// audience.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property MaxVolumeLimit. 
        /// <para>
        /// The max volume limit of a room profile.
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
        /// Gets and sets the property MeetingRoomConfiguration. 
        /// <para>
        /// Meeting room settings of a room profile.
        /// </para>
        /// </summary>
        public MeetingRoomConfiguration MeetingRoomConfiguration
        {
            get { return this._meetingRoomConfiguration; }
            set { this._meetingRoomConfiguration = value; }
        }

        // Check to see if MeetingRoomConfiguration property is set
        internal bool IsSetMeetingRoomConfiguration()
        {
            return this._meetingRoomConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The ARN of a room profile.
        /// </para>
        /// </summary>
        public string ProfileArn
        {
            get { return this._profileArn; }
            set { this._profileArn = value; }
        }

        // Check to see if ProfileArn property is set
        internal bool IsSetProfileArn()
        {
            return this._profileArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of a room profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The PSTN setting of a room profile.
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
        /// The setup mode of a room profile.
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
        /// The temperature unit of a room profile.
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
        /// The time zone of a room profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The wake word of a room profile.
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