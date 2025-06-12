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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// A summary of a change set returned in a list of change sets when the <c>ListChangeSets</c>
    /// action is called.
    /// </summary>
    public partial class ChangeSetSummaryListItem
    {
        private string _changeSetArn;
        private string _changeSetId;
        private string _changeSetName;
        private string _endTime;
        private List<string> _entityIdList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FailureCode _failureCode;
        private string _startTime;
        private ChangeStatus _status;

        /// <summary>
        /// Gets and sets the property ChangeSetArn. 
        /// <para>
        /// The ARN associated with the unique identifier for the change set referenced in this
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ChangeSetArn
        {
            get { return this._changeSetArn; }
            set { this._changeSetArn = value; }
        }

        // Check to see if ChangeSetArn property is set
        internal bool IsSetChangeSetArn()
        {
            return this._changeSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// The unique identifier for a change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ChangeSetId
        {
            get { return this._changeSetId; }
            set { this._changeSetId = value; }
        }

        // Check to see if ChangeSetId property is set
        internal bool IsSetChangeSetId()
        {
            return this._changeSetId != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The non-unique name for the change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ChangeSetName
        {
            get { return this._changeSetName; }
            set { this._changeSetName = value; }
        }

        // Check to see if ChangeSetName property is set
        internal bool IsSetChangeSetName()
        {
            return this._changeSetName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time, in ISO 8601 format (2018-02-27T13:45:22Z), when the change set was finished.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property EntityIdList. 
        /// <para>
        /// This object is a list of entity IDs (string) that are a part of a change set. The
        /// entity ID list is a maximum of 20 entities. It must contain at least one entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EntityIdList
        {
            get { return this._entityIdList; }
            set { this._entityIdList = value; }
        }

        // Check to see if EntityIdList property is set
        internal bool IsSetEntityIdList()
        {
            return this._entityIdList != null && (this._entityIdList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// Returned if the change set is in <c>FAILED</c> status. Can be either <c>CLIENT_ERROR</c>,
        /// which means that there are issues with the request (see the <c>ErrorDetailList</c>
        /// of <c>DescribeChangeSet</c>), or <c>SERVER_FAULT</c>, which means that there is a
        /// problem in the system, and you should retry your request.
        /// </para>
        /// </summary>
        public FailureCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time, in ISO 8601 format (2018-02-27T13:45:22Z), when the change set was started.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the change set.
        /// </para>
        /// </summary>
        public ChangeStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}