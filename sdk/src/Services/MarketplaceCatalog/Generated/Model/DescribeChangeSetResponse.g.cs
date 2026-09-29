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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeChangeSet operation.
    /// </summary>
    public partial class DescribeChangeSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChangeSet. 
        /// <para>
        /// An array of <c>ChangeSummary</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChangeSummary> ChangeSet { get; set; } = AWSConfigs.InitializeCollections ? new List<ChangeSummary>() : null;

        /// <summary>
        /// Checks to see if the ChangeSet property is set.
        /// </summary>
        internal bool IsSetChangeSet() => this.ChangeSet != null && (this.ChangeSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChangeSetArn. 
        /// <para>
        /// The ARN associated with the unique identifier for the change set referenced in this
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ChangeSetArn { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetArn property is set.
        /// </summary>
        internal bool IsSetChangeSetArn() => this.ChangeSetArn != null;

        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// Required. The unique identifier for the change set referenced in this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetId property is set.
        /// </summary>
        internal bool IsSetChangeSetId() => this.ChangeSetId != null;

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The optional name provided in the <c>StartChangeSet</c> request. If you do not provide
        /// a name, one is set by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ChangeSetName { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetName property is set.
        /// </summary>
        internal bool IsSetChangeSetName() => this.ChangeSetName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time, in ISO 8601 format (2018-02-27T13:45:22Z), the request transitioned
        /// to a terminal state. The change cannot transition to a different state. Null if the
        /// request is not in a terminal state. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime != null;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// Returned if the change set is in <c>FAILED</c> status. Can be either <c>CLIENT_ERROR</c>,
        /// which means that there are issues with the request (see the <c>ErrorDetailList</c>),
        /// or <c>SERVER_FAULT</c>, which means that there is a problem in the system, and you
        /// should retry your request.
        /// </para>
        /// </summary>
        public FailureCode FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureDescription. 
        /// <para>
        /// Returned if there is a failure on the change set, but that failure is not related
        /// to any of the changes in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FailureDescription { get; set; }

        /// <summary>
        /// Checks to see if the FailureDescription property is set.
        /// </summary>
        internal bool IsSetFailureDescription() => this.FailureDescription != null;

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// The optional intent provided in the <c>StartChangeSet</c> request. If you do not provide
        /// an intent, <c>APPLY</c> is set by default.
        /// </para>
        /// </summary>
        public Intent Intent { get; set; }

        /// <summary>
        /// Checks to see if the Intent property is set.
        /// </summary>
        internal bool IsSetIntent() => this.Intent != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time, in ISO 8601 format (2018-02-27T13:45:22Z), the request started.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the change request.
        /// </para>
        /// </summary>
        public ChangeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
