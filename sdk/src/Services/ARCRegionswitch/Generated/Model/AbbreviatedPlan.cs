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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// A summarized representation of a Region switch plan. This structure contains key information
    /// about a plan without all the detailed workflow and step data.
    /// </summary>
    public partial class AbbreviatedPlan
    {
        private string _activePlanExecution;
        private string _arn;
        private string _description;
        private string _executionRole;
        private string _name;
        private string _owner;
        private string _primaryRegion;
        private RecoveryApproach _recoveryApproach;
        private int? _recoveryTimeObjectiveMinutes;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _updatedAt;
        private string _version;

        /// <summary>
        /// Gets and sets the property ActivePlanExecution. 
        /// <para>
        /// Specifies if this is the active plan execution at this time.
        /// </para>
        /// </summary>
        public string ActivePlanExecution
        {
            get { return this._activePlanExecution; }
            set { this._activePlanExecution = value; }
        }

        // Check to see if ActivePlanExecution property is set
        internal bool IsSetActivePlanExecution()
        {
            return this._activePlanExecution != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Region switch plan.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of a Region switch plan.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role is a way to categorize a Region switch plan. 
        /// </para>
        /// </summary>
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a Region switch plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of a Region switch plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// The primary Region for a plan.
        /// </para>
        /// </summary>
        public string PrimaryRegion
        {
            get { return this._primaryRegion; }
            set { this._primaryRegion = value; }
        }

        // Check to see if PrimaryRegion property is set
        internal bool IsSetPrimaryRegion()
        {
            return this._primaryRegion != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryApproach. 
        /// <para>
        /// The recovery approach for a Region switch plan, which can be active/active (activeActive)
        /// or active/passive (activePassive).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecoveryApproach RecoveryApproach
        {
            get { return this._recoveryApproach; }
            set { this._recoveryApproach = value; }
        }

        // Check to see if RecoveryApproach property is set
        internal bool IsSetRecoveryApproach()
        {
            return this._recoveryApproach != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryTimeObjectiveMinutes. 
        /// <para>
        /// The recovery time objective that you've specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10080)]
        public int? RecoveryTimeObjectiveMinutes
        {
            get { return this._recoveryTimeObjectiveMinutes; }
            set { this._recoveryTimeObjectiveMinutes = value; }
        }

        // Check to see if RecoveryTimeObjectiveMinutes property is set
        internal bool IsSetRecoveryTimeObjectiveMinutes()
        {
            return this._recoveryTimeObjectiveMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Amazon Web Services Region specified for a Region switch plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the plan execution was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version for the plan.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}