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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties of the flow, such as its source, destination, trigger type, and so
    /// on.
    /// </summary>
    public partial class FlowDefinition
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  Specifies when the flow was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        ///  The ARN of the user who created the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A user-entered description of the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationConnectorLabel. 
        /// <para>
        /// The label of the destination connector in the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DestinationConnectorLabel { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConnectorLabel property is set.
        /// </summary>
        internal bool IsSetDestinationConnectorLabel() => this.DestinationConnectorLabel != null;

        /// <summary>
        /// Gets and sets the property DestinationConnectorType. 
        /// <para>
        ///  Specifies the destination connector type, such as Salesforce, Amazon S3, Amplitude,
        /// and so on. 
        /// </para>
        /// </summary>
        public ConnectorType DestinationConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConnectorType property is set.
        /// </summary>
        internal bool IsSetDestinationConnectorType() => this.DestinationConnectorType != null;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The flow's Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        ///  The specified name of the flow. Spaces are not allowed. Use underscores (_) or hyphens
        /// (-) only. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FlowName { get; set; }

        /// <summary>
        /// Checks to see if the FlowName property is set.
        /// </summary>
        internal bool IsSetFlowName() => this.FlowName != null;

        /// <summary>
        /// Gets and sets the property FlowStatus. 
        /// <para>
        ///  Indicates the current status of the flow. 
        /// </para>
        /// </summary>
        public FlowStatus FlowStatus { get; set; }

        /// <summary>
        /// Checks to see if the FlowStatus property is set.
        /// </summary>
        internal bool IsSetFlowStatus() => this.FlowStatus != null;

        /// <summary>
        /// Gets and sets the property LastRunExecutionDetails. 
        /// <para>
        ///  Describes the details of the most recent flow run. 
        /// </para>
        /// </summary>
        public ExecutionDetails LastRunExecutionDetails { get; set; }

        /// <summary>
        /// Checks to see if the LastRunExecutionDetails property is set.
        /// </summary>
        internal bool IsSetLastRunExecutionDetails() => this.LastRunExecutionDetails != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  Specifies when the flow was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        ///  Specifies the account user name that most recently updated the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property SourceConnectorLabel. 
        /// <para>
        /// The label of the source connector in the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SourceConnectorLabel { get; set; }

        /// <summary>
        /// Checks to see if the SourceConnectorLabel property is set.
        /// </summary>
        internal bool IsSetSourceConnectorLabel() => this.SourceConnectorLabel != null;

        /// <summary>
        /// Gets and sets the property SourceConnectorType. 
        /// <para>
        ///  Specifies the source connector type, such as Salesforce, Amazon S3, Amplitude, and
        /// so on. 
        /// </para>
        /// </summary>
        public ConnectorType SourceConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the SourceConnectorType property is set.
        /// </summary>
        internal bool IsSetSourceConnectorType() => this.SourceConnectorType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags used to organize, track, or control access for your flow. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TriggerType. 
        /// <para>
        ///  Specifies the type of flow trigger. This can be <c>OnDemand</c>, <c>Scheduled</c>,
        /// or <c>Event</c>. 
        /// </para>
        /// </summary>
        public TriggerType TriggerType { get; set; }

        /// <summary>
        /// Checks to see if the TriggerType property is set.
        /// </summary>
        internal bool IsSetTriggerType() => this.TriggerType != null;
    }
}
