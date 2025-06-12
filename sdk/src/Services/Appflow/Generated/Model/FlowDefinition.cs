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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties of the flow, such as its source, destination, trigger type, and so
    /// on.
    /// </summary>
    public partial class FlowDefinition
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _destinationConnectorLabel;
        private ConnectorType _destinationConnectorType;
        private string _flowArn;
        private string _flowName;
        private FlowStatus _flowStatus;
        private ExecutionDetails _lastRunExecutionDetails;
        private DateTime? _lastUpdatedAt;
        private string _lastUpdatedBy;
        private string _sourceConnectorLabel;
        private ConnectorType _sourceConnectorType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TriggerType _triggerType;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  Specifies when the flow was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        ///  The ARN of the user who created the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A user-entered description of the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationConnectorLabel. 
        /// <para>
        /// The label of the destination connector in the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DestinationConnectorLabel
        {
            get { return this._destinationConnectorLabel; }
            set { this._destinationConnectorLabel = value; }
        }

        // Check to see if DestinationConnectorLabel property is set
        internal bool IsSetDestinationConnectorLabel()
        {
            return this._destinationConnectorLabel != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationConnectorType. 
        /// <para>
        ///  Specifies the destination connector type, such as Salesforce, Amazon S3, Amplitude,
        /// and so on. 
        /// </para>
        /// </summary>
        public ConnectorType DestinationConnectorType
        {
            get { return this._destinationConnectorType; }
            set { this._destinationConnectorType = value; }
        }

        // Check to see if DestinationConnectorType property is set
        internal bool IsSetDestinationConnectorType()
        {
            return this._destinationConnectorType != null;
        }

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The flow's Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        ///  The specified name of the flow. Spaces are not allowed. Use underscores (_) or hyphens
        /// (-) only. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FlowName
        {
            get { return this._flowName; }
            set { this._flowName = value; }
        }

        // Check to see if FlowName property is set
        internal bool IsSetFlowName()
        {
            return this._flowName != null;
        }

        /// <summary>
        /// Gets and sets the property FlowStatus. 
        /// <para>
        ///  Indicates the current status of the flow. 
        /// </para>
        /// </summary>
        public FlowStatus FlowStatus
        {
            get { return this._flowStatus; }
            set { this._flowStatus = value; }
        }

        // Check to see if FlowStatus property is set
        internal bool IsSetFlowStatus()
        {
            return this._flowStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunExecutionDetails. 
        /// <para>
        ///  Describes the details of the most recent flow run. 
        /// </para>
        /// </summary>
        public ExecutionDetails LastRunExecutionDetails
        {
            get { return this._lastRunExecutionDetails; }
            set { this._lastRunExecutionDetails = value; }
        }

        // Check to see if LastRunExecutionDetails property is set
        internal bool IsSetLastRunExecutionDetails()
        {
            return this._lastRunExecutionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  Specifies when the flow was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        ///  Specifies the account user name that most recently updated the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConnectorLabel. 
        /// <para>
        /// The label of the source connector in the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SourceConnectorLabel
        {
            get { return this._sourceConnectorLabel; }
            set { this._sourceConnectorLabel = value; }
        }

        // Check to see if SourceConnectorLabel property is set
        internal bool IsSetSourceConnectorLabel()
        {
            return this._sourceConnectorLabel != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConnectorType. 
        /// <para>
        ///  Specifies the source connector type, such as Salesforce, Amazon S3, Amplitude, and
        /// so on. 
        /// </para>
        /// </summary>
        public ConnectorType SourceConnectorType
        {
            get { return this._sourceConnectorType; }
            set { this._sourceConnectorType = value; }
        }

        // Check to see if SourceConnectorType property is set
        internal bool IsSetSourceConnectorType()
        {
            return this._sourceConnectorType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags used to organize, track, or control access for your flow. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TriggerType. 
        /// <para>
        ///  Specifies the type of flow trigger. This can be <c>OnDemand</c>, <c>Scheduled</c>,
        /// or <c>Event</c>. 
        /// </para>
        /// </summary>
        public TriggerType TriggerType
        {
            get { return this._triggerType; }
            set { this._triggerType = value; }
        }

        // Check to see if TriggerType property is set
        internal bool IsSetTriggerType()
        {
            return this._triggerType != null;
        }

    }
}