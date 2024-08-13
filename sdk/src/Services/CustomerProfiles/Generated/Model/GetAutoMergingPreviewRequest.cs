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
    /// Container for the parameters to the GetAutoMergingPreview operation.
    /// Tests the auto-merging settings of your Identity Resolution Job without merging your
    /// data. It randomly selects a sample of matching groups from the existing matching results,
    /// and applies the automerging settings that you provided. You can then view the number
    /// of profiles in the sample, the number of matches, and the number of profiles identified
    /// to be merged. This enables you to evaluate the accuracy of the attributes in your
    /// matching list. 
    /// 
    ///  
    /// <para>
    /// You can't view which profiles are matched and would be merged.
    /// </para>
    ///  <important> 
    /// <para>
    /// We strongly recommend you use this API to do a dry run of the automerging process
    /// before running the Identity Resolution Job. Include <b>at least</b> two matching attributes.
    /// If your matching list includes too few attributes (such as only <c>FirstName</c> or
    /// only <c>LastName</c>), there may be a large number of matches. This increases the
    /// chances of erroneous merges.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetAutoMergingPreviewRequest : AmazonCustomerProfilesRequest
    {
        private ConflictResolution _conflictResolution;
        private Consolidation _consolidation;
        private string _domainName;
        private double? _minAllowedConfidenceScoreForMerging;

        /// <summary>
        /// Gets and sets the property ConflictResolution. 
        /// <para>
        /// How the auto-merging process should resolve conflicts between different profiles.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of matching attributes that represent matching criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property MinAllowedConfidenceScoreForMerging. 
        /// <para>
        /// Minimum confidence score required for profiles within a matching group to be merged
        /// during the auto-merge process.
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