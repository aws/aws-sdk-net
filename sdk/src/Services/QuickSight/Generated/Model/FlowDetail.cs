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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The full details of a flow, including its definition specifying the steps.
    /// </summary>
    public partial class FlowDetail
    {
        private string _arn;
        private string _createdBy;
        private DateTime? _createdTime;
        private string _description;
        private Amazon.Runtime.Documents.Document _flowDefinition;
        private string _flowId;
        private string _lastUpdatedBy;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private FlowPublishState _publishState;
        private List<StepAliasMapping> _stepAliases = AWSConfigs.InitializeCollections ? new List<StepAliasMapping>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the principal who created the flow.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time this flow was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property FlowDefinition. 
        /// <para>
        /// The definition of the flow, specifying the steps and configurations. This is the flow
        /// definition in Quick Flow's internal format. The format is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Amazon.Runtime.Documents.Document FlowDefinition
        {
            get { return this._flowDefinition; }
            set { this._flowDefinition = value; }
        }

        // Check to see if FlowDefinition property is set
        internal bool IsSetFlowDefinition()
        {
            return !this._flowDefinition.IsNull();
        }

        /// <summary>
        /// Gets and sets the property FlowId. 
        /// <para>
        /// The unique identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowId
        {
            get { return this._flowId; }
            set { this._flowId = value; }
        }

        // Check to see if FlowId property is set
        internal bool IsSetFlowId()
        {
            return this._flowId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The identifier of the last principal who updated the flow.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time this flow was modified.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PublishState. 
        /// <para>
        /// The publish state of the flow. Valid values are <c>DRAFT</c>, <c>PUBLISHED</c>, or
        /// <c>PENDING_APPROVAL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowPublishState PublishState
        {
            get { return this._publishState; }
            set { this._publishState = value; }
        }

        // Check to see if PublishState property is set
        internal bool IsSetPublishState()
        {
            return this._publishState != null;
        }

        /// <summary>
        /// Gets and sets the property StepAliases. 
        /// <para>
        /// A list of step alias mappings for the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StepAliasMapping> StepAliases
        {
            get { return this._stepAliases; }
            set { this._stepAliases = value; }
        }

        // Check to see if StepAliases property is set
        internal bool IsSetStepAliases()
        {
            return this._stepAliases != null && (this._stepAliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}