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
    /// Information about the enabled control.
    /// </summary>
    public partial class EnabledControlDetails
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the enabled control.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ControlIdentifier. 
        /// <para>
        /// The control identifier of the enabled control. For information on how to find the
        /// <c>controlIdentifier</c>, see <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/Welcome.html">the
        /// overview page</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ControlIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ControlIdentifier property is set.
        /// </summary>
        internal bool IsSetControlIdentifier() => this.ControlIdentifier != null;

        /// <summary>
        /// Gets and sets the property DriftStatusSummary. 
        /// <para>
        /// The drift status of the enabled control.
        /// </para>
        /// </summary>
        public DriftStatusSummary DriftStatusSummary { get; set; }

        /// <summary>
        /// Checks to see if the DriftStatusSummary property is set.
        /// </summary>
        internal bool IsSetDriftStatusSummary() => this.DriftStatusSummary != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Array of <c>EnabledControlParameter</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnabledControlParameterSummary> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<EnabledControlParameterSummary>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParentIdentifier. 
        /// <para>
        /// The ARN of the parent enabled control from which this control inherits its configuration,
        /// if applicable.
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
        /// <para>
        /// The deployment summary of the enabled control.
        /// </para>
        /// </summary>
        public EnablementStatusSummary StatusSummary { get; set; }

        /// <summary>
        /// Checks to see if the StatusSummary property is set.
        /// </summary>
        internal bool IsSetStatusSummary() => this.StatusSummary != null;

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The ARN of the organizational unit. For information on how to find the <c>targetIdentifier</c>,
        /// see <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/Welcome.html">the
        /// overview page</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetIdentifier() => this.TargetIdentifier != null;

        /// <summary>
        /// Gets and sets the property TargetRegions. 
        /// <para>
        /// Target Amazon Web Services Regions for the enabled control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Region> TargetRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<Region>() : null;

        /// <summary>
        /// Checks to see if the TargetRegions property is set.
        /// </summary>
        internal bool IsSetTargetRegions() => this.TargetRegions != null && (this.TargetRegions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
