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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
        private ConflictResolution _conflictResolution;
        private Consolidation _consolidation;
        private bool? _enabled;
        private double? _minAllowedConfidenceScoreForMerging;

        /// <summary>
        /// Gets and sets the property ConflictResolution. 
        /// <para>
        /// How the auto-merging process should resolve conflicts between different profiles.
        /// For example, if Profile A and Profile B have the same <c>FirstName</c> and <c>LastName</c>
        /// (and that is the matching criteria), which <c>EmailAddress</c> should be used? 
        /// </para>
        /// </summary>
        public ConflictResolution ConflictResolution
        {
            get { return this._conflictResolution; }
            set { this._conflictResolution = value; }
        }

        // Check to see if ConflictResolution property is set
        internal bool IsSetConflictResolution()
        {
            return this._conflictResolution != null;
        }

        /// <summary>
        /// Gets and sets the property Consolidation. 
        /// <para>
        /// A list of matching attributes that represent matching criteria. If two profiles meet
        /// at least one of the requirements in the matching attributes list, they will be merged.
        /// </para>
        /// </summary>
        public Consolidation Consolidation
        {
            get { return this._consolidation; }
            set { this._consolidation = value; }
        }

        // Check to see if Consolidation property is set
        internal bool IsSetConsolidation()
        {
            return this._consolidation != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// The flag that enables the auto-merging of duplicate profiles.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinAllowedConfidenceScoreForMerging. 
        /// <para>
        /// A number between 0 and 1 that represents the minimum confidence score required for
        /// profiles within a matching group to be merged during the auto-merge process. A higher
        /// score means higher similarity required to merge profiles. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? MinAllowedConfidenceScoreForMerging
        {
            get { return this._minAllowedConfidenceScoreForMerging; }
            set { this._minAllowedConfidenceScoreForMerging = value; }
        }

        // Check to see if MinAllowedConfidenceScoreForMerging property is set
        internal bool IsSetMinAllowedConfidenceScoreForMerging()
        {
            return this._minAllowedConfidenceScoreForMerging.HasValue; 
        }

    }
}