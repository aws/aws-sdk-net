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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The <b>RegistrationVersionStatusHistory</b> object contains the time stamps for when
    /// the reservations status changes.
    /// </summary>
    public partial class RegistrationVersionStatusHistory
    {
        private DateTime? _approvedTimestamp;
        private DateTime? _archivedTimestamp;
        private DateTime? _deniedTimestamp;
        private DateTime? _discardedTimestamp;
        private DateTime? _draftTimestamp;
        private DateTime? _requiresAuthenticationTimestamp;
        private DateTime? _reviewingTimestamp;
        private DateTime? _revokedTimestamp;
        private DateTime? _submittedTimestamp;

        /// <summary>
        /// Gets and sets the property ApprovedTimestamp. 
        /// <para>
        /// The time when the registration was in the approved state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? ApprovedTimestamp
        {
            get { return this._approvedTimestamp; }
            set { this._approvedTimestamp = value; }
        }

        // Check to see if ApprovedTimestamp property is set
        internal bool IsSetApprovedTimestamp()
        {
            return this._approvedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ArchivedTimestamp. 
        /// <para>
        /// The time when the registration was in the archived state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? ArchivedTimestamp
        {
            get { return this._archivedTimestamp; }
            set { this._archivedTimestamp = value; }
        }

        // Check to see if ArchivedTimestamp property is set
        internal bool IsSetArchivedTimestamp()
        {
            return this._archivedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeniedTimestamp. 
        /// <para>
        /// The time when the registration was in the denied state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? DeniedTimestamp
        {
            get { return this._deniedTimestamp; }
            set { this._deniedTimestamp = value; }
        }

        // Check to see if DeniedTimestamp property is set
        internal bool IsSetDeniedTimestamp()
        {
            return this._deniedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiscardedTimestamp. 
        /// <para>
        /// The time when the registration was in the discarded state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? DiscardedTimestamp
        {
            get { return this._discardedTimestamp; }
            set { this._discardedTimestamp = value; }
        }

        // Check to see if DiscardedTimestamp property is set
        internal bool IsSetDiscardedTimestamp()
        {
            return this._discardedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DraftTimestamp. 
        /// <para>
        /// The time when the registration was in the draft state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? DraftTimestamp
        {
            get { return this._draftTimestamp; }
            set { this._draftTimestamp = value; }
        }

        // Check to see if DraftTimestamp property is set
        internal bool IsSetDraftTimestamp()
        {
            return this._draftTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiresAuthenticationTimestamp. 
        /// <para>
        /// The time when the registration was in the requires authentication state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? RequiresAuthenticationTimestamp
        {
            get { return this._requiresAuthenticationTimestamp; }
            set { this._requiresAuthenticationTimestamp = value; }
        }

        // Check to see if RequiresAuthenticationTimestamp property is set
        internal bool IsSetRequiresAuthenticationTimestamp()
        {
            return this._requiresAuthenticationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReviewingTimestamp. 
        /// <para>
        /// The time when the registration was in the reviewing state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? ReviewingTimestamp
        {
            get { return this._reviewingTimestamp; }
            set { this._reviewingTimestamp = value; }
        }

        // Check to see if ReviewingTimestamp property is set
        internal bool IsSetReviewingTimestamp()
        {
            return this._reviewingTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevokedTimestamp. 
        /// <para>
        /// The time when the registration was in the revoked state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? RevokedTimestamp
        {
            get { return this._revokedTimestamp; }
            set { this._revokedTimestamp = value; }
        }

        // Check to see if RevokedTimestamp property is set
        internal bool IsSetRevokedTimestamp()
        {
            return this._revokedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubmittedTimestamp. 
        /// <para>
        /// The time when the registration was in the submitted state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? SubmittedTimestamp
        {
            get { return this._submittedTimestamp; }
            set { this._submittedTimestamp = value; }
        }

        // Check to see if SubmittedTimestamp property is set
        internal bool IsSetSubmittedTimestamp()
        {
            return this._submittedTimestamp.HasValue; 
        }

    }
}