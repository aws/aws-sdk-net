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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The settings object that specifies whether evidence finder is enabled. This object
    /// also describes the related event data store, and the backfill status for populating
    /// the event data store with evidence data.
    /// </summary>
    public partial class EvidenceFinderEnablement
    {
        private EvidenceFinderBackfillStatus _backfillStatus;
        private EvidenceFinderEnablementStatus _enablementStatus;
        private string _error;
        private string _eventDataStoreArn;

        /// <summary>
        /// Gets and sets the property BackfillStatus. 
        /// <para>
        /// The current status of the evidence data backfill process. 
        /// </para>
        ///  
        /// <para>
        /// The backfill starts after you enable evidence finder. During this task, Audit Manager
        /// populates an event data store with your past two years’ worth of evidence data so
        /// that your evidence can be queried.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NOT_STARTED</code> means that the backfill hasn’t started yet. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code> means that the backfill is in progress. This can take up
        /// to 7 days to complete, depending on the amount of evidence data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLETED</code> means that the backfill is complete. All of your past evidence
        /// is now queryable. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EvidenceFinderBackfillStatus BackfillStatus
        {
            get { return this._backfillStatus; }
            set { this._backfillStatus = value; }
        }

        // Check to see if BackfillStatus property is set
        internal bool IsSetBackfillStatus()
        {
            return this._backfillStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EnablementStatus. 
        /// <para>
        /// The current status of the evidence finder feature and the related event data store.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLE_IN_PROGRESS</code> means that you requested to enable evidence finder.
        /// An event data store is currently being created to support evidence finder queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENABLED</code> means that an event data store was successfully created and
        /// evidence finder is enabled. We recommend that you wait 7 days until the event data
        /// store is backfilled with your past two years’ worth of evidence data. You can use
        /// evidence finder in the meantime, but not all data might be available until the backfill
        /// is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLE_IN_PROGRESS</code> means that you requested to disable evidence finder,
        /// and your request is pending the deletion of the event data store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED</code> means that you have permanently disabled evidence finder and
        /// the event data store has been deleted. You can't re-enable evidence finder after this
        /// point.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EvidenceFinderEnablementStatus EnablementStatus
        {
            get { return this._enablementStatus; }
            set { this._enablementStatus = value; }
        }

        // Check to see if EnablementStatus property is set
        internal bool IsSetEnablementStatus()
        {
            return this._enablementStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Represents any errors that occurred when enabling or disabling evidence finder. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=300)]
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudTrail Lake event data store that’s used
        /// by evidence finder. The event data store is the lake of evidence data that evidence
        /// finder runs queries against.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string EventDataStoreArn
        {
            get { return this._eventDataStoreArn; }
            set { this._eventDataStoreArn = value; }
        }

        // Check to see if EventDataStoreArn property is set
        internal bool IsSetEventDataStoreArn()
        {
            return this._eventDataStoreArn != null;
        }

    }
}