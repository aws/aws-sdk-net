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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The combination of Amazon Web Services Regions and Amazon Web Services accounts targeted
    /// by the current Automation execution.
    /// </summary>
    public partial class TargetLocation
    {
        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// The Amazon Web Services accounts targeted by the current Automation execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> Accounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Accounts property is set.
        /// </summary>
        internal bool IsSetAccounts() => this.Accounts != null && (this.Accounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExcludeAccounts. 
        /// <para>
        /// Amazon Web Services accounts or organizational units to exclude as expanded targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public List<string> ExcludeAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludeAccounts property is set.
        /// </summary>
        internal bool IsSetExcludeAccounts() => this.ExcludeAccounts != null && (this.ExcludeAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutionRoleName. 
        /// <para>
        /// The Automation execution role used by the currently running Automation. If not specified,
        /// the default value is <c>AWS-SystemsManager-AutomationExecutionRole</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ExecutionRoleName { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleName property is set.
        /// </summary>
        internal bool IsSetExecutionRoleName() => this.ExecutionRoleName != null;

        /// <summary>
        /// Gets and sets the property IncludeChildOrganizationUnits. 
        /// <para>
        /// Indicates whether to include child organizational units (OUs) that are children of
        /// the targeted OUs. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeChildOrganizationUnits { get; set; }

        /// <summary>
        /// Checks to see if the IncludeChildOrganizationUnits property is set.
        /// </summary>
        internal bool IsSetIncludeChildOrganizationUnits() => this.IncludeChildOrganizationUnits.HasValue;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Amazon Web Services Regions targeted by the current Automation execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetLocationAlarmConfiguration.
        /// </summary>
        public AlarmConfiguration TargetLocationAlarmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetLocationAlarmConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetLocationAlarmConfiguration() => this.TargetLocationAlarmConfiguration != null;

        /// <summary>
        /// Gets and sets the property TargetLocationMaxConcurrency. 
        /// <para>
        /// The maximum number of Amazon Web Services Regions and Amazon Web Services accounts
        /// allowed to run the Automation concurrently. <c>TargetLocationMaxConcurrency</c> has
        /// a default value of 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string TargetLocationMaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the TargetLocationMaxConcurrency property is set.
        /// </summary>
        internal bool IsSetTargetLocationMaxConcurrency() => this.TargetLocationMaxConcurrency != null;

        /// <summary>
        /// Gets and sets the property TargetLocationMaxErrors. 
        /// <para>
        /// The maximum number of errors allowed before the system stops queueing additional Automation
        /// executions for the currently running Automation. <c>TargetLocationMaxErrors</c> has
        /// a default value of 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string TargetLocationMaxErrors { get; set; }

        /// <summary>
        /// Checks to see if the TargetLocationMaxErrors property is set.
        /// </summary>
        internal bool IsSetTargetLocationMaxErrors() => this.TargetLocationMaxErrors != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<Target> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetsMaxConcurrency. 
        /// <para>
        /// The maximum number of targets allowed to run this task in parallel. This <c>TargetsMaxConcurrency</c>
        /// takes precedence over the <c>StartAutomationExecution:MaxConcurrency</c> parameter
        /// if both are supplied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string TargetsMaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the TargetsMaxConcurrency property is set.
        /// </summary>
        internal bool IsSetTargetsMaxConcurrency() => this.TargetsMaxConcurrency != null;

        /// <summary>
        /// Gets and sets the property TargetsMaxErrors. 
        /// <para>
        /// The maximum number of errors that are allowed before the system stops running the
        /// automation on additional targets. This <c>TargetsMaxErrors</c> parameter takes precedence
        /// over the <c>StartAutomationExecution:MaxErrors</c> parameter if both are supplied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string TargetsMaxErrors { get; set; }

        /// <summary>
        /// Checks to see if the TargetsMaxErrors property is set.
        /// </summary>
        internal bool IsSetTargetsMaxErrors() => this.TargetsMaxErrors != null;
    }
}
