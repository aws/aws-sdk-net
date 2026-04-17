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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Version information for a contact.
    /// </summary>
    public partial class ContactVersion
    {
        private DateTime? _activated;
        private DateTime? _created;
        private List<string> _failureCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _failureMessage;
        private DateTime? _lastUpdated;
        private VersionStatus _status;
        private DateTime? _superseded;
        private int? _versionId;

        /// <summary>
        /// Gets and sets the property Activated. 
        /// <para>
        /// Time the contact version was activated in UTC. A version is activated when it becomes
        /// the current active version of the contact.
        /// </para>
        /// </summary>
        public DateTime? Activated
        {
            get { return this._activated; }
            set { this._activated = value; }
        }

        // Check to see if Activated property is set
        internal bool IsSetActivated()
        {
            return this._activated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// Time the contact version was created in UTC.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureCodes. 
        /// <para>
        /// List of failure codes for the contact version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureCodes
        {
            get { return this._failureCodes; }
            set { this._failureCodes = value; }
        }

        // Check to see if FailureCodes property is set
        internal bool IsSetFailureCodes()
        {
            return this._failureCodes != null && (this._failureCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Failure message for the contact version.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// Time the contact version was last updated in UTC.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the contact version.
        /// </para>
        /// </summary>
        public VersionStatus Status
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
        /// Gets and sets the property Superseded. 
        /// <para>
        /// Time the contact version was superseded in UTC. A version is superseded when a newer
        /// version becomes active.
        /// </para>
        /// </summary>
        public DateTime? Superseded
        {
            get { return this._superseded; }
            set { this._superseded = value; }
        }

        // Check to see if Superseded property is set
        internal bool IsSetSuperseded()
        {
            return this._superseded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID of a contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public int? VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId.HasValue; 
        }

    }
}