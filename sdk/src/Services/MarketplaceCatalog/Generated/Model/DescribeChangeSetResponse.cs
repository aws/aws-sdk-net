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
    /// This is the response object from the DescribeChangeSet operation.
    /// </summary>
    public partial class DescribeChangeSetResponse : AmazonWebServiceResponse
    {
        private List<ChangeSummary> _changeSet = AWSConfigs.InitializeCollections ? new List<ChangeSummary>() : null;
        private string _changeSetArn;
        private string _changeSetId;
        private string _changeSetName;
        private string _endTime;
        private FailureCode _failureCode;
        private string _failureDescription;
        private Intent _intent;
        private string _startTime;
        private ChangeStatus _status;

        /// <summary>
        /// Gets and sets the property ChangeSet. 
        /// <para>
        /// An array of <c>ChangeSummary</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChangeSummary> ChangeSet
        {
            get { return this._changeSet; }
            set { this._changeSet = value; }
        }

        // Check to see if ChangeSet property is set
        internal bool IsSetChangeSet()
        {
            return this._changeSet != null && (this._changeSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Required. The unique identifier for the change set referenced in this request.
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
        /// The optional name provided in the <c>StartChangeSet</c> request. If you do not provide
        /// a name, one is set by default.
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
        /// The date and time, in ISO 8601 format (2018-02-27T13:45:22Z), the request transitioned
        /// to a terminal state. The change cannot transition to a different state. Null if the
        /// request is not in a terminal state. 
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
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// Returned if the change set is in <c>FAILED</c> status. Can be either <c>CLIENT_ERROR</c>,
        /// which means that there are issues with the request (see the <c>ErrorDetailList</c>),
        /// or <c>SERVER_FAULT</c>, which means that there is a problem in the system, and you
        /// should retry your request.
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
        /// Gets and sets the property FailureDescription. 
        /// <para>
        /// Returned if there is a failure on the change set, but that failure is not related
        /// to any of the changes in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FailureDescription
        {
            get { return this._failureDescription; }
            set { this._failureDescription = value; }
        }

        // Check to see if FailureDescription property is set
        internal bool IsSetFailureDescription()
        {
            return this._failureDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// The optional intent provided in the <c>StartChangeSet</c> request. If you do not provide
        /// an intent, <c>APPLY</c> is set by default.
        /// </para>
        /// </summary>
        public Intent Intent
        {
            get { return this._intent; }
            set { this._intent = value; }
        }

        // Check to see if Intent property is set
        internal bool IsSetIntent()
        {
            return this._intent != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time, in ISO 8601 format (2018-02-27T13:45:22Z), the request started.
        /// 
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
        /// The status of the change request.
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