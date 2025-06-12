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
    /// Container for the parameters to the UpdateControl operation.
    /// Updates a custom control in Audit Manager.
    /// </summary>
    public partial class UpdateControlRequest : AmazonAuditManagerRequest
    {
        private string _actionPlanInstructions;
        private string _actionPlanTitle;
        private string _controlId;
        private List<ControlMappingSource> _controlMappingSources = AWSConfigs.InitializeCollections ? new List<ControlMappingSource>() : null;
        private string _description;
        private string _name;
        private string _testingInformation;

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
        /// Gets and sets the property ControlId. 
        /// <para>
        ///  The identifier for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ControlId
        {
            get { return this._controlId; }
            set { this._controlId = value; }
        }

        // Check to see if ControlId property is set
        internal bool IsSetControlId()
        {
            return this._controlId != null;
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
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  The optional description of the control. 
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the updated control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
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
        /// Gets and sets the property TestingInformation. 
        /// <para>
        ///  The steps that you should follow to determine if the control is met. 
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

    }
}