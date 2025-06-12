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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// A control in Audit Manager.
    /// </summary>
    public partial class Control
    {
        private string _actionPlanInstructions;
        private string _actionPlanTitle;
        private string _arn;
        private List<ControlMappingSource> _controlMappingSources = AWSConfigs.InitializeCollections ? new List<ControlMappingSource>() : null;
        private string _controlSources;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private string _lastUpdatedBy;
        private string _name;
        private ControlState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _testingInformation;
        private ControlType _type;

        /// <summary>
        /// Gets and sets the property ActionPlanInstructions. 
        /// <para>
        ///  The recommended actions to carry out if the control isn't fulfilled. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1000)]
        public string ActionPlanInstructions
        {
            get { return this._actionPlanInstructions; }
            set { this._actionPlanInstructions = value; }
        }

        // Check to see if ActionPlanInstructions property is set
        internal bool IsSetActionPlanInstructions()
        {
            return this._actionPlanInstructions != null;
        }

        /// <summary>
        /// Gets and sets the property ActionPlanTitle. 
        /// <para>
        ///  The title of the action plan for remediating the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=300)]
        public string ActionPlanTitle
        {
            get { return this._actionPlanTitle; }
            set { this._actionPlanTitle = value; }
        }

        // Check to see if ActionPlanTitle property is set
        internal bool IsSetActionPlanTitle()
        {
            return this._actionPlanTitle != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property ControlMappingSources. 
        /// <para>
        ///  The data mapping sources for the control. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ControlMappingSource> ControlMappingSources
        {
            get { return this._controlMappingSources; }
            set { this._controlMappingSources = value; }
        }

        // Check to see if ControlMappingSources property is set
        internal bool IsSetControlMappingSources()
        {
            return this._controlMappingSources != null && (this._controlMappingSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ControlSources. 
        /// <para>
        ///  The data source types that determine where Audit Manager collects evidence from for
        /// the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ControlSources
        {
            get { return this._controlSources; }
            set { this._controlSources = value; }
        }

        // Check to see if ControlSources property is set
        internal bool IsSetControlSources()
        {
            return this._controlSources != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The time when the control was created. 
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
        ///  The user or role that created the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
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
        ///  The description of the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1000)]
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
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  The time when the control was most recently updated. 
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
        ///  The user or role that most recently updated the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the control. The <c>END_OF_SUPPORT</c> state is applicable to standard
        /// controls only. This state indicates that the standard control can still be used to
        /// collect evidence, but Audit Manager is no longer updating or maintaining that control.
        /// </para>
        /// </summary>
        public ControlState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags associated with the control. 
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
        /// Gets and sets the property TestingInformation. 
        /// <para>
        ///  The steps that you should follow to determine if the control has been satisfied.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1000)]
        public string TestingInformation
        {
            get { return this._testingInformation; }
            set { this._testingInformation = value; }
        }

        // Check to see if TestingInformation property is set
        internal bool IsSetTestingInformation()
        {
            return this._testingInformation != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  Specifies whether the control is a standard control or a custom control.
        /// </para>
        /// </summary>
        public ControlType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}