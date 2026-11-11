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
    /// Information about an Automation runbook used in a runbook workflow in Change Manager.
    /// 
    ///  <note> 
    /// <para>
    /// The Automation runbooks specified for the runbook workflow can't run until all required
    /// approvals for the change request have been received.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Runbook
    {
        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the Automation runbook used in a runbook workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DocumentName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentName property is set.
        /// </summary>
        internal bool IsSetDocumentName() => this.DocumentName != null;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the Automation runbook used in a runbook workflow.
        /// </para>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The <c>MaxConcurrency</c> value specified by the user when the operation started,
        /// indicating the maximum number of resources that the runbook operation can run on at
        /// the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency != null;

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The <c>MaxErrors</c> value specified by the user when the execution started, indicating
        /// the maximum number of errors that can occur during the operation before the updates
        /// are stopped or rolled back.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxErrors { get; set; }

        /// <summary>
        /// Checks to see if the MaxErrors property is set.
        /// </summary>
        internal bool IsSetMaxErrors() => this.MaxErrors != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The key-value map of execution parameters, which were supplied when calling <c>StartChangeRequestExecution</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, List<string>> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetLocations. 
        /// <para>
        /// Information about the Amazon Web Services Regions and Amazon Web Services accounts
        /// targeted by the current Runbook operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<TargetLocation> TargetLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetLocation>() : null;

        /// <summary>
        /// Checks to see if the TargetLocations property is set.
        /// </summary>
        internal bool IsSetTargetLocations() => this.TargetLocations != null && (this.TargetLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetMaps. 
        /// <para>
        /// A key-value mapping of runbook parameters to target resources. Both Targets and TargetMaps
        /// can't be specified together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public List<Dictionary<string, List<string>>> TargetMaps { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, List<string>>>() : null;

        /// <summary>
        /// Checks to see if the TargetMaps property is set.
        /// </summary>
        internal bool IsSetTargetMaps() => this.TargetMaps != null && (this.TargetMaps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetParameterName. 
        /// <para>
        /// The name of the parameter used as the target resource for the rate-controlled runbook
        /// workflow. Required if you specify <c>Targets</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string TargetParameterName { get; set; }

        /// <summary>
        /// Checks to see if the TargetParameterName property is set.
        /// </summary>
        internal bool IsSetTargetParameterName() => this.TargetParameterName != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A key-value mapping to target resources that the runbook operation performs tasks
        /// on. Required if you specify <c>TargetParameterName</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Target> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
