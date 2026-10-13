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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides a breakdown of the number of objects labeled.
    /// </summary>
    public partial class LabelCounters
    {
        /// <summary>
        /// Gets and sets the property FailedNonRetryableError. 
        /// <para>
        /// The total number of objects that could not be labeled due to an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? FailedNonRetryableError { get; set; }

        /// <summary>
        /// Checks to see if the FailedNonRetryableError property is set.
        /// </summary>
        internal bool IsSetFailedNonRetryableError() => this.FailedNonRetryableError.HasValue;

        /// <summary>
        /// Gets and sets the property HumanLabeled. 
        /// <para>
        /// The total number of objects labeled by a human worker.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? HumanLabeled { get; set; }

        /// <summary>
        /// Checks to see if the HumanLabeled property is set.
        /// </summary>
        internal bool IsSetHumanLabeled() => this.HumanLabeled.HasValue;

        /// <summary>
        /// Gets and sets the property MachineLabeled. 
        /// <para>
        /// The total number of objects labeled by automated data labeling.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MachineLabeled { get; set; }

        /// <summary>
        /// Checks to see if the MachineLabeled property is set.
        /// </summary>
        internal bool IsSetMachineLabeled() => this.MachineLabeled.HasValue;

        /// <summary>
        /// Gets and sets the property TotalLabeled. 
        /// <para>
        /// The total number of objects labeled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalLabeled { get; set; }

        /// <summary>
        /// Checks to see if the TotalLabeled property is set.
        /// </summary>
        internal bool IsSetTotalLabeled() => this.TotalLabeled.HasValue;

        /// <summary>
        /// Gets and sets the property Unlabeled. 
        /// <para>
        /// The total number of objects not yet labeled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Unlabeled { get; set; }

        /// <summary>
        /// Checks to see if the Unlabeled property is set.
        /// </summary>
        internal bool IsSetUnlabeled() => this.Unlabeled.HasValue;
    }
}
