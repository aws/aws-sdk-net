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
    /// Container for the parameters to the UpdateConferenceProvider operation.
    /// Updates an existing conference provider's settings.
    /// </summary>
    public partial class UpdateConferenceProviderRequest : AmazonAlexaForBusinessRequest
    {
        private string _conferenceProviderArn;
        private ConferenceProviderType _conferenceProviderType;
        private IPDialIn _ipDialIn;
        private MeetingSetting _meetingSetting;
        private PSTNDialIn _pstnDialIn;

        /// <summary>
        /// Gets and sets the property ConferenceProviderArn. 
        /// <para>
        /// The ARN of the conference provider.
        /// </para>
        /// </summary>
        public string ConferenceProviderArn
        {
            get { return this._conferenceProviderArn; }
            set { this._conferenceProviderArn = value; }
        }

        // Check to see if ConferenceProviderArn property is set
        internal bool IsSetConferenceProviderArn()
        {
            return this._conferenceProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConferenceProviderType. 
        /// <para>
        /// The type of the conference provider.
        /// </para>
        /// </summary>
        public ConferenceProviderType ConferenceProviderType
        {
            get { return this._conferenceProviderType; }
            set { this._conferenceProviderType = value; }
        }

        // Check to see if ConferenceProviderType property is set
        internal bool IsSetConferenceProviderType()
        {
            return this._conferenceProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property IPDialIn. 
        /// <para>
        /// The IP endpoint and protocol for calling.
        /// </para>
        /// </summary>
        public IPDialIn IPDialIn
        {
            get { return this._ipDialIn; }
            set { this._ipDialIn = value; }
        }

        // Check to see if IPDialIn property is set
        internal bool IsSetIPDialIn()
        {
            return this._ipDialIn != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingSetting. 
        /// <para>
        /// The meeting settings for the conference provider.
        /// </para>
        /// </summary>
        public MeetingSetting MeetingSetting
        {
            get { return this._meetingSetting; }
            set { this._meetingSetting = value; }
        }

        // Check to see if MeetingSetting property is set
        internal bool IsSetMeetingSetting()
        {
            return this._meetingSetting != null;
        }

        /// <summary>
        /// Gets and sets the property PSTNDialIn. 
        /// <para>
        /// The information for PSTN conferencing.
        /// </para>
        /// </summary>
        public PSTNDialIn PSTNDialIn
        {
            get { return this._pstnDialIn; }
            set { this._pstnDialIn = value; }
        }

        // Check to see if PSTNDialIn property is set
        internal bool IsSetPSTNDialIn()
        {
            return this._pstnDialIn != null;
        }

    }
}