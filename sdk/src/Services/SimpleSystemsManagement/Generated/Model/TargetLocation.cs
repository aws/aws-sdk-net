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
    /// The combination of Amazon Web Services Regions and Amazon Web Services accounts targeted
    /// by the current Automation execution.
    /// </summary>
    public partial class TargetLocation
    {
        private List<string> _accounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _excludeAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _executionRoleName;
        private bool? _includeChildOrganizationUnits;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AlarmConfiguration _targetLocationAlarmConfiguration;
        private string _targetLocationMaxConcurrency;
        private string _targetLocationMaxErrors;
        private List<Target> _targets = AWSConfigs.InitializeCollections ? new List<Target>() : null;
        private string _targetsMaxConcurrency;
        private string _targetsMaxErrors;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// The Amazon Web Services accounts targeted by the current Automation execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && (this._accounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludeAccounts. 
        /// <para>
        /// Amazon Web Services accounts or organizational units to exclude as expanded targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public List<string> ExcludeAccounts
        {
            get { return this._excludeAccounts; }
            set { this._excludeAccounts = value; }
        }

        // Check to see if ExcludeAccounts property is set
        internal bool IsSetExcludeAccounts()
        {
            return this._excludeAccounts != null && (this._excludeAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleName. 
        /// <para>
        /// The Automation execution role used by the currently running Automation. If not specified,
        /// the default value is <c>AWS-SystemsManager-AutomationExecutionRole</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ExecutionRoleName
        {
            get { return this._executionRoleName; }
            set { this._executionRoleName = value; }
        }

        // Check to see if ExecutionRoleName property is set
        internal bool IsSetExecutionRoleName()
        {
            return this._executionRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeChildOrganizationUnits. 
        /// <para>
        /// Indicates whether to include child organizational units (OUs) that are children of
        /// the targeted OUs. The default is <c>false</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported by State Manager.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? IncludeChildOrganizationUnits
        {
            get { return this._includeChildOrganizationUnits; }
            set { this._includeChildOrganizationUnits = value; }
        }

        // Check to see if IncludeChildOrganizationUnits property is set
        internal bool IsSetIncludeChildOrganizationUnits()
        {
            return this._includeChildOrganizationUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Amazon Web Services Regions targeted by the current Automation execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property TargetLocationAlarmConfiguration.
        /// </summary>
        public AlarmConfiguration TargetLocationAlarmConfiguration
        {
            get { return this._targetLocationAlarmConfiguration; }
            set { this._targetLocationAlarmConfiguration = value; }
        }

        // Check to see if TargetLocationAlarmConfiguration property is set
        internal bool IsSetTargetLocationAlarmConfiguration()
        {
            return this._targetLocationAlarmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TargetLocationMaxConcurrency. 
        /// <para>
        /// The maximum number of Amazon Web Services Regions and Amazon Web Services accounts
        /// allowed to run the Automation concurrently. <c>TargetLocationMaxConcurrency</c> has
        /// a default value of 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string TargetLocationMaxConcurrency
        {
            get { return this._targetLocationMaxConcurrency; }
            set { this._targetLocationMaxConcurrency = value; }
        }

        // Check to see if TargetLocationMaxConcurrency property is set
        internal bool IsSetTargetLocationMaxConcurrency()
        {
            return this._targetLocationMaxConcurrency != null;
        }

        /// <summary>
        /// Gets and sets the property TargetLocationMaxErrors. 
        /// <para>
        /// The maximum number of errors allowed before the system stops queueing additional Automation
        /// executions for the currently running Automation. <c>TargetLocationMaxErrors</c> has
        /// a default value of 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string TargetLocationMaxErrors
        {
            get { return this._targetLocationMaxErrors; }
            set { this._targetLocationMaxErrors = value; }
        }

        // Check to see if TargetLocationMaxErrors property is set
        internal bool IsSetTargetLocationMaxErrors()
        {
            return this._targetLocationMaxErrors != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A list of key-value mappings to target resources. If you specify values for this data
        /// type, you must also specify a value for <c>TargetParameterName</c>.
        /// </para>
        ///  
        /// <para>
        /// This <c>Targets</c> parameter takes precedence over the <c>StartAutomationExecution:Targets</c>
        /// parameter if both are supplied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetsMaxConcurrency. 
        /// <para>
        /// The maximum number of targets allowed to run this task in parallel. This <c>TargetsMaxConcurrency</c>
        /// takes precedence over the <c>StartAutomationExecution:MaxConcurrency</c> parameter
        /// if both are supplied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string TargetsMaxConcurrency
        {
            get { return this._targetsMaxConcurrency; }
            set { this._targetsMaxConcurrency = value; }
        }

        // Check to see if TargetsMaxConcurrency property is set
        internal bool IsSetTargetsMaxConcurrency()
        {
            return this._targetsMaxConcurrency != null;
        }

        /// <summary>
        /// Gets and sets the property TargetsMaxErrors. 
        /// <para>
        /// The maximum number of errors that are allowed before the system stops running the
        /// automation on additional targets. This <c>TargetsMaxErrors</c> parameter takes precedence
        /// over the <c>StartAutomationExecution:MaxErrors</c> parameter if both are supplied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string TargetsMaxErrors
        {
            get { return this._targetsMaxErrors; }
            set { this._targetsMaxErrors = value; }
        }

        // Check to see if TargetsMaxErrors property is set
        internal bool IsSetTargetsMaxErrors()
        {
            return this._targetsMaxErrors != null;
        }

    }
}