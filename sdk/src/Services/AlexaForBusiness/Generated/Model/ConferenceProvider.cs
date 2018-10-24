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
    /// An entity that provides a conferencing solution. Alexa for Business acts as the voice
    /// interface and mediator that connects users to their preferred conference provider.
    /// Examples of conference providers include Amazon Chime, Zoom, Cisco, and Polycom.
    /// </summary>
    public partial class ConferenceProvider
    {
        private string _arn;
        private IPDialIn _ipDialIn;
        private MeetingSetting _meetingSetting;
        private string _name;
        private PSTNDialIn _pstnDialIn;
        private ConferenceProviderType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the newly created conference provider.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the conference provider.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of conference providers.
        /// </para>
        /// </summary>
        public ConferenceProviderType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}