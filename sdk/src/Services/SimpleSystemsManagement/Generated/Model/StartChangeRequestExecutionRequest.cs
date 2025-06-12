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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the StartChangeRequestExecution operation.
    /// Creates a change request for Change Manager. The Automation runbooks specified in
    /// the change request run only after all required approvals for the change request have
    /// been received.
    /// </summary>
    public partial class StartChangeRequestExecutionRequest : AmazonSimpleSystemsManagementRequest
    {
        private bool? _autoApprove;
        private string _changeDetails;
        private string _changeRequestName;
        private string _clientToken;
        private string _documentName;
        private string _documentVersion;
        private Dictionary<string, List<string>> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private List<Runbook> _runbooks = AWSConfigs.InitializeCollections ? new List<Runbook>() : null;
        private DateTime? _scheduledEndTime;
        private DateTime? _scheduledTime;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AutoApprove. 
        /// <para>
        /// Indicates whether the change request can be approved automatically without the need
        /// for manual approvals.
        /// </para>
        ///  
        /// <para>
        /// If <c>AutoApprovable</c> is enabled in a change template, then setting <c>AutoApprove</c>
        /// to <c>true</c> in <c>StartChangeRequestExecution</c> creates a change request that
        /// bypasses approver review.
        /// </para>
        ///  <note> 
        /// <para>
        /// Change Calendar restrictions are not bypassed in this scenario. If the state of an
        /// associated calendar is <c>CLOSED</c>, change freeze approvers must still grant permission
        /// for this change request to run. If they don't, the change won't be processed until
        /// the calendar state is again <c>OPEN</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        public bool? AutoApprove
        {
            get { return this._autoApprove; }
            set { this._autoApprove = value; }
        }

        // Check to see if AutoApprove property is set
        internal bool IsSetAutoApprove()
        {
            return this._autoApprove.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChangeDetails. 
        /// <para>
        /// User-provided details about the change. If no details are provided, content specified
        /// in the <b>Template information</b> section of the associated change template is added.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32768)]
        public string ChangeDetails
        {
            get { return this._changeDetails; }
            set { this._changeDetails = value; }
        }

        // Check to see if ChangeDetails property is set
        internal bool IsSetChangeDetails()
        {
            return this._changeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeRequestName. 
        /// <para>
        /// The name of the change request associated with the runbook workflow to be run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ChangeRequestName
        {
            get { return this._changeRequestName; }
            set { this._changeRequestName = value; }
        }

        // Check to see if ChangeRequestName property is set
        internal bool IsSetChangeRequestName()
        {
            return this._changeRequestName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The user-provided idempotency token. The token must be unique, is case insensitive,
        /// enforces the UUID format, and can't be reused.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the change template document to run during the runbook workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the change template document to run during the runbook workflow.
        /// </para>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A key-value map of parameters that match the declared parameters in the change template
        /// document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Runbooks. 
        /// <para>
        /// Information about the Automation runbooks that are run during the runbook workflow.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Automation runbooks specified for the runbook workflow can't run until all required
        /// approvals for the change request have been received.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<Runbook> Runbooks
        {
            get { return this._runbooks; }
            set { this._runbooks = value; }
        }

        // Check to see if Runbooks property is set
        internal bool IsSetRunbooks()
        {
            return this._runbooks != null && (this._runbooks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduledEndTime. 
        /// <para>
        /// The time that the requester expects the runbook workflow related to the change request
        /// to complete. The time is an estimate only that the requester provides for reviewers.
        /// </para>
        /// </summary>
        public DateTime? ScheduledEndTime
        {
            get { return this._scheduledEndTime; }
            set { this._scheduledEndTime = value; }
        }

        // Check to see if ScheduledEndTime property is set
        internal bool IsSetScheduledEndTime()
        {
            return this._scheduledEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledTime. 
        /// <para>
        /// The date and time specified in the change request to run the Automation runbooks.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Automation runbooks specified for the runbook workflow can't run until all required
        /// approvals for the change request have been received.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime? ScheduledTime
        {
            get { return this._scheduledTime; }
            set { this._scheduledTime = value; }
        }

        // Check to see if ScheduledTime property is set
        internal bool IsSetScheduledTime()
        {
            return this._scheduledTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. You can specify a maximum of five
        /// tags for a change request. Tags enable you to categorize a resource in different ways,
        /// such as by purpose, owner, or environment. For example, you might want to tag a change
        /// request to identify an environment or target Amazon Web Services Region. In this case,
        /// you could specify the following key-value pairs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Key=Environment,Value=Production</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Region,Value=us-east-2</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>Array Members</c> maximum value is reported as 1000. This number includes capacity
        /// reserved for internal operations. When calling the <c>StartChangeRequestExecution</c>
        /// action, you can specify a maximum of 5 tags. You can, however, use the <a>AddTagsToResource</a>
        /// action to add up to a total of 50 tags to an existing change request configuration.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1000)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}