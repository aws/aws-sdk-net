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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Configuration settings for how to perform the auto-merging of profiles.
    /// </summary>
    public partial class AutoMerging
    {
        /// <summary>
        /// Gets and sets the property ConflictResolution. 
        /// <para>
        /// How the auto-merging process should resolve conflicts between different profiles.
        /// For example, if Profile A and Profile B have the same <c>FirstName</c> and <c>LastName</c>
        /// (and that is the matching criteria), which <c>EmailAddress</c> should be used? 
        /// </para>
        /// </summary>
        public ConflictResolution ConflictResolution { get; set; }

        /// <summary>
        /// Checks to see if the ConflictResolution property is set.
        /// </summary>
        internal bool IsSetConflictResolution() => this.ConflictResolution != null;

        /// <summary>
        /// Gets and sets the property Consolidation. 
        /// <para>
        /// A list of matching attributes that represent matching criteria. If two profiles meet
        /// at least one of the requirements in the matching attributes list, they will be merged.
        /// </para>
        /// </summary>
        public Consolidation Consolidation { get; set; }

        /// <summary>
        /// Checks to see if the Consolidation property is set.
        /// </summary>
        internal bool IsSetConsolidation() => this.Consolidation != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// The flag that enables the auto-merging of duplicate profiles.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property MinAllowedConfidenceScoreForMerging. 
        /// <para>
        /// A number between 0 and 1 that represents the minimum confidence score required for
        /// profiles within a matching group to be merged during the auto-merge process. A higher
        /// score means higher similarity required to merge profiles. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? MinAllowedConfidenceScoreForMerging { get; set; }

        /// <summary>
        /// Checks to see if the MinAllowedConfidenceScoreForMerging property is set.
        /// </summary>
        internal bool IsSetMinAllowedConfidenceScoreForMerging() => this.MinAllowedConfidenceScoreForMerging.HasValue;
    }
}
