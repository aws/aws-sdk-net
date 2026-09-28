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

namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Details of the <c>EnabledBaseline</c> resource.
    /// </summary>
    public partial class EnabledBaselineDetails
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the <c>EnabledBaseline</c> resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BaselineIdentifier. 
        /// <para>
        /// The specific <c>Baseline</c> enabled as part of the <c>EnabledBaseline</c> resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BaselineIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BaselineIdentifier property is set.
        /// </summary>
        internal bool IsSetBaselineIdentifier() => this.BaselineIdentifier != null;

        /// <summary>
        /// Gets and sets the property BaselineVersion. 
        /// <para>
        /// The enabled version of the <c>Baseline</c>.
        /// </para>
        /// </summary>
        public string BaselineVersion { get; set; }

        /// <summary>
        /// Checks to see if the BaselineVersion property is set.
        /// </summary>
        internal bool IsSetBaselineVersion() => this.BaselineVersion != null;

        /// <summary>
        /// Gets and sets the property DriftStatusSummary. 
        /// <para>
        /// The drift status of the enabled baseline.
        /// </para>
        /// </summary>
        public EnabledBaselineDriftStatusSummary DriftStatusSummary { get; set; }

        /// <summary>
        /// Checks to see if the DriftStatusSummary property is set.
        /// </summary>
        internal bool IsSetDriftStatusSummary() => this.DriftStatusSummary != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Shows the parameters that are applied when enabling this <c>Baseline</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnabledBaselineParameterSummary> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<EnabledBaselineParameterSummary>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParentIdentifier. 
        /// <para>
        /// An ARN that represents the parent <c>EnabledBaseline</c> at the Organizational Unit
        /// (OU) level, from which the child <c>EnabledBaseline</c> inherits its configuration.
        /// The value is returned by <c>GetEnabledBaseline</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ParentIdentifier property is set.
        /// </summary>
        internal bool IsSetParentIdentifier() => this.ParentIdentifier != null;

        /// <summary>
        /// Gets and sets the property StatusSummary.
        /// </summary>
        [AWSProperty(Required = true)]
        public EnablementStatusSummary StatusSummary { get; set; }

        /// <summary>
        /// Checks to see if the StatusSummary property is set.
        /// </summary>
        internal bool IsSetStatusSummary() => this.StatusSummary != null;

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The target on which to enable the <c>Baseline</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetIdentifier() => this.TargetIdentifier != null;
    }
}
