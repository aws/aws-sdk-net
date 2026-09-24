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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The settings object that specifies whether evidence finder is enabled. This object
    /// also describes the related event data store, and the backfill status for populating
    /// the event data store with evidence data.
    /// </summary>
    public partial class EvidenceFinderEnablement
    {
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
        ///  <c>NOT_STARTED</c> means that the backfill hasn’t started yet. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> means that the backfill is in progress. This can take up to 7
        /// days to complete, depending on the amount of evidence data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> means that the backfill is complete. All of your past evidence is
        /// now queryable. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EvidenceFinderBackfillStatus BackfillStatus { get; set; }

        /// <summary>
        /// Checks to see if the BackfillStatus property is set.
        /// </summary>
        internal bool IsSetBackfillStatus() => this.BackfillStatus != null;

        /// <summary>
        /// Gets and sets the property EnablementStatus. 
        /// <para>
        /// The current status of the evidence finder feature and the related event data store.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLE_IN_PROGRESS</c> means that you requested to enable evidence finder. An
        /// event data store is currently being created to support evidence finder queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED</c> means that an event data store was successfully created and evidence
        /// finder is enabled. We recommend that you wait 7 days until the event data store is
        /// backfilled with your past two years’ worth of evidence data. You can use evidence
        /// finder in the meantime, but not all data might be available until the backfill is
        /// complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLE_IN_PROGRESS</c> means that you requested to disable evidence finder, and
        /// your request is pending the deletion of the event data store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> means that you have permanently disabled evidence finder and the
        /// event data store has been deleted. You can't re-enable evidence finder after this
        /// point.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EvidenceFinderEnablementStatus EnablementStatus { get; set; }

        /// <summary>
        /// Checks to see if the EnablementStatus property is set.
        /// </summary>
        internal bool IsSetEnablementStatus() => this.EnablementStatus != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Represents any errors that occurred when enabling or disabling evidence finder. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudTrail Lake event data store that’s used
        /// by evidence finder. The event data store is the lake of evidence data that evidence
        /// finder runs queries against.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string EventDataStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStoreArn property is set.
        /// </summary>
        internal bool IsSetEventDataStoreArn() => this.EventDataStoreArn != null;
    }
}
