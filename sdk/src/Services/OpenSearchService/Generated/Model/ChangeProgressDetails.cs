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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for information about a configuration change happening on a domain.
    /// </summary>
    public partial class ChangeProgressDetails
    {
        private string _changeId;
        private ConfigChangeStatus _configChangeStatus;
        private InitiatedBy _initiatedBy;
        private DateTime? _lastUpdatedTime;
        private string _message;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property ChangeId. 
        /// <para>
        /// The ID of the configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ChangeId
        {
            get { return this._changeId; }
            set { this._changeId = value; }
        }

        // Check to see if ChangeId property is set
        internal bool IsSetChangeId()
        {
            return this._changeId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigChangeStatus. 
        /// <para>
        /// The current status of the configuration change.
        /// </para>
        /// </summary>
        public ConfigChangeStatus ConfigChangeStatus
        {
            get { return this._configChangeStatus; }
            set { this._configChangeStatus = value; }
        }

        // Check to see if ConfigChangeStatus property is set
        internal bool IsSetConfigChangeStatus()
        {
            return this._configChangeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InitiatedBy. 
        /// <para>
        /// The IAM principal who initiated the configuration change.
        /// </para>
        /// </summary>
        public InitiatedBy InitiatedBy
        {
            get { return this._initiatedBy; }
            set { this._initiatedBy = value; }
        }

        // Check to see if InitiatedBy property is set
        internal bool IsSetInitiatedBy()
        {
            return this._initiatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that the configuration change was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message corresponding to the status of the configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the configuration change was initiated, in Universal Coordinated Time
        /// (UTC).
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}