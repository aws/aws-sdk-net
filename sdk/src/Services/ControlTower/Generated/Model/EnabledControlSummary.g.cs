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
    /// Returns a summary of information about an enabled control.
    /// </summary>
    public partial class EnabledControlSummary
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
        /// The <c>controlIdentifier</c> of the enabled control.
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
        /// A short description of the status of the enabled control.
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
        /// The ARN of the organizational unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetIdentifier() => this.TargetIdentifier != null;
    }
}
