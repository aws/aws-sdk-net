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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Specifies a snapshot retention rule for an Amazon FSx for NetApp ONTAP SnapMirror
    /// policy.
    /// </summary>
    public partial class SnapmirrorPolicyRetentionRule
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of snapshots with the label to retain on the destination volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1019)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property CreationSchedule. 
        /// <para>
        /// The name of the ONTAP schedule on which SnapMirror creates snapshots with the label
        /// directly on the destination volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string CreationSchedule { get; set; }

        /// <summary>
        /// Checks to see if the CreationSchedule property is set.
        /// </summary>
        internal bool IsSetCreationSchedule() => this.CreationSchedule != null;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The SnapMirror label of the snapshots that the rule applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 31)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;
    }
}
