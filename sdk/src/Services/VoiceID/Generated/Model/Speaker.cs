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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Contains all the information about a speaker.
    /// </summary>
    public partial class Speaker
    {
        private DateTime? _createdAt;
        private string _customerSpeakerId;
        private string _domainId;
        private string _generatedSpeakerId;
        private DateTime? _lastAccessedAt;
        private SpeakerStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp of when the speaker was created. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerSpeakerId. 
        /// <para>
        /// The client-provided identifier for the speaker.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string CustomerSpeakerId
        {
            get { return this._customerSpeakerId; }
            set { this._customerSpeakerId = value; }
        }

        // Check to see if CustomerSpeakerId property is set
        internal bool IsSetCustomerSpeakerId()
        {
            return this._customerSpeakerId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the speaker.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedSpeakerId. 
        /// <para>
        /// The service-generated identifier for the speaker.
        /// </para>
        /// </summary>
        [AWSProperty(Min=25, Max=25)]
        public string GeneratedSpeakerId
        {
            get { return this._generatedSpeakerId; }
            set { this._generatedSpeakerId = value; }
        }

        // Check to see if GeneratedSpeakerId property is set
        internal bool IsSetGeneratedSpeakerId()
        {
            return this._generatedSpeakerId != null;
        }

        /// <summary>
        /// Gets and sets the property LastAccessedAt. 
        /// <para>
        /// The timestamp of when the speaker was last accessed for enrollment, re-enrollment
        /// or a successful authentication. This timestamp is accurate to one hour.
        /// </para>
        /// </summary>
        public DateTime LastAccessedAt
        {
            get { return this._lastAccessedAt.GetValueOrDefault(); }
            set { this._lastAccessedAt = value; }
        }

        // Check to see if LastAccessedAt property is set
        internal bool IsSetLastAccessedAt()
        {
            return this._lastAccessedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the speaker.
        /// </para>
        /// </summary>
        public SpeakerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// A timestamp of the speaker's last update.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}